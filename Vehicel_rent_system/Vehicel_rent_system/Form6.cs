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

namespace Vehicel_rent_system
{
    public partial class returns : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");
        public returns()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Hide();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  R_Details(ReturnId,BookinId,CustomerId,R_Date) VALUES(" + txtrReturn.Text + "," + txtBookingId.Text + "," + txtCustomerId.Text + ",'" + dateP1.Text + "' )", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }

        private void returns_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'v_ManageDataSet6.R_Details' table. You can move, or remove it, as needed.
            this.r_DetailsTableAdapter.Fill(this.v_ManageDataSet6.R_Details);

        }

        private void dateP1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");
            string viewall = ("SELECT * FROM R_Details");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(viewall, con);
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Hide();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM R_Details WHERE ReturnId=" + dataGridView1.SelectedRows[0].Cells[0].Value, con);
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

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE R_Details SET BookinId='" + txtBookingId.Text + "', CustomerId='" + txtCustomerId.Text + "', R_Date='" + dateP1.Text +  "'  WHERE ReturnId=" +txtrReturn.Text, con);
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