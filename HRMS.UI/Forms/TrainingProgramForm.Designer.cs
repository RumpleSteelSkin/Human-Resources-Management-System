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
            btnTrainingProgramDelete.Location = new Point(653, 547);
            btnTrainingProgramDelete.Margin = new Padding(5, 4, 5, 4);
            btnTrainingProgramDelete.Name = "btnTrainingProgramDelete";
            btnTrainingProgramDelete.Size = new Size(185, 77);
            btnTrainingProgramDelete.TabIndex = 0;
            btnTrainingProgramDelete.Text = "SEÇİLİ EĞİTİM PROGRAMINI SİL";
            btnTrainingProgramDelete.UseVisualStyleBackColor = false;
            btnTrainingProgramDelete.Click += BtnTrainingProgramDelete_Click;
            // 
            // lstTrainingProgram
            // 
            lstTrainingProgram.FormattingEnabled = true;
            lstTrainingProgram.ItemHeight = 21;
            lstTrainingProgram.Location = new Point(432, 57);
            lstTrainingProgram.Margin = new Padding(5, 4, 5, 4);
            lstTrainingProgram.Name = "lstTrainingProgram";
            lstTrainingProgram.Size = new Size(406, 487);
            lstTrainingProgram.TabIndex = 1;
            lstTrainingProgram.SelectedIndexChanged += LstTrainingProgram_SelectedIndexChanged;
            lstTrainingProgram.DoubleClick += LstTrainingProgram_DoubleClick;
            // 
            // btnTrainingProgramUpdate
            // 
            btnTrainingProgramUpdate.BackColor = Color.FromArgb(255, 224, 192);
            btnTrainingProgramUpdate.Location = new Point(433, 547);
            btnTrainingProgramUpdate.Margin = new Padding(5, 4, 5, 4);
            btnTrainingProgramUpdate.Name = "btnTrainingProgramUpdate";
            btnTrainingProgramUpdate.Size = new Size(185, 77);
            btnTrainingProgramUpdate.TabIndex = 0;
            btnTrainingProgramUpdate.Text = "SEÇİLİ EĞİTİM PROGRAMINI GÜNCELLE";
            btnTrainingProgramUpdate.UseVisualStyleBackColor = false;
            btnTrainingProgramUpdate.Click += BtnTrainingProgramUpdate_Click;
            // 
            // txtTrainingProgramSearch
            // 
            txtTrainingProgramSearch.Location = new Point(432, 17);
            txtTrainingProgramSearch.Margin = new Padding(5, 4, 5, 4);
            txtTrainingProgramSearch.Name = "txtTrainingProgramSearch";
            txtTrainingProgramSearch.PlaceholderText = "EĞİTİM PROGRAMI ARA";
            txtTrainingProgramSearch.Size = new Size(406, 29);
            txtTrainingProgramSearch.TabIndex = 2;
            txtTrainingProgramSearch.TextChanged += TxtTrainingProgramSearch_TextChanged;
            // 
            // lblTrainingProgramName
            // 
            lblTrainingProgramName.AutoSize = true;
            lblTrainingProgramName.Location = new Point(17, 21);
            lblTrainingProgramName.Margin = new Padding(5, 0, 5, 0);
            lblTrainingProgramName.Name = "lblTrainingProgramName";
            lblTrainingProgramName.Size = new Size(160, 21);
            lblTrainingProgramName.TabIndex = 3;
            lblTrainingProgramName.Text = "Eğitim Program Adı";
            // 
            // txtTrainingProgramName
            // 
            txtTrainingProgramName.Location = new Point(17, 46);
            txtTrainingProgramName.Margin = new Padding(5, 4, 5, 4);
            txtTrainingProgramName.Name = "txtTrainingProgramName";
            txtTrainingProgramName.Size = new Size(342, 29);
            txtTrainingProgramName.TabIndex = 4;
            // 
            // lblTrainingProgramDescription
            // 
            lblTrainingProgramDescription.AutoSize = true;
            lblTrainingProgramDescription.Location = new Point(17, 83);
            lblTrainingProgramDescription.Margin = new Padding(5, 0, 5, 0);
            lblTrainingProgramDescription.Name = "lblTrainingProgramDescription";
            lblTrainingProgramDescription.Size = new Size(217, 21);
            lblTrainingProgramDescription.TabIndex = 3;
            lblTrainingProgramDescription.Text = "Eğitim Program Açıklaması";
            // 
            // txtTrainingProgramDescription
            // 
            txtTrainingProgramDescription.Location = new Point(17, 108);
            txtTrainingProgramDescription.Margin = new Padding(5, 4, 5, 4);
            txtTrainingProgramDescription.Multiline = true;
            txtTrainingProgramDescription.Name = "txtTrainingProgramDescription";
            txtTrainingProgramDescription.Size = new Size(342, 110);
            txtTrainingProgramDescription.TabIndex = 4;
            // 
            // dtTrainingProgramStartDate
            // 
            dtTrainingProgramStartDate.Location = new Point(17, 249);
            dtTrainingProgramStartDate.Margin = new Padding(5, 4, 5, 4);
            dtTrainingProgramStartDate.Name = "dtTrainingProgramStartDate";
            dtTrainingProgramStartDate.Size = new Size(342, 29);
            dtTrainingProgramStartDate.TabIndex = 5;
            // 
            // lblTrainingProgramStartDate
            // 
            lblTrainingProgramStartDate.AutoSize = true;
            lblTrainingProgramStartDate.Location = new Point(18, 224);
            lblTrainingProgramStartDate.Margin = new Padding(5, 0, 5, 0);
            lblTrainingProgramStartDate.Name = "lblTrainingProgramStartDate";
            lblTrainingProgramStartDate.Size = new Size(254, 21);
            lblTrainingProgramStartDate.TabIndex = 3;
            lblTrainingProgramStartDate.Text = "Eğitim Program Başlangıç Tarihi";
            // 
            // lblTrainingProgramEndDate
            // 
            lblTrainingProgramEndDate.AutoSize = true;
            lblTrainingProgramEndDate.Location = new Point(17, 286);
            lblTrainingProgramEndDate.Margin = new Padding(5, 0, 5, 0);
            lblTrainingProgramEndDate.Name = "lblTrainingProgramEndDate";
            lblTrainingProgramEndDate.Size = new Size(214, 21);
            lblTrainingProgramEndDate.TabIndex = 3;
            lblTrainingProgramEndDate.Text = "Eğitim Program Bitiş Tarihi";
            // 
            // dtTrainingProgramEndDate
            // 
            dtTrainingProgramEndDate.Location = new Point(17, 311);
            dtTrainingProgramEndDate.Margin = new Padding(5, 4, 5, 4);
            dtTrainingProgramEndDate.Name = "dtTrainingProgramEndDate";
            dtTrainingProgramEndDate.Size = new Size(342, 29);
            dtTrainingProgramEndDate.TabIndex = 5;
            // 
            // lblTrainer
            // 
            lblTrainer.AutoSize = true;
            lblTrainer.Location = new Point(17, 347);
            lblTrainer.Margin = new Padding(5, 0, 5, 0);
            lblTrainer.Name = "lblTrainer";
            lblTrainer.Size = new Size(74, 21);
            lblTrainer.TabIndex = 3;
            lblTrainer.Text = "Eğitmen";
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 21;
            lstEmployees.Location = new Point(17, 417);
            lstEmployees.Margin = new Padding(5, 4, 5, 4);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(342, 151);
            lstEmployees.TabIndex = 1;
            // 
            // txtTrainerSearch
            // 
            txtTrainerSearch.Location = new Point(17, 377);
            txtTrainerSearch.Margin = new Padding(5, 4, 5, 4);
            txtTrainerSearch.Name = "txtTrainerSearch";
            txtTrainerSearch.PlaceholderText = "EĞİTİMCİ ARA";
            txtTrainerSearch.Size = new Size(342, 29);
            txtTrainerSearch.TabIndex = 2;
            txtTrainerSearch.TextChanged += TxtTrainerSearch_TextChanged;
            // 
            // btnTrainingProgramAdd
            // 
            btnTrainingProgramAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnTrainingProgramAdd.Location = new Point(17, 578);
            btnTrainingProgramAdd.Margin = new Padding(5, 4, 5, 4);
            btnTrainingProgramAdd.Name = "btnTrainingProgramAdd";
            btnTrainingProgramAdd.Size = new Size(345, 46);
            btnTrainingProgramAdd.TabIndex = 6;
            btnTrainingProgramAdd.Text = "Eğitim Programını Ekle";
            btnTrainingProgramAdd.UseVisualStyleBackColor = false;
            btnTrainingProgramAdd.Click += BtnTrainingProgramAdd_Click;
            // 
            // TrainingProgramForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(855, 630);
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
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 4, 5, 4);
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