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
            puanlst = new ListBox();
            button2 = new Button();
            button3 = new Button();
            puanlisteara = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)puan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(11, 19);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "Performans Değerlendirme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 71);
            label2.Name = "label2";
            label2.Size = new Size(1095, 20);
            label2.TabIndex = 1;
            label2.Text = "-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(367, 117);
            label3.Name = "label3";
            label3.Size = new Size(268, 28);
            label3.TabIndex = 3;
            label3.Text = "Puan verilecek olan çalışan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(14, 395);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 5;
            label4.Text = "Puan";
            // 
            // yorumtxt
            // 
            yorumtxt.Font = new Font("Segoe UI", 12F);
            yorumtxt.Location = new Point(11, 515);
            yorumtxt.Multiline = true;
            yorumtxt.Name = "yorumtxt";
            yorumtxt.PlaceholderText = "Yorum ekleyiniz";
            yorumtxt.Size = new Size(647, 233);
            yorumtxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(11, 484);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 7;
            label5.Text = "Yorum";
            // 
            // aramaTxt
            // 
            aramaTxt.Font = new Font("Segoe UI", 18F);
            aramaTxt.Location = new Point(367, 148);
            aramaTxt.Multiline = true;
            aramaTxt.Name = "aramaTxt";
            aramaTxt.PlaceholderText = "Çalışan ara";
            aramaTxt.Size = new Size(292, 49);
            aramaTxt.TabIndex = 8;
            aramaTxt.TextChanged += AramaTxt_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(196, 777);
            button1.Name = "button1";
            button1.Size = new Size(214, 71);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Button1_Click;
            // 
            // calisanliste
            // 
            calisanliste.FormattingEnabled = true;
            calisanliste.Location = new Point(367, 204);
            calisanliste.Name = "calisanliste";
            calisanliste.Size = new Size(292, 184);
            calisanliste.TabIndex = 11;
            // 
            // puan
            // 
            puan.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 162);
            puan.Location = new Point(14, 429);
            puan.Name = "puan";
            puan.Size = new Size(643, 47);
            puan.TabIndex = 12;
            // 
            // lblVoter
            // 
            lblVoter.AutoSize = true;
            lblVoter.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblVoter.Location = new Point(11, 117);
            lblVoter.Name = "lblVoter";
            lblVoter.Size = new Size(209, 28);
            lblVoter.TabIndex = 3;
            lblVoter.Text = "Puan verecek çalışan";
            // 
            // txtVoterSearch
            // 
            txtVoterSearch.Font = new Font("Segoe UI", 18F);
            txtVoterSearch.Location = new Point(14, 148);
            txtVoterSearch.Multiline = true;
            txtVoterSearch.Name = "txtVoterSearch";
            txtVoterSearch.PlaceholderText = "Çalışan ara";
            txtVoterSearch.Size = new Size(269, 49);
            txtVoterSearch.TabIndex = 8;
            txtVoterSearch.TextChanged += TxtVoterSearch_TextChanged;
            // 
            // lstVoterEmployee
            // 
            lstVoterEmployee.FormattingEnabled = true;
            lstVoterEmployee.Location = new Point(14, 204);
            lstVoterEmployee.Name = "lstVoterEmployee";
            lstVoterEmployee.Size = new Size(269, 184);
            lstVoterEmployee.TabIndex = 11;
            // 
            // puanlst
            // 
            puanlst.FormattingEnabled = true;
            puanlst.Location = new Point(683, 204);
            puanlst.Name = "puanlst";
            puanlst.Size = new Size(426, 544);
            puanlst.TabIndex = 13;
            puanlst.SelectedIndexChanged += puanlst_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 192, 0);
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button2.Location = new Point(448, 777);
            button2.Name = "button2";
            button2.Size = new Size(214, 71);
            button2.TabIndex = 14;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(192, 0, 0);
            button3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button3.Location = new Point(713, 777);
            button3.Name = "button3";
            button3.Size = new Size(214, 71);
            button3.TabIndex = 15;
            button3.Text = "Sil";
            button3.UseVisualStyleBackColor = false;
            // 
            // puanlisteara
            // 
            puanlisteara.Font = new Font("Segoe UI", 18F);
            puanlisteara.Location = new Point(683, 148);
            puanlisteara.Multiline = true;
            puanlisteara.Name = "puanlisteara";
            puanlisteara.PlaceholderText = "Puan listesini ara";
            puanlisteara.Size = new Size(426, 49);
            puanlisteara.TabIndex = 16;
            puanlisteara.TextChanged += puanlisteara_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label6.Location = new Point(683, 117);
            label6.Name = "label6";
            label6.Size = new Size(137, 28);
            label6.TabIndex = 17;
            label6.Text = "Puan Tablosu";
            // 
            // PerformanceReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1121, 860);
            Controls.Add(label6);
            Controls.Add(puanlisteara);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(puanlst);
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
        private ListBox puanlst;
        private Button button2;
        private Button button3;
        private TextBox puanlisteara;
        private Label label6;
    }
}