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
    public partial class frmMain : Form
    {
        MySqlConnection conn = DbConn.getConn();
        private String userId = frmLogin.userId;
        public frmMain()
        {
            InitializeComponent();
        }

        private void pbPunch_Click(object sender, EventArgs e)
        {
            var punchForm = new frmPunch();
            punchForm.Show();
            this.Hide();
        }

        private void pbBooking_Click(object sender, EventArgs e)
        {
            var bookingForm = new frmBooking();
            bookingForm.Show();
            this.Hide();
        }

        private void pbOrder_Click(object sender, EventArgs e)
        {
            var orderForm = new frmOrder();
            orderForm.Show();
            this.Hide();
        }

        private void pbPay_Click(object sender, EventArgs e)
        {
            var payForm = new frmPay();
            payForm.Show();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            String query = "Select * from staff where username='" +
                userId + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {

                    lblWelcome.Text = "Welcome,\n" + rdr[8] + ", " + rdr[3];

                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        public void setUserName(String userId)
        {
            this.userId = userId;
        }

        private void pbSignout_Click(object sender, EventArgs e)
        {
            frmLogin loginForm = new frmLogin();
            loginForm.Show();
            this.Hide();
        }
    }
}
