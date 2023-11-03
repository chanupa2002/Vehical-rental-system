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
    public partial class managecar : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-EU1QSR0\SQLEXPRESS;Initial Catalog=V_Manage;Integrated Security=True");

        public managecar()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            welcome welcome = new welcome();
            welcome.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void managecar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'v_ManageDataSet.V_Details' table. You can move, or remove it, as needed.
            this.v_DetailsTableAdapter.Fill(this.v_ManageDataSet.V_Details);
            // TODO: This line of code loads data into the 'vehicle_SystemDataSet2.Manage_car' table. You can move, or remove it, as needed.
            this.manage_carTableAdapter1.Fill(this.vehicle_SystemDataSet2.Manage_car);
            // TODO: This line of code loads data into the 'vehicle_SystemDataSet.Manage_car' table. You can move, or remove it, as needed.
            this.manage_carTableAdapter.Fill(this.vehicle_SystemDataSet.Manage_car);

        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO  V_Details(VehicleId,VehicleNum,Brand,Model,Color,Type) VALUES(" + txtCarId.Text + ",'" +txtCarNum.Text + "','" + txtbrand.Text + "','" + txtModel.Text + "','" + txtColor.Text + "','"+txtType+"')", con);
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
            string viewall= ("SELECT * FROM V_Details");
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    SqlCommand command = new SqlCommand(viewall, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM V_Details WHERE VehicleId=" + dataGridView1.SelectedRows[0].Cells[0].Value, con);
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
                    SqlCommand cmd = new SqlCommand("UPDATE V_Details SET VehicleNum='" + txtCarNum.Text + "', Brand='" + txtbrand.Text + "', Model='" + txtModel.Text + "', Color='" + txtColor.Text + "', Type='" + txtType.Text + "' WHERE VehicleId=" + txtCarId.Text, con);
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
