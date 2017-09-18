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
using System.Drawing.Printing;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;



namespace Doctors_Desktop
{
    public partial class Doctor : Form
    {
        public Doctor()
        {
            InitializeComponent();
            label25.Hide();
            textBox10.Hide();
            numericUpDown20.Hide();
            numericUpDown19.Hide();
            numericUpDown18.Hide();

            label26.Hide();
            textBox11.Hide();
            numericUpDown21.Hide();
            numericUpDown22.Hide();
            numericUpDown23.Hide();

            label27.Hide();
            textBox12.Hide();
            numericUpDown24.Hide();
            numericUpDown25.Hide();
            numericUpDown26.Hide();

            button3.Hide();

            button4.Hide();
        }
        private void clear()
        {
            textBox_MedicineName.Text = "";
            comboBox_MedicineType.Text = "--Select--";
            textBox_CompanyName.Text = "";
            textBox_Price.Text = "";
        }
        private void searchClear()
        {
            textBox_SearchForMedicineName.Text = "";
            textBox_SearchedMedicineName.Text = "";
            comboBox_SearchedMedicineType.Text = "--Select--";
            textBox_SearchedCompanyName.Text = "";
            textBox_SearchedPrice.Text = "";
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet8.Medicine_Information' table. You can move, or remove it, as needed.
            this.medicine_InformationTableAdapter4.Fill(this.dataSet8.Medicine_Information);
            // TODO: This line of code loads data into the 'dataSet7.Medicine_Information' table. You can move, or remove it, as needed.
            this.medicine_InformationTableAdapter3.Fill(this.dataSet7.Medicine_Information);
            // TODO: This line of code loads data into the 'dataSet6.Medicine_Information' table. You can move, or remove it, as needed.
            //this.medicine_InformationTableAdapter3.Fill(this.dataSet6.Medicine_Information);
            // TODO: This line of code loads data into the 'dataSet5.Medicine_Information' table. You can move, or remove it, as needed.
            this.medicine_InformationTableAdapter2.Fill(this.dataSet5.Medicine_Information);
            // TODO: This line of code loads data into the 'dataSet4.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter2.Fill(this.dataSet4.Patient_Information);
            // TODO: This line of code loads data into the 'dataSet3.Medicine_Information' table. You can move, or remove it, as needed.
            this.medicine_InformationTableAdapter1.Fill(this.dataSet3.Medicine_Information);
            // TODO: This line of code loads data into the 'dataSet2.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter1.Fill(this.dataSet2.Patient_Information);
            // TODO: This line of code loads data into the 'msdbDataSet6.Medicine_Information' table. You can move, or remove it, as needed.
            this.medicine_InformationTableAdapter.Fill(this.msdbDataSet6.Medicine_Information);
            // TODO: This line of code loads data into the 'msdbDataSet5.Patient_Information' table. You can move, or remove it, as needed.
            this.patient_InformationTableAdapter.Fill(this.msdbDataSet5.Patient_Information);
            autoSuggest();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.google.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Yahoo.com");
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.msn.com");
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.Ask.com");
        }

