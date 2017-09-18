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
    public partial class Login_Form : Form
    {
        public Login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count (*) From Doctor_Login_Info where UserName = '" + textBox_UserName.Text + "' and Password = '" + textBox_Password.Text + "' ", con);
            SqlDataAdapter sda1 = new SqlDataAdapter("Select Count (*) From Assistant_Login_Info where UserName = '" + textBox_UserName.Text + "' and Password = '" + textBox_Password.Text + "' ", con);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            sda.Fill(dt);
            sda1.Fill(dt1);
            try
            {
                if (textBox_UserName.Text == String.Empty || textBox_Password.Text == String.Empty)
                {
                    MessageBox.Show("You Have to fill all the Field");

                }
                else if (dt.Rows[0][0].ToString() == "1")
                {
                    Doctor doc = new Doctor();
                    doc.Show();
                    this.Visible = false;
                }
                else if (dt1.Rows[0][0].ToString() == "1")
                {
                    Assistent ass = new Assistent();
                    ass.Show();
                    this.Visible = false;
                }

                else
                {
                    MessageBox.Show("Incorrect UserName & Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }

            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            Front_Page fp = new Front_Page();
            fp.Show();
            this.Close();
            
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {

        }

        private void textBox_UserName_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_ChangePassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ChangePassword cp = new ChangePassword();
            cp.Show();
        }
    }
}
