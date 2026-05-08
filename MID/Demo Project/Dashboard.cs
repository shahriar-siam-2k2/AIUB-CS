using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Demo_Project
{
    public partial class Dashboard : Form
    {
        string userName;
        public Dashboard(string userName)
        {
            this.userName = userName;
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            lblUser.Text = userName;
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
            
        }
    }
}
