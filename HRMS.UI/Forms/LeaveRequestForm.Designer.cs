namespace HRMS.UI.Forms
{
    partial class LeaveRequestForm
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
            lblLeaveRequestForm = new Label();
            lblQuotes = new Label();
            cmbLeaveType = new ComboBox();
            lblLeaveType = new Label();
            txtOther = new TextBox();
            lblOther = new Label();
            lblEndDate = new Label();
            lblStartDate = new Label();
            dtEndDate = new DateTimePicker();
            dtStartDate = new DateTimePicker();
            btnSaveLeaveRequest = new Button();
            txtSearch = new TextBox();
            lstEmployees = new ListBox();
            cmbLeaveStatus = new ComboBox();
            lblLeaveStatus = new Label();
            lstLeaveRequest = new ListBox();
            btnUpdateLeaveRequest = new Button();
            btnDeleteLeaveRequest = new Button();
            pBottomTab = new Panel();
            txtSearchLeaveRequest = new TextBox();
            pBottomTab.SuspendLayout();
            SuspendLayout();
            // 
            // lblLeaveRequestForm
            // 
            lblLeaveRequestForm.AutoSize = true;
            lblLeaveRequestForm.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblLeaveRequestForm.Location = new Point(10, 7);
            lblLeaveRequestForm.Name = "lblLeaveRequestForm";
            lblLeaveRequestForm.Size = new Size(198, 32);
            lblLeaveRequestForm.TabIndex = 0;
            lblLeaveRequestForm.Text = "İzin talep formu";
            // 
            // lblQuotes
            // 
            lblQuotes.AutoSize = true;
            lblQuotes.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblQuotes.Location = new Point(4, 38);
            lblQuotes.Name = "lblQuotes";
            lblQuotes.Size = new Size(644, 32);
            lblQuotes.TabIndex = 1;
            lblQuotes.Text = "---------------------------------------------------------------\r\n";
            // 
            // cmbLeaveType
            // 
            cmbLeaveType.Font = new Font("Segoe UI", 18F);
            cmbLeaveType.FormattingEnabled = true;
            cmbLeaveType.ItemHeight = 32;
            cmbLeaveType.Items.AddRange(new object[] { "Yıllık izin", "Doğum izni", "Süt izni", "Babalık izni", "Hastalık izni", "Ölüm izni", "Yeni iş arama izni", "Diğer" });
            cmbLeaveType.Location = new Point(10, 368);
            cmbLeaveType.Margin = new Padding(3, 2, 3, 2);
            cmbLeaveType.Name = "cmbLeaveType";
            cmbLeaveType.Size = new Size(296, 40);
            cmbLeaveType.TabIndex = 13;
            cmbLeaveType.SelectedIndexChanged += CmbLeaveType_SelectedIndexChanged;
            // 
            // lblLeaveType
            // 
            lblLeaveType.AutoSize = true;
            lblLeaveType.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLeaveType.Location = new Point(10, 344);
            lblLeaveType.Name = "lblLeaveType";
            lblLeaveType.Size = new Size(92, 21);
            lblLeaveType.TabIndex = 14;
            lblLeaveType.Text = "İzin sebebi";
            // 
            // txtOther
            // 
            txtOther.BorderStyle = BorderStyle.FixedSingle;
            txtOther.Font = new Font("Segoe UI", 18F);
            txtOther.Location = new Point(10, 437);
            txtOther.Margin = new Padding(3, 2, 3, 2);
            txtOther.MaxLength = 500;
            txtOther.Multiline = true;
            txtOther.Name = "txtOther";
            txtOther.Size = new Size(649, 151);
            txtOther.TabIndex = 13;
            // 
            // lblOther
            // 
            lblOther.AutoSize = true;
            lblOther.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblOther.Location = new Point(10, 414);
            lblOther.Name = "lblOther";
            lblOther.Size = new Size(52, 21);
            lblOther.TabIndex = 14;
            lblOther.Text = "Diğer";
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblEndDate.Location = new Point(331, 19);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(88, 21);
            lblEndDate.TabIndex = 24;
            lblEndDate.Text = "Bitiş tarihi";
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblStartDate.Location = new Point(3, 19);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(128, 21);
            lblStartDate.TabIndex = 21;
            lblStartDate.Text = "Başlangıç tarihi";
            // 
            // dtEndDate
            // 
            dtEndDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtEndDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtEndDate.Location = new Point(331, 43);
            dtEndDate.Margin = new Padding(3, 2, 3, 2);
            dtEndDate.MinDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtEndDate.Name = "dtEndDate";
            dtEndDate.Size = new Size(318, 39);
            dtEndDate.TabIndex = 23;
            // 
            // dtStartDate
            // 
            dtStartDate.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dtStartDate.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            dtStartDate.Location = new Point(3, 43);
            dtStartDate.Margin = new Padding(3, 2, 3, 2);
            dtStartDate.MinDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            dtStartDate.Name = "dtStartDate";
            dtStartDate.Size = new Size(321, 39);
            dtStartDate.TabIndex = 25;
            // 
            // btnSaveLeaveRequest
            // 
            btnSaveLeaveRequest.BackColor = Color.LimeGreen;
            btnSaveLeaveRequest.FlatAppearance.BorderColor = Color.White;
            btnSaveLeaveRequest.FlatAppearance.BorderSize = 0;
            btnSaveLeaveRequest.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSaveLeaveRequest.ForeColor = SystemColors.Control;
            btnSaveLeaveRequest.Location = new Point(3, 93);
            btnSaveLeaveRequest.Margin = new Padding(3, 2, 3, 2);
            btnSaveLeaveRequest.Name = "btnSaveLeaveRequest";
            btnSaveLeaveRequest.Size = new Size(196, 64);
            btnSaveLeaveRequest.TabIndex = 26;
            btnSaveLeaveRequest.Text = "İzin Talep Et";
            btnSaveLeaveRequest.UseVisualStyleBackColor = false;
            btnSaveLeaveRequest.Click += BtnSaveLeaveRequest_Click;
            // 
            // txtSearch
            // 
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 18F);
            txtSearch.Location = new Point(10, 72);
            txtSearch.Margin = new Padding(3, 2, 3, 2);
            txtSearch.MaxLength = 11;
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Çalışan Arama";
            txtSearch.Size = new Size(296, 37);
            txtSearch.TabIndex = 29;
            txtSearch.TextChanged += TxtSearch_TextChanged;
            // 
            // lstEmployees
            // 
            lstEmployees.FormattingEnabled = true;
            lstEmployees.ItemHeight = 15;
            lstEmployees.Location = new Point(10, 113);
            lstEmployees.Margin = new Padding(3, 2, 3, 2);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(296, 229);
            lstEmployees.TabIndex = 31;
            // 
            // cmbLeaveStatus
            // 
            cmbLeaveStatus.Font = new Font("Segoe UI", 18F);
            cmbLeaveStatus.FormattingEnabled = true;
            cmbLeaveStatus.ItemHeight = 32;
            cmbLeaveStatus.Items.AddRange(new object[] { "Beklemede", "Onaylandı ", "Reddedildi" });
            cmbLeaveStatus.Location = new Point(363, 368);
            cmbLeaveStatus.Margin = new Padding(3, 2, 3, 2);
            cmbLeaveStatus.Name = "cmbLeaveStatus";
            cmbLeaveStatus.Size = new Size(296, 40);
            cmbLeaveStatus.TabIndex = 32;
            // 
            // lblLeaveStatus
            // 
            lblLeaveStatus.AutoSize = true;
            lblLeaveStatus.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblLeaveStatus.Location = new Point(363, 344);
            lblLeaveStatus.Name = "lblLeaveStatus";
            lblLeaveStatus.Size = new Size(115, 21);
            lblLeaveStatus.TabIndex = 33;
            lblLeaveStatus.Text = "Onay durumu";
            // 
            // lstLeaveRequest
            // 
            lstLeaveRequest.FormattingEnabled = true;
            lstLeaveRequest.ItemHeight = 15;
            lstLeaveRequest.Location = new Point(363, 113);
            lstLeaveRequest.Margin = new Padding(3, 2, 3, 2);
            lstLeaveRequest.Name = "lstLeaveRequest";
            lstLeaveRequest.Size = new Size(296, 229);
            lstLeaveRequest.TabIndex = 34;
            lstLeaveRequest.SelectedIndexChanged += LstLeaveRequest_SelectedIndexChanged;
            // 
            // btnUpdateLeaveRequest
            // 
            btnUpdateLeaveRequest.BackColor = Color.FromArgb(192, 192, 0);
            btnUpdateLeaveRequest.FlatAppearance.BorderColor = Color.White;
            btnUpdateLeaveRequest.FlatAppearance.BorderSize = 0;
            btnUpdateLeaveRequest.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnUpdateLeaveRequest.ForeColor = SystemColors.Control;
            btnUpdateLeaveRequest.Location = new Point(233, 93);
            btnUpdateLeaveRequest.Margin = new Padding(3, 2, 3, 2);
            btnUpdateLeaveRequest.Name = "btnUpdateLeaveRequest";
            btnUpdateLeaveRequest.Size = new Size(196, 64);
            btnUpdateLeaveRequest.TabIndex = 36;
            btnUpdateLeaveRequest.Text = "İzin Güncelle";
            btnUpdateLeaveRequest.UseVisualStyleBackColor = false;
            btnUpdateLeaveRequest.Click += BtnUpdateLeaveRequest_Click;
            // 
            // btnDeleteLeaveRequest
            // 
            btnDeleteLeaveRequest.BackColor = Color.Red;
            btnDeleteLeaveRequest.FlatAppearance.BorderColor = Color.White;
            btnDeleteLeaveRequest.FlatAppearance.BorderSize = 0;
            btnDeleteLeaveRequest.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnDeleteLeaveRequest.ForeColor = SystemColors.Control;
            btnDeleteLeaveRequest.Location = new Point(456, 93);
            btnDeleteLeaveRequest.Margin = new Padding(3, 2, 3, 2);
            btnDeleteLeaveRequest.Name = "btnDeleteLeaveRequest";
            btnDeleteLeaveRequest.Size = new Size(196, 64);
            btnDeleteLeaveRequest.TabIndex = 37;
            btnDeleteLeaveRequest.Text = "İzin Sil";
            btnDeleteLeaveRequest.UseVisualStyleBackColor = false;
            btnDeleteLeaveRequest.Click += BtnDeleteLeaveRequest_Click;
            // 
            // pBottomTab
            // 
            pBottomTab.Controls.Add(lblStartDate);
            pBottomTab.Controls.Add(btnDeleteLeaveRequest);
            pBottomTab.Controls.Add(dtEndDate);
            pBottomTab.Controls.Add(btnUpdateLeaveRequest);
            pBottomTab.Controls.Add(lblEndDate);
            pBottomTab.Controls.Add(dtStartDate);
            pBottomTab.Controls.Add(btnSaveLeaveRequest);
            pBottomTab.Location = new Point(10, 593);
            pBottomTab.Name = "pBottomTab";
            pBottomTab.Size = new Size(652, 162);
            pBottomTab.TabIndex = 38;
            // 
            // txtSearchLeaveRequest
            // 
            txtSearchLeaveRequest.BorderStyle = BorderStyle.FixedSingle;
            txtSearchLeaveRequest.Font = new Font("Segoe UI", 18F);
            txtSearchLeaveRequest.Location = new Point(363, 72);
            txtSearchLeaveRequest.Margin = new Padding(3, 2, 3, 2);
            txtSearchLeaveRequest.MaxLength = 11;
            txtSearchLeaveRequest.Multiline = true;
            txtSearchLeaveRequest.Name = "txtSearchLeaveRequest";
            txtSearchLeaveRequest.PlaceholderText = "İzin Talebi Arama";
            txtSearchLeaveRequest.Size = new Size(296, 37);
            txtSearchLeaveRequest.TabIndex = 29;
            txtSearchLeaveRequest.TextChanged += TxtSearchLeaveRequest_TextChanged;
            // 
            // LeaveRequestForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(691, 571);
            Controls.Add(pBottomTab);
            Controls.Add(lstLeaveRequest);
            Controls.Add(lblLeaveStatus);
            Controls.Add(cmbLeaveStatus);
            Controls.Add(lstEmployees);
            Controls.Add(txtSearchLeaveRequest);
            Controls.Add(txtSearch);
            Controls.Add(lblLeaveType);
            Controls.Add(txtOther);
            Controls.Add(lblOther);
            Controls.Add(cmbLeaveType);
            Controls.Add(lblQuotes);
            Controls.Add(lblLeaveRequestForm);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 2, 3, 2);
            Name = "LeaveRequestForm";
            Text = "İzin Talebi Formu";
            Load += LeaveRequestForm_Load;
            pBottomTab.ResumeLayout(false);
            pBottomTab.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLeaveRequestForm;
        private Label lblQuotes;
        private ComboBox cmbLeaveType;
        private Label lblLeaveType;
        private TextBox txtOther;
        private Label lblOther;
        private Label lblEndDate;
        private Label lblStartDate;
        private DateTimePicker dtEndDate;
        private DateTimePicker dtStartDate;
        private Button btnSaveLeaveRequest;
        private TextBox txtSearch;
        private ListBox lstEmployees;
        private ComboBox cmbLeaveStatus;
        private Label lblLeaveStatus;
        private ListBox lstLeaveRequest;
        private Button btnUpdateLeaveRequest;
        private Button btnDeleteLeaveRequest;
        private Panel pBottomTab;
        private TextBox txtSearchLeaveRequest;
    }
}