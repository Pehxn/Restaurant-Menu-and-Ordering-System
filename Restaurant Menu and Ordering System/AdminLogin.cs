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
    public partial class AdminLogin : Form
    {
       
        public AdminLogin()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=JIMA;Initial Catalog=resturant;Integrated Security=True");
        SqlCommand cmd;

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
                string fh = "select pass from adminLogin where username='"+ textBox1.Text+ "'";
                cmd = new SqlCommand(fh, con);
               // MessageBox.Show(fh);
                object output = cmd.ExecuteScalar(); 
               
                
                if (output != null)
                {
                    string val = output.ToString();
                    
                    if (val == txtPw.Text)
                    {
                        MessageBox.Show("Logged in Successfully (-_-)");
                        AdminForm B = new AdminForm();
                        B.Show();
                        this.Hide();
                   
                    }
                    else
                    {
                        MessageBox.Show("Please enter the Password");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the Username and Password");
                }


                con.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AdminRegistration C = new AdminRegistration();
            C.Show();
            this.Hide();
        }

        
    }
}
