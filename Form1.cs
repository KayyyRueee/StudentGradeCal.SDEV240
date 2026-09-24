namespace StudentCal
{
    public partial class Form1 : Form
    {
        private Assignment[] Assignments;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblStatusMessage.Text = "Please enter your student ID.";
        }

        private void btnLoadClass_Click(object sender, EventArgs e)
        {
            if (txtStudentID.Text != "1001" && txtStudentID.Text != "1002")
            {
                lblStatusMessage.Text = "Student ID not found.";
                return;
            }

            cboClass.Items.Clear();
            cboClass.Items.Add("Programming");
            cboClass.Items.Add("Mathematics");

            cboClass.SelectedIndex = -1;

            lblStatusMessage.Text = "Student ID verified. Please select a class.";
        }
        private void btnCalculateCurrent_Click(object sender, EventArgs e)
        {
            if (Assignments == null)
            {
                lblStatusMessage.Text = "Please load a class first.";
                return;
            }

            double gradedPoints = 0;
            double gradedPossible = 0;

            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] is GradedAssignment)
                {
                    gradedPoints += Assignments[i].GetPointsForCalculation();
                    gradedPossible += Assignments[i].PossiblePoints;
                }
            }

            double currentGrade = CalculateCurrentGrade(
                gradedPoints,
                gradedPossible);

            string currentLetterGrade = DetermineLetterGrade(currentGrade);

            txtCurrentGrade.Text = currentGrade.ToString("F2") + "%";
            txtCurrentLetter.Text = currentLetterGrade;

            lblStatusMessage.Text = "Current grade calculated.";
        }

        private void btnCalculateEstimated_Click(object sender, EventArgs e)
        {
            if (Assignments == null)
            {
                lblStatusMessage.Text = "Please load a class first.";
                return;
            }

            double gradedPoints = 0;
            double gradedPossible = 0;
            double estimatedPoints = 0;
            double estimatedPossible = 0;

            for (int i = 0; i < Assignments.Length; i++)
            {
                if (Assignments[i] is GradedAssignment)
                {
                    gradedPoints += Assignments[i].GetPointsForCalculation();
                    gradedPossible += Assignments[i].PossiblePoints;
                }
                else
                {
                    string input = dgvAssignments.Rows[i].Cells["colEstScore"].Value?.ToString();

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        continue;
                    }

                    double estimate;

                    if (!double.TryParse(input, out estimate))
                    {
                        lblStatusMessage.Text = "Please enter a valid estimated score.";
                        return;
                    }

                    if (estimate < 0 || estimate > Assignments[i].PossiblePoints)
                    {
                        lblStatusMessage.Text =
                            "Estimated score must be between 0 and "
                            + Assignments[i].PossiblePoints + ".";
                        return;
                    }

                    estimatedPoints += estimate;
                    estimatedPossible += Assignments[i].PossiblePoints;
                }
            }

            if (estimatedPossible == 0)
            {
                lblStatusMessage.Text =
                    "Enter an estimated score before calculating.";
                return;
            }

            double estimatedGrade = CalculateEstimatedGrade(
                gradedPoints,
                gradedPossible,
                estimatedPoints,
                estimatedPossible);

            string estimatedLetterGrade =
                DetermineLetterGrade(estimatedGrade);

            txtEstimatedGrade.Text = estimatedGrade.ToString("F2") + "%";
            txtEstimatedLetter.Text = estimatedLetterGrade;

            lblStatusMessage.Text = "Estimated grade calculated.";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtStudentID.Clear();

            cboClass.SelectedIndex = -1;
            cboClass.Text = "Select a class";

            dgvAssignments.Rows.Clear();

            txtCurrentGrade.Clear();
            txtCurrentLetter.Clear();
            txtEstimatedGrade.Clear();
            txtEstimatedLetter.Clear();

            Assignments = null;

            lblStatusMessage.Text = "Ready";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        static Assignment[] GetAssignments(string classStudy)
        {
            Assignment[] assignments;

            if (classStudy == "Programming")
            {
                assignments = new Assignment[]
                {
            new GradedAssignment("Assignment 1", 100, 90),
            new GradedAssignment("Assignment 2", 100, 85),
            new EstimatedAssignment("Final Project", 100, 0)
                };
            }
            else
            {
                assignments = new Assignment[]
                {
            new GradedAssignment("Test 1", 100, 80),
            new GradedAssignment("Test 2", 100, 90),
            new EstimatedAssignment("Final Test", 100, 0)
                };
            }

            return assignments; 
        }

        static double CalculateCurrentGrade(double studentInput, double totalPoints)
        {

            if (totalPoints <= 0)
            {
                return 0;
            }

            double currentGrade = (studentInput / totalPoints) * 100;
            return currentGrade;
        }

        static double CalculateEstimatedGrade(
            double gradedPoints,
            double gradedPossible,
            double estimatedPoints,
            double estimatedPossible)
        {
            double totalPoints = gradedPoints + estimatedPoints;
            double totalPossible = gradedPossible + estimatedPossible;

            if (totalPossible <= 0)
            {
                return 0;
            }

            double estimatedGrade = (totalPoints / totalPossible) * 100;
            return estimatedGrade;
        }

        static string DetermineLetterGrade(double percentage)
        {
            if (percentage >= 90) return "A";
            else if (percentage >= 80) return "B";
            else if (percentage >= 70) return "C";
            else if (percentage >= 60) return "D";
            else return "F";
        }

        private void cboClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboClass.SelectedItem == null)
            {
                return;
            }

            string classStudy = cboClass.SelectedItem.ToString();

            Assignments = GetAssignments(classStudy);

            dgvAssignments.Rows.Clear();

            foreach (Assignment assignment in Assignments)
            {
                if (assignment is GradedAssignment)
                {
                    dgvAssignments.Rows.Add(
                        assignment.Name,
                        assignment.PossiblePoints,
                        assignment.GetPointsForCalculation(),
                        "");
                }
                else
                {
                    dgvAssignments.Rows.Add(
                        assignment.Name,
                        assignment.PossiblePoints,
                        "",
                        "");
                }
            }

            lblStatusMessage.Text = classStudy + " loaded successfully.";
        }

        private void lblAssignments_Click(object sender, EventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusMessage_Click(object sender, EventArgs e)
        {

        }

        private void lblStatusMessage_Click_1(object sender, EventArgs e)
        {

        }
    }

  
}
