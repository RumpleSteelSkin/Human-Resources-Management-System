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
            label1.Location = new Point(0, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 20);
            label1.TabIndex = 0;
            label1.Text = "İsim:";
            // 
            // txtName
            // 
            txtName.Location = new Point(107, 30);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 1;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(107, 86);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(151, 27);
            txtSurname.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 86);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 2;
            label2.Text = "Soyisim:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 238);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Departman:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 293);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Pozisyon:";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(107, 293);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(151, 28);
            cmbPosition.TabIndex = 6;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(107, 238);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 7;
            cmbDepartment.SelectedIndexChanged += cmbDepartment_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 189);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 8;
            label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(282, 30);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 9;
            label6.Text = "Doğum Tarihi:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Erkek", "Kadın" });
            cmbGender.Location = new Point(107, 181);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 10;
            cmbGender.SelectedIndexChanged += cmbGender_SelectedIndexChanged;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(416, 25);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(231, 27);
            dtpDateOfBirth.TabIndex = 11;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(416, 79);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(231, 27);
            dtpHireDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(281, 84);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 13;
            label7.Text = "İşe Başlama Tarihi:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(312, 212);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(157, 54);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnCıkar
            // 
            btnCıkar.Location = new Point(490, 212);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(157, 54);
            btnCıkar.TabIndex = 17;
            btnCıkar.Text = "ÇIKAR";
            btnCıkar.UseVisualStyleBackColor = true;
            btnCıkar.Click += btnCıkar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 139);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 18;
            label9.Text = "Maaş:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(107, 132);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(151, 27);
            txtSalary.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(671, 44);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 20;
            label10.Text = "Astı:";
            // 
            // txtSubordinate
            // 
            txtSubordinate.Location = new Point(714, 37);
            txtSubordinate.Name = "txtSubordinate";
            txtSubordinate.Size = new Size(188, 27);
            txtSubordinate.TabIndex = 1;
            txtSubordinate.TextChanged += txtSubordinate_TextChanged;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(312, 286);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(335, 54);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "GÜNCELLE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lstÇalışanlar
            // 
            lstÇalışanlar.FormattingEnabled = true;
            lstÇalışanlar.Location = new Point(714, 85);
            lstÇalışanlar.Name = "lstÇalışanlar";
            lstÇalışanlar.Size = new Size(188, 344);
            lstÇalışanlar.TabIndex = 24;
            lstÇalışanlar.SelectedIndexChanged += lstÇalışanlar_SelectedIndexChanged;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.Location = new Point(945, 90);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(448, 344);
            lstEmployees.TabIndex = 25;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            // 
            // txtArama
            // 
            txtArama.Location = new Point(945, 44);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Çalışan Arama";
            txtArama.Size = new Size(448, 27);
            txtArama.TabIndex = 26;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1420, 450);
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