using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicel_rent_system
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bookingPg bookingPg = new bookingPg();
            bookingPg.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            customerpg customerpg = new customerpg();
            customerpg.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            returns returns = new returns();
            returns.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            managecar managecar = new managecar();
            managecar.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you sure !", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
            flogin flogin = new flogin();
            flogin.Show();
            this.Hide();


            this.Hide();
        }
    }
}
