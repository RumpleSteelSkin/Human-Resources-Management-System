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
            dtpTerminationDate = new DateTimePicker();
            label8 = new Label();
            btnEkle = new Button();
            btnCıkar = new Button();
            label9 = new Label();
            txtSalary = new TextBox();
            label10 = new Label();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            txtSubordinate = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            label3.Location = new Point(0, 135);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Departman:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 190);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 5;
            label4.Text = "Pozisyon:";
            // 
            // cmbPosition
            // 
            cmbPosition.FormattingEnabled = true;
            cmbPosition.Location = new Point(107, 190);
            cmbPosition.Name = "cmbPosition";
            cmbPosition.Size = new Size(151, 28);
            cmbPosition.TabIndex = 6;
            // 
            // cmbDepartment
            // 
            cmbDepartment.FormattingEnabled = true;
            cmbDepartment.Location = new Point(107, 135);
            cmbDepartment.Name = "cmbDepartment";
            cmbDepartment.Size = new Size(151, 28);
            cmbDepartment.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 253);
            label5.Name = "label5";
            label5.Size = new Size(63, 20);
            label5.TabIndex = 8;
            label5.Text = "Cinsiyet:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(362, 37);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 9;
            label6.Text = "Doğum Tarihi:";
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(107, 245);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(151, 28);
            cmbGender.TabIndex = 10;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(496, 32);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(250, 27);
            dtpDateOfBirth.TabIndex = 11;
            // 
            // dtpHireDate
            // 
            dtpHireDate.Location = new Point(496, 86);
            dtpHireDate.Name = "dtpHireDate";
            dtpHireDate.Size = new Size(250, 27);
            dtpHireDate.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(361, 91);
            label7.Name = "label7";
            label7.Size = new Size(129, 20);
            label7.TabIndex = 13;
            label7.Text = "İşe Başlama Tarihi:";
            // 
            // dtpTerminationDate
            // 
            dtpTerminationDate.Location = new Point(496, 136);
            dtpTerminationDate.Name = "dtpTerminationDate";
            dtpTerminationDate.Size = new Size(250, 27);
            dtpTerminationDate.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(356, 136);
            label8.Name = "label8";
            label8.Size = new Size(137, 20);
            label8.TabIndex = 15;
            label8.Text = "İşten Ayrılma Tarihi:";
            // 
            // btnEkle
            // 
            btnEkle.Location = new Point(617, 369);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(94, 29);
            btnEkle.TabIndex = 16;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = true;
            // 
            // btnCıkar
            // 
            btnCıkar.Location = new Point(469, 369);
            btnCıkar.Name = "btnCıkar";
            btnCıkar.Size = new Size(94, 29);
            btnCıkar.TabIndex = 17;
            btnCıkar.Text = "ÇIKAR";
            btnCıkar.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(0, 349);
            label9.Name = "label9";
            label9.Size = new Size(47, 20);
            label9.TabIndex = 18;
            label9.Text = "Maaş:";
            // 
            // txtSalary
            // 
            txtSalary.Location = new Point(107, 342);
            txtSalary.Name = "txtSalary";
            txtSalary.Size = new Size(151, 27);
            txtSalary.TabIndex = 19;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(2, 302);
            label10.Name = "label10";
            label10.Size = new Size(37, 20);
            label10.TabIndex = 20;
            label10.Text = "Astı:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(846, 30);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(454, 408);
            groupBox1.TabIndex = 21;
            groupBox1.TabStop = false;
            groupBox1.Text = "ÇALIŞANLAR";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 23);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(448, 382);
            dataGridView1.TabIndex = 0;
            // 
            // txtSubordinate
            // 
            txtSubordinate.Location = new Point(107, 295);
            txtSubordinate.Name = "txtSubordinate";
            txtSubordinate.Size = new Size(151, 27);
            txtSubordinate.TabIndex = 1;
            // 
            // EmployeeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1322, 450);
            Controls.Add(txtSubordinate);
            Controls.Add(groupBox1);
            Controls.Add(label10);
            Controls.Add(txtSalary);
            Controls.Add(label9);
            Controls.Add(btnCıkar);
            Controls.Add(btnEkle);
            Controls.Add(label8);
            Controls.Add(dtpTerminationDate);
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
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private DateTimePicker dtpTerminationDate;
        private Label label8;
        private Button btnEkle;
        private Button btnCıkar;
        private Label label9;
        private TextBox txtSalary;
        private Label label10;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private TextBox txtSubordinate;
    }
}