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
    public partial class bookingPg : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");

        public bookingPg()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  B_Details(BookinId,CarId,RentDate,ReturnDate,Payment_S) VALUES(" + txtBooking.Text + ",'" + txtcid.Text + "','" + dateP1.Text + "','" + dateP2.Text + "','" + combB1.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Done !", ":-)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            con.Close();
        }
        private void bookingPg_Load(object sender, EventArgs e)
        {
                // TODO: This line of code loads data into the 'v_ManageDataSet5.V_Details' table. You can move, or remove it, as needed.
                this.v_DetailsTableAdapter.Fill(this.v_ManageDataSet5.V_Details);
                // TODO: This line of code loads data into the 'v_ManageDataSet1.B_Details' table. You can move, or remove it, as needed.
                this.b_DetailsTableAdapter.Fill(this.v_ManageDataSet1.B_Details);

            




        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string connectionString = (@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");
            string v_all = ("SELECT * FROM B_Details");
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(v_all, con);
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

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM B_Details WHERE BookinId=" + dataGridView2.SelectedRows[0].Cells[0].Value, con);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("UPDATE B_Details SET CarId='" + txtcid.Text + "', RentDate='" + dateP1.Text + "',ReturnDate='" + dateP2.Text + "', Payment_S='" + combB1.Text + "' WHERE BookinId=" + txtBooking.Text, con);
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
