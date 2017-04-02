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
    public partial class panelFoods : UserControl
    {
        MySqlConnection conn = DbConn.getConn();
        public panelFoods()
        {
            InitializeComponent();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            String query = "DELETE FROM orderdetail where item_id='" + this.lblFid.Text + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                if(cmd.ExecuteNonQuery() >= 1)
                {
                    this.Hide();
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
