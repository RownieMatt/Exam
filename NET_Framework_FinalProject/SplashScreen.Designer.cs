namespace NET_Framework_FinalProject
{
    partial class SplashScreen
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            timer1 = new System.Windows.Forms.Timer(components);
            SplashTitle = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 2000;
            timer1.Tick += timer1_Tick;
            // 
            // SplashTitle
            // 
            SplashTitle.AutoSize = true;
            SplashTitle.BackColor = Color.Transparent;
            SplashTitle.Dock = DockStyle.Top;
            SplashTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            SplashTitle.ForeColor = SystemColors.ActiveCaption;
            SplashTitle.Location = new Point(0, 0);
            SplashTitle.Name = "SplashTitle";
            SplashTitle.Size = new Size(262, 21);
            SplashTitle.TabIndex = 0;
            SplashTitle.Text = "Employee/Customer Information";
            SplashTitle.TextAlign = ContentAlignment.TopCenter;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(275, 181);
            Controls.Add(SplashTitle);
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += SplashScreen_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label SplashTitle;
    }
}