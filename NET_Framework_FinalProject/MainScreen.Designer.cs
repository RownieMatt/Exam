namespace NET_Framework_FinalProject
{
    partial class MainScreen
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
            WlcmLabel = new Label();
            LogOB = new Button();
            tblEmployeeB = new Button();
            tblCustomerB = new Button();
            GridView = new DataGridView();
            CloseB = new Button();
            DetailsB = new Button();
            SearchTBox = new TextBox();
            AscB = new Button();
            DscB = new Button();
            DeleteB = new Button();
            SearchB = new Button();
            ((System.ComponentModel.ISupportInitialize)GridView).BeginInit();
            SuspendLayout();
            // 
            // WlcmLabel
            // 
            WlcmLabel.AutoSize = true;
            WlcmLabel.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            WlcmLabel.Location = new Point(314, 14);
            WlcmLabel.Name = "WlcmLabel";
            WlcmLabel.Size = new Size(63, 25);
            WlcmLabel.TabIndex = 0;
            WlcmLabel.Text = "label1";
            // 
            // LogOB
            // 
            LogOB.Location = new Point(577, 14);
            LogOB.Name = "LogOB";
            LogOB.Size = new Size(94, 34);
            LogOB.TabIndex = 1;
            LogOB.Text = "Logout ";
            LogOB.UseVisualStyleBackColor = true;
            LogOB.Click += LogOB_Click;
            // 
            // tblEmployeeB
            // 
            tblEmployeeB.Location = new Point(200, 65);
            tblEmployeeB.Name = "tblEmployeeB";
            tblEmployeeB.Size = new Size(160, 25);
            tblEmployeeB.TabIndex = 2;
            tblEmployeeB.Text = "Show Employees";
            tblEmployeeB.UseVisualStyleBackColor = true;
            tblEmployeeB.Click += tblEmployeeB_Click;
            // 
            // tblCustomerB
            // 
            tblCustomerB.Location = new Point(366, 65);
            tblCustomerB.Name = "tblCustomerB";
            tblCustomerB.Size = new Size(160, 25);
            tblCustomerB.TabIndex = 3;
            tblCustomerB.Text = "Show Customers";
            tblCustomerB.UseVisualStyleBackColor = true;
            tblCustomerB.Click += tblCustomerB_Click;
            // 
            // GridView
            // 
            GridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridView.Dock = DockStyle.Bottom;
            GridView.Location = new Point(0, 300);
            GridView.Name = "GridView";
            GridView.RowTemplate.Height = 25;
            GridView.Size = new Size(800, 150);
            GridView.TabIndex = 4;
            GridView.Visible = false;
            // 
            // CloseB
            // 
            CloseB.Location = new Point(698, 14);
            CloseB.Name = "CloseB";
            CloseB.Size = new Size(94, 34);
            CloseB.TabIndex = 6;
            CloseB.Text = "Close";
            CloseB.UseVisualStyleBackColor = true;
            CloseB.Click += CloseB_Click;
            // 
            // DetailsB
            // 
            DetailsB.Location = new Point(279, 257);
            DetailsB.Name = "DetailsB";
            DetailsB.Size = new Size(160, 25);
            DetailsB.TabIndex = 7;
            DetailsB.Text = "Table Details";
            DetailsB.UseVisualStyleBackColor = true;
            DetailsB.Visible = false;
            DetailsB.Click += DetailsB_Click;
            // 
            // SearchTBox
            // 
            SearchTBox.Location = new Point(279, 117);
            SearchTBox.Name = "SearchTBox";
            SearchTBox.Size = new Size(169, 23);
            SearchTBox.TabIndex = 30;
            SearchTBox.Visible = false;
            // 
            // AscB
            // 
            AscB.Location = new Point(83, 257);
            AscB.Name = "AscB";
            AscB.Size = new Size(160, 25);
            AscB.TabIndex = 31;
            AscB.Text = "Order by Ascending";
            AscB.UseVisualStyleBackColor = true;
            AscB.Visible = false;
            AscB.Click += AscB_Click;
            // 
            // DscB
            // 
            DscB.Location = new Point(487, 257);
            DscB.Name = "DscB";
            DscB.Size = new Size(160, 25);
            DscB.TabIndex = 32;
            DscB.Text = "Order by Descending";
            DscB.UseVisualStyleBackColor = true;
            DscB.Visible = false;
            DscB.Click += DscB_Click;
            // 
            // DeleteB
            // 
            DeleteB.Location = new Point(200, 163);
            DeleteB.Name = "DeleteB";
            DeleteB.Size = new Size(160, 25);
            DeleteB.TabIndex = 33;
            DeleteB.Text = "Delete Row";
            DeleteB.UseVisualStyleBackColor = true;
            DeleteB.Visible = false;
            DeleteB.Click += DeleteB_Click;
            // 
            // SearchB
            // 
            SearchB.Location = new Point(366, 163);
            SearchB.Name = "SearchB";
            SearchB.Size = new Size(160, 25);
            SearchB.TabIndex = 34;
            SearchB.Text = "Search";
            SearchB.UseVisualStyleBackColor = true;
            SearchB.Visible = false;
            SearchB.Click += SearchB_Click;
            // 
            // MainScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchB);
            Controls.Add(DeleteB);
            Controls.Add(DscB);
            Controls.Add(AscB);
            Controls.Add(SearchTBox);
            Controls.Add(DetailsB);
            Controls.Add(CloseB);
            Controls.Add(GridView);
            Controls.Add(tblCustomerB);
            Controls.Add(tblEmployeeB);
            Controls.Add(LogOB);
            Controls.Add(WlcmLabel);
            Name = "MainScreen";
            Text = "MainScreen";
            Load += MainScreen_Load;
            ((System.ComponentModel.ISupportInitialize)GridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label WlcmLabel;
        private Button LogOB;
        private Button tblEmployeeB;
        private Button tblCustomerB;
        private DataGridView GridView;
        private Button CloseB;
        private Button DetailsB;
        private TextBox SearchTBox;
        private Button AscB;
        private Button DscB;
        private Button DeleteB;
        private Button SearchB;
    }
}