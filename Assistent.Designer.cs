namespace Doctors_Desktop
{
    partial class Assistent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Patient_Registration = new System.Windows.Forms.TabPage();
            this.richTextBox_Disease = new System.Windows.Forms.RichTextBox();
            this.richTextBox_Address = new System.Windows.Forms.RichTextBox();
            this.comboBox_Gender = new System.Windows.Forms.ComboBox();
            this.label_Gender = new System.Windows.Forms.Label();
            this.button_Clear = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.textBox_PhoneNo = new System.Windows.Forms.TextBox();
            this.textBox_Age = new System.Windows.Forms.TextBox();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.label_Disease = new System.Windows.Forms.Label();
            this.label_PhoneNo = new System.Windows.Forms.Label();
            this.label_Address = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.Old_Patient = new System.Windows.Forms.TabPage();
            this.button_SearchClear = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.richTextBox_SearchedDisease = new System.Windows.Forms.RichTextBox();
            this.richTextBox_SearchedAddress = new System.Windows.Forms.RichTextBox();
            this.comboBox_SearchedAge = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_SearchedPhoneNo = new System.Windows.Forms.TextBox();
            this.textBox_SearchedAge = new System.Windows.Forms.TextBox();
            this.textBox_SearchedName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Search = new System.Windows.Forms.Button();
            this.textBox_Patient_ID = new System.Windows.Forms.TextBox();
            this.label_Patient_ID = new System.Windows.Forms.Label();
            this.Patient_List = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diseaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientInformationBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.msdbDataSet2 = new Doctors_Desktop.msdbDataSet2();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.button_Logout = new System.Windows.Forms.Button();
            this.msdbDataSet = new Doctors_Desktop.msdbDataSet();
            this.patientInformationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patient_InformationTableAdapter = new Doctors_Desktop.msdbDataSetTableAdapters.Patient_InformationTableAdapter();
            this.msdbDataSet1 = new Doctors_Desktop.msdbDataSet1();
            this.patientInformationBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patient_InformationTableAdapter1 = new Doctors_Desktop.msdbDataSet1TableAdapters.Patient_InformationTableAdapter();
            this.patient_InformationTableAdapter2 = new Doctors_Desktop.msdbDataSet2TableAdapters.Patient_InformationTableAdapter();
            this.dataSet1 = new Doctors_Desktop.DataSet1();
            this.patientInformationBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.patient_InformationTableAdapter3 = new Doctors_Desktop.DataSet1TableAdapters.Patient_InformationTableAdapter();
            this.tabControl1.SuspendLayout();
            this.Patient_Registration.SuspendLayout();
            this.Old_Patient.SuspendLayout();
            this.Patient_List.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdbDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdbDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.Patient_Registration);
            this.tabControl1.Controls.Add(this.Old_Patient);
            this.tabControl1.Controls.Add(this.Patient_List);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1246, 727);
            this.tabControl1.TabIndex = 0;
            // 
            // Patient_Registration
            // 
            this.Patient_Registration.Controls.Add(this.richTextBox_Disease);
            this.Patient_Registration.Controls.Add(this.richTextBox_Address);
            this.Patient_Registration.Controls.Add(this.comboBox_Gender);
            this.Patient_Registration.Controls.Add(this.label_Gender);
            this.Patient_Registration.Controls.Add(this.button_Clear);
            this.Patient_Registration.Controls.Add(this.button_Save);
            this.Patient_Registration.Controls.Add(this.textBox_PhoneNo);
            this.Patient_Registration.Controls.Add(this.textBox_Age);
            this.Patient_Registration.Controls.Add(this.textBox_Name);
            this.Patient_Registration.Controls.Add(this.label_Disease);
            this.Patient_Registration.Controls.Add(this.label_PhoneNo);
            this.Patient_Registration.Controls.Add(this.label_Address);
            this.Patient_Registration.Controls.Add(this.label_Age);
            this.Patient_Registration.Controls.Add(this.label_Name);
            this.Patient_Registration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_Registration.Location = new System.Drawing.Point(4, 33);
            this.Patient_Registration.Name = "Patient_Registration";
            this.Patient_Registration.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_Registration.Size = new System.Drawing.Size(1238, 690);
            this.Patient_Registration.TabIndex = 0;
            this.Patient_Registration.Text = "Patient Registration";
            this.Patient_Registration.UseVisualStyleBackColor = true;
            // 
            // richTextBox_Disease
            // 
            this.richTextBox_Disease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox_Disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Disease.Location = new System.Drawing.Point(335, 337);
            this.richTextBox_Disease.Name = "richTextBox_Disease";
            this.richTextBox_Disease.Size = new System.Drawing.Size(492, 151);
            this.richTextBox_Disease.TabIndex = 18;
            this.richTextBox_Disease.Text = "";
            // 
            // richTextBox_Address
            // 
            this.richTextBox_Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_Address.Location = new System.Drawing.Point(335, 156);
            this.richTextBox_Address.Name = "richTextBox_Address";
            this.richTextBox_Address.Size = new System.Drawing.Size(492, 126);
            this.richTextBox_Address.TabIndex = 17;
            this.richTextBox_Address.Text = "";
            // 
            // comboBox_Gender
            // 
            this.comboBox_Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Gender.FormattingEnabled = true;
            this.comboBox_Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_Gender.Location = new System.Drawing.Point(335, 122);
            this.comboBox_Gender.Name = "comboBox_Gender";
            this.comboBox_Gender.Size = new System.Drawing.Size(492, 28);
            this.comboBox_Gender.TabIndex = 16;
            this.comboBox_Gender.Text = "---Select---";
            // 
            // label_Gender
            // 
            this.label_Gender.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(229, 123);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(67, 20);
            this.label_Gender.TabIndex = 15;
            this.label_Gender.Text = "Gender:";
            // 
            // button_Clear
            // 
            this.button_Clear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Clear.Location = new System.Drawing.Point(687, 525);
            this.button_Clear.Name = "button_Clear";
            this.button_Clear.Size = new System.Drawing.Size(140, 54);
            this.button_Clear.TabIndex = 14;
            this.button_Clear.Text = "Clear";
            this.button_Clear.UseVisualStyleBackColor = true;
            this.button_Clear.Click += new System.EventHandler(this.button_Clear_Click);
            // 
            // button_Save
            // 
            this.button_Save.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(335, 525);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(140, 54);
            this.button_Save.TabIndex = 13;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // textBox_PhoneNo
            // 
            this.textBox_PhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PhoneNo.Location = new System.Drawing.Point(335, 300);
            this.textBox_PhoneNo.Name = "textBox_PhoneNo";
            this.textBox_PhoneNo.Size = new System.Drawing.Size(492, 26);
            this.textBox_PhoneNo.TabIndex = 10;
            this.textBox_PhoneNo.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox_Age
            // 
            this.textBox_Age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Age.Location = new System.Drawing.Point(335, 82);
            this.textBox_Age.Name = "textBox_Age";
            this.textBox_Age.Size = new System.Drawing.Size(492, 26);
            this.textBox_Age.TabIndex = 8;
            this.textBox_Age.UseWaitCursor = true;
            // 
            // textBox_Name
            // 
            this.textBox_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Name.Location = new System.Drawing.Point(335, 39);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.Size = new System.Drawing.Size(492, 26);
            this.textBox_Name.TabIndex = 7;
            // 
            // label_Disease
            // 
            this.label_Disease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Disease.AutoSize = true;
            this.label_Disease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Disease.Location = new System.Drawing.Point(229, 338);
            this.label_Disease.Name = "label_Disease";
            this.label_Disease.Size = new System.Drawing.Size(71, 20);
            this.label_Disease.TabIndex = 5;
            this.label_Disease.Text = "Disease:";
            // 
            // label_PhoneNo
            // 
            this.label_PhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_PhoneNo.AutoSize = true;
            this.label_PhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhoneNo.Location = new System.Drawing.Point(229, 300);
            this.label_PhoneNo.Name = "label_PhoneNo";
            this.label_PhoneNo.Size = new System.Drawing.Size(87, 20);
            this.label_PhoneNo.TabIndex = 4;
            this.label_PhoneNo.Text = "Phone No.:";
            // 
            // label_Address
            // 
            this.label_Address.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Address.AutoSize = true;
            this.label_Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Address.Location = new System.Drawing.Point(229, 157);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(72, 20);
            this.label_Address.TabIndex = 3;
            this.label_Address.Text = "Address:";
            // 
            // label_Age
            // 
            this.label_Age.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Age.Location = new System.Drawing.Point(229, 82);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(42, 20);
            this.label_Age.TabIndex = 2;
            this.label_Age.Text = "Age:";
            // 
            // label_Name
            // 
            this.label_Name.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(229, 40);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(55, 20);
            this.label_Name.TabIndex = 1;
            this.label_Name.Text = "Name:";
            this.label_Name.Click += new System.EventHandler(this.label_Name_Click);
            // 
            // Old_Patient
            // 
            this.Old_Patient.Controls.Add(this.button_SearchClear);
            this.Old_Patient.Controls.Add(this.button_Update);
            this.Old_Patient.Controls.Add(this.richTextBox_SearchedDisease);
            this.Old_Patient.Controls.Add(this.richTextBox_SearchedAddress);
            this.Old_Patient.Controls.Add(this.comboBox_SearchedAge);
            this.Old_Patient.Controls.Add(this.label1);
            this.Old_Patient.Controls.Add(this.textBox_SearchedPhoneNo);
            this.Old_Patient.Controls.Add(this.textBox_SearchedAge);
            this.Old_Patient.Controls.Add(this.textBox_SearchedName);
            this.Old_Patient.Controls.Add(this.label2);
            this.Old_Patient.Controls.Add(this.label3);
            this.Old_Patient.Controls.Add(this.label4);
            this.Old_Patient.Controls.Add(this.label5);
            this.Old_Patient.Controls.Add(this.label6);
            this.Old_Patient.Controls.Add(this.button_Search);
            this.Old_Patient.Controls.Add(this.textBox_Patient_ID);
            this.Old_Patient.Controls.Add(this.label_Patient_ID);
            this.Old_Patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Old_Patient.Location = new System.Drawing.Point(4, 33);
            this.Old_Patient.Name = "Old_Patient";
            this.Old_Patient.Padding = new System.Windows.Forms.Padding(3);
            this.Old_Patient.Size = new System.Drawing.Size(1238, 690);
            this.Old_Patient.TabIndex = 1;
            this.Old_Patient.Text = "Old Patient";
            this.Old_Patient.UseVisualStyleBackColor = true;
            // 
            // button_SearchClear
            // 
            this.button_SearchClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SearchClear.Location = new System.Drawing.Point(557, 571);
            this.button_SearchClear.Name = "button_SearchClear";
            this.button_SearchClear.Size = new System.Drawing.Size(142, 54);
            this.button_SearchClear.TabIndex = 32;
            this.button_SearchClear.Text = "Clear";
            this.button_SearchClear.UseVisualStyleBackColor = true;
            this.button_SearchClear.Click += new System.EventHandler(this.button_SearchClear_Click);
            // 
            // button_Update
            // 
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(207, 571);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(139, 54);
            this.button_Update.TabIndex = 31;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // richTextBox_SearchedDisease
            // 
            this.richTextBox_SearchedDisease.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox_SearchedDisease.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_SearchedDisease.Location = new System.Drawing.Point(207, 369);
            this.richTextBox_SearchedDisease.Name = "richTextBox_SearchedDisease";
            this.richTextBox_SearchedDisease.Size = new System.Drawing.Size(492, 151);
            this.richTextBox_SearchedDisease.TabIndex = 30;
            this.richTextBox_SearchedDisease.Text = "";
            // 
            // richTextBox_SearchedAddress
            // 
            this.richTextBox_SearchedAddress.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.richTextBox_SearchedAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_SearchedAddress.Location = new System.Drawing.Point(207, 188);
            this.richTextBox_SearchedAddress.Name = "richTextBox_SearchedAddress";
            this.richTextBox_SearchedAddress.Size = new System.Drawing.Size(492, 126);
            this.richTextBox_SearchedAddress.TabIndex = 29;
            this.richTextBox_SearchedAddress.Text = "";
            // 
            // comboBox_SearchedAge
            // 
            this.comboBox_SearchedAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_SearchedAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_SearchedAge.FormattingEnabled = true;
            this.comboBox_SearchedAge.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.comboBox_SearchedAge.Location = new System.Drawing.Point(207, 154);
            this.comboBox_SearchedAge.Name = "comboBox_SearchedAge";
            this.comboBox_SearchedAge.Size = new System.Drawing.Size(492, 28);
            this.comboBox_SearchedAge.TabIndex = 28;
            this.comboBox_SearchedAge.Text = "---Select---";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Gender:";
            // 
            // textBox_SearchedPhoneNo
            // 
            this.textBox_SearchedPhoneNo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_SearchedPhoneNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchedPhoneNo.Location = new System.Drawing.Point(207, 332);
            this.textBox_SearchedPhoneNo.Name = "textBox_SearchedPhoneNo";
            this.textBox_SearchedPhoneNo.Size = new System.Drawing.Size(492, 26);
            this.textBox_SearchedPhoneNo.TabIndex = 26;
            // 
            // textBox_SearchedAge
            // 
            this.textBox_SearchedAge.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_SearchedAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchedAge.Location = new System.Drawing.Point(207, 114);
            this.textBox_SearchedAge.Name = "textBox_SearchedAge";
            this.textBox_SearchedAge.Size = new System.Drawing.Size(492, 26);
            this.textBox_SearchedAge.TabIndex = 25;
            this.textBox_SearchedAge.UseWaitCursor = true;
            // 
            // textBox_SearchedName
            // 
            this.textBox_SearchedName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_SearchedName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_SearchedName.Location = new System.Drawing.Point(207, 71);
            this.textBox_SearchedName.Name = "textBox_SearchedName";
            this.textBox_SearchedName.Size = new System.Drawing.Size(492, 26);
            this.textBox_SearchedName.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Disease:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 332);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Phone No.:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Address:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Age:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(101, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Name:";
            // 
            // button_Search
            // 
            this.button_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Search.Location = new System.Drawing.Point(347, 22);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(125, 30);
            this.button_Search.TabIndex = 2;
            this.button_Search.Text = "Search";
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // textBox_Patient_ID
            // 
            this.textBox_Patient_ID.Location = new System.Drawing.Point(105, 26);
            this.textBox_Patient_ID.Name = "textBox_Patient_ID";
            this.textBox_Patient_ID.Size = new System.Drawing.Size(188, 26);
            this.textBox_Patient_ID.TabIndex = 1;
            // 
            // label_Patient_ID
            // 
            this.label_Patient_ID.AutoSize = true;
            this.label_Patient_ID.Location = new System.Drawing.Point(15, 29);
            this.label_Patient_ID.Name = "label_Patient_ID";
            this.label_Patient_ID.Size = new System.Drawing.Size(84, 20);
            this.label_Patient_ID.TabIndex = 0;
            this.label_Patient_ID.Text = "Patient ID:";
            // 
            // Patient_List
            // 
            this.Patient_List.Controls.Add(this.dataGridView1);
            this.Patient_List.Controls.Add(this.button_Refresh);
            this.Patient_List.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Patient_List.Location = new System.Drawing.Point(4, 33);
            this.Patient_List.Name = "Patient_List";
            this.Patient_List.Padding = new System.Windows.Forms.Padding(3);
            this.Patient_List.Size = new System.Drawing.Size(1238, 690);
            this.Patient_List.TabIndex = 2;
            this.Patient_List.Text = "Patient List";
            this.Patient_List.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.phoneNoDataGridViewTextBoxColumn,
            this.diseaseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientInformationBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1141, 678);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDDataGridViewTextBoxColumn.Width = 60;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 200;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.Width = 80;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.Width = 120;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.Width = 230;
            // 
            // phoneNoDataGridViewTextBoxColumn
            // 
            this.phoneNoDataGridViewTextBoxColumn.DataPropertyName = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.HeaderText = "PhoneNo";
            this.phoneNoDataGridViewTextBoxColumn.Name = "phoneNoDataGridViewTextBoxColumn";
            this.phoneNoDataGridViewTextBoxColumn.Width = 170;
            // 
            // diseaseDataGridViewTextBoxColumn
            // 
            this.diseaseDataGridViewTextBoxColumn.DataPropertyName = "Disease";
            this.diseaseDataGridViewTextBoxColumn.HeaderText = "Disease";
            this.diseaseDataGridViewTextBoxColumn.Name = "diseaseDataGridViewTextBoxColumn";
            this.diseaseDataGridViewTextBoxColumn.Width = 230;
            // 
            // patientInformationBindingSource2
            // 
            this.patientInformationBindingSource2.DataMember = "Patient_Information";
            this.patientInformationBindingSource2.DataSource = this.msdbDataSet2;
            // 
            // msdbDataSet2
            // 
            this.msdbDataSet2.DataSetName = "msdbDataSet2";
            this.msdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Location = new System.Drawing.Point(1153, 19);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(82, 60);
            this.button_Refresh.TabIndex = 2;
            this.button_Refresh.Text = "Refresh";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Logout
            // 
            this.button_Logout.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Logout.Location = new System.Drawing.Point(1264, 25);
            this.button_Logout.Name = "button_Logout";
            this.button_Logout.Size = new System.Drawing.Size(94, 58);
            this.button_Logout.TabIndex = 1;
            this.button_Logout.Text = "Logout";
            this.button_Logout.UseVisualStyleBackColor = true;
            this.button_Logout.Click += new System.EventHandler(this.button_Logout_Click);
            // 
            // msdbDataSet
            // 
            this.msdbDataSet.DataSetName = "msdbDataSet";
            this.msdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInformationBindingSource
            // 
            this.patientInformationBindingSource.DataMember = "Patient_Information";
            this.patientInformationBindingSource.DataSource = this.msdbDataSet;
            // 
            // patient_InformationTableAdapter
            // 
            this.patient_InformationTableAdapter.ClearBeforeFill = true;
            // 
            // msdbDataSet1
            // 
            this.msdbDataSet1.DataSetName = "msdbDataSet1";
            this.msdbDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInformationBindingSource1
            // 
            this.patientInformationBindingSource1.DataMember = "Patient_Information";
            this.patientInformationBindingSource1.DataSource = this.msdbDataSet1;
            // 
            // patient_InformationTableAdapter1
            // 
            this.patient_InformationTableAdapter1.ClearBeforeFill = true;
            // 
            // patient_InformationTableAdapter2
            // 
            this.patient_InformationTableAdapter2.ClearBeforeFill = true;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientInformationBindingSource3
            // 
            this.patientInformationBindingSource3.DataMember = "Patient_Information";
            this.patientInformationBindingSource3.DataSource = this.dataSet1;
            // 
            // patient_InformationTableAdapter3
            // 
            this.patient_InformationTableAdapter3.ClearBeforeFill = true;
            // 
            // Assistent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.button_Logout);
            this.Controls.Add(this.tabControl1);
            this.Name = "Assistent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Assistent";
            this.Load += new System.EventHandler(this.Assistent_Load);
            this.tabControl1.ResumeLayout(false);
            this.Patient_Registration.ResumeLayout(false);
            this.Patient_Registration.PerformLayout();
            this.Old_Patient.ResumeLayout(false);
            this.Old_Patient.PerformLayout();
            this.Patient_List.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdbDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msdbDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientInformationBindingSource3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Old_Patient;
        private System.Windows.Forms.TabPage Patient_List;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_Patient_ID;
        private System.Windows.Forms.Label label_Patient_ID;
        private System.Windows.Forms.TabPage Patient_Registration;
        private System.Windows.Forms.RichTextBox richTextBox_Disease;
        private System.Windows.Forms.RichTextBox richTextBox_Address;
        private System.Windows.Forms.ComboBox comboBox_Gender;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Button button_Clear;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.TextBox textBox_PhoneNo;
        private System.Windows.Forms.TextBox textBox_Age;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.Label label_Disease;
        private System.Windows.Forms.Label label_PhoneNo;
        private System.Windows.Forms.Label label_Address;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Button button_Logout;
        private System.Windows.Forms.Button button_Refresh;
        private msdbDataSet msdbDataSet;
        private System.Windows.Forms.BindingSource patientInformationBindingSource;
        private msdbDataSetTableAdapters.Patient_InformationTableAdapter patient_InformationTableAdapter;
        private msdbDataSet1 msdbDataSet1;
        private System.Windows.Forms.BindingSource patientInformationBindingSource1;
        private msdbDataSet1TableAdapters.Patient_InformationTableAdapter patient_InformationTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private msdbDataSet2 msdbDataSet2;
        private System.Windows.Forms.BindingSource patientInformationBindingSource2;
        private msdbDataSet2TableAdapters.Patient_InformationTableAdapter patient_InformationTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diseaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button_SearchClear;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.RichTextBox richTextBox_SearchedDisease;
        private System.Windows.Forms.RichTextBox richTextBox_SearchedAddress;
        private System.Windows.Forms.ComboBox comboBox_SearchedAge;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_SearchedPhoneNo;
        private System.Windows.Forms.TextBox textBox_SearchedAge;
        private System.Windows.Forms.TextBox textBox_SearchedName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource patientInformationBindingSource3;
        private DataSet1TableAdapters.Patient_InformationTableAdapter patient_InformationTableAdapter3;
    }
}