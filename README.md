 Project OverviewCricket enthusiasts often find information scattered across inconsistent sources
 
  This project implements an Expert System using ML.NET to categorize natural language queries and provide instant, offline responses. The system utilizes a hybrid approach: Machine Learning Classification for intent detection and a Heuristic Knowledge Base for high-precision answers.
  
  🛠️ 2. Technical StackLanguage: C# (Object-Oriented, Type-safe)Frontend: Windows Forms (WinForms) for high-performance desktop GUI.AI Engine: ML.NET Model Builder with AutoML integration.Core Algorithm: LightGbmMulti (Light Gradient Boosting Machine) for multi-class text classification.
  
  Containerization: 
  Docker Desktop v4.67.0 with WSL 2 backend.Version Control: Git/GitHub for CI/CD readiness.
  
  📊 3. Machine Learning Pipeline3.1 Data EngineeringThe model was trained on a curated dataset of 201 manually labeled samples.Input Features: Raw text strings (User Queries).Target Classes: Player_Info, Rules_Umpiring, Match_Info, and Personal_Query.3.2 Model TrainingWe allocated a 600-second training budget to explore multiple trainers. The LightGbmMulti algorithm outperformed others in macro-accuracy and latency, making it ideal for real-time inference in a desktop environment.
  
  🧠 4. Hybrid Inference LogicTo ensure 100% reliability even when ML confidence is low (e.g., 0.61% certainty), the system implements a Two-Layer Response System:Layer 1 (Heuristics): High-weight keyword matching for 30+ specific topics (Babar Azam, LBW, PSL, etc.).Layer 2 (ML Fallback): If no keyword matches, the system uses the PredictedLabel from ML.NET to provide a category-specific expert summary.C#// Core Prediction Snippet
var input = new CricketAI.ModelInput() { Col0 = txtQuestion.Text };
var result = CricketAI.Predict(input);
ProcessExpertKnowledge(result, userQuery);

🐳 5. Docker ImplementationThe application is containerized for seamless deployment using a specialized Dockerfile that targets the .NET 10.0 SDK.Bash# Build the Docker image
docker build -t cricket-ai-app .

# Execute the container
docker run cricket-ai-app
Note: Includes EnableWindowsTargeting=true to facilitate WinForms compilation within the container.

📈 6. Results & EvaluationThe system was tested against various edge cases, including empty inputs and unknown player names, demonstrating robust error handling and HCI (Human-Computer Interaction) transparency through real-time confidence score displays.FeatureStatusIntent Detection✅ Highly Accurate (LightGBM)Response Speed✅ < 100ms (Offline Inference)UI Experience✅ Color-coded RichText Feedback👤 DeveloperFarkhanda Moqim BSCS (5th Semester) | Artificial Intelligence in .NET GitHub Profile
