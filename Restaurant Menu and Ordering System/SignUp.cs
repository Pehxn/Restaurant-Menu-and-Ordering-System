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

namespace Restaurant_Menu_and_Ordering_System
{
    public partial class AdminRegistration : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=JIMA;Initial Catalog=resturant;Integrated Security=True");
        SqlCommand cmd;
        public AdminRegistration()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            AdminLogin A = new AdminLogin();
            A.Show();
            this.Hide();
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

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                
                con.Open();
                if (textBox1.Text=="" || txtPw.Text=="")
                {
                    int.Parse(textBox1.Text);
                    int.Parse(txtPw.Text);
                }
                string fh = "insert into adminLogin(username,pass,Fullname,age,gender)values('" + textBox1.Text + "','" + txtPw.Text + "','" + textBox3.Text + "','" + textBox2.Text + "','" + textBox4.Text + "')";
                cmd = new SqlCommand(fh, con);
               
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Signed Up Successfully (-_-)");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         
        }

        private void AdminRegistration_Load(object sender, EventArgs e)
        {

        }
    }
}