        private void button_Logout_Click(object sender, EventArgs e)
        {
            Front_Page fp = new Front_Page();
            fp.Show();
            this.Hide();
                 
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            if (textBox_MedicineName.Text == string.Empty || textBox_CompanyName.Text == string.Empty || comboBox_MedicineType.SelectedItem.ToString() == null || textBox_Price.Text == string.Empty)
            {
                MessageBox.Show("You Have to fill All the Field Properly");
            }
            /*else if (textBox_MedicineName.Text != string.Empty || textBox_CompanyName.Text != string.Empty || comboBox_MedicineType.SelectedItem.ToString() != null || textBox_Price.Text != string.Empty)
            {
                SqlConnection con = new SqlConnection(@"Data Source=.\SQLEXPRESS;Initial Catalog=msdb;Integrated Security=True");
                con.Open();
                SqlCommand sc = new SqlCommand();
                sc.CommandText = "Select * from Medicine_Information";
                sc.Connection = con;
                SqlDataReader sdr = sc.ExecuteReader();
                sdr.Read();
                if (textBox_MedicineName.Text == sdr.GetString(1) )
                {
                    MessageBox.Show("Medicine Already exist");
                    this.Show();
                    this.Close();
                }
            }*/



            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Insert into Medicine_Information (Name, Type, CompanyName, Price) Values ('" + textBox_MedicineName.Text + "', '" + comboBox_MedicineType.SelectedItem + "','" + textBox_CompanyName.Text + "','" + textBox_Price.Text + "') ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Medicine Information stored Successfully");
                    clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (textBox_SearchedMedicineName.Text == string.Empty || comboBox_SearchedMedicineType.SelectedItem.ToString() == null || textBox_SearchedCompanyName.Text == string.Empty || textBox_SearchedPrice.Text == string.Empty)
            {
                MessageBox.Show("All Field must Required");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("UPDATE Medicine_Information set Name = '" + textBox_SearchedMedicineName.Text + "',  Type = '" + comboBox_SearchedMedicineType.SelectedItem + "', CompanyName = '" + textBox_SearchedCompanyName.Text + "', Price = '" + textBox_SearchedPrice.Text + "' where Name  = '" + textBox_SearchForMedicineName.Text + "' ", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Updated Successfully");
                    searchClear();

                    //clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button_Search_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_SearchForMedicineName.Text != string.Empty)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    con.Open();
                    string sda = "Select * from Medicine_Information where Name = '" + textBox_SearchForMedicineName.Text+ "'";
                    SqlCommand sc = new SqlCommand(sda, con);
                    SqlDataReader sdr = sc.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox_SearchedMedicineName.Text = sdr["Name"].ToString();
                        comboBox_SearchedMedicineType.Text = sdr["Type"].ToString();
                        textBox_SearchedCompanyName.Text = sdr["CompanyName"].ToString();
                        textBox_SearchedPrice.Text = sdr["Price"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("No Information againest this Medicine Name");
                    }
                }
                else
                {
                    MessageBox.Show("Please provide a Medicine Name");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check the Medicine Name which you provide.");
            }

        }

        private void button_SearchClear_Click(object sender, EventArgs e)
        {
            searchClear();
        }

        private void button_Logout_Click_1(object sender, EventArgs e)
        {
            Front_Page fp = new Front_Page();
            fp.Show();
            this.Hide();
        }

        private void button_PatientRefresh_Click(object sender, EventArgs e)
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

        private void button_MedicineRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                con.Open();
                SqlCommand sc = con.CreateCommand();
                sc.CommandType = CommandType.Text;
                sc.CommandText = "Select * from Medicine_Information";
                sc.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(sc);
                sda.Fill(dt);
                dataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label25.Show();
            textBox10.Show();
            numericUpDown20.Show();
            numericUpDown19.Show();
            numericUpDown18.Show();
            button5.Hide();
            button3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label26.Show();
            textBox11.Show();
            numericUpDown21.Show();
            numericUpDown22.Show();
            numericUpDown23.Show();
            button3.Hide();
            button4.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label27.Show();
            textBox12.Show();
            numericUpDown24.Show();
            numericUpDown25.Show();
            numericUpDown26.Show();
            button4.Hide();

        }

