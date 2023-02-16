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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            // TODO: This line of code loads data into the 'vOTING_PLATFORMDataSet1.SP_GetWinner' table. You can move, or remove it, as needed.
            this.sP_GetWinnerTableAdapter.Fill(this.vOTING_PLATFORMDataSet1.SP_GetWinner);
            // TODO: This line of code loads data into the 'vOTING_PLATFORMDataSet.Party' table. You can move, or remove it, as needed.
            this.partyTableAdapter.Fill(this.vOTING_PLATFORMDataSet.Party);



        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWinner_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
               
                string comm = "exec dbo.SP_GetWinner";
                SqlCommand cmd = new SqlCommand(comm, con);
                // cmd.ExecuteNonQuery();
                SqlDataReader dataReader = cmd.ExecuteReader();
                dataReader.Read();
                if (dataReader != null)
                {
                    int anc = dataReader.GetInt32(0);
                    int eff = dataReader.GetInt32(1);
                    int da = dataReader.GetInt32(2);
                    int actionSa = dataReader.GetInt32(3);
                    int ifp = dataReader.GetInt32(4);
                    int cope = dataReader.GetInt32(5);
                    int id = dataReader.GetInt32(6);
                    int udm = dataReader.GetInt32(7);
                    int vf = dataReader.GetInt32(8);


                    if (anc > eff && anc > da && anc > actionSa && anc > ifp && anc > cope
                        && anc > id && anc > udm && anc > vf)
                    {
                        MessageBox.Show("ANC is the winner with " + anc + " votes");
                    }
                     if (da > eff && da > anc && da > actionSa && da > ifp && da > cope
                        && da > id && da > udm && da > vf)
                    {
                        MessageBox.Show("DA is the winner with " + da + " votes");
                    }
                     if (eff > da && eff > anc && eff > actionSa && eff > ifp && eff > cope
                        && eff > id && eff > udm && eff > vf)
                    {
                        MessageBox.Show("EFF is the winner with " + eff + " votes");
                    }
                     if (actionSa > da && actionSa > anc && actionSa > eff && actionSa > ifp && actionSa > cope
                       && actionSa > id && actionSa > udm && actionSa > vf)
                    {
                        MessageBox.Show("Action SA is the winner with " + actionSa + " votes");
                    }
                     if (ifp > da && ifp > anc && ifp > eff && ifp > actionSa && ifp > cope
                       && ifp > id && ifp > udm && ifp > vf)
                    {
                        MessageBox.Show("IFP is the winner with " + ifp + " votes");
                    }
                     if (cope > eff && cope > anc && cope > actionSa && cope > ifp && cope > da
                       && cope > id && cope > udm && cope > vf)
                    {
                        MessageBox.Show("COPE is the winner with " + cope + " votes");
                    }
                     if (id > eff && id > anc && id > actionSa && id > ifp && id > da
                       && id > cope && id > udm && id > vf)
                    {
                        MessageBox.Show("ID is the winner with " + id + " votes");
                    }
                     if (udm > eff && udm > anc && udm > actionSa && udm > ifp && udm > da
                       && udm > cope && udm > id && udm > vf)
                    {
                        MessageBox.Show("UDM is the winner with " + udm + " votes");
                    }
                     if (vf > eff && vf > anc && vf > actionSa && vf > ifp && vf > da
                       && vf > cope && vf > id && vf > udm)
                    {
                        MessageBox.Show("VF is the winner with " + vf + " votes");
                    }

                }

                dataReader.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }


        }
    }
}
