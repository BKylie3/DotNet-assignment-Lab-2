using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace StudentRentalAndMushroomApp
{
    public partial class MushroomIdForm : Form
    {
        private readonly MainMenuForm _mainMenuForm;
        private readonly LoginForm _loginForm;
        private bool _isNavigating = false;

        // Botanical database according to the assignment specification
        private List<Mushroom> _allMushrooms = new List<Mushroom>();
        private List<Question> _allQuestions = new List<Question>();

        // Session state
        private List<Mushroom> _remainingMushrooms = new List<Mushroom>();
        private readonly List<int> _askedQuestionIds = new List<int>();
        private int _questionsAskedCount = 0;
        private Question? _currentQuestion = null;

        public MushroomIdForm(MainMenuForm mainMenuForm, LoginForm loginForm)
        {
            _mainMenuForm = mainMenuForm;
            _loginForm = loginForm;
            InitializeComponent();
            InitializeDatabase();
            StartNewIdentification();
        }

        /// <summary>
        /// Populates the initial database of mushrooms and questions.
        /// </summary>
        private void InitializeDatabase()
        {
            // Table from assignment:
            // 1. Agaric jaunissant: Gills=Yes, Forest=No,  Ring=Yes, Convex=Yes
            // 2. Amanite tue-mouche: Gills=Yes, Forest=Yes, Ring=Yes, Convex=Yes
            // 3. Cèpe de Bordeaux:  Gills=No,  Forest=Yes, Ring=No,  Convex=No
            // 4. Coprin chevelu:    Gills=Yes, Forest=No,  Ring=Yes, Convex=No
            // 5. Girolle:           Gills=Yes, Forest=Yes, Ring=No,  Convex=No
            // 6. Pied bleu:         Gills=Yes, Forest=Yes, Ring=No,  Convex=Yes

            _allMushrooms = new List<Mushroom>
            {
                new Mushroom("Agaric jaunissant",  hasGills: true,  growsInForest: false, hasRing: true,  hasConvexCup: true),
                new Mushroom("Amanite tue-mouche", hasGills: true,  growsInForest: true,  hasRing: true,  hasConvexCup: true),
                new Mushroom("Cèpe de Bordeaux",   hasGills: false, growsInForest: true,  hasRing: false, hasConvexCup: false),
                new Mushroom("Coprin chevelu",     hasGills: true,  growsInForest: false, hasRing: true,  hasConvexCup: false),
                new Mushroom("Girolle",            hasGills: true,  growsInForest: true,  hasRing: false, hasConvexCup: false),
                new Mushroom("Pied bleu",          hasGills: true,  growsInForest: true,  hasRing: false, hasConvexCup: true)
            };

            // Four defined questions
            _allQuestions = new List<Question>
            {
                new Question(1, "Does your mushroom grow in a forest?"),
                new Question(2, "Does your mushroom have gills"),
                new Question(3, "Does your mushroom have a ring?"),
                new Question(4, "Does your mushroom have a convex cup?")
            };
        }

        /// <summary>
        /// Starts or resets an identification session.
        /// </summary>
        private void StartNewIdentification()
        {
            _remainingMushrooms = new List<Mushroom>(_allMushrooms);
            _askedQuestionIds.Clear();
            _questionsAskedCount = 0;

            lstHistory.Items.Clear();
            btnYes.Enabled = true;
            btnNo.Enabled = true;

            lblResultStatus.Text = "Identification Status:";
            lblResultStatus.ForeColor = Color.FromArgb(60, 60, 60);
            lblResultMessage.Text = "Identification session started. Please answer the question above truthfully using YES or NO.";
            lblResultMessage.ForeColor = Color.FromArgb(30, 45, 70);

            UpdateCandidateListUI();
            PresentNextQuestion();
        }

        /// <summary>
        /// Updates the candidate mushrooms listbox and remaining count badge.
        /// </summary>
        private void UpdateCandidateListUI()
        {
            lstRemaining.Items.Clear();
            foreach (var m in _remainingMushrooms)
            {
                lstRemaining.Items.Add(m.Name);
            }

            lblRemainingCount.Text = $"{_remainingMushrooms.Count} of {_allMushrooms.Count} candidates remain";
        }

        /// <summary>
        /// Selects the best next question adaptively based on the remaining candidate mushrooms.
        /// </summary>
        private Question? SelectAdaptiveQuestion()
        {
            // First question: begin with Question 1 ("Does your mushroom grow in a forest?")
            if (_askedQuestionIds.Count == 0)
            {
                return _allQuestions[0];
            }

            // Adaptive selection: evaluate unasked questions to find the one that best splits
            // the remaining mushrooms (i.e. minimizes the difference between YES and NO counts)
            Question? bestQuestion = null;
            int bestDifference = int.MaxValue;

            foreach (var question in _allQuestions)
            {
                // Skip questions already asked
                if (_askedQuestionIds.Contains(question.Id))
                {
                    continue;
                }

                int countYes = 0;
                int countNo = 0;

                foreach (var mushroom in _remainingMushrooms)
                {
                    if (mushroom.GetCharacteristic(question.Id))
                    {
                        countYes++;
                    }
                    else
                    {
                        countNo++;
                    }
                }

                // A question is useful only if it can eliminate at least one candidate (both counts > 0)
                if (countYes > 0 && countNo > 0)
                {
                    int difference = Math.Abs(countYes - countNo);
                    if (difference < bestDifference)
                    {
                        bestDifference = difference;
                        bestQuestion = question;
                    }
                }
            }

            // Fallback: if no question provides a partition, pick the first unasked question
            if (bestQuestion == null)
            {
                foreach (var question in _allQuestions)
                {
                    if (!_askedQuestionIds.Contains(question.Id))
                    {
                        bestQuestion = question;
                        break;
                    }
                }
            }

            return bestQuestion;
        }

        /// <summary>
        /// Displays the next question or concludes identification if termination criteria are met.
        /// </summary>
        private void PresentNextQuestion()
        {
            // Check condition 1: Exactly 1 mushroom remains -> Identify immediately
            if (_remainingMushrooms.Count == 1)
            {
                ConcludeIdentificationSingle(_remainingMushrooms[0]);
                return;
            }

            // Check condition 2: 0 mushrooms remain -> No match
            if (_remainingMushrooms.Count == 0)
            {
                ConcludeIdentificationNoMatch();
                return;
            }

            // Check condition 3: Maximum 3 questions reached -> Display remaining possibilities
            if (_questionsAskedCount >= 3)
            {
                ConcludeIdentificationMultipleRemaining();
                return;
            }

            // Select next question adaptively
            _currentQuestion = SelectAdaptiveQuestion();

            if (_currentQuestion == null)
            {
                // No more questions available
                if (_remainingMushrooms.Count > 1)
                {
                    ConcludeIdentificationMultipleRemaining();
                }
                else
                {
                    ConcludeIdentificationNoMatch();
                }
                return;
            }

            // Display question
            int currentStep = _questionsAskedCount + 1;
            lblQuestionBadge.Text = $"QUESTION {currentStep} OF AT MOST 3";
            lblQuestionPrompt.Text = _currentQuestion.Text;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            ProcessAnswer(true);
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            ProcessAnswer(false);
        }

        /// <summary>
        /// Processes user's YES or NO response:
        /// 1. Eliminates mushrooms that do not match the answer using loops and decision logic.
        /// 2. Records question history.
        /// 3. Advances question count.
        /// 4. Determines whether to conclude or adaptively select the next question.
        /// </summary>
        private void ProcessAnswer(bool userAnswer)
        {
            if (_currentQuestion == null) return;

            // 1. Record the question and answer in history
            string answerText = userAnswer ? "YES" : "NO";
            lstHistory.Items.Add($"Q{_questionsAskedCount + 1}: {_currentQuestion.Text} -> {answerText}");
            _askedQuestionIds.Add(_currentQuestion.Id);
            _questionsAskedCount++;

            // 2. Eliminate mushrooms that do not match the answer
            // Implemented using a loop and condition as required
            List<Mushroom> matchingMushrooms = new List<Mushroom>();
            foreach (var mushroom in _remainingMushrooms)
            {
                bool characteristicValue = mushroom.GetCharacteristic(_currentQuestion.Id);
                if (characteristicValue == userAnswer)
                {
                    matchingMushrooms.Add(mushroom);
                }
            }
            _remainingMushrooms = matchingMushrooms;

            // 3. Update candidate list in GUI
            UpdateCandidateListUI();

            // 4. Check status and present next question
            PresentNextQuestion();
        }

        /// <summary>
        /// Concludes when exactly one mushroom has been uniquely identified.
        /// </summary>
        private void ConcludeIdentificationSingle(Mushroom identifiedMushroom)
        {
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            lblQuestionBadge.Text = "IDENTIFICATION COMPLETE";
            lblQuestionPrompt.Text = $"Identification completed in {_questionsAskedCount} question(s).";

            lblResultStatus.Text = "Result: Identified Mushroom";
            lblResultStatus.ForeColor = Color.FromArgb(46, 125, 50);

            lblResultMessage.ForeColor = Color.FromArgb(46, 125, 50);
            lblResultMessage.Text = $"SUCCESS! Your mushroom is uniquely identified as:\n" +
                                   $"• {identifiedMushroom.Name}\n" +
                                   $"[Gills: {(identifiedMushroom.HasGills ? "Yes" : "No")} | " +
                                   $"Forest: {(identifiedMushroom.GrowsInForest ? "Yes" : "No")} | " +
                                   $"Ring: {(identifiedMushroom.HasRing ? "Yes" : "No")} | " +
                                   $"Convex cup: {(identifiedMushroom.HasConvexCup ? "Yes" : "No")}]";
        }

        /// <summary>
        /// Concludes when no mushroom in the database matches the user's answers.
        /// </summary>
        private void ConcludeIdentificationNoMatch()
        {
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            lblQuestionBadge.Text = "IDENTIFICATION COMPLETE";
            lblQuestionPrompt.Text = "No mushroom matches your answers.";

            lblResultStatus.Text = "Result: No Match Found";
            lblResultStatus.ForeColor = Color.FromArgb(211, 47, 47);

            lblResultMessage.ForeColor = Color.FromArgb(211, 47, 47);
            lblResultMessage.Text = "No mushroom in the botanical database matches this combination of answers.\n" +
                                   "Click 'Restart Identification' below to begin a new identification.";
        }

        /// <summary>
        /// Concludes when 3 questions have been asked but multiple candidates still remain.
        /// </summary>
        private void ConcludeIdentificationMultipleRemaining()
        {
            btnYes.Enabled = false;
            btnNo.Enabled = false;
            lblQuestionBadge.Text = "3-QUESTION LIMIT REACHED";
            lblQuestionPrompt.Text = "Maximum of 3 questions asked.";

            lblResultStatus.Text = "Result: Multiple Possibilities Remaining";
            lblResultStatus.ForeColor = Color.FromArgb(190, 110, 0);

            string remainingNames = string.Join(", ", _remainingMushrooms.Select(m => m.Name));
            lblResultMessage.ForeColor = Color.FromArgb(170, 95, 0);
            lblResultMessage.Text = $"The identification reached the maximum limit of 3 questions.\n" +
                                   $"Remaining possible mushrooms:\n• {remainingNames}";
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewIdentification();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            this.Close();
            _mainMenuForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            _isNavigating = true;
            this.Close();
            _mainMenuForm.LogoutToLogin();
        }

        private void MushroomIdForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_isNavigating && e.CloseReason == CloseReason.UserClosing)
            {
                _mainMenuForm.Show();
            }
        }
    }
}
