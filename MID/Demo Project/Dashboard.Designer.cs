namespace Demo_Project
{
    partial class Dashboard
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
            lblTitle = new Label();
            lblUser = new Label();
            lblSubtitle = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitle.Location = new Point(176, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(434, 25);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUser.ForeColor = Color.FromArgb(128, 64, 0);
            lblUser.Location = new Point(377, 198);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(0, 25);
            lblUser.TabIndex = 2;
            lblUser.Click += lblUser_Click;
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSubtitle.ForeColor = Color.FromArgb(128, 64, 0);
            lblSubtitle.Location = new Point(347, 70);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(93, 21);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "Dashboard";
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSubtitle);
            Controls.Add(lblUser);
            Controls.Add(lblTitle);
            Name = "Dashboard";
            Text = "Dashboard";
            Load += Dashboard_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUser;
        private Label lblSubtitle;
    }
}