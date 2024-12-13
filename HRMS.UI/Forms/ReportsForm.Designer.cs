namespace HRMS.UI.Forms
{
    partial class ReportsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportsForm));
            lblGeneralCondition = new Label();
            lblPerformanceReview = new Label();
            lblEmployeeDateOfBirth = new Label();
            lblGenderGraph = new Label();
            lblEmployeesInDepartments = new Label();
            lblPassiveReports = new Label();
            btnExportPDF = new Button();
            btnExportToExcel = new Button();
            lblLeaveRequestTypeGraph = new Label();
            pAllGraph = new Panel();
            lblPassiveLeaveRequestTitle = new Label();
            pAllGraph.SuspendLayout();
            SuspendLayout();
            // 
            // lblGeneralCondition
            // 
            lblGeneralCondition.BackColor = Color.FromArgb(128, 255, 255);
            lblGeneralCondition.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblGeneralCondition.Location = new Point(3, 0);
            lblGeneralCondition.Name = "lblGeneralCondition";
            lblGeneralCondition.Size = new Size(423, 284);
            lblGeneralCondition.TabIndex = 0;
            lblGeneralCondition.Text = "ÇALIŞAN SAYISI\r\nORTALAMA MAAŞ\r\nTOPLAM MAAŞ\r\nGenel tüm çalışanlara göre salary ortalaması ve toplam gider adına toplam salary\r\n";
            lblGeneralCondition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPerformanceReview
            // 
            lblPerformanceReview.BackColor = Color.FromArgb(128, 255, 255);
            lblPerformanceReview.Location = new Point(861, 0);
            lblPerformanceReview.Name = "lblPerformanceReview";
            lblPerformanceReview.Size = new Size(423, 284);
            lblPerformanceReview.TabIndex = 0;
            lblPerformanceReview.Text = "ÇALIŞANLARIN PERFORMANS DEĞERLENDİRMELERİ *CHART\r\nBunu yapabilirsem chart grafiği olacak, bakalım\r\n";
            lblPerformanceReview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeDateOfBirth
            // 
            lblEmployeeDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmployeeDateOfBirth.BackColor = Color.FromArgb(128, 255, 255);
            lblEmployeeDateOfBirth.Location = new Point(432, 0);
            lblEmployeeDateOfBirth.Name = "lblEmployeeDateOfBirth";
            lblEmployeeDateOfBirth.Size = new Size(423, 284);
            lblEmployeeDateOfBirth.TabIndex = 0;
            lblEmployeeDateOfBirth.Text = "ÇALIŞANLARIN DOĞUM GÜNLERİ YAKINDAN UZAĞA SIRALI\r\ngenel olarak şirketlerdeki IK çalışanların doğum gününü minimum seviyede(mail) kutlar, bunun takibini yapar";
            lblEmployeeDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenderGraph
            // 
            lblGenderGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGenderGraph.BackColor = Color.FromArgb(255, 192, 192);
            lblGenderGraph.Location = new Point(432, 290);
            lblGenderGraph.Name = "lblGenderGraph";
            lblGenderGraph.Size = new Size(423, 284);
            lblGenderGraph.TabIndex = 0;
            lblGenderGraph.Text = resources.GetString("lblGenderGraph.Text");
            lblGenderGraph.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeesInDepartments
            // 
            lblEmployeesInDepartments.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmployeesInDepartments.BackColor = Color.FromArgb(255, 192, 192);
            lblEmployeesInDepartments.Location = new Point(4, 290);
            lblEmployeesInDepartments.Name = "lblEmployeesInDepartments";
            lblEmployeesInDepartments.Size = new Size(423, 284);
            lblEmployeesInDepartments.TabIndex = 0;
            lblEmployeesInDepartments.Text = "DEPARTMANLARDA BULUNAN TOPLAM ÇALIŞANLAR GRAFİĞİ\r\nHer bir departmanda kaç adet çalışanın olduğu buradan gözlemlenebilir.\r\n";
            lblEmployeesInDepartments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPassiveReports
            // 
            lblPassiveReports.AutoSize = true;
            lblPassiveReports.BackColor = Color.Black;
            lblPassiveReports.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassiveReports.ForeColor = Color.White;
            lblPassiveReports.Location = new Point(12, 9);
            lblPassiveReports.Name = "lblPassiveReports";
            lblPassiveReports.Size = new Size(543, 65);
            lblPassiveReports.TabIndex = 2;
            lblPassiveReports.Text = "GENEL ŞİRKET DURUM";
            // 
            // btnExportPDF
            // 
            btnExportPDF.BackColor = Color.FromArgb(192, 255, 192);
            btnExportPDF.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExportPDF.Location = new Point(1172, 8);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(127, 66);
            btnExportPDF.TabIndex = 1;
            btnExportPDF.Text = "PDF'YE AKTAR";
            btnExportPDF.UseVisualStyleBackColor = false;
            btnExportPDF.Click += BtnExportPDF_Click;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.BackColor = Color.FromArgb(192, 255, 192);
            btnExportToExcel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnExportToExcel.Location = new Point(1029, 8);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(137, 66);
            btnExportToExcel.TabIndex = 1;
            btnExportToExcel.Text = "EXCEL'E AKTAR";
            btnExportToExcel.UseVisualStyleBackColor = false;
            btnExportToExcel.Click += BtnExportToExcel_Click;
            // 
            // lblLeaveRequestTypeGraph
            // 
            lblLeaveRequestTypeGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLeaveRequestTypeGraph.BackColor = Color.FromArgb(255, 192, 192);
            lblLeaveRequestTypeGraph.Location = new Point(861, 326);
            lblLeaveRequestTypeGraph.Name = "lblLeaveRequestTypeGraph";
            lblLeaveRequestTypeGraph.Size = new Size(423, 248);
            lblLeaveRequestTypeGraph.TabIndex = 0;
            lblLeaveRequestTypeGraph.Text = "İZİNDE OLAN ÇALIŞANLAR GRAFİĞİ\r\nBir çalışan izne çıktıysa bu tabloda/grafikte gösterilir. Yani LeaveRequest tablosunda StartDate ve EndDate arasında olan çalışanı gösteren tablo";
            lblLeaveRequestTypeGraph.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pAllGraph
            // 
            pAllGraph.Controls.Add(lblGeneralCondition);
            pAllGraph.Controls.Add(lblPassiveLeaveRequestTitle);
            pAllGraph.Controls.Add(lblLeaveRequestTypeGraph);
            pAllGraph.Controls.Add(lblEmployeesInDepartments);
            pAllGraph.Controls.Add(lblGenderGraph);
            pAllGraph.Controls.Add(lblPerformanceReview);
            pAllGraph.Controls.Add(lblEmployeeDateOfBirth);
            pAllGraph.Location = new Point(12, 77);
            pAllGraph.Name = "pAllGraph";
            pAllGraph.Size = new Size(1287, 574);
            pAllGraph.TabIndex = 3;
            // 
            // lblPassiveLeaveRequestTitle
            // 
            lblPassiveLeaveRequestTitle.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblPassiveLeaveRequestTitle.BackColor = Color.FromArgb(255, 192, 192);
            lblPassiveLeaveRequestTitle.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassiveLeaveRequestTitle.Location = new Point(861, 290);
            lblPassiveLeaveRequestTitle.Name = "lblPassiveLeaveRequestTitle";
            lblPassiveLeaveRequestTitle.Size = new Size(423, 36);
            lblPassiveLeaveRequestTitle.TabIndex = 0;
            lblPassiveLeaveRequestTitle.Text = "İZİNDE OLAN ÇALIŞANLAR";
            lblPassiveLeaveRequestTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 64, 64);
            ClientSize = new Size(1315, 663);
            Controls.Add(pAllGraph);
            Controls.Add(lblPassiveReports);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnExportPDF);
            Name = "ReportsForm";
            Text = "ReportsForm";
            Load += ReportsForm_Load;
            pAllGraph.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblGeneralCondition;
        private Label lblPerformanceReview;
        private Label lblEmployeeDateOfBirth;
        private Label lblGenderGraph;
        private Label lblEmployeesInDepartments;
        private Label lblPassiveReports;
        private Button btnExportPDF;
        private Button btnExportToExcel;
        private Label lblLeaveRequestTypeGraph;
        private Panel pAllGraph;
        private Label lblPassiveLeaveRequestTitle;
    }
}