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
            flpReports = new FlowLayoutPanel();
            lblGeneralCondition = new Label();
            lblPerformanceReview = new Label();
            lblEmployeeDateOfBirth = new Label();
            lblGenderGraph = new Label();
            lblEmployeesInDepartments = new Label();
            lblLeaveRequestTypeGraph = new Label();
            btnSampleData = new Button();
            lblPassiveReports = new Label();
            btnExportPDF = new Button();
            btnExportToExcel = new Button();
            btnUpdateCharts = new Button();
            flpReports.SuspendLayout();
            SuspendLayout();
            // 
            // flpReports
            // 
            flpReports.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flpReports.BackColor = Color.FromArgb(0, 192, 192);
            flpReports.BorderStyle = BorderStyle.FixedSingle;
            flpReports.Controls.Add(lblGeneralCondition);
            flpReports.Controls.Add(lblPerformanceReview);
            flpReports.Controls.Add(lblEmployeeDateOfBirth);
            flpReports.Controls.Add(lblGenderGraph);
            flpReports.Controls.Add(lblEmployeesInDepartments);
            flpReports.Controls.Add(lblLeaveRequestTypeGraph);
            flpReports.Location = new Point(12, 125);
            flpReports.Name = "flpReports";
            flpReports.Size = new Size(1101, 552);
            flpReports.TabIndex = 0;
            // 
            // lblGeneralCondition
            // 
            lblGeneralCondition.BackColor = Color.FromArgb(128, 255, 255);
            lblGeneralCondition.Font = new Font("Segoe UI", 20F);
            lblGeneralCondition.Location = new Point(3, 0);
            lblGeneralCondition.Name = "lblGeneralCondition";
            lblGeneralCondition.Size = new Size(360, 273);
            lblGeneralCondition.TabIndex = 0;
            lblGeneralCondition.Text = "ÇALIŞAN SAYISI\r\nORTALAMA MAAŞ\r\nTOPLAM MAAŞ\r\nGenel tüm çalışanlara göre salary ortalaması ve toplam gider adına toplam salary\r\n";
            lblGeneralCondition.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPerformanceReview
            // 
            lblPerformanceReview.BackColor = Color.FromArgb(128, 255, 255);
            lblPerformanceReview.Location = new Point(369, 0);
            lblPerformanceReview.Name = "lblPerformanceReview";
            lblPerformanceReview.Size = new Size(360, 273);
            lblPerformanceReview.TabIndex = 0;
            lblPerformanceReview.Text = "ÇALIŞANLARIN PERFORMANS DEĞERLENDİRMELERİ *CHART\r\nBunu yapabilirsem chart grafiği olacak, bakalım\r\n";
            lblPerformanceReview.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeeDateOfBirth
            // 
            lblEmployeeDateOfBirth.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblEmployeeDateOfBirth.BackColor = Color.FromArgb(128, 255, 255);
            lblEmployeeDateOfBirth.Location = new Point(735, 0);
            lblEmployeeDateOfBirth.Name = "lblEmployeeDateOfBirth";
            lblEmployeeDateOfBirth.Size = new Size(360, 273);
            lblEmployeeDateOfBirth.TabIndex = 0;
            lblEmployeeDateOfBirth.Text = "ÇALIŞANLARIN DOĞUM GÜNLERİ YAKINDAN UZAĞA SIRALI\r\ngenel olarak şirketlerdeki IK çalışanların doğum gününü minimum seviyede(mail) kutlar, bunun takibini yapar";
            lblEmployeeDateOfBirth.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGenderGraph
            // 
            lblGenderGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblGenderGraph.BackColor = Color.FromArgb(255, 192, 192);
            lblGenderGraph.Location = new Point(3, 273);
            lblGenderGraph.Name = "lblGenderGraph";
            lblGenderGraph.Size = new Size(360, 273);
            lblGenderGraph.TabIndex = 0;
            lblGenderGraph.Text = resources.GetString("lblGenderGraph.Text");
            lblGenderGraph.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmployeesInDepartments
            // 
            lblEmployeesInDepartments.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblEmployeesInDepartments.BackColor = Color.FromArgb(255, 192, 192);
            lblEmployeesInDepartments.Location = new Point(369, 273);
            lblEmployeesInDepartments.Name = "lblEmployeesInDepartments";
            lblEmployeesInDepartments.Size = new Size(360, 273);
            lblEmployeesInDepartments.TabIndex = 0;
            lblEmployeesInDepartments.Text = "DEPARTMANLARDA BULUNAN TOPLAM ÇALIŞANLAR GRAFİĞİ\r\nHer bir departmanda kaç adet çalışanın olduğu buradan gözlemlenebilir.\r\n";
            lblEmployeesInDepartments.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblLeaveRequestTypeGraph
            // 
            lblLeaveRequestTypeGraph.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lblLeaveRequestTypeGraph.BackColor = Color.FromArgb(255, 192, 192);
            lblLeaveRequestTypeGraph.Location = new Point(735, 273);
            lblLeaveRequestTypeGraph.Name = "lblLeaveRequestTypeGraph";
            lblLeaveRequestTypeGraph.Size = new Size(360, 273);
            lblLeaveRequestTypeGraph.TabIndex = 0;
            lblLeaveRequestTypeGraph.Text = "İZİNDE OLAN ÇALIŞANLAR GRAFİĞİ\r\nBir çalışan izne çıktıysa bu tabloda/grafikte gösterilir. Yani LeaveRequest tablosunda StartDate ve EndDate arasında olan çalışanı gösteren tablo";
            lblLeaveRequestTypeGraph.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSampleData
            // 
            btnSampleData.Location = new Point(16, 77);
            btnSampleData.Name = "btnSampleData";
            btnSampleData.Size = new Size(360, 42);
            btnSampleData.TabIndex = 1;
            btnSampleData.Text = "DATABASE'E ÖRNEK VERİLERİ EKLE";
            btnSampleData.UseVisualStyleBackColor = true;
            btnSampleData.Click += BtnSampleData_Click;
            // 
            // lblPassiveReports
            // 
            lblPassiveReports.AutoSize = true;
            lblPassiveReports.BackColor = Color.FromArgb(128, 128, 255);
            lblPassiveReports.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblPassiveReports.ForeColor = Color.White;
            lblPassiveReports.Location = new Point(12, 9);
            lblPassiveReports.Name = "lblPassiveReports";
            lblPassiveReports.Size = new Size(280, 65);
            lblPassiveReports.TabIndex = 2;
            lblPassiveReports.Text = "RAPORLAR";
            // 
            // btnExportPDF
            // 
            btnExportPDF.Location = new Point(748, 29);
            btnExportPDF.Name = "btnExportPDF";
            btnExportPDF.Size = new Size(360, 42);
            btnExportPDF.TabIndex = 1;
            btnExportPDF.Text = "PDF'YE AKTAR (WIP)";
            btnExportPDF.UseVisualStyleBackColor = true;
            // 
            // btnExportToExcel
            // 
            btnExportToExcel.Location = new Point(748, 77);
            btnExportToExcel.Name = "btnExportToExcel";
            btnExportToExcel.Size = new Size(360, 42);
            btnExportToExcel.TabIndex = 1;
            btnExportToExcel.Text = "EXCEL'E AKTAR (WIP)";
            btnExportToExcel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateCharts
            // 
            btnUpdateCharts.Location = new Point(382, 77);
            btnUpdateCharts.Name = "btnUpdateCharts";
            btnUpdateCharts.Size = new Size(360, 42);
            btnUpdateCharts.TabIndex = 1;
            btnUpdateCharts.Text = "CHART GÜNCELLE";
            btnUpdateCharts.UseVisualStyleBackColor = true;
            btnUpdateCharts.Click += BtnUpdateCharts_Click;
            // 
            // ReportsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(1125, 689);
            Controls.Add(lblPassiveReports);
            Controls.Add(btnExportToExcel);
            Controls.Add(btnUpdateCharts);
            Controls.Add(btnExportPDF);
            Controls.Add(btnSampleData);
            Controls.Add(flpReports);
            Name = "ReportsForm";
            Text = "ReportsForm";
            flpReports.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpReports;
        private Button btnSampleData;
        private Label lblGeneralCondition;
        private Label lblPerformanceReview;
        private Label lblEmployeeDateOfBirth;
        private Label lblGenderGraph;
        private Label lblEmployeesInDepartments;
        private Label lblLeaveRequestTypeGraph;
        private Label lblPassiveReports;
        private Button btnExportPDF;
        private Button btnExportToExcel;
        private Button btnUpdateCharts;
    }
}