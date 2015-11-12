namespace InSession
{
    partial class ClassManagement
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
            this.label33 = new System.Windows.Forms.Label();
            this.dtpClassTime = new System.Windows.Forms.DateTimePicker();
            this.chkbxKids = new System.Windows.Forms.CheckBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.gbFrequency = new System.Windows.Forms.GroupBox();
            this.rbOnce = new System.Windows.Forms.RadioButton();
            this.rbBiWeekly = new System.Windows.Forms.RadioButton();
            this.rbWeekly = new System.Windows.Forms.RadioButton();
            this.label31 = new System.Windows.Forms.Label();
            this.dtpClassDate = new System.Windows.Forms.DateTimePicker();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnSaveClassData = new System.Windows.Forms.Button();
            this.btnMoveDownClass = new System.Windows.Forms.Button();
            this.btnMoveUpClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.btnAddClass = new System.Windows.Forms.Button();
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.gbFrequency.SuspendLayout();
            this.SuspendLayout();
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(167, 98);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(55, 13);
            this.label33.TabIndex = 50;
            this.label33.Text = "Start Time";
            // 
            // dtpClassTime
            // 
            this.dtpClassTime.CustomFormat = "HH:mm";
            this.dtpClassTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpClassTime.Location = new System.Drawing.Point(171, 114);
            this.dtpClassTime.Name = "dtpClassTime";
            this.dtpClassTime.ShowUpDown = true;
            this.dtpClassTime.Size = new System.Drawing.Size(200, 20);
            this.dtpClassTime.TabIndex = 49;
            // 
            // chkbxKids
            // 
            this.chkbxKids.AutoSize = true;
            this.chkbxKids.Location = new System.Drawing.Point(383, 136);
            this.chkbxKids.Name = "chkbxKids";
            this.chkbxKids.Size = new System.Drawing.Size(74, 17);
            this.chkbxKids.TabIndex = 48;
            this.chkbxKids.Text = "Kids Class";
            this.chkbxKids.UseVisualStyleBackColor = true;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(170, 30);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(200, 20);
            this.txtClassName.TabIndex = 47;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(167, 12);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(63, 13);
            this.label32.TabIndex = 46;
            this.label32.Text = "Class Name";
            // 
            // gbFrequency
            // 
            this.gbFrequency.Controls.Add(this.rbOnce);
            this.gbFrequency.Controls.Add(this.rbBiWeekly);
            this.gbFrequency.Controls.Add(this.rbWeekly);
            this.gbFrequency.Location = new System.Drawing.Point(377, 30);
            this.gbFrequency.Name = "gbFrequency";
            this.gbFrequency.Size = new System.Drawing.Size(80, 100);
            this.gbFrequency.TabIndex = 45;
            this.gbFrequency.TabStop = false;
            this.gbFrequency.Text = "Frequency";
            // 
            // rbOnce
            // 
            this.rbOnce.AutoSize = true;
            this.rbOnce.Location = new System.Drawing.Point(6, 19);
            this.rbOnce.Name = "rbOnce";
            this.rbOnce.Size = new System.Drawing.Size(51, 17);
            this.rbOnce.TabIndex = 2;
            this.rbOnce.TabStop = true;
            this.rbOnce.Text = "Once";
            this.rbOnce.UseVisualStyleBackColor = true;
            // 
            // rbBiWeekly
            // 
            this.rbBiWeekly.AutoSize = true;
            this.rbBiWeekly.Location = new System.Drawing.Point(6, 66);
            this.rbBiWeekly.Name = "rbBiWeekly";
            this.rbBiWeekly.Size = new System.Drawing.Size(73, 17);
            this.rbBiWeekly.TabIndex = 1;
            this.rbBiWeekly.TabStop = true;
            this.rbBiWeekly.Text = "Bi-Weekly";
            this.rbBiWeekly.UseVisualStyleBackColor = true;
            // 
            // rbWeekly
            // 
            this.rbWeekly.AutoSize = true;
            this.rbWeekly.Location = new System.Drawing.Point(6, 42);
            this.rbWeekly.Name = "rbWeekly";
            this.rbWeekly.Size = new System.Drawing.Size(61, 17);
            this.rbWeekly.TabIndex = 0;
            this.rbWeekly.TabStop = true;
            this.rbWeekly.Text = "Weekly";
            this.rbWeekly.UseVisualStyleBackColor = true;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(167, 53);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(55, 13);
            this.label31.TabIndex = 44;
            this.label31.Text = "Start Date";
            // 
            // dtpClassDate
            // 
            this.dtpClassDate.CustomFormat = "";
            this.dtpClassDate.Location = new System.Drawing.Point(170, 70);
            this.dtpClassDate.Name = "dtpClassDate";
            this.dtpClassDate.Size = new System.Drawing.Size(200, 20);
            this.dtpClassDate.TabIndex = 43;
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(199, 294);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(75, 23);
            this.btnEditClass.TabIndex = 42;
            this.btnEditClass.Text = "Edit Class";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnSaveClassData
            // 
            this.btnSaveClassData.Location = new System.Drawing.Point(370, 325);
            this.btnSaveClassData.Name = "btnSaveClassData";
            this.btnSaveClassData.Size = new System.Drawing.Size(75, 23);
            this.btnSaveClassData.TabIndex = 41;
            this.btnSaveClassData.Text = "Save Changes";
            this.btnSaveClassData.UseVisualStyleBackColor = true;
            // 
            // btnMoveDownClass
            // 
            this.btnMoveDownClass.Location = new System.Drawing.Point(118, 324);
            this.btnMoveDownClass.Name = "btnMoveDownClass";
            this.btnMoveDownClass.Size = new System.Drawing.Size(75, 23);
            this.btnMoveDownClass.TabIndex = 40;
            this.btnMoveDownClass.Text = "Move Down";
            this.btnMoveDownClass.UseVisualStyleBackColor = true;
            // 
            // btnMoveUpClass
            // 
            this.btnMoveUpClass.Location = new System.Drawing.Point(36, 325);
            this.btnMoveUpClass.Name = "btnMoveUpClass";
            this.btnMoveUpClass.Size = new System.Drawing.Size(75, 23);
            this.btnMoveUpClass.TabIndex = 39;
            this.btnMoveUpClass.Text = "Move Up";
            this.btnMoveUpClass.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(118, 294);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClass.TabIndex = 38;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(36, 295);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 37;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // lbClasses
            // 
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.Location = new System.Drawing.Point(22, 12);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.Size = new System.Drawing.Size(139, 277);
            this.lbClasses.TabIndex = 36;
            // 
            // ClassManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 473);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.dtpClassTime);
            this.Controls.Add(this.chkbxKids);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.gbFrequency);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.dtpClassDate);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnSaveClassData);
            this.Controls.Add(this.btnMoveDownClass);
            this.Controls.Add(this.btnMoveUpClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.lbClasses);
            this.Name = "ClassManagement";
            this.Text = "Class Management";
            this.gbFrequency.ResumeLayout(false);
            this.gbFrequency.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DateTimePicker dtpClassTime;
        private System.Windows.Forms.CheckBox chkbxKids;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.GroupBox gbFrequency;
        private System.Windows.Forms.RadioButton rbOnce;
        private System.Windows.Forms.RadioButton rbBiWeekly;
        private System.Windows.Forms.RadioButton rbWeekly;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.DateTimePicker dtpClassDate;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnSaveClassData;
        private System.Windows.Forms.Button btnMoveDownClass;
        private System.Windows.Forms.Button btnMoveUpClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.ListBox lbClasses;
    }
}