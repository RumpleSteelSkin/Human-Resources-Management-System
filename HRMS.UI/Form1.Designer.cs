﻿namespace HRMS.UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(158, 100);
            button1.Name = "button1";
            button1.Size = new Size(287, 184);
            button1.TabIndex = 0;
            button1.Text = "EREN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(158, 289);
            button2.Name = "button2";
            button2.Size = new Size(287, 184);
            button2.TabIndex = 1;
            button2.Text = "AHMET";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.BackColor = Color.FromArgb(255, 192, 192);
            label1.Location = new Point(478, 100);
            label1.Name = "label1";
            label1.Size = new Size(242, 184);
            label1.TabIndex = 2;
            label1.Text = "ASLIHAN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 771);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
    }
}
