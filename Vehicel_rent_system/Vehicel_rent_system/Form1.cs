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
    public partial class flogin : Form
    {
        public flogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtuname.Text == "A" && txtpwrd.Text == "Ad")
            {
                welcome welcome = new welcome();
                welcome.Show();

                this.Hide();
                MessageBox.Show("Succesfully Login", "New", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            else if (txtuname.Text == "Fofficer" && txtpwrd.Text == "F123")
            {

                welcome welcome = new welcome();
                welcome.Show();

                this.Hide();
                MessageBox.Show("Succesfully Login", "New", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            { MessageBox.Show("Incorrect username or password", "Aleart", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
