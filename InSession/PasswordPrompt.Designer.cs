namespace InSession
{
    partial class PasswordPrompt
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chxStayAdmin = new System.Windows.Forms.CheckBox();
            this.bSubmit = new System.Windows.Forms.Button();
            this.bCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "What is the admin password?";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(189, 25);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(209, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // chxStayAdmin
            // 
            this.chxStayAdmin.AutoSize = true;
            this.chxStayAdmin.Location = new System.Drawing.Point(40, 57);
            this.chxStayAdmin.Name = "chxStayAdmin";
            this.chxStayAdmin.Size = new System.Drawing.Size(189, 17);
            this.chxStayAdmin.TabIndex = 5;
            this.chxStayAdmin.Text = "Keep me logged in for this session.";
            this.chxStayAdmin.UseVisualStyleBackColor = true;
            // 
            // bSubmit
            // 
            this.bSubmit.Location = new System.Drawing.Point(322, 52);
            this.bSubmit.Name = "bSubmit";
            this.bSubmit.Size = new System.Drawing.Size(75, 23);
            this.bSubmit.TabIndex = 6;
            this.bSubmit.Text = "Submit";
            this.bSubmit.UseVisualStyleBackColor = true;
            this.bSubmit.Click += new System.EventHandler(this.bSubmit_Click);
            // 
            // bCancel
            // 
            this.bCancel.Location = new System.Drawing.Point(241, 53);
            this.bCancel.Name = "bCancel";
            this.bCancel.Size = new System.Drawing.Size(75, 23);
            this.bCancel.TabIndex = 7;
            this.bCancel.Text = "Cancel";
            this.bCancel.UseVisualStyleBackColor = true;
            this.bCancel.Click += new System.EventHandler(this.bCancel_Click);
            // 
            // PasswordPrompt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 110);
            this.Controls.Add(this.bCancel);
            this.Controls.Add(this.bSubmit);
            this.Controls.Add(this.chxStayAdmin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Name = "PasswordPrompt";
            this.Text = "Password Prompt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chxStayAdmin;
        private System.Windows.Forms.Button bSubmit;
        private System.Windows.Forms.Button bCancel;
    }
}