        private void button_SearchPatient_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox_SearchPatient.Text != string.Empty)
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    con.Open();
                    string sda = "Select * from Patient_Information where ID = '" + textBox_SearchPatient.Text.Trim() + "'";
                    SqlCommand sc = new SqlCommand(sda, con);
                    SqlDataReader sdr = sc.ExecuteReader();
                    if (sdr.Read())
                    {
                        textBox_PatientName.Text = sdr["Name"].ToString();
                        textBox_PatientAge.Text = sdr["Age"].ToString();
                        textBox_PatientGender.Text = sdr["Gender"].ToString();
                        richTextBox_Disease.Text = sdr["Disease"].ToString();
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

        

        private void button_Print_Click(object sender, PrintPageEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
           
        }
        private void autoSuggest()
        {
            SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
            con.Open();
            SqlCommand sc = new SqlCommand();
            sc.CommandText =  "Select Name from [Medicine_Information]";
            sc.Connection = con;
            SqlDataReader sdr = sc.ExecuteReader();
            AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
            while (sdr.Read())
            {
                auto.Add(sdr.GetString(0));
            }

        }

        private void button_Delete_Click(object sender, EventArgs e)
        {

            if (textBox_SearchedMedicineName.Text == string.Empty || comboBox_SearchedMedicineType.SelectedItem.ToString() == null || textBox_SearchedCompanyName.Text == string.Empty || textBox_SearchedPrice.Text == string.Empty)
            {
                MessageBox.Show("All Field must Required");
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection(@"Data Source=Afif-PC;Integrated Security=True");
                    SqlDataAdapter sda = new SqlDataAdapter("Delete From Medicine_Information Where Name = '" + textBox_SearchedMedicineName.Text + "'", con);
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    MessageBox.Show("Data Deleted Successfully");
                    searchClear();

                    //clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.gmail.com");

        }

        private void button_Print_Click(object sender, EventArgs e)
        {
            if (textBox_PatientName.Text != string.Empty)
            {
            Document doc = new Document(iTextSharp.text.PageSize.LETTER,10,10,42,35);
                PdfWriter wri = PdfWriter.GetInstance(doc, new FileStream("D://"+textBox_SearchPatient.Text+".pdf", FileMode.Create));
            doc.Open();
            Paragraph p1 = new Paragraph("       Dr. MD. Habibur Rahman\nM.B.B.S (Dhaka Medical College)\n          F.C.P.S (Medicine)");
            p1.IndentationLeft = 240f;
            doc.Add(p1);
            
            Paragraph p2 = new Paragraph("Patient Name: " + textBox_PatientName.Text + "    Age: " + textBox_PatientAge.Text + "     Gender: " + textBox_PatientGender.Text + "\nDisease: " + richTextBox_Disease.Text);
            doc.Add(p2);
            
            Paragraph p24 = new Paragraph("\n");
            doc.Add(p24);
            
            Paragraph p3 = new Paragraph("Blood Pressure: " + numericUpDown_BP1.Value + "/" + numericUpDown_BP2.Value);
            doc.Add(p3);

            Paragraph p25 = new Paragraph("\n");
            doc.Add(p25);

            
                if (textBox5.Text != string.Empty)
            {
                Paragraph p7 = new Paragraph("Medicine Name: " + textBox5.Text + " - " + numericUpDown3.Value + " - " + numericUpDown4.Value + " - " + numericUpDown5.Value);
                doc.Add(p7);
            }
            if (textBox6.Text != string.Empty)
            {
               Paragraph p8 = new Paragraph( textBox6.Text + " - " + numericUpDown8.Value + " - " + numericUpDown7.Value + " - " + numericUpDown6.Value);
               doc.Add(p8);
             }
                if (textBox7.Text != string.Empty)
                {
                    Paragraph p9 = new Paragraph(textBox7.Text + " - " + numericUpDown11.Value + " - " + numericUpDown10.Value + " - " + numericUpDown9.Value);
                    doc.Add(p9);
                }
                if (textBox8.Text != string.Empty)
                {
                    Paragraph p10 = new Paragraph(textBox8.Text + " - " + numericUpDown14.Value + " - " + numericUpDown13.Value + " - " + numericUpDown12.Value);
                    doc.Add(p10);
                }
                if (textBox9.Text != string.Empty)
                {
                    Paragraph p11 = new Paragraph(textBox9.Text + " - " + numericUpDown17.Value + " - " + numericUpDown16.Value + " - " + numericUpDown15.Value);
                    doc.Add(p11);
                }
                if (textBox10.Text != string.Empty)
                {
                    Paragraph p12 = new Paragraph(textBox10.Text + " - " + numericUpDown20.Value + " - " + numericUpDown19.Value + " - " + numericUpDown18.Value);
                    doc.Add(p12);
                }
                if (textBox11.Text != string.Empty)
                {
                    Paragraph p13 = new Paragraph(textBox11.Text + " - " + numericUpDown23.Value + " - " + numericUpDown22.Value + " - " + numericUpDown21.Value);
                    doc.Add(p13);
                }
                if (textBox12.Text != string.Empty)
                {
                    Paragraph p14 = new Paragraph(textBox12.Text + " - " + numericUpDown26.Value + " - " + numericUpDown25.Value + " - " + numericUpDown24.Value);
                    doc.Add(p14);
                }

                Paragraph p26 = new Paragraph("\n");
                doc.Add(p26);
            
           
            
            
            if (checkBox1.Checked)
            {
                Paragraph p4 = new Paragraph("Test List: " + "Blood");
                doc.Add(p4);
            }
            if (checkBox2.Checked)
            {
                Paragraph p15 = new Paragraph("Test List: " + "Urine");
                doc.Add(p15);
            }
            if (checkBox3.Checked)
            {
                Paragraph p16 = new Paragraph("Test List: " + "CBC");
                doc.Add(p16);
            }
            if (checkBox4.Checked)
            {
                Paragraph p17 = new Paragraph("Test List: " + "X-Ray");
                doc.Add(p17);
            }
            if (checkBox5.Checked)
            {
                Paragraph p18 = new Paragraph("Test List: " + "Serum Creatinine");
                doc.Add(p18);
            }
            if (checkBox6.Checked)
            {
                Paragraph p19 = new Paragraph("Test List: " + "HBsAG");
                doc.Add(p19);
            }
            if (checkBox7.Checked)
            {
                Paragraph p20 = new Paragraph("Test List: " + "Serum Calcium");
                doc.Add(p20);
            }
            if (checkBox8.Checked)
            {
                Paragraph p21 = new Paragraph("Test List: " + "Lipid Profile");
                doc.Add(p21);
            }
            if (checkBox9.Checked)
            {
                Paragraph p22 = new Paragraph("Test List: " + "OGTT");
                doc.Add(p22);
            }
            if (checkBox10.Checked)
            {
                Paragraph p23 = new Paragraph("Test List: " + "Widal Test");
                doc.Add(p23);
            }
            Paragraph p27 = new Paragraph("\n");
            doc.Add(p27);
            
                if (string.IsNullOrEmpty(richTextBox_Suggession.Text))
            {
                Paragraph p5 = new Paragraph("Suggession: " + "No Suggession");
                doc.Add(p5);
            }
            else
            {
                Paragraph p5 = new Paragraph("Suggession: " + richTextBox_Suggession.Text);
                doc.Add(p5);
            }
                Paragraph p28 = new Paragraph("\n");
                doc.Add(p28);
           
            Paragraph p6 = new Paragraph("Next Visit Date: " + dateTimePicker_NextVisitDate.Value);
            doc.Add(p6);
            
            
            doc.Close();
            MessageBox.Show("Prescription Printed Successfully");
            }
            else
            {
                MessageBox.Show("No Patient inserted");
            }
        }

        private void textBox_MedicineName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
