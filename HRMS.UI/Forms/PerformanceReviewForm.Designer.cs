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
            puantxt = new TextBox();
            label4 = new Label();
            yorumtxt = new TextBox();
            label5 = new Label();
            aramaTxt = new TextBox();
            calisanliste = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(399, 41);
            label1.TabIndex = 0;
            label1.Text = "Performans Değerlendirme";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(651, 20);
            label2.TabIndex = 1;
            label2.Text = "-----------------------------------------------------------------------------------------------------------\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(12, 107);
            label3.Name = "label3";
            label3.Size = new Size(104, 28);
            label3.TabIndex = 3;
            label3.Text = "Çalışanlar";
            // 
            // puantxt
            // 
            puantxt.Font = new Font("Segoe UI", 18F);
            puantxt.Location = new Point(433, 138);
            puantxt.Multiline = true;
            puantxt.Name = "puantxt";
            puantxt.PlaceholderText = "0";
            puantxt.Size = new Size(226, 49);
            puantxt.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(433, 107);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 5;
            label4.Text = "Puan";
            // 
            // yorumtxt
            // 
            yorumtxt.Font = new Font("Segoe UI", 12F);
            yorumtxt.Location = new Point(12, 515);
            yorumtxt.Multiline = true;
            yorumtxt.Name = "yorumtxt";
            yorumtxt.PlaceholderText = "Yorum ekleyiniz";
            yorumtxt.Size = new Size(647, 245);
            yorumtxt.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(12, 484);
            label5.Name = "label5";
            label5.Size = new Size(72, 28);
            label5.TabIndex = 7;
            label5.Text = "Yorum";
            // 
            // aramaTxt
            // 
            aramaTxt.Font = new Font("Segoe UI", 18F);
            aramaTxt.Location = new Point(12, 138);
            aramaTxt.Multiline = true;
            aramaTxt.Name = "aramaTxt";
            aramaTxt.PlaceholderText = "Çalışan ara";
            aramaTxt.Size = new Size(399, 49);
            aramaTxt.TabIndex = 8;
            aramaTxt.TextChanged += textBox1_TextChanged;
            // 
            // calisanliste
            // 
            calisanliste.Font = new Font("Segoe UI", 12F);
            calisanliste.Location = new Point(12, 193);
            calisanliste.Multiline = true;
            calisanliste.Name = "calisanliste";
            calisanliste.PlaceholderText = "Çalışan listesi";
            calisanliste.Size = new Size(399, 288);
            calisanliste.TabIndex = 9;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(186, 781);
            button1.Name = "button1";
            button1.Size = new Size(214, 71);
            button1.TabIndex = 10;
            button1.Text = "Ekle";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PerformanceReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 864);
            Controls.Add(button1);
            Controls.Add(calisanliste);
            Controls.Add(aramaTxt);
            Controls.Add(label5);
            Controls.Add(yorumtxt);
            Controls.Add(label4);
            Controls.Add(puantxt);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "PerformanceReviewForm";
            Text = "PerformanceReviewForm";
            Load += PerformanceReviewForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox puantxt;
        private Label label4;
        private TextBox yorumtxt;
        private Label label5;
        private TextBox aramaTxt;
        private TextBox calisanliste;
        private Button button1;
    }
}