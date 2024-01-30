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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void iExit3_Click(object sender, EventArgs e)
        {
            DialogResult iExit2;
            iExit2 = MessageBox.Show("Do you want to exit", "PS Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit2 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Menu A= new Menu();
            A.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PlaceOrders2 B = new PlaceOrders2();
            B.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Contact C = new Contact();
            C.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AdminLogin D = new AdminLogin();
            D.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin3 E = new Admin3();
            E.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AdminRegistration F = new AdminRegistration();
            F.Show();
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            PlaceOrders2 G = new PlaceOrders2();
            G.Show();
            this.Hide();
        }

        
    }
}
