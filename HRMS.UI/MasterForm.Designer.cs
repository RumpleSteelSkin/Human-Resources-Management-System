namespace HRMS.UI
{
    partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            lblCredits = new Label();
            SuspendLayout();
            // 
            // lblCredits
            // 
            lblCredits.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCredits.BackColor = Color.White;
            lblCredits.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblCredits.Location = new Point(823, 336);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(229, 199);
            lblCredits.TabIndex = 1;
            lblCredits.Text = "GELİŞTİRENLER\r\nEREN\r\nASLIHAN\r\nMETİNHAN\r\nAHMET\r\n";
            lblCredits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MasterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1064, 544);
            Controls.Add(lblCredits);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            IsMdiContainer = true;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MasterForm";
            Text = "GİRİŞ EKRANI";
            WindowState = FormWindowState.Maximized;
            Load += MasterForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label lblCredits;
    }
}
