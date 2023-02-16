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
using System.Xml.Linq;

namespace Voting_Platform
{
    public partial class Vote : Form
    {
        public Vote()
        {
            InitializeComponent();
        }
        public int VoterId = 0;
        public int PartyId = 0;
        SqlConnection con = new SqlConnection("Data Source=RYZEN-3;Initial Catalog=VOTING_PLATFORM;Integrated Security=True");
        
        internal void getUId(int uId)
        {
            VoterId = uId;
        }
        
        private void btnVote_Click(object sender, EventArgs e)
        {
            PartyId = (int)cbParty.SelectedValue;

            try
            {
                con.Open();
                String comm = "exec dbo.SP_Vote '" + VoterId + "', '" + PartyId + "'";
                SqlCommand cmd = new SqlCommand(comm, con);
                cmd.ExecuteNonQuery();

                MessageBox.Show("vote Successful");

                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void Vote_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vOTING_PLATFORMDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.vOTING_PLATFORMDataSet.Party);

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();   
        }
    }
}
