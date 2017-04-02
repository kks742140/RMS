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
    public partial class frmBooking : Form
    {
        
        MySqlConnection conn = DbConn.getConn();
        public frmBooking()
        {
            InitializeComponent();
        }

        private void frmBooking_Load(object sender, EventArgs e)
        {
            String userid = frmLogin.userId;
            String query;
            MySqlCommand cmd;
            MySqlDataReader rdr;
            panelBkRecord[] record;
            query = "SELECT * FROM booking_record";

            //booking detail
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                int y = 29, count = 0;
                record = new panelBkRecord[15];
                while (rdr.Read())
                {
                    record[count]= new panelBkRecord();
                    record[count].Location = new System.Drawing.Point(5, y);
                    record[count].lblBid.Text = "Booking ID: " + rdr[0];
                    record[count].lblHideBid.Text = "" + rdr[0];
                    record[count].lblName.Text = "First Name: " + rdr[2];
                    record[count].lblPhone.Text = "Phone: " + rdr[3];
                    record[count].lblPno.Text = "No.Of People: " + rdr[4];
                    DateTime dt = rdr.GetDateTime(5);
                    //record[count].lblTime.Text = "Time: " + dt.ToShortTimeString();
                    record[count].lblDate.Text = "Date: " + dt.ToShortDateString();
                    record[count].lblTime.Text = "Status: " + rdr[6];
                    this.panelShow.Controls.Add(record[count]);
                    y += 97;
                    count++;
                }
                rdr.Close();

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
                //find table_id

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            var mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            panelBkUpdate update = new panelBkUpdate();
            
            update.Location = new System.Drawing.Point(0, 0);
            update.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            TableLayoutPanel tbL = (TableLayoutPanel)this.tableLayoutPanel1;
            tbL.SetCellPosition(update, new TableLayoutPanelCellPosition(1, 1));
            tbL.SetColumnSpan(update, 2);
            update.lblStatus.Hide();
            update.txtBid.ReadOnly = false;
            update.txtStatus.Hide();
            update.btnReset.Hide();
            update.btnUpdate.Hide();
            update.txtBid.Hide();
            update.lblBid.Hide();
            this.lblHeader.Text = "Make A Booking";

            this.panelShow.Hide();
            this.panelShow.Parent.Controls.Add(update);
        }
    }
}
