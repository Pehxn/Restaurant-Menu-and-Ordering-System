using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Menu_and_Ordering_System
{
    public partial class Admin3 : Form
    {
        public Admin3()
        {
            InitializeComponent();
        }

        private void Admin3_Load(object sender, EventArgs e)
        {
            order_disp();
        }
        public void order_disp()
        {
            SqlConnection on = new SqlConnection(@"Data Source=JIMA;Initial Catalog=resturant;Integrated Security=True");
            on.Open();
            SqlCommand cmd = on.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Select * from Place_Order_Detail";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            on.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            DialogResult button6;
            button6 = MessageBox.Show("Are you Sure", "PS Restaurant", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (button6 == DialogResult.Yes)
            {
                SqlConnection con = new SqlConnection(@"Data Source=JIMA;Initial Catalog=resturant;Integrated Security=True");

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from Place_Order_Detail where Name='" + textBox1.Text + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Deleted Successfully");

                order_disp();

            }




        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=JIMA;Initial Catalog=resturant;Integrated Security=True");

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Place_Order_Detail set Address = '"+ textBox3.Text + "', Contact_No = '" + textBox2.Text + "' where Name='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update Successfully");

            order_disp();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdminForm D = new AdminForm();
            D.Show();
            this.Hide();
        }
    }
    }

