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

    public partial class panelBkUpdate : UserControl
    {
        
        MySqlConnection conn = DbConn.getConn();
        String BId;

        public panelBkUpdate()
        {
            InitializeComponent();
        }

        private void panelBkUpdate_Load(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            MySqlDataReader rdr;
            String query = "SELECT * FROM booking_record WHERE booking_id='"
                + BId + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    txtBid.Text = "" + rdr[0];
                    txtCid.Text = "" + rdr[1];
                    //txtTid.Text = "" + rdr[2];
                    txtName.Text = "" + rdr[2];
                    txtTel.Text = "" + rdr[3];
                    txtPno.Text = "" + rdr[4];
                    DateTime dt = rdr.GetDateTime(5);
                    dtpDate.Value = dt;
                    txtStatus.Text = "" + rdr[6];
                    txtOther.Text = "" + rdr[7];

                }
                rdr.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        public void setBId(String BId)
        {
            this.BId = BId;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            panelBkUpdate_Load(sender, e);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            
            var sqlFormattedDate = dtpDate.Value.ToString("dd-MM-yyyy hh:mm");
            String query = "Update booking_record SET client_id ='" + txtCid.Text + "',"
               
                + "booking_fname='" + txtName.Text + "',"
                + "booking_tel='" + txtTel.Text + "',"
                + "booking_person='" + txtPno.Text +"',"
                + "booking_datetime='" + sqlFormattedDate  + "',"
                + "booking_other='" + txtOther.Text + "',"
                + "booking_status='" + txtStatus.Text + "' WHERE booking_id='"
                + BId + "'";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                panelBkUpdate_Load(sender, e);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;
            
            String query = "INSERT INTO booking_record(client_id,booking_fname, booking_tel, booking_person, booking_datetime, booking_status, booking_other) " +
                "VALUES (" + txtCid.Text + ",'" + txtName.Text + "','" + txtTel.Text + "','" + txtPno.Text + "','" + dtpDate.Value.ToString(dtpDate.CustomFormat) + "','Unverify',null)";
            MessageBox.Show(dtpDate.Value.ToString(dtpDate.CustomFormat));
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
               
                if(cmd.ExecuteNonQuery() >= 1)
                {
                    MessageBox.Show("Success add a new booking");
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            conn.Close();
        }
    }
}
