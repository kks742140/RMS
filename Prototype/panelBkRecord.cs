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
    public partial class panelBkRecord : UserControl
    {
        
        MySqlConnection conn = DbConn.getConn();
        public panelBkRecord()
        {
            InitializeComponent();
        }

        private void panelBkRecord_Load(object sender, EventArgs e)
        {

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            String query = "Delete from booking_record where booking_id='"
                + this.lblHideBid.Text + "'";
            
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            String query = "Update booking_record  set booking_status ='Attended' WHERE booking_id='"
                + this.lblHideBid.Text + "' ";
            
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Clinet have come");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            String query = "Update booking_record  set booking_status ='Verified' WHERE booking_id='"
                + this.lblHideBid.Text + "';";
            
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Confirm booking");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String booking_id = this.lblHideBid.Text;
            panelBkUpdate update = new panelBkUpdate();
            update.setBId(booking_id);
            update.Location = new System.Drawing.Point(0, 0);
            update.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            TableLayoutPanel tbL = (TableLayoutPanel)this.Parent.Parent;
            tbL.SetCellPosition(update, new TableLayoutPanelCellPosition(1, 1));
            tbL.SetColumnSpan(update, 2);
            

            this.Parent.Hide();
            this.Parent.Parent.Controls.Add(update);
        }
    }
}
