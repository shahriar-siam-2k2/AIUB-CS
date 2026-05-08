namespace Demo_Project
{
    partial class LoginPage
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
            lblTitle = new Label();
            lblUsername = new Label();
            lblUserPass = new Label();
            txtUserName = new TextBox();
            txtUserPass = new TextBox();
            btnLogin = new Button();
            lblUserEmpty = new Label();
            lblPassEmpty = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.FromArgb(128, 64, 0);
            lblTitle.Location = new Point(27, 23);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(434, 25);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory and Warehouse Management System";
            lblTitle.Click += label1_Click;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUsername.Location = new Point(106, 181);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(99, 20);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "User Name : ";
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(117, 249);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(88, 20);
            lblUserPass.TabIndex = 2;
            lblUserPass.Text = "Password : ";
            // 
            // txtUserName
            // 
            txtUserName.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserName.Location = new Point(211, 178);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(160, 27);
            txtUserName.TabIndex = 3;
            // 
            // txtUserPass
            // 
            txtUserPass.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUserPass.Location = new Point(211, 246);
            txtUserPass.Name = "txtUserPass";
            txtUserPass.PasswordChar = '*';
            txtUserPass.Size = new Size(160, 27);
            txtUserPass.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Lime;
            btnLogin.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(195, 356);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(101, 33);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblUserEmpty
            // 
            lblUserEmpty.AutoSize = true;
            lblUserEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserEmpty.ForeColor = Color.Red;
            lblUserEmpty.Location = new Point(209, 209);
            lblUserEmpty.Name = "lblUserEmpty";
            lblUserEmpty.Size = new Size(175, 15);
            lblUserEmpty.TabIndex = 6;
            lblUserEmpty.Text = "The User Name field is required.";
            // 
            // lblPassEmpty
            // 
            lblPassEmpty.AutoSize = true;
            lblPassEmpty.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassEmpty.ForeColor = Color.Red;
            lblPassEmpty.Location = new Point(211, 278);
            lblPassEmpty.Name = "lblPassEmpty";
            lblPassEmpty.Size = new Size(167, 15);
            lblPassEmpty.TabIndex = 7;
            lblPassEmpty.Text = "The Password field is required.";
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(485, 488);
            Controls.Add(lblPassEmpty);
            Controls.Add(lblUserEmpty);
            Controls.Add(btnLogin);
            Controls.Add(txtUserPass);
            Controls.Add(txtUserName);
            Controls.Add(lblUserPass);
            Controls.Add(lblUsername);
            Controls.Add(lblTitle);
            Name = "LoginPage";
            Text = "Login";
            Load += LoginPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblUsername;
        private Label lblUserPass;
        private TextBox txtUserName;
        private TextBox txtUserPass;
        private Button btnLogin;
        private Label lblUserEmpty;
        private Label lblPassEmpty;
    }
}
