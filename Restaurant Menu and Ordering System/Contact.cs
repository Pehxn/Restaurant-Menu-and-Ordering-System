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
    public partial class Contact : Form
    {
        public Contact()
        {
            InitializeComponent();
        }

        private void Contact_Load(object sender, EventArgs e)
        {

        }

        private void iExit3_Click(object sender, EventArgs e)
        {
            DialogResult iExit3;
            iExit3 = MessageBox.Show("Do you want to exit", "PS Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (iExit3 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form Menu = new Menu();
            Menu.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm C = new AdminForm();
            C.Show();
            this.Hide();
        }
    }
}
