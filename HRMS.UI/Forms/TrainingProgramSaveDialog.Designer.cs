namespace HRMS.UI.Forms
{
    partial class TrainingProgramSaveDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            chkListEmployees = new CheckedListBox();
            lblChkLstTitle = new Label();
            lblDialogTitle = new Label();
            btnYes = new Button();
            btnNo = new Button();
            txtEmployeeSearch = new TextBox();
            lstStudents = new ListBox();
            lblLstTitle = new Label();
            btnProcess = new Button();
            SuspendLayout();
            // 
            // chkListEmployees
            // 
            chkListEmployees.FormattingEnabled = true;
            chkListEmployees.Location = new Point(12, 121);
            chkListEmployees.Name = "chkListEmployees";
            chkListEmployees.Size = new Size(246, 220);
            chkListEmployees.TabIndex = 0;
            // 
            // lblChkLstTitle
            // 
            lblChkLstTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblChkLstTitle.ForeColor = Color.White;
            lblChkLstTitle.Location = new Point(12, 67);
            lblChkLstTitle.Name = "lblChkLstTitle";
            lblChkLstTitle.Size = new Size(246, 22);
            lblChkLstTitle.TabIndex = 1;
            lblChkLstTitle.Text = "ÇALIŞAN SEÇİNİZ";
            lblChkLstTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDialogTitle
            // 
            lblDialogTitle.BackColor = Color.Green;
            lblDialogTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblDialogTitle.ForeColor = Color.White;
            lblDialogTitle.Location = new Point(12, 2);
            lblDialogTitle.Name = "lblDialogTitle";
            lblDialogTitle.Size = new Size(524, 65);
            lblDialogTitle.TabIndex = 2;
            lblDialogTitle.Text = "EĞİTİM PROGRAMI KAYIT FORMU";
            lblDialogTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnYes
            // 
            btnYes.BackColor = Color.FromArgb(128, 255, 128);
            btnYes.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnYes.Location = new Point(429, 347);
            btnYes.Name = "btnYes";
            btnYes.Size = new Size(107, 31);
            btnYes.TabIndex = 3;
            btnYes.Text = "ONAYLA";
            btnYes.UseVisualStyleBackColor = false;
            btnYes.Click += BtnYes_Click;
            // 
            // btnNo
            // 
            btnNo.BackColor = Color.FromArgb(255, 128, 128);
            btnNo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnNo.Location = new Point(301, 347);
            btnNo.Name = "btnNo";
            btnNo.Size = new Size(107, 31);
            btnNo.TabIndex = 3;
            btnNo.Text = "VAZGEÇ";
            btnNo.UseVisualStyleBackColor = false;
            btnNo.Click += BtnNo_Click;
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Location = new Point(12, 92);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.PlaceholderText = "ÇALIŞAN ARA";
            txtEmployeeSearch.Size = new Size(246, 23);
            txtEmployeeSearch.TabIndex = 4;
            txtEmployeeSearch.TextChanged += TxtEmployeeSearch_TextChanged;
            // 
            // lstStudents
            // 
            lstStudents.FormattingEnabled = true;
            lstStudents.IntegralHeight = false;
            lstStudents.ItemHeight = 15;
            lstStudents.Location = new Point(301, 92);
            lstStudents.Name = "lstStudents";
            lstStudents.Size = new Size(235, 249);
            lstStudents.TabIndex = 5;
            lstStudents.DoubleClick += LstStudents_DoubleClick;
            // 
            // lblLstTitle
            // 
            lblLstTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLstTitle.ForeColor = Color.White;
            lblLstTitle.Location = new Point(301, 67);
            lblLstTitle.Name = "lblLstTitle";
            lblLstTitle.Size = new Size(235, 22);
            lblLstTitle.TabIndex = 1;
            lblLstTitle.Text = "EĞİTİM GÖRECEK ÇALIŞANLAR";
            lblLstTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnProcess
            // 
            btnProcess.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnProcess.Location = new Point(12, 347);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(246, 31);
            btnProcess.TabIndex = 6;
            btnProcess.Text = "SEÇİLENLERİ AKTAR >>";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += BtnProcess_Click;
            // 
            // TrainingProgramSaveDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(0, 64, 0);
            ClientSize = new Size(548, 386);
            Controls.Add(btnProcess);
            Controls.Add(lstStudents);
            Controls.Add(txtEmployeeSearch);
            Controls.Add(btnNo);
            Controls.Add(btnYes);
            Controls.Add(lblDialogTitle);
            Controls.Add(lblLstTitle);
            Controls.Add(lblChkLstTitle);
            Controls.Add(chkListEmployees);
            Name = "TrainingProgramSaveDialog";
            Text = "EĞİTİM PROGRAMI KAYIT FORMU";
            TopMost = true;
            Load += TrainingProgramSaveDialog_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chkListEmployees;
        private Label lblChkLstTitle;
        private Label lblDialogTitle;
        private Button btnYes;
        private Button btnNo;
        private TextBox txtEmployeeSearch;
        private ListBox lstStudents;
        private Label lblLstTitle;
        private Button btnProcess;
    }
}