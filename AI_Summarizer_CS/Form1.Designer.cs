namespace AI_Summarizer_CS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Button btnAsk;
        private System.Windows.Forms.RichTextBox txtAnswer;
        private System.Windows.Forms.Label lblStatus;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.btnAsk = new System.Windows.Forms.Button();
            this.txtAnswer = new System.Windows.Forms.RichTextBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();

            // Header Panel
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(103, 58, 183);
            this.pnlHeader.Controls.Add(this.lblTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(780, 80);

            // Title Label
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Black", 20F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Text = "🏏 CRICKET AI EXPERT";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Input TextBox
            this.txtQuestion.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtQuestion.Location = new System.Drawing.Point(50, 110);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(600, 35);

            // Analyze Button
            this.btnAsk.BackColor = System.Drawing.Color.FromArgb(103, 58, 183);
            this.btnAsk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsk.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAsk.ForeColor = System.Drawing.Color.White;
            this.btnAsk.Location = new System.Drawing.Point(250, 160);
            this.btnAsk.Name = "btnAsk";
            this.btnAsk.Size = new System.Drawing.Size(250, 45);
            this.btnAsk.Text = "Analyze with AI";
            this.btnAsk.UseVisualStyleBackColor = false;
            this.btnAsk.Click += new System.EventHandler(this.btnAsk_Click);

            // Result Answer Box
            this.txtAnswer.BackColor = System.Drawing.Color.FromArgb(245, 245, 255);
            this.txtAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAnswer.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtAnswer.Location = new System.Drawing.Point(50, 230);
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.ReadOnly = true;
            this.txtAnswer.Size = new System.Drawing.Size(680, 200);

            // Status Label
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(50, 440);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Text = "Status: Initializing...";

            // Form Main Settings
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 480);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.txtAnswer);
            this.Controls.Add(this.btnAsk);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.pnlHeader);
            this.Name = "Form1";
            this.Text = "Cricket AI Expert v1.0";
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}