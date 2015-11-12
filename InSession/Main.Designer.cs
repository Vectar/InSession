namespace InSession
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.FileBrowser = new System.Windows.Forms.OpenFileDialog();
            this.MainMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuEditPeople = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEditRanks = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TodayAttendence = new System.Windows.Forms.ToolStripMenuItem();
            this.WeeklyAttendence = new System.Windows.Forms.ToolStripMenuItem();
            this.MonthlyAttendence = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEditOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.editSetupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchool = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bOne = new System.Windows.Forms.Button();
            this.bTwo = new System.Windows.Forms.Button();
            this.bThree = new System.Windows.Forms.Button();
            this.bFour = new System.Windows.Forms.Button();
            this.bSix = new System.Windows.Forms.Button();
            this.bFive = new System.Windows.Forms.Button();
            this.bZero = new System.Windows.Forms.Button();
            this.bNine = new System.Windows.Forms.Button();
            this.bEight = new System.Windows.Forms.Button();
            this.bSeven = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.bRegister = new System.Windows.Forms.Button();
            this.pbMenu = new System.Windows.Forms.PictureBox();
            this.pbLeft = new System.Windows.Forms.PictureBox();
            this.pbRight = new System.Windows.Forms.PictureBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSoftwareVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.menuDatabaseVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.MainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).BeginInit();
            this.SuspendLayout();
            // 
            // FileBrowser
            // 
            this.FileBrowser.FileName = "openFileDialog1";
            this.FileBrowser.Filter = "*.jpg|*.png";
            this.FileBrowser.Title = "Browse for rank image";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEditPeople,
            this.MenuEditClasses,
            this.MenuEditRanks,
            this.reportsToolStripMenuItem,
            this.menuEditOptions,
            this.aboutToolStripMenuItem,
            this.MenuExit});
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Size = new System.Drawing.Size(136, 158);
            // 
            // MenuEditPeople
            // 
            this.MenuEditPeople.Name = "MenuEditPeople";
            this.MenuEditPeople.Size = new System.Drawing.Size(135, 22);
            this.MenuEditPeople.Text = "Edit People";
            this.MenuEditPeople.Click += new System.EventHandler(this.MenuEditPeople_Click);
            // 
            // MenuEditClasses
            // 
            this.MenuEditClasses.Name = "MenuEditClasses";
            this.MenuEditClasses.Size = new System.Drawing.Size(135, 22);
            this.MenuEditClasses.Text = "Edit Classes";
            this.MenuEditClasses.Click += new System.EventHandler(this.MenuEditClasses_Click);
            // 
            // MenuEditRanks
            // 
            this.MenuEditRanks.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.MenuEditRanks.Name = "MenuEditRanks";
            this.MenuEditRanks.Size = new System.Drawing.Size(135, 22);
            this.MenuEditRanks.Text = "Edit Ranks";
            this.MenuEditRanks.Click += new System.EventHandler(this.MenuEditRanks_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendenceToolStripMenuItem1});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // attendenceToolStripMenuItem1
            // 
            this.attendenceToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TodayAttendence,
            this.WeeklyAttendence,
            this.MonthlyAttendence,
            this.summaryToolStripMenuItem});
            this.attendenceToolStripMenuItem1.Name = "attendenceToolStripMenuItem1";
            this.attendenceToolStripMenuItem1.Size = new System.Drawing.Size(135, 22);
            this.attendenceToolStripMenuItem1.Text = "Attendence";
            // 
            // TodayAttendence
            // 
            this.TodayAttendence.Name = "TodayAttendence";
            this.TodayAttendence.Size = new System.Drawing.Size(125, 22);
            this.TodayAttendence.Text = "Today";
            this.TodayAttendence.Click += new System.EventHandler(this.attendenceToolStripMenuItem_Click);
            // 
            // WeeklyAttendence
            // 
            this.WeeklyAttendence.Name = "WeeklyAttendence";
            this.WeeklyAttendence.Size = new System.Drawing.Size(125, 22);
            this.WeeklyAttendence.Text = "Weekly";
            this.WeeklyAttendence.Click += new System.EventHandler(this.WeeklyAttendence_Click);
            // 
            // MonthlyAttendence
            // 
            this.MonthlyAttendence.Name = "MonthlyAttendence";
            this.MonthlyAttendence.Size = new System.Drawing.Size(125, 22);
            this.MonthlyAttendence.Text = "Monthly";
            this.MonthlyAttendence.Click += new System.EventHandler(this.MonthlyAttendence_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.summaryToolStripMenuItem.Text = "Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // menuEditOptions
            // 
            this.menuEditOptions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editSetupToolStripMenuItem});
            this.menuEditOptions.Name = "menuEditOptions";
            this.menuEditOptions.Size = new System.Drawing.Size(135, 22);
            this.menuEditOptions.Text = "Options";
            this.menuEditOptions.Click += new System.EventHandler(this.menuEditOptions_Click);
            // 
            // editSetupToolStripMenuItem
            // 
            this.editSetupToolStripMenuItem.Name = "editSetupToolStripMenuItem";
            this.editSetupToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.editSetupToolStripMenuItem.Text = "Edit Setup";
            this.editSetupToolStripMenuItem.Click += new System.EventHandler(this.editSetupToolStripMenuItem_Click);
            // 
            // MenuExit
            // 
            this.MenuExit.Name = "MenuExit";
            this.MenuExit.Size = new System.Drawing.Size(135, 22);
            this.MenuExit.Text = "Exit";
            this.MenuExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Yu Gothic", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(6, 31);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(340, 82);
            this.lblSchool.TabIndex = 1;
            this.lblSchool.Text = "Welcome!";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(271, 162);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(237, 63);
            this.txtID.TabIndex = 2;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(242, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(311, 36);
            this.label2.TabIndex = 3;
            this.label2.Text = "Please enter your ID.";
            // 
            // bOne
            // 
            this.bOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bOne.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOne.Location = new System.Drawing.Point(188, 231);
            this.bOne.Name = "bOne";
            this.bOne.Size = new System.Drawing.Size(75, 54);
            this.bOne.TabIndex = 4;
            this.bOne.Text = "1";
            this.bOne.UseVisualStyleBackColor = false;
            this.bOne.Click += new System.EventHandler(this.bOne_Click);
            // 
            // bTwo
            // 
            this.bTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bTwo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bTwo.Location = new System.Drawing.Point(271, 231);
            this.bTwo.Name = "bTwo";
            this.bTwo.Size = new System.Drawing.Size(75, 54);
            this.bTwo.TabIndex = 5;
            this.bTwo.Text = "2";
            this.bTwo.UseVisualStyleBackColor = false;
            this.bTwo.Click += new System.EventHandler(this.bTwo_Click);
            // 
            // bThree
            // 
            this.bThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bThree.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bThree.Location = new System.Drawing.Point(352, 231);
            this.bThree.Name = "bThree";
            this.bThree.Size = new System.Drawing.Size(75, 54);
            this.bThree.TabIndex = 6;
            this.bThree.Text = "3";
            this.bThree.UseVisualStyleBackColor = false;
            this.bThree.Click += new System.EventHandler(this.bThree_Click);
            // 
            // bFour
            // 
            this.bFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bFour.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFour.Location = new System.Drawing.Point(433, 231);
            this.bFour.Name = "bFour";
            this.bFour.Size = new System.Drawing.Size(75, 54);
            this.bFour.TabIndex = 7;
            this.bFour.Text = "4";
            this.bFour.UseVisualStyleBackColor = false;
            this.bFour.Click += new System.EventHandler(this.bFour_Click);
            // 
            // bSix
            // 
            this.bSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bSix.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSix.Location = new System.Drawing.Point(188, 291);
            this.bSix.Name = "bSix";
            this.bSix.Size = new System.Drawing.Size(75, 54);
            this.bSix.TabIndex = 8;
            this.bSix.Text = "6";
            this.bSix.UseVisualStyleBackColor = false;
            this.bSix.Click += new System.EventHandler(this.bSix_Click);
            // 
            // bFive
            // 
            this.bFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bFive.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFive.Location = new System.Drawing.Point(514, 231);
            this.bFive.Name = "bFive";
            this.bFive.Size = new System.Drawing.Size(75, 54);
            this.bFive.TabIndex = 9;
            this.bFive.Text = "5";
            this.bFive.UseVisualStyleBackColor = false;
            this.bFive.Click += new System.EventHandler(this.bFive_Click);
            // 
            // bZero
            // 
            this.bZero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bZero.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bZero.Location = new System.Drawing.Point(514, 291);
            this.bZero.Name = "bZero";
            this.bZero.Size = new System.Drawing.Size(75, 54);
            this.bZero.TabIndex = 10;
            this.bZero.Text = "0";
            this.bZero.UseVisualStyleBackColor = false;
            this.bZero.Click += new System.EventHandler(this.bZero_Click);
            // 
            // bNine
            // 
            this.bNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bNine.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bNine.Location = new System.Drawing.Point(433, 291);
            this.bNine.Name = "bNine";
            this.bNine.Size = new System.Drawing.Size(75, 54);
            this.bNine.TabIndex = 11;
            this.bNine.Text = "9";
            this.bNine.UseVisualStyleBackColor = false;
            this.bNine.Click += new System.EventHandler(this.bNine_Click);
            // 
            // bEight
            // 
            this.bEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bEight.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEight.Location = new System.Drawing.Point(352, 291);
            this.bEight.Name = "bEight";
            this.bEight.Size = new System.Drawing.Size(75, 54);
            this.bEight.TabIndex = 12;
            this.bEight.Text = "8";
            this.bEight.UseVisualStyleBackColor = false;
            this.bEight.Click += new System.EventHandler(this.bEight_Click);
            // 
            // bSeven
            // 
            this.bSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bSeven.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeven.Location = new System.Drawing.Point(271, 291);
            this.bSeven.Name = "bSeven";
            this.bSeven.Size = new System.Drawing.Size(75, 54);
            this.bSeven.TabIndex = 13;
            this.bSeven.Text = "7";
            this.bSeven.UseVisualStyleBackColor = false;
            this.bSeven.Click += new System.EventHandler(this.bSeven_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReset.BackgroundImage")));
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.Location = new System.Drawing.Point(188, 162);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(63, 63);
            this.btnReset.TabIndex = 15;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // bRegister
            // 
            this.bRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bRegister.BackgroundImage = global::InSession.Properties.Resources.arrow;
            this.bRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bRegister.Location = new System.Drawing.Point(526, 162);
            this.bRegister.Name = "bRegister";
            this.bRegister.Size = new System.Drawing.Size(63, 63);
            this.bRegister.TabIndex = 14;
            this.bRegister.UseVisualStyleBackColor = false;
            this.bRegister.Click += new System.EventHandler(this.bRegister_Click);
            // 
            // pbMenu
            // 
            this.pbMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbMenu.Image = ((System.Drawing.Image)(resources.GetObject("pbMenu.Image")));
            this.pbMenu.Location = new System.Drawing.Point(747, 12);
            this.pbMenu.Name = "pbMenu";
            this.pbMenu.Size = new System.Drawing.Size(44, 48);
            this.pbMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbMenu.TabIndex = 0;
            this.pbMenu.TabStop = false;
            this.pbMenu.Click += new System.EventHandler(this.Menu_Click);
            // 
            // pbLeft
            // 
            this.pbLeft.Location = new System.Drawing.Point(13, 162);
            this.pbLeft.Name = "pbLeft";
            this.pbLeft.Size = new System.Drawing.Size(169, 183);
            this.pbLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLeft.TabIndex = 16;
            this.pbLeft.TabStop = false;
            // 
            // pbRight
            // 
            this.pbRight.Location = new System.Drawing.Point(595, 162);
            this.pbRight.Name = "pbRight";
            this.pbRight.Size = new System.Drawing.Size(169, 183);
            this.pbRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRight.TabIndex = 17;
            this.pbRight.TabStop = false;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuSoftwareVersion,
            this.menuDatabaseVersion});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(135, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // menuSoftwareVersion
            // 
            this.menuSoftwareVersion.Name = "menuSoftwareVersion";
            this.menuSoftwareVersion.Size = new System.Drawing.Size(161, 22);
            this.menuSoftwareVersion.Text = "Software Version";
            // 
            // menuDatabaseVersion
            // 
            this.menuDatabaseVersion.Name = "menuDatabaseVersion";
            this.menuDatabaseVersion.Size = new System.Drawing.Size(161, 22);
            this.menuDatabaseVersion.Text = "DatabaseVersion";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(803, 391);
            this.Controls.Add(this.pbRight);
            this.Controls.Add(this.pbLeft);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bRegister);
            this.Controls.Add(this.bSeven);
            this.Controls.Add(this.bEight);
            this.Controls.Add(this.bNine);
            this.Controls.Add(this.bZero);
            this.Controls.Add(this.bFive);
            this.Controls.Add(this.bSix);
            this.Controls.Add(this.bFour);
            this.Controls.Add(this.bThree);
            this.Controls.Add(this.bTwo);
            this.Controls.Add(this.bOne);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.pbMenu);
            this.DoubleBuffered = true;
            this.Name = "frmMain";
            this.Text = " InSession";
            this.MainMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog FileBrowser;
        private System.Windows.Forms.ContextMenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuEditPeople;
        private System.Windows.Forms.ToolStripMenuItem MenuEditClasses;
        private System.Windows.Forms.ToolStripMenuItem MenuEditRanks;
        private System.Windows.Forms.ToolStripMenuItem menuEditOptions;
        private System.Windows.Forms.ToolStripMenuItem MenuExit;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bOne;
        private System.Windows.Forms.Button bTwo;
        private System.Windows.Forms.Button bThree;
        private System.Windows.Forms.Button bFour;
        private System.Windows.Forms.Button bSix;
        private System.Windows.Forms.Button bFive;
        private System.Windows.Forms.Button bZero;
        private System.Windows.Forms.Button bNine;
        private System.Windows.Forms.Button bEight;
        private System.Windows.Forms.Button bSeven;
        private System.Windows.Forms.Button bRegister;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.PictureBox pbMenu;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem TodayAttendence;
        private System.Windows.Forms.ToolStripMenuItem WeeklyAttendence;
        private System.Windows.Forms.ToolStripMenuItem MonthlyAttendence;
        private System.Windows.Forms.ToolStripMenuItem editSetupToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLeft;
        private System.Windows.Forms.PictureBox pbRight;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuSoftwareVersion;
        private System.Windows.Forms.ToolStripMenuItem menuDatabaseVersion;
    }
}

