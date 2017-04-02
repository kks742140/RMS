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
    public partial class panelOrderRecord : UserControl
    {

        MySqlConnection conn = DbConn.getConn();
        public panelOrderRecord()
        {
            InitializeComponent();
        }

        private void panelDetail_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String order_id = this.lblHoid.Text;
            panelOrderDetail update = new panelOrderDetail();
            update.Location = new System.Drawing.Point(0, 0);
            update.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            TableLayoutPanel tbL = (TableLayoutPanel)this.Parent.Parent;
            tbL.SetCellPosition(update, new TableLayoutPanelCellPosition(1, 1));
            tbL.SetColumnSpan(update, 2);
            update.setOid(order_id);
            this.Parent.Parent.Controls.Add(update);
            this.Parent.Hide();

        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            String query = "DELETE from orderdetail where order_id='" + this.lblHoid.Text + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                query = "Delete from orders where order_id='" + this.lblHoid.Text + "'";
                cmd = new MySqlCommand(query, conn);
                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Delete Success");
                    this.Hide();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            String order_id = this.lblHoid.Text;
            panelPayDetail pay = new panelPayDetail();
            pay.Location = new System.Drawing.Point(0, 0);
            pay.Anchor = (AnchorStyles.Bottom | AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
            TableLayoutPanel tbL = (TableLayoutPanel)this.Parent.Parent;
            tbL.SetCellPosition(pay, new TableLayoutPanelCellPosition(1, 1));
            tbL.SetColumnSpan(pay, 2);
            pay.setOid(order_id);
            this.Parent.Parent.Controls.Add(pay);
            this.Parent.Hide();
        }
    }
}
