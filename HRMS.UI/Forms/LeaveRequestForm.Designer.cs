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
            label1 = new Label();
            label2 = new Label();
            izinCombo = new ComboBox();
            label9 = new Label();
            yorumtxt = new TextBox();
            yorumlbl = new Label();
            label13 = new Label();
            label12 = new Label();
            endDatePicker = new DateTimePicker();
            startDatePicker = new DateTimePicker();
            button1 = new Button();
            label3 = new Label();
            aramaTxt = new TextBox();
            calisanlst = new ListBox();
            onayCombo = new ComboBox();
            label4 = new Label();
            izinLst = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(244, 41);
            label1.TabIndex = 0;
            label1.Text = "İzin talep formu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(5, 50);
            label2.Name = "label2";
            label2.Size = new Size(774, 41);
            label2.TabIndex = 1;
            label2.Text = "---------------------------------------------------------------\r\n";
            // 
            // izinCombo
            // 
            izinCombo.Font = new Font("Segoe UI", 18F);
            izinCombo.FormattingEnabled = true;
            izinCombo.ItemHeight = 41;
            izinCombo.Items.AddRange(new object[] { "Yıllık izin", "Doğum izni", "Süt izni", "Babalık izni", "Hastalık izni", "Ölüm izni", "Yeni iş arama izni", "Diğer" });
            izinCombo.Location = new Point(14, 570);
            izinCombo.Name = "izinCombo";
            izinCombo.Size = new Size(338, 49);
            izinCombo.TabIndex = 13;
            izinCombo.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label9.Location = new Point(14, 539);
            label9.Name = "label9";
            label9.Size = new Size(113, 28);
            label9.TabIndex = 14;
            label9.Text = "İzin sebebi";
            // 
            // yorumtxt
            // 
            yorumtxt.BorderStyle = BorderStyle.FixedSingle;
            yorumtxt.Font = new Font("Segoe UI", 18F);
            yorumtxt.Location = new Point(14, 663);
            yorumtxt.MaxLength = 500;
            yorumtxt.Multiline = true;
            yorumtxt.Name = "yorumtxt";
            yorumtxt.Size = new Size(741, 201);
            yorumtxt.TabIndex = 13;
            // 
            // yorumlbl
            // 
            yorumlbl.AutoSize = true;
            yorumlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            yorumlbl.Location = new Point(14, 632);
            yorumlbl.Name = "yorumlbl";
            yorumlbl.Size = new Size(64, 28);
            yorumlbl.TabIndex = 14;
            yorumlbl.Text = "Diğer";
            yorumlbl.Click += yorumlbl_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label13.Location = new Point(389, 878);
            label13.Name = "label13";
            label13.Size = new Size(111, 28);
            label13.TabIndex = 24;
            label13.Text = "Bitiş tarihi";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label12.Location = new Point(14, 878);
            label12.Name = "label12";
            label12.Size = new Size(159, 28);
            label12.TabIndex = 21;
            label12.Text = "Başlangıç tarihi";
            label12.Click += label12_Click_1;
            // 
            // endDatePicker
            // 
            endDatePicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            endDatePicker.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            endDatePicker.Location = new Point(389, 909);
            endDatePicker.MinDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            endDatePicker.Name = "endDatePicker";
            endDatePicker.Size = new Size(366, 47);
            endDatePicker.TabIndex = 23;
            // 
            // startDatePicker
            // 
            startDatePicker.CalendarFont = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            startDatePicker.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            startDatePicker.Location = new Point(14, 909);
            startDatePicker.MinDate = new DateTime(2024, 12, 10, 0, 0, 0, 0);
            startDatePicker.Name = "startDatePicker";
            startDatePicker.Size = new Size(366, 47);
            startDatePicker.TabIndex = 25;
            // 
            // button1
            // 
            button1.BackColor = Color.LimeGreen;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(14, 976);
            button1.Name = "button1";
            button1.Size = new Size(224, 86);
            button1.TabIndex = 26;
            button1.Text = "Gönder";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label3.Location = new Point(12, 98);
            label3.Name = "label3";
            label3.Size = new Size(194, 41);
            label3.TabIndex = 28;
            label3.Text = "İsim Soyisim";
            // 
            // aramaTxt
            // 
            aramaTxt.BorderStyle = BorderStyle.FixedSingle;
            aramaTxt.Font = new Font("Segoe UI", 18F);
            aramaTxt.Location = new Point(12, 142);
            aramaTxt.MaxLength = 11;
            aramaTxt.Multiline = true;
            aramaTxt.Name = "aramaTxt";
            aramaTxt.Size = new Size(338, 49);
            aramaTxt.TabIndex = 29;
            aramaTxt.TextChanged += aramaTxt_TextChanged;
            // 
            // calisanlst
            // 
            calisanlst.FormattingEnabled = true;
            calisanlst.Location = new Point(12, 215);
            calisanlst.Name = "calisanlst";
            calisanlst.Size = new Size(338, 304);
            calisanlst.TabIndex = 31;
            // 
            // onayCombo
            // 
            onayCombo.Font = new Font("Segoe UI", 18F);
            onayCombo.FormattingEnabled = true;
            onayCombo.ItemHeight = 41;
            onayCombo.Items.AddRange(new object[] { "Beklemede", "Onaylandı ", "Reddedildi" });
            onayCombo.Location = new Point(417, 570);
            onayCombo.Name = "onayCombo";
            onayCombo.Size = new Size(338, 49);
            onayCombo.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(417, 539);
            label4.Name = "label4";
            label4.Size = new Size(141, 28);
            label4.TabIndex = 33;
            label4.Text = "Onay durumu";
            // 
            // izinLst
            // 
            izinLst.FormattingEnabled = true;
            izinLst.Location = new Point(429, 215);
            izinLst.Name = "izinLst";
            izinLst.Size = new Size(338, 304);
            izinLst.TabIndex = 34;
            // 
            // button2
            // 
            button2.Location = new Point(429, 142);
            button2.Name = "button2";
            button2.Size = new Size(326, 49);
            button2.TabIndex = 35;
            button2.Text = "İzin taleplerini getir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 192, 0);
            button3.FlatAppearance.BorderColor = Color.White;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(276, 976);
            button3.Name = "button3";
            button3.Size = new Size(224, 86);
            button3.TabIndex = 36;
            button3.Text = "Güncelle";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Red;
            button4.FlatAppearance.BorderColor = Color.White;
            button4.FlatAppearance.BorderSize = 0;
            button4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(531, 976);
            button4.Name = "button4";
            button4.Size = new Size(224, 86);
            button4.TabIndex = 37;
            button4.Text = "Sil";
            button4.UseVisualStyleBackColor = false;
            // 
            // LeaveRequestForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(790, 509);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(izinLst);
            Controls.Add(label4);
            Controls.Add(onayCombo);
            Controls.Add(calisanlst);
            Controls.Add(aramaTxt);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(startDatePicker);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(endDatePicker);
            Controls.Add(label9);
            Controls.Add(yorumtxt);
            Controls.Add(yorumlbl);
            Controls.Add(izinCombo);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LeaveRequestForm";
            Text = "LeaveRequestForm";
            Load += LeaveRequestForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox izinCombo;
        private Label label9;
        private TextBox yorumtxt;
        private Label yorumlbl;
        private Label label13;
        private Label label12;
        private DateTimePicker endDatePicker;
        private DateTimePicker startDatePicker;
        private Button button1;
        private Label label3;
        private TextBox aramaTxt;
        private ListBox calisanlst;
        private ComboBox onayCombo;
        private Label label4;
        private ListBox izinLst;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}