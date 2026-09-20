namespace StudentCal
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentID = new Label();
            txtStudentID = new TextBox();
            btnLoadClass = new Button();
            lblClass = new Label();
            cboClass = new ComboBox();
            lblAssignments = new Label();
            dgvAssignments = new DataGridView();
            colAssignments = new DataGridViewTextBoxColumn();
            colPosPts = new DataGridViewTextBoxColumn();
            calGrdPts = new DataGridViewTextBoxColumn();
            colEstScore = new DataGridViewTextBoxColumn();
            btnCalculateCurrent = new Button();
            btnCalculateEstimated = new Button();
            btnExit = new Button();
            btnClear = new Button();
            grpResults = new GroupBox();
            lblEstimatedLetter = new Label();
            lblCurrentLetter = new Label();
            txtEstimatedLetter = new TextBox();
            txtCurrentLetter = new TextBox();
            txtEstimatedGrade = new TextBox();
            txtCurrentGrade = new TextBox();
            lblEstimatedGrade = new Label();
            lblCurrentGrade = new Label();
            lblStatus = new Label();
            lblStatusMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).BeginInit();
            grpResults.SuspendLayout();
            SuspendLayout();
            // 
            // lblStudentID
            // 
            lblStudentID.AutoSize = true;
            lblStudentID.Location = new Point(17, 26);
            lblStudentID.Name = "lblStudentID";
            lblStudentID.Size = new Size(86, 20);
            lblStudentID.TabIndex = 0;
            lblStudentID.Text = " Student ID:";
            // 
            // txtStudentID
            // 
            txtStudentID.Location = new Point(112, 23);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(125, 27);
            txtStudentID.TabIndex = 1;
            // 
            // btnLoadClass
            // 
            btnLoadClass.Location = new Point(243, 22);
            btnLoadClass.Name = "btnLoadClass";
            btnLoadClass.Size = new Size(115, 29);
            btnLoadClass.TabIndex = 2;
            btnLoadClass.Text = "Load Classes";
            btnLoadClass.UseVisualStyleBackColor = true;
            btnLoadClass.Click += btnLoadClass_Click;
            // 
            // lblClass
            // 
            lblClass.AutoSize = true;
            lblClass.Location = new Point(38, 57);
            lblClass.Name = "lblClass";
            lblClass.Size = new Size(42, 20);
            lblClass.TabIndex = 3;
            lblClass.Text = "Class";
            // 
            // cboClass
            // 
            cboClass.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            cboClass.FormattingEnabled = true;
            cboClass.Location = new Point(112, 54);
            cboClass.Name = "cboClass";
            cboClass.Size = new Size(246, 28);
            cboClass.TabIndex = 4;
            cboClass.Text = "Select a class";
            cboClass.SelectedIndexChanged += cboClass_SelectedIndexChanged;
            // 
            // lblAssignments
            // 
            lblAssignments.AutoSize = true;
            lblAssignments.Location = new Point(33, 101);
            lblAssignments.Name = "lblAssignments";
            lblAssignments.Size = new Size(92, 20);
            lblAssignments.TabIndex = 5;
            lblAssignments.Text = "Assignments";
            lblAssignments.Click += lblAssignments_Click;
            // 
            // dgvAssignments
            // 
            dgvAssignments.AllowUserToAddRows = false;
            dgvAssignments.AllowUserToDeleteRows = false;
            dgvAssignments.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvAssignments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvAssignments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvAssignments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAssignments.Columns.AddRange(new DataGridViewColumn[] { colAssignments, colPosPts, calGrdPts, colEstScore });
            dgvAssignments.Location = new Point(33, 135);
            dgvAssignments.MaximumSize = new Size(487, 250);
            dgvAssignments.MinimumSize = new Size(487, 106);
            dgvAssignments.Name = "dgvAssignments";
            dgvAssignments.RowHeadersVisible = false;
            dgvAssignments.RowHeadersWidth = 51;
            dgvAssignments.Size = new Size(487, 106);
            dgvAssignments.TabIndex = 6;
            // 
            // colAssignments
            // 
            colAssignments.HeaderText = "Assignments";
            colAssignments.MinimumWidth = 6;
            colAssignments.Name = "colAssignments";
            colAssignments.ReadOnly = true;
            colAssignments.Resizable = DataGridViewTriState.False;
            colAssignments.Width = 121;
            // 
            // colPosPts
            // 
            colPosPts.HeaderText = "Possible Pts";
            colPosPts.MinimumWidth = 6;
            colPosPts.Name = "colPosPts";
            colPosPts.ReadOnly = true;
            colPosPts.Resizable = DataGridViewTriState.False;
            colPosPts.Width = 114;
            // 
            // calGrdPts
            // 
            calGrdPts.HeaderText = "Graded Pts";
            calGrdPts.MinimumWidth = 6;
            calGrdPts.Name = "calGrdPts";
            calGrdPts.ReadOnly = true;
            calGrdPts.Resizable = DataGridViewTriState.False;
            calGrdPts.Width = 110;
            // 
            // colEstScore
            // 
            colEstScore.HeaderText = "Estimated Score";
            colEstScore.MinimumWidth = 6;
            colEstScore.Name = "colEstScore";
            colEstScore.Resizable = DataGridViewTriState.False;
            colEstScore.Width = 145;
            // 
            // btnCalculateCurrent
            // 
            btnCalculateCurrent.Location = new Point(60, 390);
            btnCalculateCurrent.Name = "btnCalculateCurrent";
            btnCalculateCurrent.Size = new Size(124, 50);
            btnCalculateCurrent.TabIndex = 7;
            btnCalculateCurrent.Text = "Calculate Current Grade";
            btnCalculateCurrent.UseVisualStyleBackColor = true;
            btnCalculateCurrent.Click += btnCalculateCurrent_Click;
            // 
            // btnCalculateEstimated
            // 
            btnCalculateEstimated.Location = new Point(339, 390);
            btnCalculateEstimated.Name = "btnCalculateEstimated";
            btnCalculateEstimated.Size = new Size(127, 50);
            btnCalculateEstimated.TabIndex = 8;
            btnCalculateEstimated.Text = "Calculate Estimated Grade";
            btnCalculateEstimated.UseVisualStyleBackColor = true;
            btnCalculateEstimated.Click += btnCalculateEstimated_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(355, 455);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 9;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(72, 455);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // grpResults
            // 
            grpResults.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            grpResults.Controls.Add(lblEstimatedLetter);
            grpResults.Controls.Add(lblCurrentLetter);
            grpResults.Controls.Add(txtEstimatedLetter);
            grpResults.Controls.Add(txtCurrentLetter);
            grpResults.Controls.Add(txtEstimatedGrade);
            grpResults.Controls.Add(txtCurrentGrade);
            grpResults.Controls.Add(lblEstimatedGrade);
            grpResults.Controls.Add(lblCurrentGrade);
            grpResults.Location = new Point(38, 503);
            grpResults.MaximumSize = new Size(482, 160);
            grpResults.MinimumSize = new Size(482, 116);
            grpResults.Name = "grpResults";
            grpResults.Size = new Size(482, 116);
            grpResults.TabIndex = 11;
            grpResults.TabStop = false;
            grpResults.Text = "Results";
            // 
            // lblEstimatedLetter
            // 
            lblEstimatedLetter.AutoSize = true;
            lblEstimatedLetter.Location = new Point(220, 69);
            lblEstimatedLetter.Name = "lblEstimatedLetter";
            lblEstimatedLetter.Size = new Size(120, 20);
            lblEstimatedLetter.TabIndex = 19;
            lblEstimatedLetter.Text = "Estimated Letter:";
            // 
            // lblCurrentLetter
            // 
            lblCurrentLetter.AutoSize = true;
            lblCurrentLetter.Location = new Point(238, 32);
            lblCurrentLetter.Name = "lblCurrentLetter";
            lblCurrentLetter.Size = new Size(102, 20);
            lblCurrentLetter.TabIndex = 18;
            lblCurrentLetter.Text = "Current Letter:";
            // 
            // txtEstimatedLetter
            // 
            txtEstimatedLetter.Location = new Point(357, 69);
            txtEstimatedLetter.Name = "txtEstimatedLetter";
            txtEstimatedLetter.ReadOnly = true;
            txtEstimatedLetter.Size = new Size(55, 27);
            txtEstimatedLetter.TabIndex = 17;
            // 
            // txtCurrentLetter
            // 
            txtCurrentLetter.Location = new Point(357, 32);
            txtCurrentLetter.Name = "txtCurrentLetter";
            txtCurrentLetter.ReadOnly = true;
            txtCurrentLetter.Size = new Size(55, 27);
            txtCurrentLetter.TabIndex = 16;
            // 
            // txtEstimatedGrade
            // 
            txtEstimatedGrade.Location = new Point(134, 62);
            txtEstimatedGrade.Name = "txtEstimatedGrade";
            txtEstimatedGrade.ReadOnly = true;
            txtEstimatedGrade.Size = new Size(53, 27);
            txtEstimatedGrade.TabIndex = 15;
            // 
            // txtCurrentGrade
            // 
            txtCurrentGrade.Location = new Point(134, 29);
            txtCurrentGrade.Name = "txtCurrentGrade";
            txtCurrentGrade.ReadOnly = true;
            txtCurrentGrade.Size = new Size(51, 27);
            txtCurrentGrade.TabIndex = 14;
            // 
            // lblEstimatedGrade
            // 
            lblEstimatedGrade.AutoSize = true;
            lblEstimatedGrade.Location = new Point(6, 66);
            lblEstimatedGrade.Name = "lblEstimatedGrade";
            lblEstimatedGrade.Size = new Size(122, 20);
            lblEstimatedGrade.TabIndex = 13;
            lblEstimatedGrade.Text = "Estimated Grade:";
            // 
            // lblCurrentGrade
            // 
            lblCurrentGrade.AutoSize = true;
            lblCurrentGrade.Location = new Point(6, 32);
            lblCurrentGrade.Name = "lblCurrentGrade";
            lblCurrentGrade.Size = new Size(104, 20);
            lblCurrentGrade.TabIndex = 12;
            lblCurrentGrade.Text = "Current Grade:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(38, 667);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 12;
            lblStatus.Text = "Status";
            // 
            // lblStatusMessage
            // 
            lblStatusMessage.AutoSize = true;
            lblStatusMessage.Location = new Point(33, 687);
            lblStatusMessage.Name = "lblStatusMessage";
            lblStatusMessage.Size = new Size(65, 20);
            lblStatusMessage.TabIndex = 13;
            lblStatusMessage.Text = "              ";
            lblStatusMessage.Click += lblStatusMessage_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(675, 740);
            Controls.Add(lblStatusMessage);
            Controls.Add(lblStatus);
            Controls.Add(grpResults);
            Controls.Add(btnClear);
            Controls.Add(btnExit);
            Controls.Add(btnCalculateEstimated);
            Controls.Add(btnCalculateCurrent);
            Controls.Add(dgvAssignments);
            Controls.Add(lblAssignments);
            Controls.Add(cboClass);
            Controls.Add(lblClass);
            Controls.Add(btnLoadClass);
            Controls.Add(txtStudentID);
            Controls.Add(lblStudentID);
            Name = "Form1";
            Text = "Student Grade Calculator";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAssignments).EndInit();
            grpResults.ResumeLayout(false);
            grpResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentID;
        private TextBox txtStudentID;
        private Button btnLoadClass;
        private Label lblClass;
        private ComboBox cboClass;
        private Label lblAssignments;
        private DataGridView dgvAssignments;
        private Button btnCalculateCurrent;
        private Button btnCalculateEstimated;
        private Button btnExit;
        private Button btnClear;
        private GroupBox grpResults;
        private Label lblCurrentGrade;
        private TextBox txtCurrentGrade;
        private Label lblEstimatedGrade;
        private Label lblEstimatedLetter;
        private Label lblCurrentLetter;
        private TextBox txtEstimatedLetter;
        private TextBox txtCurrentLetter;
        private TextBox txtEstimatedGrade;
        private Label lblStatus;
        private Label lblStatusMessage;
        private DataGridViewTextBoxColumn colAssignments;
        private DataGridViewTextBoxColumn colPosPts;
        private DataGridViewTextBoxColumn calGrdPts;
        private DataGridViewTextBoxColumn colEstScore;
    }
}
