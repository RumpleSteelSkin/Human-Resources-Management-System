namespace HRMS.UI.Forms
{
    partial class DepartmentForm
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
            txtDepartmentName = new TextBox();
            gbDepartmentProcess = new GroupBox();
            chkDepartmentActiveOrPassive = new CheckBox();
            lstDepartmentList = new ListBox();
            btnAdd = new Button();
            label1 = new Label();
            lblDepartmentLocation = new Label();
            txtSearch = new TextBox();
            txtDepartmentLocation = new TextBox();
            lblDepartmentName = new Label();
            gbDepartmentProcess.SuspendLayout();
            SuspendLayout();
            // 
            // txtDepartmentName
            // 
            txtDepartmentName.Location = new Point(204, 39);
            txtDepartmentName.Margin = new Padding(5, 6, 5, 6);
            txtDepartmentName.Name = "txtDepartmentName";
            txtDepartmentName.Size = new Size(429, 34);
            txtDepartmentName.TabIndex = 1;
            // 
            // gbDepartmentProcess
            // 
            gbDepartmentProcess.Controls.Add(chkDepartmentActiveOrPassive);
            gbDepartmentProcess.Controls.Add(lstDepartmentList);
            gbDepartmentProcess.Controls.Add(btnAdd);
            gbDepartmentProcess.Controls.Add(label1);
            gbDepartmentProcess.Controls.Add(lblDepartmentLocation);
            gbDepartmentProcess.Controls.Add(txtSearch);
            gbDepartmentProcess.Controls.Add(txtDepartmentLocation);
            gbDepartmentProcess.Controls.Add(lblDepartmentName);
            gbDepartmentProcess.Controls.Add(txtDepartmentName);
            gbDepartmentProcess.Location = new Point(5, 22);
            gbDepartmentProcess.Margin = new Padding(5, 6, 5, 6);
            gbDepartmentProcess.Name = "gbDepartmentProcess";
            gbDepartmentProcess.Padding = new Padding(5, 6, 5, 6);
            gbDepartmentProcess.Size = new Size(646, 618);
            gbDepartmentProcess.TabIndex = 2;
            gbDepartmentProcess.TabStop = false;
            gbDepartmentProcess.Text = "Departman İşlemleri";
            // 
            // chkDepartmentActiveOrPassive
            // 
            chkDepartmentActiveOrPassive.AutoSize = true;
            chkDepartmentActiveOrPassive.Location = new Point(204, 137);
            chkDepartmentActiveOrPassive.Name = "chkDepartmentActiveOrPassive";
            chkDepartmentActiveOrPassive.Size = new Size(83, 32);
            chkDepartmentActiveOrPassive.TabIndex = 5;
            chkDepartmentActiveOrPassive.Text = "PASİF";
            chkDepartmentActiveOrPassive.UseVisualStyleBackColor = true;
            chkDepartmentActiveOrPassive.CheckedChanged += ChkDepartmentActiveOrPassive_CheckedChanged;
            // 
            // lstDepartmentList
            // 
            lstDepartmentList.FormattingEnabled = true;
            lstDepartmentList.ItemHeight = 28;
            lstDepartmentList.Location = new Point(15, 232);
            lstDepartmentList.Margin = new Padding(5, 6, 5, 6);
            lstDepartmentList.Name = "lstDepartmentList";
            lstDepartmentList.Size = new Size(618, 368);
            lstDepartmentList.TabIndex = 3;
            lstDepartmentList.SelectedIndexChanged += LstDepartmentList_SelectedIndexChanged;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 138);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 28);
            label1.TabIndex = 2;
            label1.Text = "Durum (A/P):";
            // 
            // lblDepartmentLocation
            // 
            lblDepartmentLocation.AutoSize = true;
            lblDepartmentLocation.Location = new Point(10, 85);
            lblDepartmentLocation.Margin = new Padding(5, 0, 5, 0);
            lblDepartmentLocation.Name = "lblDepartmentLocation";
            lblDepartmentLocation.Size = new Size(117, 28);
            lblDepartmentLocation.TabIndex = 2;
            lblDepartmentLocation.Text = "Lokasyonu:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(15, 186);
            txtSearch.Margin = new Padding(5, 6, 5, 6);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Departman Arama";
            txtSearch.Size = new Size(618, 34);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // txtDepartmentLocation
            // 
            txtDepartmentLocation.Location = new Point(204, 85);
            txtDepartmentLocation.Margin = new Padding(5, 6, 5, 6);
            txtDepartmentLocation.Name = "txtDepartmentLocation";
            txtDepartmentLocation.Size = new Size(429, 34);
            txtDepartmentLocation.TabIndex = 2;
            // 
            // lblDepartmentName
            // 
            lblDepartmentName.AutoSize = true;
            lblDepartmentName.Location = new Point(10, 42);
            lblDepartmentName.Margin = new Padding(5, 0, 5, 0);
            lblDepartmentName.Name = "lblDepartmentName";
            lblDepartmentName.Size = new Size(162, 28);
            lblDepartmentName.TabIndex = 2;
            lblDepartmentName.Text = "Departman Adı:";
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(12F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(660, 643);
            Controls.Add(gbDepartmentProcess);
            Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 162);
            Margin = new Padding(5, 6, 5, 6);
            Name = "DepartmentForm";
            Text = "DEPARTMAN FORMU";
            Load += DepartmentForm_Load;
            gbDepartmentProcess.ResumeLayout(false);
            gbDepartmentProcess.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtDepartmentName;
        private GroupBox gbDepartmentProcess;
        private Label lblDepartmentName;
        private Label lblDepartmentLocation;
        private TextBox txtDepartmentLocation;
        private Button btnAdd;
        private ListBox lstDepartmentList;
        private TextBox txtSearch;
        private CheckBox chkDepartmentActiveOrPassive;
        private Label label1;
    }
}