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
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=RYZEN-3;Initial Catalog=VOTING_PLATFORM;Integrated Security=True");

        private void btnVote_Click(object sender, EventArgs e)
        {

        }
    }
}
