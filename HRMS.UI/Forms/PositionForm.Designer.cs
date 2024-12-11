namespace HRMS.UI.Forms
{
    partial class PositionForm
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
            txtPositionName = new TextBox();
            lblDepartmentName = new Label();
            txtSearch = new TextBox();
            lblDepartmentLocation = new Label();
            label1 = new Label();
            btnAdd = new Button();
            lstPositionList = new ListBox();
            chkPositionActiveOrPassive = new CheckBox();
            gbDepartmentProcess = new GroupBox();
            nmrPositionSalary = new NumericUpDown();
            gbDepartmentProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPositionSalary).BeginInit();
            SuspendLayout();
            // 
            // txtPositionName
            // 
            txtPositionName.Location = new Point(204, 39);
            txtPositionName.Margin = new Padding(5, 6, 5, 6);
            txtPositionName.Name = "txtPositionName";
            txtPositionName.Size = new Size(429, 41);
            txtPositionName.TabIndex = 1;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(12, 45);
            lblDepartmentName.Margin = new Padding(5, 0, 5, 0);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(171, 35);
            lblDepartmentName.TabIndex = 2;
            lblDepartmentName.Text = "Pozisyon Adı:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 186);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Pozisyon Arama";
            txtSearch.Size = new Size(618, 41);
            txtSearch.TabIndex = 4;
            // 
            // lblDepartmentLocation
            // 
            lblDepartmentLocation.AutoSize = true;
            lblDepartmentLocation.Location = new Point(12, 88);
            lblDepartmentLocation.Margin = new Padding(5, 0, 5, 0);
            lblDepartmentLocation.Name = "lblDepartmentLocation";
            lblDepartmentLocation.Size = new Size(90, 35);
            lblDepartmentLocation.TabIndex = 2;
            lblDepartmentLocation.Text = "Maaşı:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 141);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 35);
            label1.TabIndex = 2;
            label1.Text = "Durum (A/P):";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(504, 131);
            btnAdd.Margin = new Padding(5, 6, 5, 6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(129, 43);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "EKLE";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += BtnAdd_Click;
            // 
            // lstPositionList
            // 
            lstPositionList.FormattingEnabled = true;
            lstPositionList.ItemHeight = 35;
            lstPositionList.Location = new Point(15, 232);
            lstPositionList.Margin = new Padding(5, 6, 5, 6);
            lstPositionList.Name = "lstPositionList";
            lstPositionList.Size = new Size(618, 354);
            lstPositionList.TabIndex = 3;
            // 
            // chkPositionActiveOrPassive
            // 
            chkPositionActiveOrPassive.AutoSize = true;
            chkPositionActiveOrPassive.Location = new Point(206, 140);
            chkPositionActiveOrPassive.Name = "chkPositionActiveOrPassive";
            chkPositionActiveOrPassive.Size = new Size(104, 39);
            chkPositionActiveOrPassive.TabIndex = 5;
            chkPositionActiveOrPassive.Text = "PASİF";
            chkPositionActiveOrPassive.UseVisualStyleBackColor = true;
            chkPositionActiveOrPassive.Click += ChkPositionActiveOrPassive_CheckedChanged;
            // 
            // gbDepartmentProcess
            // 
            gbDepartmentProcess.Controls.Add(nmrPositionSalary);
            gbDepartmentProcess.Controls.Add(chkPositionActiveOrPassive);
            gbDepartmentProcess.Controls.Add(lstPositionList);
            gbDepartmentProcess.Controls.Add(btnAdd);
            gbDepartmentProcess.Controls.Add(label1);
            gbDepartmentProcess.Controls.Add(lblDepartmentLocation);
            gbDepartmentProcess.Controls.Add(txtSearch);
            gbDepartmentProcess.Controls.Add(lblDepartmentName);
            gbDepartmentProcess.Controls.Add(txtPositionName);
            gbDepartmentProcess.Location = new Point(14, 15);
            gbDepartmentProcess.Margin = new Padding(5, 6, 5, 6);
            gbDepartmentProcess.Name = "gbDepartmentProcess";
            gbDepartmentProcess.Padding = new Padding(5, 6, 5, 6);
            gbDepartmentProcess.Size = new Size(646, 618);
            gbDepartmentProcess.TabIndex = 3;
            gbDepartmentProcess.TabStop = false;
            gbDepartmentProcess.Text = "Pozisyon İşlemleri";
            // 
            // nmrPositionSalary
            // 
            nmrPositionSalary.Location = new Point(204, 88);
            nmrPositionSalary.Margin = new Padding(6, 5, 6, 5);
            nmrPositionSalary.Name = "nmrPositionSalary";
            nmrPositionSalary.Size = new Size(429, 41);
            nmrPositionSalary.TabIndex = 6;
            // 
            // PositionForm
            // 
            AutoScaleDimensions = new SizeF(15F, 35F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(680, 607);
            Controls.Add(gbDepartmentProcess);
            Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(6, 5, 6, 5);
            Name = "PositionForm";
            Text = "POZİSYON FORMU";
            gbDepartmentProcess.ResumeLayout(false);
            gbDepartmentProcess.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmrPositionSalary).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtPositionName;
        private Label lblDepartmentName;
        private TextBox txtSearch;
        private Label lblDepartmentLocation;
        private Label label1;
        private Button btnAdd;
        private ListBox lstPositionList;
        private CheckBox chkPositionActiveOrPassive;
        private GroupBox gbDepartmentProcess;
        private NumericUpDown nmrPositionSalary;
    }
}