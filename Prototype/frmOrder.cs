using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Prototype
{
    public partial class frmOrder : Form
    {
        
        MySqlConnection conn = DbConn.getConn();
        panelOrderRecord[] record;
        public frmOrder()
        {
            InitializeComponent();
        }

        private void frmOrder_Load(object sender, EventArgs e)
        {
            String userid = frmLogin.userId;
            String query;
            MySqlCommand cmd;
            MySqlDataReader rdr;
            
            query = "SELECT * FROM orders";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                int y = 35, count = 0;
                record = new panelOrderRecord[15];

                while (rdr.Read())
                {
                    record[count] = new panelOrderRecord();
                    record[count].lblOid.Text = "Order ID: " + rdr[0];
                    //Hiden oid
                    record[count].lblHoid.Text = "" + rdr[0];
                    record[count].lblTid.Text = "Table ID: " + rdr[1];
                    
                    DateTime dt = rdr.GetDateTime(3);
                    record[count].lblTime.Text = "Time: " + dt.ToLongTimeString();
                    record[count].lblDate.Text = "Date: " + dt.ToShortDateString();
                    record[count].lblSid.Text = "" + rdr[2];
                    record[count].lblTotal.Text = "Total: $" + rdr[4];
                    record[count].Location = new System.Drawing.Point(10, y);
                    record[count].btnPay.Hide();
                    this.panelShow.Controls.Add(record[count]);
                    y += 150;
                    count++;
                }
                rdr.Close();
                for(int i =0;i<count; i++)
                {
                    query = "SELECT name from staff where staff_id='" + record[i].lblSid.Text + "'";
                    cmd = new MySqlCommand(query, conn);
                    rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        record[i].lblStaff.Text = "Staff: " + rdr[0];
                    }
                    rdr.Close();
                }
                
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }


        private void btnHome_Click(object sender, EventArgs e)
        {
            frmMain main = new Prototype.frmMain();
            this.Hide();
            main.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            frmMain main = new Prototype.frmMain();
            this.Hide();
            main.Show();
        }
    }
}
