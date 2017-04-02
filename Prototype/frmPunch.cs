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
    public partial class frmPunch : Form
    {
        const string myConnectionString = "server=127.0.0.1;uid=root;database=fypdb";
        MySqlConnection conn = new MySqlConnection(myConnectionString);
        private String userId = frmLogin.userId;
        private String myQ;
        public frmPunch()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            var mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }

        private void frmPunch_Load(object sender, EventArgs e)
        {
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            timer1.Start();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            myQ = "SELECT * FROM attendance WHERE staffid='" + userId + "' AND a_date = '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(myQ, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read()) 
                    myQ = "UPDATE attendance SET intime ='" + DateTime.Now.ToShortTimeString() + "' WHERE staffid='" + userId +
                "' AND a_date = '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "';";
                else
                    myQ = "insert into attendance (StaffId,InTime,a_date,status) values('" +
                userId + "','" + DateTime.Now.ToShortTimeString() + "','" + DateTime.Now.Year + "-"+ DateTime.Now.Month + "-" + DateTime.Now.Day + "','onTime');";
                rdr.Close();
            }catch(MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmd = new MySqlCommand(myQ, conn);

                if (cmd.ExecuteNonQuery()>=1)
                {
                    MessageBox.Show("Successfully Punch in. The Time is : " + DateTime.Now.ToShortTimeString());
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            myQ = "SELECT * FROM attendance WHERE staffid='" + userId + "' AND a_date = '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "';";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(myQ, conn);
                rdr = cmd.ExecuteReader();
                if (rdr.Read())
                    myQ = "UPDATE attendance SET outtime ='" + DateTime.Now.ToShortTimeString() + "' WHERE staffid='" + userId +
                "' AND a_date = '" + DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day + "';";
                else
                    MessageBox.Show("You have to punch in first!");
                rdr.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            try
            {
                cmd = new MySqlCommand(myQ, conn);

                if (cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Successfully Punch Out. The Time is : " + DateTime.Now.ToShortTimeString());
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnArecord_Click(object sender, EventArgs e)
        {
            myQ = "SELECT * from attendance where staffid='" +
    frmLogin.userId + "'";
            DataSet dataSet = new DataSet();
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(myQ, conn);
            dataAdapter.Fill(dataSet, "attendance");
            DataTable dataTable = dataSet.Tables["attendance"];

            MyAttendance myAttend = new MyAttendance();
            myAttend.dgvArecord.DataSource = dataTable;
            myAttend.Show();
        }

        private void pbLogo_Click(object sender, EventArgs e)
        {
            var mainForm = new frmMain();
            mainForm.Show();
            this.Hide();
        }
    }
}
