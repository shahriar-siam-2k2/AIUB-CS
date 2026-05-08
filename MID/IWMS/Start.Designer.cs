namespace IWMS
{
    partial class Start
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
            btnLogin = new Button();
            btnRegister = new Button();
            btnContribution = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(19, 36);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Inventory and Warehouse Management System";
            lblTitle.Click += lblTitle_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.FromArgb(128, 255, 128);
            btnLogin.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(177, 161);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(145, 45);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(177, 225);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 45);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnContribution
            // 
            btnContribution.BackColor = Color.FromArgb(128, 128, 255);
            btnContribution.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnContribution.ForeColor = SystemColors.ButtonHighlight;
            btnContribution.Location = new Point(177, 288);
            btnContribution.Name = "btnContribution";
            btnContribution.Size = new Size(145, 45);
            btnContribution.TabIndex = 3;
            btnContribution.Text = "Contribution";
            btnContribution.UseVisualStyleBackColor = false;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(496, 450);
            Controls.Add(btnContribution);
            Controls.Add(btnRegister);
            Controls.Add(btnLogin);
            Controls.Add(lblTitle);
            Name = "Start";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Button btnLogin;
        private Button btnRegister;
        private Button btnContribution;
    }
}
