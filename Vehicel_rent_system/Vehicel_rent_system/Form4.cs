using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace Vehicel_rent_system
{
    public partial class customerpg : Form
    {
        private const string V = "SELECT * Cus_Details";
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");

        public customerpg()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Hide();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            bookingPg bookingPg = new bookingPg();
            bookingPg.Show();
            this.Hide();
        }

        private void customerpg_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'v_ManageDataSet4.Cus_Details' table. You can move, or remove it, as needed.
            this.cus_DetailsTableAdapter1.Fill(this.v_ManageDataSet4.Cus_Details);


        }

        private void btnAdd1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  Cus_Details(CustomerId,C_Name,Email,PhoneNum,Adress) VALUES(" + txtCid.Text + ",'" + txtName.Text + "','" + txtEmail.Text + "','" + txtPN.Text + "','" + txtAdr.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();



        }



        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");
            string ViewCD = ("SELECT * FROM Cus_Details ");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(ViewCD, con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    dataGridView1.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);


                }


            }


        }

        private void btnDelete1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM Cus_Details WHERE CustomerId=" + dataGridView1.SelectedRows[0].Cells[0].Value, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnUpdate1_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE Cus_Details SET  C_Name ='" + txtName.Text + "', Email='" + txtEmail.Text + "', PhoneNum='" + txtPN.Text + "', Adress='" + txtAdr.Text + "' WHERE CustomerId=" + txtCid.Text, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
