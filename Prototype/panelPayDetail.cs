using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype
{
    public partial class panelPayDetail : UserControl
    {
        MySqlConnection conn = DbConn.getConn();
        String Oid;
        double total = 0;
        panelFoodPay[] foodForm;
        public panelPayDetail()
        {
            InitializeComponent();
        }

        private void panelPayDetail_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            String query = "SELECT * FROM orders WHERE order_id='"
                + Oid + "'";
            int count = 0;
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtOid.Text = "" + rdr[0];
                    txtDT.Text = "" + rdr[3];
                    txtStaff.Text = "" + rdr[2];
                    txtTid.Text = "" + rdr[1];
                }
                rdr.Close();

                query = "SELECT name from staff where staff_id='" + txtStaff.Text + "'";
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtStaff.Text = "" + rdr[0];
                }
                rdr.Close();
                //-----------------------------------------------------------
                query = "SELECT count(*) from orderDetail where order_id='" + Oid + "'";
                cmd = new MySqlCommand(query, conn);
                int row = 0;
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    row = rdr.GetInt32(0);
                }
                rdr.Close();
                //---------------------------------------------------------------------
                query = "SELECT * FROM orderDetail WHERE order_id='"
                + Oid + "'";

                cmd = new MySqlCommand(query, conn);

                panelFoodPay[] food = new panelFoodPay[row];
                int y = 30;
                
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    food[count] = new panelFoodPay();
                    food[count].lblQty.Text = "" + rdr[3];
                    food[count].lblFid.Text = "" + rdr[2];
                    //food[count].lblUniP.Text = "" + rdr[];
                    food[count].lblType.Text = "" + rdr[6];
                    //food[count].cbxStatus.Text = "" + rdr[5];
                    food[count].lblSubT.Text = "" + rdr[4];
                    total += rdr.GetDouble(4);
                    food[count].Location = new System.Drawing.Point(0, y);
                    this.panelFood.Controls.Add(food[count]);
                    this.lblTotal.Text = "Total : $" + total;
                    y += 60;
                    count++;
                }
                this.setFoodForm(food);
                rdr.Close();

                for (int i = 0; i < count; i++)
                {
                    query = "SELECT item_name, item_price from menu_item where item_id='" + food[i].lblFid.Text
                        + "'";
                    cmd = new MySqlCommand(query, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        food[i].lblFood.Text = "" + rdr[0];
                        food[i].lblUniP.Text = "" + rdr[1];
                    }
                    rdr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void setFoodForm(panelFoodPay[] food)
        {
            this.foodForm = food;
        }

        public panelFoodPay[] getFoodForm()
        {
            return foodForm;
        }


        public void setOid(String Oid)
        {
            this.Oid = Oid;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if(Int32.Parse(txtCash.Text) >= total)
            {
                MessageBox.Show("Finish Payment, The Balance is $" + (Int32.Parse(txtCash.Text) - total));
            }
        }
    }
}
