namespace IWMS
{
    partial class User_Registration
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
            lblFullName = new Label();
            lblUserName = new Label();
            lblUserPass = new Label();
            lblConfirmPass = new Label();
            lblEmail = new Label();
            lblPhone = new Label();
            lblRole = new Label();
            txtFullName = new TextBox();
            txtUserName = new TextBox();
            txtPass = new TextBox();
            txtConfirmPass = new TextBox();
            txtEmail = new TextBox();
            comboRole = new ComboBox();
            lblGender = new Label();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            lblDOB = new Label();
            dtpDOB = new DateTimePicker();
            btnRegister = new Button();
            mtbPhone = new MaskedTextBox();
            rbOthers = new RadioButton();
            rTxtAddress = new RichTextBox();
            lblAddress = new Label();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Trebuchet MS", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(32, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(465, 27);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Inventory and Warehouse Management System";
            // 
            // lblSubtitle
            // 
            lblSubtitle.AutoSize = true;
            lblSubtitle.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtitle.Location = new Point(177, 45);
            lblSubtitle.Name = "lblSubtitle";
            lblSubtitle.Size = new Size(154, 24);
            lblSubtitle.TabIndex = 3;
            lblSubtitle.Text = "User Registration";
            lblSubtitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFullName.Location = new Point(117, 103);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(90, 22);
            lblFullName.TabIndex = 4;
            lblFullName.Text = "Full Name :";
            lblFullName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserName.Location = new Point(110, 155);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(97, 22);
            lblUserName.TabIndex = 5;
            lblUserName.Text = "User Name :";
            lblUserName.TextAlign = ContentAlignment.MiddleCenter;
            lblUserName.Click += label1_Click;
            // 
            // lblUserPass
            // 
            lblUserPass.AutoSize = true;
            lblUserPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserPass.Location = new Point(121, 201);
            lblUserPass.Name = "lblUserPass";
            lblUserPass.Size = new Size(86, 22);
            lblUserPass.TabIndex = 6;
            lblUserPass.Text = "Password :";
            lblUserPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConfirmPass
            // 
            lblConfirmPass.AutoSize = true;
            lblConfirmPass.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfirmPass.Location = new Point(59, 255);
            lblConfirmPass.Name = "lblConfirmPass";
            lblConfirmPass.Size = new Size(148, 22);
            lblConfirmPass.TabIndex = 7;
            lblConfirmPass.Text = "Confirm Password :";
            lblConfirmPass.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(147, 300);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(60, 22);
            lblEmail.TabIndex = 8;
            lblEmail.Text = "Email :";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPhone.Location = new Point(143, 354);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(64, 22);
            lblPhone.TabIndex = 9;
            lblPhone.Text = "Phone :";
            lblPhone.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRole.Location = new Point(156, 597);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(51, 22);
            lblRole.TabIndex = 10;
            lblRole.Text = "Role :";
            lblRole.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(206, 102);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(204, 23);
            txtFullName.TabIndex = 11;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(206, 154);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(204, 23);
            txtUserName.TabIndex = 12;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(206, 200);
            txtPass.Name = "txtPass";
            txtPass.PasswordChar = '*';
            txtPass.Size = new Size(204, 23);
            txtPass.TabIndex = 13;
            // 
            // txtConfirmPass
            // 
            txtConfirmPass.Location = new Point(206, 254);
            txtConfirmPass.Name = "txtConfirmPass";
            txtConfirmPass.PasswordChar = '*';
            txtConfirmPass.Size = new Size(204, 23);
            txtConfirmPass.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(206, 302);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(204, 23);
            txtEmail.TabIndex = 15;
            // 
            // comboRole
            // 
            comboRole.DropDownStyle = ComboBoxStyle.DropDownList;
            comboRole.FormattingEnabled = true;
            comboRole.Items.AddRange(new object[] { "Admin", "Staff" });
            comboRole.Location = new Point(206, 596);
            comboRole.Name = "comboRole";
            comboRole.Size = new Size(121, 23);
            comboRole.TabIndex = 17;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblGender.Location = new Point(134, 546);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(73, 22);
            lblGender.TabIndex = 18;
            lblGender.Text = "Gender :";
            lblGender.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Trebuchet MS", 12F);
            rbMale.Location = new Point(226, 546);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(60, 26);
            rbMale.TabIndex = 19;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Trebuchet MS", 12F);
            rbFemale.Location = new Point(310, 546);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(79, 26);
            rbFemale.TabIndex = 20;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDOB.Location = new Point(93, 504);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(114, 22);
            lblDOB.TabIndex = 21;
            lblDOB.Text = "Date of Birth :";
            lblDOB.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // dtpDOB
            // 
            dtpDOB.Font = new Font("Trebuchet MS", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDOB.Location = new Point(206, 505);
            dtpDOB.MaxDate = new DateTime(2026, 4, 27, 14, 42, 27, 0);
            dtpDOB.Name = "dtpDOB";
            dtpDOB.Size = new Size(200, 21);
            dtpDOB.TabIndex = 22;
            dtpDOB.Value = new DateTime(2026, 4, 27, 0, 0, 0, 0);
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Cyan;
            btnRegister.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.Location = new Point(194, 660);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(145, 45);
            btnRegister.TabIndex = 23;
            btnRegister.Text = "Register User";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // mtbPhone
            // 
            mtbPhone.Font = new Font("Trebuchet MS", 12F);
            mtbPhone.Location = new Point(206, 351);
            mtbPhone.Mask = "+88 00000000000";
            mtbPhone.Name = "mtbPhone";
            mtbPhone.Size = new Size(204, 26);
            mtbPhone.TabIndex = 24;
            // 
            // rbOthers
            // 
            rbOthers.AutoSize = true;
            rbOthers.Font = new Font("Trebuchet MS", 12F);
            rbOthers.Location = new Point(408, 546);
            rbOthers.Name = "rbOthers";
            rbOthers.Size = new Size(75, 26);
            rbOthers.TabIndex = 25;
            rbOthers.TabStop = true;
            rbOthers.Text = "Others";
            rbOthers.UseVisualStyleBackColor = true;
            // 
            // rTxtAddress
            // 
            rTxtAddress.Location = new Point(206, 403);
            rTxtAddress.Name = "rTxtAddress";
            rTxtAddress.Size = new Size(204, 71);
            rTxtAddress.TabIndex = 26;
            rTxtAddress.Text = "";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.BackColor = Color.Transparent;
            lblAddress.Font = new Font("Trebuchet MS", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAddress.Location = new Point(130, 425);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(75, 22);
            lblAddress.TabIndex = 27;
            lblAddress.Text = "Address :";
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // User_Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(540, 736);
            Controls.Add(lblAddress);
            Controls.Add(rTxtAddress);
            Controls.Add(rbOthers);
            Controls.Add(mtbPhone);
            Controls.Add(btnRegister);
            Controls.Add(dtpDOB);
            Controls.Add(lblDOB);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(lblGender);
            Controls.Add(comboRole);
            Controls.Add(txtEmail);
            Controls.Add(txtConfirmPass);
            Controls.Add(txtPass);
            Controls.Add(txtUserName);
            Controls.Add(txtFullName);
            Controls.Add(lblRole);
            Controls.Add(lblPhone);
            Controls.Add(lblEmail);
            Controls.Add(lblConfirmPass);
            Controls.Add(lblUserPass);
            Controls.Add(lblUserName);
            Controls.Add(lblFullName);
            Controls.Add(lblSubtitle);
            Controls.Add(lblTitle);
            Name = "User_Registration";
            Text = "User_Registration";
            Load += User_Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label lblSubtitle;
        private Label lblFullName;
        private Label lblUserName;
        private Label lblUserPass;
        private Label lblConfirmPass;
        private Label lblEmail;
        private Label lblPhone;
        private Label lblRole;
        private TextBox txtFullName;
        private TextBox txtUserName;
        private TextBox txtPass;
        private TextBox txtConfirmPass;
        private TextBox txtEmail;
        private ComboBox comboRole;
        private Label lblGender;
        private RadioButton rbMale;
        private RadioButton rbFemale;
        private Label lblDOB;
        private DateTimePicker dtpDOB;
        private Button btnRegister;
        private MaskedTextBox mtbPhone;
        private RadioButton rbOthers;
        private RichTextBox rTxtAddress;
        private Label lblAddress;
    }
}