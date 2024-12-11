namespace HRMS.UI.Forms
{
    partial class TrainingProgramForm
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
            btnTrainingProgramDelete = new Button();
            lstTrainingProgram = new ListBox();
            btnTrainingProgramUpdate = new Button();
            txtTrainingProgramSearch = new TextBox();
            lblTrainingProgramName = new Label();
            txtTrainingProgramName = new TextBox();
            lblTrainingProgramDescription = new Label();
            txtTrainingProgramDescription = new TextBox();
            dtTrainingProgramStartDate = new DateTimePicker();
            lblTrainingProgramStartDate = new Label();
            lblTrainingProgramEndDate = new Label();
            dtTrainingProgramEndDate = new DateTimePicker();
            lblTrainer = new Label();
            lstEmployees = new ListBox();
            txtTrainerSearch = new TextBox();
            btnTrainingProgramAdd = new Button();
            SuspendLayout();
            // 
            // btnTrainingProgramDelete
            // 
            btnTrainingProgramDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnTrainingProgramDelete.Location = new Point(456, 381);
            btnTrainingProgramDelete.Name = "btnTrainingProgramDelete";
            btnTrainingProgramDelete.Size = new Size(130, 55);
            btnTrainingProgramDelete.TabIndex = 0;
            btnTrainingProgramDelete.Text = "SEÇİLİ EĞİTİM PROGRAMINI SİL";
            btnTrainingProgramDelete.UseVisualStyleBackColor = false;
            btnTrainingProgramDelete.Click += BtnTrainingProgramDelete_Click;
            // 
            // lstTrainingProgram
            // 
            lstTrainingProgram.FormattingEnabled = true;
            lstTrainingProgram.ItemHeight = 15;
            lstTrainingProgram.Location = new Point(302, 41);
            lstTrainingProgram.Name = "lstTrainingProgram";
            lstTrainingProgram.Size = new Size(285, 334);
            lstTrainingProgram.TabIndex = 1;
            lstTrainingProgram.SelectedIndexChanged += LstTrainingProgram_SelectedIndexChanged;
            lstTrainingProgram.DoubleClick += LstTrainingProgram_DoubleClick;
            // 
            // btnTrainingProgramUpdate
            // 
            btnTrainingProgramUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnTrainingProgramUpdate.Location = new Point(302, 381);
            btnTrainingProgramUpdate.Name = "btnTrainingProgramUpdate";
            btnTrainingProgramUpdate.Size = new Size(130, 55);
            btnTrainingProgramUpdate.TabIndex = 0;
            btnTrainingProgramUpdate.Text = "SEÇİLİ EĞİTİM PROGRAMINI GÜNCELLE";
            btnTrainingProgramUpdate.UseVisualStyleBackColor = false;
            btnTrainingProgramUpdate.Click += BtnTrainingProgramUpdate_Click;
            // 
            // txtTrainingProgramSearch
            // 
            txtTrainingProgramSearch.Location = new Point(302, 12);
            txtTrainingProgramSearch.Name = "txtTrainingProgramSearch";
            txtTrainingProgramSearch.PlaceholderText = "EĞİTİM PROGRAMI ARA";
            txtTrainingProgramSearch.Size = new Size(285, 23);
            txtTrainingProgramSearch.TabIndex = 2;
            txtTrainingProgramSearch.TextChanged += TxtTrainingProgramSearch_TextChanged;
            // 
            // lblTrainingProgramName
            // 
            lblTrainingProgramName.AutoSize = true;
            lblTrainingProgramName.Location = new Point(12, 15);
            lblTrainingProgramName.Name = "lblTrainingProgramName";
            lblTrainingProgramName.Size = new Size(114, 15);
            lblTrainingProgramName.TabIndex = 3;
            lblTrainingProgramName.Text = "Eğitim Program Adı";
            // 
            // txtTrainingProgramName
            // 
            txtTrainingProgramName.Location = new Point(12, 33);
            txtTrainingProgramName.Name = "txtTrainingProgramName";
            txtTrainingProgramName.Size = new Size(241, 23);
            txtTrainingProgramName.TabIndex = 4;
            // 
            // lblTrainingProgramDescription
            // 
            lblTrainingProgramDescription.AutoSize = true;
            lblTrainingProgramDescription.Location = new Point(12, 59);
            lblTrainingProgramDescription.Name = "lblTrainingProgramDescription";
            lblTrainingProgramDescription.Size = new Size(154, 15);
            lblTrainingProgramDescription.TabIndex = 3;
            lblTrainingProgramDescription.Text = "Eğitim Program Açıklaması";
            // 
            // txtTrainingProgramDescription
            // 
            txtTrainingProgramDescription.Location = new Point(12, 77);
            txtTrainingProgramDescription.Multiline = true;
            txtTrainingProgramDescription.Name = "txtTrainingProgramDescription";
            txtTrainingProgramDescription.Size = new Size(241, 80);
            txtTrainingProgramDescription.TabIndex = 4;
            // 
            // dtTrainingProgramStartDate
            // 
            dtTrainingProgramStartDate.Location = new Point(12, 178);
            dtTrainingProgramStartDate.Name = "dtTrainingProgramStartDate";
            dtTrainingProgramStartDate.Size = new Size(241, 23);
            dtTrainingProgramStartDate.TabIndex = 5;
            // 
            // lblTrainingProgramStartDate
            // 
            lblTrainingProgramStartDate.AutoSize = true;
            lblTrainingProgramStartDate.Location = new Point(13, 160);
            lblTrainingProgramStartDate.Name = "lblTrainingProgramStartDate";
            lblTrainingProgramStartDate.Size = new Size(180, 15);
            lblTrainingProgramStartDate.TabIndex = 3;
            lblTrainingProgramStartDate.Text = "Eğitim Program Başlangıç Tarihi";
            // 
            // lblTrainingProgramEndDate
            // 
            lblTrainingProgramEndDate.AutoSize = true;
            lblTrainingProgramEndDate.Location = new Point(12, 204);
            lblTrainingProgramEndDate.Name = "lblTrainingProgramEndDate";
            lblTrainingProgramEndDate.Size = new Size(153, 15);
            lblTrainingProgramEndDate.TabIndex = 3;
            lblTrainingProgramEndDate.Text = "Eğitim Program Bitiş Tarihi";
            // 
            // dtTrainingProgramEndDate
            // 
            dtTrainingProgramEndDate.Location = new Point(12, 222);
            dtTrainingProgramEndDate.Name = "dtTrainingProgramEndDate";
            dtTrainingProgramEndDate.Size = new Size(241, 23);
            dtTrainingProgramEndDate.TabIndex = 5;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Location = new Point(12, 248);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(53, 15);
            lblTrainer.TabIndex = 3;
            lblTrainer.Text = "Eğitmen";
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(12, 298);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(241, 109);
            lstEmployees.TabIndex = 1;
            // 
            // txtTrainerSearch
            // 
            txtTrainerSearch.Location = new Point(12, 269);
            txtTrainerSearch.Name = "txtTrainerSearch";
            txtTrainerSearch.PlaceholderText = "EĞİTİMCİ ARA";
            txtTrainerSearch.Size = new Size(241, 23);
            txtTrainerSearch.TabIndex = 2;
            txtTrainerSearch.TextChanged += TxtTrainerSearch_TextChanged;
            // 
            // btnTrainingProgramAdd
            // 
            btnTrainingProgramAdd.BackColor = Color.FromArgb(192, 255, 192);
            btnTrainingProgramAdd.Location = new Point(12, 413);
            btnTrainingProgramAdd.Name = "btnTrainingProgramAdd";
            btnTrainingProgramAdd.Size = new Size(241, 23);
            btnTrainingProgramAdd.TabIndex = 6;
            btnTrainingProgramAdd.Text = "Eğitim Programını Ekle";
            btnTrainingProgramAdd.UseVisualStyleBackColor = false;
            btnTrainingProgramAdd.Click += BtnTrainingProgramAdd_Click;
            // 
            // TrainingProgramForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(598, 443);
            Controls.Add(btnTrainingProgramAdd);
            Controls.Add(dtTrainingProgramEndDate);
            Controls.Add(dtTrainingProgramStartDate);
            Controls.Add(txtTrainingProgramDescription);
            Controls.Add(txtTrainingProgramName);
            Controls.Add(lblTrainer);
            Controls.Add(lblTrainingProgramEndDate);
            Controls.Add(lblTrainingProgramStartDate);
            Controls.Add(lblTrainingProgramDescription);
            Controls.Add(lblTrainingProgramName);
            Controls.Add(txtTrainerSearch);
            Controls.Add(txtTrainingProgramSearch);
            Controls.Add(lstEmployees);
            Controls.Add(lstTrainingProgram);
            Controls.Add(btnTrainingProgramUpdate);
            Controls.Add(btnTrainingProgramDelete);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Name = "TrainingProgramForm";
            Text = "EĞİTİM PROGRAM FORMU";
            Load += TrainingProgramForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTrainingProgramDelete;
        private ListBox lstTrainingProgram;
        private Button btnTrainingProgramUpdate;
        private TextBox txtTrainingProgramSearch;
        private Label lblTrainingProgramName;
        private TextBox txtTrainingProgramName;
        private Label lblTrainingProgramDescription;
        private TextBox txtTrainingProgramDescription;
        private DateTimePicker dtTrainingProgramStartDate;
        private Label lblTrainingProgramStartDate;
        private Label lblTrainingProgramEndDate;
        private DateTimePicker dtTrainingProgramEndDate;
        private Label lblTrainer;
        private ListBox lstEmployees;
        private TextBox txtTrainerSearch;
        private Button btnTrainingProgramAdd;
    }
}