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
    public partial class PlaceOrders2 : Form
    {
        const double pricePizza = 1400;
        const double priceNoodles = 400;
        const double priceBurger = 450;
        const double pricePasta = 350;
        const double priceHotdogs = 350;
        const double priceFries = 200;
        const double priceCandycrush = 120;
        const double priceFreshmilk = 170;
        const double priceNecto = 80;
        const double priceMilo = 80;
        const double priceFalooda = 100;
        const double priceCocacola = 80;

        const double COD = 200;
        double Tot;



        public PlaceOrders2()


        {
            InitializeComponent();
        }

       
        private void btnorder_Click(object sender, EventArgs e)
        {
           MessageBox.Show("Thankyou for choosing our Restaurant.. Enjoy your Order");

            SqlConnection con = new SqlConnection(@"Data Source=JIMA;Initial Catalog=resturant;Integrated Security=True");
            //SqlCommand on;

            con.Open();
            SqlCommand on = new SqlCommand("insert into Place_Order_Detail(Name,Address,Contact_No,Total) values (@Nm,@Add,@Cno,@TT)", con);
            on.Parameters.AddWithValue("@Nm", txtName.Text);
            on.Parameters.AddWithValue("@Add", txtAddress.Text);
            on.Parameters.AddWithValue("@Cno", txtNo.Text);
            on.Parameters.AddWithValue("@TT", txtPayment.Text);


            on.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Successfully Saved ! ");

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

        

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPayment.Text == "Cash")
            {
                txtPayment.Enabled = false;
                txtPayment.Text = txtTotal.Text;
                
            }
            else if (cmbPayment.Text == "Cash On Delivery")
            {
                double COD = 200;

                txtPayment.Enabled = false;
                Tot = Convert.ToDouble(txtTotal.Text) + COD;
                txtPayment.Text = Convert.ToString(Tot);
                txtName.Enabled = true;
                txtAddress.Enabled = true;
                txtNo.Enabled = true;
                txtName.Text = "";
                txtAddress.Text = "";
                txtNo.Text = "";
                txtName.Focus();
                txtAddress.Focus();
                txtNo.Focus();
            }
            else
            {
                txtPayment.Enabled = false;
                txtPayment.Text = txtTotal.Text;
            }
       
           
        }

        
       

        private void RestCheckBox()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Text = "0";
                    else
                        func(Controls);


            };
            func(Controls);
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Menu A = new Menu();
            A.Show();
            this.Hide();
        }

        

        private void PlaceOrders2_Load(object sender, EventArgs e)
        {
            cmbPayment.Items.Add("   ");
            cmbPayment.Items.Add("Cash");
            cmbPayment.Items.Add("Cash On Delivery");
            cmbPayment.Items.Add("Credit/Debit card payments");
        }

      

        private void btnTotal_Click(object sender, EventArgs e)
        {
            
            double[] itemcost = new double[100];
            itemcost[2] = Convert.ToDouble(txtPizza.Text) * pricePizza;
            itemcost[3] = Convert.ToDouble(txtNoodles.Text) * priceNoodles;
            itemcost[4] = Convert.ToDouble(txtBurger.Text) * priceBurger;
            itemcost[5] = Convert.ToDouble(txtPasta.Text) * pricePasta;
            itemcost[6] = Convert.ToDouble(txtHotdogs.Text) * priceHotdogs;
            itemcost[7] = Convert.ToDouble(txtFries.Text) * priceFries;
            itemcost[8] = Convert.ToDouble(txtCandycrush.Text) * priceCandycrush;
            itemcost[9] = Convert.ToDouble(txtFreshmilk.Text) * priceFreshmilk;
            itemcost[10] = Convert.ToDouble(txtNecto.Text) * priceNecto;
            itemcost[11] = Convert.ToDouble(txtMilo.Text) * priceMilo;
            itemcost[12] = Convert.ToDouble(txtFalooda.Text) * priceFalooda;
            itemcost[13] = Convert.ToDouble(txtCocacola.Text) * priceCocacola;

            double Total;
            {
                Total = itemcost[0] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6]
                    + itemcost[7] + itemcost[8] + itemcost[9] + itemcost[10] + itemcost[11] + itemcost[12]
                    + itemcost[13];

                txtTotal.Text = Convert.ToString(Total);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AdminForm B = new AdminForm();
            B.Show();
            this.Hide();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
        

       

        
