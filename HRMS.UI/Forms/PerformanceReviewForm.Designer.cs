namespace HRMS.UI.Forms
{
    partial class PerformanceReviewForm
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
            label3 = new Label();
            label4 = new Label();
            yorumtxt = new TextBox();
            label5 = new Label();
            aramaTxt = new TextBox();
            button1 = new Button();
            calisanliste = new ListBox();
            puan = new NumericUpDown();
            lblVoter = new Label();
            txtVoterSearch = new TextBox();
            lstVoterEmployee = new ListBox();
            ((System.ComponentModel.ISupportInitialize)puan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(325, 32);
            label1.TabIndex = 0;
            label1.Text = "Performans Değerlendirme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 53);
            label2.Name = "label2";
            label2.Size = new Size(542, 15);
            label2.TabIndex = 1;
            label2.Text = "-----------------------------------------------------------------------------------------------------------\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(321, 88);
            label3.Name = "label3";
            label3.Size = new Size(217, 21);
            label3.TabIndex = 3;
            label3.Text = "Puan verilecek olan çalışan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(12, 296);
            label4.Name = "label4";
            label4.Size = new Size(49, 21);
            label4.TabIndex = 5;
            label4.Text = "Puan";
            // 
            // yorumtxt
            // 
            yorumtxt.Font = new Font("Segoe UI", 12F);
            yorumtxt.Location = new Point(10, 386);
            yorumtxt.Margin = new Padding(3, 2, 3, 2);
            yorumtxt.Multiline = true;
            yorumtxt.Name = "yorumtxt";
            yorumtxt.PlaceholderText = "Yorum ekleyiniz";
            yorumtxt.Size = new Size(567, 185);
            yorumtxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(10, 363);
            label5.Name = "label5";
            label5.Size = new Size(60, 21);
            label5.TabIndex = 7;
            label5.Text = "Yorum";
            // 
            // aramaTxt
            // 
            aramaTxt.Font = new Font("Segoe UI", 18F);
            aramaTxt.Location = new Point(321, 111);
            aramaTxt.Margin = new Padding(3, 2, 3, 2);
            aramaTxt.Multiline = true;
            aramaTxt.Name = "aramaTxt";
            aramaTxt.PlaceholderText = "Çalışan ara";
            aramaTxt.Size = new Size(256, 38);
            aramaTxt.TabIndex = 8;
            aramaTxt.TextChanged += AramaTxt_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(163, 586);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(187, 53);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // calisanliste
            // 
            calisanliste.FormattingEnabled = true;
            calisanliste.ItemHeight = 15;
            calisanliste.Location = new Point(321, 153);
            calisanliste.Margin = new Padding(3, 2, 3, 2);
            calisanliste.Name = "calisanliste";
            calisanliste.Size = new Size(256, 139);
            calisanliste.TabIndex = 11;
            // 
            // puan
            // 
            puan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            puan.Location = new Point(12, 322);
            puan.Margin = new Padding(3, 2, 3, 2);
            puan.Name = "puan";
            puan.Size = new Size(563, 39);
            puan.TabIndex = 12;
            // 
            // lblVoter
            // 
            lblVoter.AutoSize = true;
            lblVoter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVoter.Location = new Point(10, 88);
            lblVoter.Name = "lblVoter";
            lblVoter.Size = new Size(169, 21);
            lblVoter.TabIndex = 3;
            lblVoter.Text = "Puan verecek çalışan";
            // 
            // txtVoterSearch
            // 
            txtVoterSearch.Font = new Font("Segoe UI", 18F);
            txtVoterSearch.Location = new Point(12, 111);
            txtVoterSearch.Margin = new Padding(3, 2, 3, 2);
            txtVoterSearch.Multiline = true;
            txtVoterSearch.Name = "txtVoterSearch";
            txtVoterSearch.PlaceholderText = "Çalışan ara";
            txtVoterSearch.Size = new Size(236, 38);
            txtVoterSearch.TabIndex = 8;
            txtVoterSearch.TextChanged += TxtVoterSearch_TextChanged;
            // 
            // lstVoterEmployee
            // 
            lstVoterEmployee.FormattingEnabled = true;
            lstVoterEmployee.ItemHeight = 15;
            lstVoterEmployee.Location = new Point(12, 153);
            lstVoterEmployee.Margin = new Padding(3, 2, 3, 2);
            lstVoterEmployee.Name = "lstVoterEmployee";
            lstVoterEmployee.Size = new Size(236, 139);
            lstVoterEmployee.TabIndex = 11;
            // 
            // PerformanceReviewForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(587, 648);
            Controls.Add(puan);
            Controls.Add(lstVoterEmployee);
            Controls.Add(calisanliste);
            Controls.Add(button1);
            Controls.Add(txtVoterSearch);
            Controls.Add(aramaTxt);
            Controls.Add(label5);
            Controls.Add(yorumtxt);
            Controls.Add(label4);
            Controls.Add(lblVoter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PerformanceReviewForm";
            Text = "PerformanceReviewForm";
            Load += PerformanceReviewForm_Load;
            ((System.ComponentModel.ISupportInitialize)puan).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox yorumtxt;
        private Label label5;
        private TextBox aramaTxt;
        private Button button1;
        private ListBox calisanliste;
        private NumericUpDown puan;
        private Label lblVoter;
        private TextBox txtVoterSearch;
        private ListBox lstVoterEmployee;
    }
}