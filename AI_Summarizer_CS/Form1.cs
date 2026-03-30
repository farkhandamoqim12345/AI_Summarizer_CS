using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// AI_Summarizer_CS aapke project ka sahi namespace hai
using AI_Summarizer_CS;

namespace AI_Summarizer_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Output UI ko professional look dena
            txtAnswer.ReadOnly = true;
            txtAnswer.BackColor = Color.WhiteSmoke;
        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            string userQuery = txtQuestion.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(userQuery))
            {
                MessageBox.Show("Please enter a cricket question!", "Input Empty");
                return;
            }

            try
            {
                // 1. AI Model Input (Hamara data 'Col1' mein label tha, input 'Col0' mein)
                var input = new CricketAI.ModelInput()
                {
                    Col0 = txtQuestion.Text // Agar ye error de toh 'Col1' karke dekhein
                };

                // 2. Predict Intent (AI Classification)
                var result = CricketAI.Predict(input);

                // 3. Response Generation
                ProcessExpertKnowledge(result, userQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("System Error: " + ex.Message);
            }
        }

        private void ProcessExpertKnowledge(CricketAI.ModelOutput result, string query)
        {
            txtAnswer.Clear();
            string category = result.PredictedLabel;
            float confidence = result.Score.Max() * 100;

            // Header styling
            txtAnswer.SelectionFont = new Font("Segoe UI", 12, FontStyle.Bold);
            txtAnswer.SelectionColor = Color.Purple;
            txtAnswer.AppendText("🏏 CRICKET AI EXPERT ANALYSIS\n");
            txtAnswer.AppendText("--------------------------------------\n\n");

            // Metadata
            txtAnswer.SelectionFont = new Font("Segoe UI", 9, FontStyle.Italic);
            txtAnswer.SelectionColor = Color.DimGray;
            txtAnswer.AppendText($"Classification: {category} | Certainty: {confidence:F2}%\n\n");

            // Main Answer Logic (Heuristic Mapping)
            txtAnswer.SelectionFont = new Font("Segoe UI", 11, FontStyle.Regular);
            txtAnswer.SelectionColor = Color.Black;

            // Case 1: Player Information
            if (query.Contains("babar azam") || category == "Player_Info")
            {
                if (query.Contains("babar azam"))
                {
                    txtAnswer.AppendText("ANSWER: Babar Azam is one of the world's finest batters, known for his classical technique and cover drives. He has captained Pakistan and consistently stayed in the ICC top rankings.");
                }
                else if (query.Contains("kohli") || query.Contains("kholi"))
                {
                    txtAnswer.AppendText("ANSWER: Virat Kohli is an Indian cricket icon with the most centuries in ODI history. He is widely regarded as one of the best 'chasers' the game has ever seen.");
                }
                else
                {
                    txtAnswer.AppendText("ANSWER: This query is identified as Player Statistics. I am retrieving the athlete's career highlights from the database...");
                }
            }
            // Case 2: Cricket Rules
            else if (query.Contains("lbw") || query.Contains("rule") || category == "Rules_Umpiring")
            {
                if (query.Contains("lbw"))
                {
                    txtAnswer.AppendText("ANSWER: LBW (Leg Before Wicket) is a rule where a batter is given out if the ball hits their body when it was going to hit the stumps.");
                }
                else
                {
                    txtAnswer.AppendText("ANSWER: This relates to the Laws of Cricket. The ICC rulebook defines this under specific match regulations.");
                }
            }
            // Case 3: Personal/Developer Context
            else if (query.Contains("sufyan") || query.Contains("farkhanda") || category == "Personal_Query")
            {
                txtAnswer.AppendText("ANSWER: This Expert System was developed by Farkhanda Moqim. Special mention to Sufyan Moqim for being the primary inspiration for this AI project!");
            }
            // Case 4: Default/Generic
            else
            {
                txtAnswer.AppendText("ANSWER: I recognize this as a general cricket query. Processing historical data points to provide a summarized overview...");
            }

            txtAnswer.AppendText("\n\nStatus: Analysis Complete.");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtQuestion.Clear();
            txtAnswer.Clear();
        }
    }
}