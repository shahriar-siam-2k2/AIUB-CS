namespace IWMS
{
    partial class Login
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
            lblSubtitle = new Label();
            lblUserID = new Label();
            lblUserPass = new Label();
            txtUserID = new TextBox();
            txtPass = new TextBox();
            btnLogin = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(12, 35);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(165, 86);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(142, 27);
            lblSubtitle.TabIndex = 2;
            lblSubtitle.Text = "Member Login";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserID.Location = new Point(106, 132);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(66, 22);
            lblUserID.TabIndex = 3;
            lblUserID.Text = "UserID :";
            lblUserID.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(107, 214);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(86, 22);
            lblUserPass.TabIndex = 4;
            lblUserPass.Text = "Password :";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtUserID
            // 
            txtUserID.Location = new Point(110, 157);
            txtUserID.Name = "txtUserID";
            txtUserID.Size = new Size(263, 23);
            txtUserID.TabIndex = 5;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(110, 239);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(263, 23);
            txtPass.TabIndex = 6;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(175, 322);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(123, 34);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 128, 128);
            btnCancel.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.ForeColor = SystemColors.ButtonHighlight;
            btnCancel.Location = new Point(175, 378);
            btnCancel.Name = "btnCancel";
            btnCancel.RightToLeft = RightToLeft.No;
            btnCancel.Size = new Size(123, 34);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(485, 450);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPass);
            Controls.Add(txtUserID);
            Controls.Add(lblUserPass);
            Controls.Add(lblUserID);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblUserID;
        private Label lblUserPass;
        private TextBox txtUserID;
        private TextBox txtPass;
        private Button btnLogin;
        private Button btnCancel;
    }
}