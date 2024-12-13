namespace HRMS.UI.Forms
{
    partial class EmployeeForm
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
            label1 = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cmbPosition = new ComboBox();
            cmbDepartment = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cmbGender = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            dtpHireDate = new DateTimePicker();
            label7 = new Label();
            btnEkle = new Button();
            btnCıkar = new Button();
            label9 = new Label();
            txtSalary = new TextBox();
            label10 = new Label();
            txtSubordinate = new TextBox();
            btnUpdate = new Button();
            lstÇalışanlar = new ListBox();
            lstEmployees = new ListBox();
            txtArama = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 21);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // txtName
            // 
            txtName.Location = new Point(134, 31);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(234, 29);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(134, 90);
            txtSurname.Margin = new Padding(4, 3, 4, 3);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(234, 29);
            txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 95);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 21);
            label2.TabIndex = 2;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 249);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 21);
            label3.TabIndex = 4;
            label3.Text = "Departman:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 308);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 21);
            label4.TabIndex = 5;
            label4.Text = "Pozisyon:";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(134, 308);
            cmbPosition.Margin = new Padding(4, 3, 4, 3);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(234, 29);
            cmbPosition.TabIndex = 6;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(134, 249);
            cmbDepartment.Margin = new Padding(4, 3, 4, 3);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(234, 29);
            cmbDepartment.TabIndex = 7;
            cmbDepartment.SelectedIndexChanged += CmbDepartment_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 195);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(75, 21);
            label5.TabIndex = 8;
            label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(390, 31);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(118, 21);
            label6.TabIndex = 9;
            label6.Text = "Doğum Tarihi:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "KADIN", "ERKEK" });
            cmbGender.Location = new Point(134, 190);
            cmbGender.Margin = new Padding(4, 3, 4, 3);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(234, 29);
            cmbGender.TabIndex = 10;
            cmbGender.SelectedIndexChanged += CmbGender_SelectedIndexChanged;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(546, 27);
            dtpDateOfBirth.Margin = new Padding(4, 3, 4, 3);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(261, 29);
            dtpDateOfBirth.TabIndex = 11;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(546, 83);
            dtpHireDate.Margin = new Padding(4, 3, 4, 3);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(261, 29);
            dtpHireDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(390, 90);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 21);
            label7.TabIndex = 13;
            label7.Text = "İşe Başlama Tarihi:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(390, 444);
            btnEkle.Margin = new Padding(4, 3, 4, 3);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(134, 56);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += BtnEkle_Click;
            // 
            // btnCıkar
            // 
            btnCıkar.Location = new Point(684, 444);
            btnCıkar.Margin = new Padding(4, 3, 4, 3);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(124, 56);
            btnCıkar.TabIndex = 17;
            btnCıkar.Text = "ÇIKAR";
            btnCıkar.UseVisualStyleBackColor = true;
            btnCıkar.Click += BtnCıkar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 143);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(54, 21);
            label9.TabIndex = 18;
            label9.Text = "Maaş:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(134, 139);
            txtSalary.Margin = new Padding(4, 3, 4, 3);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(234, 29);
            txtSalary.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(0, 356);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(49, 21);
            label10.TabIndex = 20;
            label10.Text = "Üstü:";
            // 
            // txtSubordinate
            // 
            txtSubordinate.Location = new Point(134, 351);
            txtSubordinate.Margin = new Padding(4, 3, 4, 3);
            txtSubordinate.Name = "txtSubordinate";
            txtSubordinate.PlaceholderText = "Üst Çalışan Giriniz";
            txtSubordinate.Size = new Size(234, 29);
            txtSubordinate.TabIndex = 1;
            txtSubordinate.TextChanged += TxtSubordinate_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(533, 444);
            btnUpdate.Margin = new Padding(4, 3, 4, 3);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(143, 56);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += BtnUpdate_Click;
            // 
            // lstÇalışanlar
            // 
            lstÇalışanlar.FormattingEnabled = true;
            lstÇalışanlar.ItemHeight = 21;
            lstÇalışanlar.Location = new Point(134, 389);
            lstÇalışanlar.Margin = new Padding(4, 3, 4, 3);
            lstÇalışanlar.Name = "lstÇalışanlar";
            lstÇalışanlar.Size = new Size(234, 109);
            lstÇalışanlar.TabIndex = 24;
            lstÇalışanlar.SelectedIndexChanged += LstÇalışanlar_SelectedIndexChanged;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 21;
            lstEmployees.Location = new Point(390, 169);
            lstEmployees.Margin = new Padding(4, 3, 4, 3);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(417, 256);
            lstEmployees.TabIndex = 25;
            lstEmployees.SelectedIndexChanged += LstEmployees_SelectedIndexChanged;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(390, 120);
            txtArama.Margin = new Padding(4, 3, 4, 3);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Çalışan Arama";
            txtArama.Size = new Size(417, 29);
            txtArama.TabIndex = 26;
            txtArama.TextChanged += TxtArama_TextChanged;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(823, 515);
            Controls.Add(txtArama);
            Controls.Add(lstEmployees);
            Controls.Add(lstÇalışanlar);
            Controls.Add(btnUpdate);
            Controls.Add(txtSubordinate);
            Controls.Add(label10);
            Controls.Add(txtSalary);
            Controls.Add(label9);
            Controls.Add(btnCıkar);
            Controls.Add(btnEkle);
            Controls.Add(label7);
            Controls.Add(dtpHireDate);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(cmbGender);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cmbDepartment);
            Controls.Add(cmbPosition);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtSurname);
            Controls.Add(label2);
            Controls.Add(txtName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmployeeForm";
            Text = "EmployeeForm";
            Load += EmployeeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtName;
        private TextBox txtSurname;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cmbPosition;
        private ComboBox cmbDepartment;
        private Label label5;
        private Label label6;
        private ComboBox cmbGender;
        private DateTimePicker dtpDateOfBirth;
        private DateTimePicker dtpHireDate;
        private Label label7;
        private Button btnEkle;
        private Button btnCıkar;
        private Label label9;
        private TextBox txtSalary;
        private Label label10;
        private TextBox txtSubordinate;
        private Button btnUpdate;
        private ListBox lstÇalışanlar;
        private ListBox lstEmployees;
        private TextBox txtArama;
    }
}