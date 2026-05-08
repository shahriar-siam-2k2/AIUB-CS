using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace IWMS
{
    public partial class User_Registration : Form
    {
        string fullName, userName, pass, confPass, email, phone, address, gender, role;
        DateTime dob;

        public User_Registration()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtFullName.Text == "" || txtUserName.Text == "" || txtPass.Text == "" || txtConfirmPass.Text == "" || txtEmail.Text == "" || mtbPhone.Text == "" || rTxtAddress.Text == "" || 
              comboRole.Text == "" || (!rbMale.Checked && !rbFemale.Checked && !rbOthers.Checked)
              )
            {
                MessageBox.Show("Please fill all the fields and select a gender.");
                return;
            }
            else
            {
                fullName = txtFullName.Text;
                userName = txtUserName.Text;
                pass = txtPass.Text;
                confPass = txtConfirmPass.Text;
                email = txtEmail.Text;
                phone = mtbPhone.Text;
                address = rTxtAddress.Text;
                dob = dtpDOB.Value;
                role = comboRole.Text;

                if (rbMale.Checked)
                    gender = "Male";
                else if (rbFemale.Checked)
                    gender = "Female";
                else if (rbOthers.Checked)
                    gender = "Others";
                else
                    gender = string.Empty;

                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=IWMS_DB;Integrated Security=True;Encrypt=True;TrustServerCertificate=True");
                con.Open();

                string query = "INSERT INTO User_Registration (FullName, UserName, Password, Email, Phone, Address, DOB, Gender, Role) VALUES (@FullName, @UserName, @Password, @Email, @Phone, @Address, @DOB, @Gender, @Role)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@UserName", userName);
                    cmd.Parameters.AddWithValue("@Password", pass);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@DOB", dob);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Role", role);

                    cmd.ExecuteNonQuery();
                    con.Close();

                    string message = $"Successfully Registered.\n\n" +
                                     $"Full Name: {fullName}\n\n" +
                                     $"User Name: {userName}\n\n" +
                                     $"Password: {pass}\n\n" +
                                     $"Email: {email}\n\n" +
                                     $"Phone: {phone}\n\n" +
                                     $"Address: {address}\n\n" +
                                     $"DOB: {dob.ToShortDateString()}\n\n" +
                                     $"Gender: {gender}\n\n" +
                                     $"Role: {role}\n\n";

                    MessageBox.Show(message);
                }
            }

        }

        private void User_Registration_Load(object sender, EventArgs e)
        {

        }
    }
}
