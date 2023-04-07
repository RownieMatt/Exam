namespace NET_Framework_FinalProject
{
    partial class LoginScreen
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
            UserNL = new Label();
            PassL = new Label();
            UserNTBox = new TextBox();
            PassTBox = new TextBox();
            LoginB = new Button();
            RegisterB = new Button();
            CPassTBox = new TextBox();
            CPassL = new Label();
            tblUser = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)tblUser).BeginInit();
            SuspendLayout();
            // 
            // UserNL
            // 
            UserNL.AutoSize = true;
            UserNL.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            UserNL.Location = new Point(143, 90);
            UserNL.Name = "UserNL";
            UserNL.Size = new Size(75, 20);
            UserNL.TabIndex = 0;
            UserNL.Text = "Username";
            // 
            // PassL
            // 
            PassL.AutoSize = true;
            PassL.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PassL.Location = new Point(143, 152);
            PassL.Name = "PassL";
            PassL.Size = new Size(70, 20);
            PassL.TabIndex = 1;
            PassL.Text = "Password";
            // 
            // UserNTBox
            // 
            UserNTBox.Location = new Point(253, 91);
            UserNTBox.Name = "UserNTBox";
            UserNTBox.Size = new Size(235, 23);
            UserNTBox.TabIndex = 2;
            // 
            // PassTBox
            // 
            PassTBox.Location = new Point(253, 153);
            PassTBox.Name = "PassTBox";
            PassTBox.Size = new Size(235, 23);
            PassTBox.TabIndex = 3;
            // 
            // LoginB
            // 
            LoginB.Location = new Point(148, 257);
            LoginB.Name = "LoginB";
            LoginB.Size = new Size(134, 34);
            LoginB.TabIndex = 4;
            LoginB.Text = "Login";
            LoginB.UseVisualStyleBackColor = true;
            LoginB.Click += LoginB_Click;
            // 
            // RegisterB
            // 
            RegisterB.Location = new Point(326, 257);
            RegisterB.Name = "RegisterB";
            RegisterB.Size = new Size(167, 34);
            RegisterB.TabIndex = 5;
            RegisterB.Text = "Register";
            RegisterB.UseVisualStyleBackColor = true;
            RegisterB.Click += RegisterB_Click;
            // 
            // CPassTBox
            // 
            CPassTBox.Location = new Point(253, 209);
            CPassTBox.Name = "CPassTBox";
            CPassTBox.Size = new Size(240, 23);
            CPassTBox.TabIndex = 7;
            CPassTBox.Visible = false;
            // 
            // CPassL
            // 
            CPassL.AutoSize = true;
            CPassL.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CPassL.Location = new Point(80, 208);
            CPassL.Name = "CPassL";
            CPassL.Size = new Size(127, 20);
            CPassL.TabIndex = 6;
            CPassL.Text = "Confirm Password";
            CPassL.Visible = false;
            // 
            // tblUser
            // 
            tblUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblUser.Dock = DockStyle.Bottom;
            tblUser.Location = new Point(0, 297);
            tblUser.Name = "tblUser";
            tblUser.RowTemplate.Height = 25;
            tblUser.Size = new Size(656, 130);
            tblUser.TabIndex = 8;
            tblUser.Visible = false;
            // 
            // LoginScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 427);
            Controls.Add(tblUser);
            Controls.Add(CPassTBox);
            Controls.Add(CPassL);
            Controls.Add(RegisterB);
            Controls.Add(LoginB);
            Controls.Add(PassTBox);
            Controls.Add(UserNTBox);
            Controls.Add(PassL);
            Controls.Add(UserNL);
            Name = "LoginScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginScreen";
            Load += LoginScreen_Load;
            ((System.ComponentModel.ISupportInitialize)tblUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNL;
        private Label PassL;
        private TextBox UserNTBox;
        private TextBox PassTBox;
        private Button LoginB;
        private Button RegisterB;
        private TextBox CPassTBox;
        private Label CPassL;
        private DataGridView tblUser;
    }
}