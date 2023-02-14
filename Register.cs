using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Voting_Platform
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RYZEN-3;Initial Catalog=VOTING_PLATFORM;Integrated Security=True");


        private void pictureBox1_Click(object sender, EventArgs e)
        {
                    }

        private void linklblLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Length > 0  && txtEmail.Text.Length>0)
            {

            }
            else
            {
                MessageBox.Show("Name and Email Required");
            }
        }
    }
}
