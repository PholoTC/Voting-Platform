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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Voting_Platform
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            
        }
        public  static int VoterID { get; set; }

        SqlConnection con = new SqlConnection("Data Source=RYZEN-3;Initial Catalog=VOTING_PLATFORM;Integrated Security=True");

        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Vote frmVote = new Vote();

            string username;
            string password;

            username = txtName.Text;
            password   = txtEmail.Text;

            try
            {
                string querry = "exec SP_Login '"+ username+ "', '"+ password+"'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, con);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

              

                 if (dataTable.Rows.Count > 0 )
                {
                    //Get  UserId from line in Datatable
                    VoterID = (from DataRow dr in dataTable.Rows
                               where (string)dr["FullNames"] == username
                               select (int)dr["VoterId"]).FirstOrDefault();

                    frmVote.getUId(VoterID);
                    this.Hide();
                    frmVote.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Invalid Login Details","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    txtName.Clear();    
                    txtEmail.Clear();

                    txtName.Focus();
                }


            }
            catch {
                MessageBox.Show("ERROR");
            }
            finally { con.Close(); }

           
           /* try
            {
                con.Open();
                String comm = "exec dbo.SP_Login '"+ txtName.Text+"', '"+txtEmail.Text+"'";
                SqlCommand cmd = new SqlCommand(comm, con);
            cmd.ExecuteNonQuery();
                //SqlDataReader sqlDr = cmd.ExecuteReader();
                object result = cmd.ExecuteScalar();
                Vote frmVote = new Vote();
                

                if ( result !=null)
                {
                    VoterID = Convert.ToInt32(result);
                   // MessageBox.Show("Login Successful");
                    frmVote.getUId(VoterID);
                    this.Hide();
                    frmVote.ShowDialog();
                    
                }
                else
                {
                MessageBox.Show("Login NOT Successfully");

                }
                
                //sqlDr.Close();
                con.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }*/


           
        }
    }
}
