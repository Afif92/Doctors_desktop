using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Doctors_Desktop
{
    public partial class ChangePassword : Form
    {
        public ChangePassword()
        {
            InitializeComponent();
        }

        private void button_DocUpdate_Click(object sender, EventArgs e)
        {
            
            if (textBox_DocCurrentUserName.Text != string.Empty || textBox_DocCurrentPassword.Text != string.Empty || textBox_DocNewUserName.Text != string.Empty || textBox_DocNewPassword.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.CommandText = "Select * from Doctor_Login_Info";
                sc.Connection = con;
                SqlDataReader sdr = sc.ExecuteReader();
                sdr.Read();
                if (textBox_DocCurrentUserName.Text != sdr.GetString(0) && textBox_DocCurrentPassword.Text != sdr.GetString(0))
                {
                    MessageBox.Show("Check Previous UserName & Password");
                    this.Close();

                }
                else
                {
                    sdr.Close();
                    SqlDataAdapter sda1 = new SqlDataAdapter("Update Doctor_Login_Info set UserName = '" + textBox_DocNewUserName.Text + "' , Password = '" + textBox_DocNewPassword.Text + "' ", con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    MessageBox.Show("Updated Successfully");
                    this.Close();

                }
            }
            else
            {
                MessageBox.Show("You Have to fill all the fields.");
            }
        }

        private void button_AssUpdate_Click(object sender, EventArgs e)
        {
            if (textBox_AssCurrentUserName.Text != string.Empty || textBox_AssCurrentPassword.Text != string.Empty || textBox_AssNewUsername.Text != string.Empty || textBox_AssNewPassword.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.CommandText = "Select * from Assistant_Login_Info";
                sc.Connection = con;
                SqlDataReader sdr = sc.ExecuteReader();
                sdr.Read();
                if (textBox_AssCurrentUserName.Text != sdr.GetString(0) && textBox_AssCurrentPassword.Text != sdr.GetString(0))
                {
                    MessageBox.Show("Check Previous UserName & Password");
                    this.Close();
                }
                else
                {
                    sdr.Close();
                    SqlDataAdapter sda1 = new SqlDataAdapter("Update Assistant_Login_Info set UserName = '" + textBox_AssNewUsername.Text + "' , Password = '" + textBox_AssNewPassword.Text + "' ", con);
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);
                    MessageBox.Show("Updated Successfully");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("You Have to fill all the fields.");
            }
        

        }
    }
}
