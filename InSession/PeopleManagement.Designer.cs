namespace InSession
{
    partial class PeopleManagement
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
            this.txtEditLName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.comboUserSelect = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtEditPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtEditState = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEditZip = new System.Windows.Forms.TextBox();
            this.txtEditCity = new System.Windows.Forms.TextBox();
            this.txtEditAddress = new System.Windows.Forms.TextBox();
            this.comboEdit = new System.Windows.Forms.ComboBox();
            this.txtEditFName = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.btnAddPerson = new System.Windows.Forms.Button();
            this.btnEditPerson = new System.Windows.Forms.Button();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnAddEmergencyContact = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboEmergencyContact = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboGuardians = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtEditLName
            // 
            this.txtEditLName.Location = new System.Drawing.Point(94, 71);
            this.txtEditLName.Name = "txtEditLName";
            this.txtEditLName.Size = new System.Drawing.Size(100, 20);
            this.txtEditLName.TabIndex = 64;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(329, 26);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 20);
            this.txtID.TabIndex = 61;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(280, 33);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(43, 13);
            this.label25.TabIndex = 89;
            this.label25.Text = "User ID";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(20, 33);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(62, 13);
            this.label24.TabIndex = 88;
            this.label24.Text = "Select User";
            // 
            // comboUserSelect
            // 
            this.comboUserSelect.FormattingEnabled = true;
            this.comboUserSelect.Location = new System.Drawing.Point(94, 26);
            this.comboUserSelect.Name = "comboUserSelect";
            this.comboUserSelect.Size = new System.Drawing.Size(179, 21);
            this.comboUserSelect.TabIndex = 60;
            this.comboUserSelect.TabStop = false;
            this.comboUserSelect.SelectedIndexChanged += new System.EventHandler(this.comboUserSelect_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 23);
            this.button1.TabIndex = 75;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtEditPhone
            // 
            this.txtEditPhone.Location = new System.Drawing.Point(329, 71);
            this.txtEditPhone.Mask = "(999) 000-0000";
            this.txtEditPhone.Name = "txtEditPhone";
            this.txtEditPhone.Size = new System.Drawing.Size(121, 20);
            this.txtEditPhone.TabIndex = 65;
            // 
            // txtEditState
            // 
            this.txtEditState.Location = new System.Drawing.Point(329, 115);
            this.txtEditState.Name = "txtEditState";
            this.txtEditState.Size = new System.Drawing.Size(121, 20);
            this.txtEditState.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(280, 118);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 85;
            this.label13.Text = "State";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(280, 74);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(48, 13);
            this.label15.TabIndex = 84;
            this.label15.Text = "Phone #";
            // 
            // txtEditZip
            // 
            this.txtEditZip.Location = new System.Drawing.Point(94, 137);
            this.txtEditZip.Name = "txtEditZip";
            this.txtEditZip.Size = new System.Drawing.Size(100, 20);
            this.txtEditZip.TabIndex = 69;
            // 
            // txtEditCity
            // 
            this.txtEditCity.Location = new System.Drawing.Point(94, 115);
            this.txtEditCity.Name = "txtEditCity";
            this.txtEditCity.Size = new System.Drawing.Size(100, 20);
            this.txtEditCity.TabIndex = 67;
            // 
            // txtEditAddress
            // 
            this.txtEditAddress.Location = new System.Drawing.Point(94, 93);
            this.txtEditAddress.Name = "txtEditAddress";
            this.txtEditAddress.Size = new System.Drawing.Size(356, 20);
            this.txtEditAddress.TabIndex = 66;
            // 
            // comboEdit
            // 
            this.comboEdit.FormattingEnabled = true;
            this.comboEdit.Items.AddRange(new object[] {
            "White",
            "Rokkyu",
            "Rokkyu - Second",
            "Gokkyu",
            "Gokkyu - Second"});
            this.comboEdit.Location = new System.Drawing.Point(329, 49);
            this.comboEdit.Name = "comboEdit";
            this.comboEdit.Size = new System.Drawing.Size(121, 21);
            this.comboEdit.TabIndex = 63;
            // 
            // txtEditFName
            // 
            this.txtEditFName.Location = new System.Drawing.Point(94, 49);
            this.txtEditFName.Name = "txtEditFName";
            this.txtEditFName.Size = new System.Drawing.Size(100, 20);
            this.txtEditFName.TabIndex = 62;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(280, 52);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(33, 13);
            this.label17.TabIndex = 82;
            this.label17.Text = "Rank";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(20, 121);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(24, 13);
            this.label19.TabIndex = 80;
            this.label19.Text = "City";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(20, 143);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(50, 13);
            this.label20.TabIndex = 79;
            this.label20.Text = "Zip Code";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 99);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(45, 13);
            this.label21.TabIndex = 78;
            this.label21.Text = "Address";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(20, 77);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(58, 13);
            this.label22.TabIndex = 77;
            this.label22.Text = "Last Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(20, 55);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(57, 13);
            this.label23.TabIndex = 76;
            this.label23.Text = "First Name";
            // 
            // btnAddPerson
            // 
            this.btnAddPerson.Location = new System.Drawing.Point(139, 214);
            this.btnAddPerson.Name = "btnAddPerson";
            this.btnAddPerson.Size = new System.Drawing.Size(98, 23);
            this.btnAddPerson.TabIndex = 90;
            this.btnAddPerson.Text = "Add New Person";
            this.btnAddPerson.UseVisualStyleBackColor = true;
            this.btnAddPerson.Click += new System.EventHandler(this.btnAddPerson_Click);
            // 
            // btnEditPerson
            // 
            this.btnEditPerson.Location = new System.Drawing.Point(243, 214);
            this.btnEditPerson.Name = "btnEditPerson";
            this.btnEditPerson.Size = new System.Drawing.Size(97, 23);
            this.btnEditPerson.TabIndex = 91;
            this.btnEditPerson.Text = "Edit Person";
            this.btnEditPerson.UseVisualStyleBackColor = true;
            this.btnEditPerson.Click += new System.EventHandler(this.btnEditPerson_Click);
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.Location = new System.Drawing.Point(346, 214);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(97, 23);
            this.btnDeletePerson.TabIndex = 92;
            this.btnDeletePerson.Text = "Delete Person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnAddEmergencyContact
            // 
            this.btnAddEmergencyContact.Location = new System.Drawing.Point(626, 54);
            this.btnAddEmergencyContact.Name = "btnAddEmergencyContact";
            this.btnAddEmergencyContact.Size = new System.Drawing.Size(137, 23);
            this.btnAddEmergencyContact.TabIndex = 93;
            this.btnAddEmergencyContact.Text = "Add Emergency Contact";
            this.btnAddEmergencyContact.UseVisualStyleBackColor = true;
            this.btnAddEmergencyContact.Click += new System.EventHandler(this.btnAddEmergencyContact_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(626, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(137, 23);
            this.button2.TabIndex = 94;
            this.button2.Text = "Add Guardian(s)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnAddGuardian_Click);
            // 
            // comboEmergencyContact
            // 
            this.comboEmergencyContact.FormattingEnabled = true;
            this.comboEmergencyContact.Location = new System.Drawing.Point(592, 25);
            this.comboEmergencyContact.Name = "comboEmergencyContact";
            this.comboEmergencyContact.Size = new System.Drawing.Size(171, 21);
            this.comboEmergencyContact.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 96;
            this.label1.Text = "Emergency Contact(s)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Guardian(s)";
            // 
            // comboGuardians
            // 
            this.comboGuardians.FormattingEnabled = true;
            this.comboGuardians.Location = new System.Drawing.Point(592, 91);
            this.comboGuardians.Name = "comboGuardians";
            this.comboGuardians.Size = new System.Drawing.Size(171, 21);
            this.comboGuardians.TabIndex = 98;
            // 
            // PeopleManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 264);
            this.Controls.Add(this.comboGuardians);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboEmergencyContact);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddEmergencyContact);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.btnEditPerson);
            this.Controls.Add(this.btnAddPerson);
            this.Controls.Add(this.txtEditLName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.comboUserSelect);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtEditPhone);
            this.Controls.Add(this.txtEditState);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEditZip);
            this.Controls.Add(this.txtEditCity);
            this.Controls.Add(this.txtEditAddress);
            this.Controls.Add(this.comboEdit);
            this.Controls.Add(this.txtEditFName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Name = "PeopleManagement";
            this.Text = "People Management";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEditLName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.ComboBox comboUserSelect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtEditPhone;
        private System.Windows.Forms.TextBox txtEditState;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEditZip;
        private System.Windows.Forms.TextBox txtEditCity;
        private System.Windows.Forms.TextBox txtEditAddress;
        private System.Windows.Forms.ComboBox comboEdit;
        private System.Windows.Forms.TextBox txtEditFName;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Button btnAddPerson;
        private System.Windows.Forms.Button btnEditPerson;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnAddEmergencyContact;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboEmergencyContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboGuardians;
    }
}