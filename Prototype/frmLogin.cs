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
    public partial class frmLogin : Form
    {

        MySqlConnection conn = DbConn.getConn();
        public static String userId;
        

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            frmMain mainForm = new frmMain();
            MySqlCommand cmd;
            MySqlDataReader rdr;
            string myQuery = "select password from staff where username='" + txtUser.Text + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(myQuery, conn);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    if (txtPwd.Text.Equals(rdr[0]))
                    {
                        mainForm.Show();
                        this.Hide(); 
                    }
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            userId = txtUser.Text;
        }
    }
}
