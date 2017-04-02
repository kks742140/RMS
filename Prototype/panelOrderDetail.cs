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
    public partial class panelOrderDetail : UserControl
    {
        
        MySqlConnection conn = DbConn.getConn();
        String Oid;
        panelFoods[] foodForm;
        public panelOrderDetail()
        {
            InitializeComponent();
        }

        public void setOid(String Oid)
        {
            this.Oid = Oid;
        }



        private void btnReset_Click(object sender, EventArgs e)
        {
 
            panelOrderDetail_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            String query;
            try
            {
                conn.Open();
                for (int i = 0; i < foodForm.Length; i++)
                {
                    
                    query = "update orderdetail set qty=" + foodForm[i].noQty.Text +
                        ",subtotal=" + (Int32.Parse(foodForm[i].noQty.Text)* Int32.Parse(foodForm[i].lblUniP.Text)) +
                        ", status='" + foodForm[i].cbxStatus.Text + "'" +
                        ", order_type='" + foodForm[i].cbxType.Text + "' WHERE item_id='" + foodForm[i].lblFid.Text + "'";

                    cmd = new MySqlCommand(query, conn);
                    if (cmd.ExecuteNonQuery() >= 1)
                    {
                        MessageBox.Show("Update success");
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            // query = "UPDATE orders set total=" + ;
            conn.Close();
        }

        private void panelOrderDetail_Load(object sender, EventArgs e)
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
                
                panelFoods[] food = new panelFoods[row];
                int y = 30;
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    food[count] = new panelFoods();
                    //food[count].lblFood.Text = "" + rdr[4];
                    food[count].noQty.Text = "" + rdr[3];
                    food[count].lblFid.Text = "" + rdr[2];
                    //food[count].lblUniP.Text = "" + rdr[];
                    food[count].cbxType.Text = "" + rdr[6];
                    food[count].cbxStatus.Text = "" + rdr[5];
                    food[count].Location = new System.Drawing.Point(0, y);
                    this.panelFood.Controls.Add(food[count]);
                    y += 60;
                    count++;
                }
                this.setFoodForm(food);
                rdr.Close();

                for(int i = 0; i < count; i++)
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

        public void setFoodForm(panelFoods[] food)
        {
            this.foodForm = food;
        }

        public panelFoods[] getFoodForm()
        {
            return foodForm;
        }

    }
    
}
