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
    public partial class Assistent : Form
    {
        public Assistent()
        {
            InitializeComponent();
        }
        private void clear()
        {
            textBox_Name.Text = "";
            textBox_Age.Text = "";
            comboBox_Gender.SelectedItem = "---Select---";
            richTextBox_Address.Text = "";
            textBox_PhoneNo.Text = "";
            richTextBox_Disease.Text = "";

        }
        private void searchClear()
        {
            textBox_Patient_ID.Text = "";
            textBox_SearchedName.Text = "";
            textBox_SearchedAge.Text = "";
            comboBox_SearchedAge.Text = "";
            richTextBox_SearchedAddress.Text = "";
            textBox_SearchedPhoneNo.Text = "";
            richTextBox_SearchedDisease.Text = "";
        }

        private void label_Name_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Front_Page fp = new Front_Page();
            fp.Show();
            this.Visible = false;
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_Name.Text == string.Empty || textBox_Age.Text == string.Empty || comboBox_Gender.SelectedItem.ToString() == null || richTextBox_Address.Text == string.Empty || textBox_PhoneNo.Text == string.Empty || richTextBox_Disease.Text == string.Empty)
            {
                MessageBox.Show("You Have to fill All the Field Properly");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Patient_Information (Name, Age, Gender, Address, PhoneNo, Disease) Values ('" + textBox_Name.Text + "', '" + textBox_Age.Text + "','" + comboBox_Gender.SelectedItem + "','" + richTextBox_Address.Text + "','" + textBox_PhoneNo.Text + "','" + richTextBox_Disease.Text + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Registered Successfully");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Assistent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter3.Fill(this.dataSet1.Patient_Information);
            // TODO: This line of code loads data into the 'msdbDataSet2.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter2.Fill(this.msdbDataSet2.Patient_Information);
            // TODO: This line of code loads data into the 'msdbDataSet1.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter1.Fill(this.msdbDataSet1.Patient_Information);
            // TODO: This line of code loads data into the 'msdbDataSet.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter.Fill(this.msdbDataSet.Patient_Information);

        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                con.Open();
                SqlCommand sc = con.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "Select * from Patient_Information";
                sc.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_Patient_ID.Text != string.Empty)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    con.Open();
                    string sda = "Select * from Patient_Information where ID = '" + textBox_Patient_ID.Text.Trim() + "'";
                    SqlCommand sc = new SqlCommand(sda, con);
                    SqlDataReader sdr = sc.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox_SearchedName.Text = sdr["Name"].ToString();
                        textBox_SearchedAge.Text = sdr["Age"].ToString();
                        comboBox_SearchedAge.Text = sdr["Gender"].ToString();
                        richTextBox_SearchedAddress.Text = sdr["Address"].ToString();
                        textBox_SearchedPhoneNo.Text = sdr["PhoneNo"].ToString();
                        richTextBox_SearchedDisease.Text = sdr["Disease"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No data againest this ID");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide an ID");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check the ID which you provide.");
            }

        }

        private void button_SearchClear_Click(object sender, EventArgs e)
        {
            searchClear();
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_SearchedName.Text == string.Empty || textBox_SearchedAge.Text == string.Empty || comboBox_SearchedAge.SelectedItem.ToString() == null || richTextBox_SearchedAddress.Text == string.Empty || textBox_SearchedPhoneNo.Text == String.Empty || richTextBox_SearchedDisease.Text == string.Empty)
            {
                MessageBox.Show("All Field must Required");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("UPDATE Patient_Information set Name = '" + textBox_SearchedName.Text + "', Age = '" + textBox_SearchedAge.Text + "', Gender = '" + comboBox_SearchedAge.SelectedItem + "', Address = '" + richTextBox_SearchedAddress.Text + "', PhoneNo = '" + textBox_SearchedPhoneNo.Text + "', Disease = '" + richTextBox_SearchedDisease.Text + "' where ID  = '" + textBox_Patient_ID.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Updated Successfully");

                    //clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}