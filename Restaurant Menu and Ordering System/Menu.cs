using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Menu_and_Ordering_System
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        

        private void button3_Click(object sender, EventArgs e)
        {
            Form Contact = new Contact();
            Contact.Show();
            this.Hide();
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            foods1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drinks1.BringToFront();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DialogResult iExit2;
            iExit2 = MessageBox.Show("Do you want to exit", "PS Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit2 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            Form PlaceOrders2 = new PlaceOrders2();
            PlaceOrders2.Show();
            this.Hide();
        }

       

        private void button5_Click_1(object sender, EventArgs e)
        {
            Form AdminLogin = new AdminLogin();
            AdminLogin.Show();
            this.Hide();
        }

      
    }
}
