
namespace Contact_Tracing_App
{
    partial class Second
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Second));
            this.label6 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.MidInitial = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.HomeAddress = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.TextBox_Date = new System.Windows.Forms.TextBox();
            this.TextBox_Home = new System.Windows.Forms.TextBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Gender = new System.Windows.Forms.TextBox();
            this.TextBox_Contact = new System.Windows.Forms.TextBox();
            this.TextBox_Last = new System.Windows.Forms.TextBox();
            this.TextBox_Mid = new System.Windows.Forms.TextBox();
            this.TextBox_First = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(33, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 30);
            this.label6.TabIndex = 5;
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstName.Location = new System.Drawing.Point(39, 90);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(131, 30);
            this.FirstName.TabIndex = 16;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.COVID);
            // 
            // MidInitial
            // 
            this.MidInitial.AutoSize = true;
            this.MidInitial.BackColor = System.Drawing.Color.Transparent;
            this.MidInitial.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MidInitial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MidInitial.Location = new System.Drawing.Point(39, 131);
            this.MidInitial.Name = "MidInitial";
            this.MidInitial.Size = new System.Drawing.Size(151, 30);
            this.MidInitial.TabIndex = 17;
            this.MidInitial.Text = "Middle Initial";
            this.MidInitial.Click += new System.EventHandler(this.COVID);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastName.Location = new System.Drawing.Point(39, 172);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(130, 30);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.COVID);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gender.Location = new System.Drawing.Point(39, 218);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(90, 30);
            this.Gender.TabIndex = 19;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.COVID);
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.ContactNumber.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactNumber.Location = new System.Drawing.Point(39, 259);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(187, 30);
            this.ContactNumber.TabIndex = 20;
            this.ContactNumber.Text = "Contact Number";
            this.ContactNumber.Click += new System.EventHandler(this.COVID);
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.EmailAddress.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailAddress.Location = new System.Drawing.Point(39, 300);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(165, 30);
            this.EmailAddress.TabIndex = 21;
            this.EmailAddress.Text = "Email Address";
            this.EmailAddress.Click += new System.EventHandler(this.COVID);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirm.Location = new System.Drawing.Point(349, 445);
            this.Confirm.Name = "Confirm";
            this.Confirm.Size = new System.Drawing.Size(94, 29);
            this.Confirm.TabIndex = 22;
            this.Confirm.Text = "Confirm";
            this.Confirm.UseVisualStyleBackColor = false;
            this.Confirm.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // Reset
            // 
            this.Reset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Reset.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Reset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Reset.Location = new System.Drawing.Point(142, 445);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 23;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Button);
            // 
            // HomeAddress
            // 
            this.HomeAddress.AutoSize = true;
            this.HomeAddress.BackColor = System.Drawing.Color.Transparent;
            this.HomeAddress.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeAddress.Location = new System.Drawing.Point(39, 341);
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.Size = new System.Drawing.Size(175, 30);
            this.HomeAddress.TabIndex = 24;
            this.HomeAddress.Text = "Homel Address";
            this.HomeAddress.Click += new System.EventHandler(this.COVID);
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.BackColor = System.Drawing.Color.Transparent;
            this.Date.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Date.Location = new System.Drawing.Point(37, 382);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(217, 30);
            this.Date.TabIndex = 32;
            this.Date.Text = "Date [DD/MM/YY]";
            this.Date.Click += new System.EventHandler(this.COVID);
            // 
            // TextBox_Date
            // 
            this.TextBox_Date.BackColor = System.Drawing.Color.Black;
            this.TextBox_Date.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Date.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Date.Location = new System.Drawing.Point(260, 377);
            this.TextBox_Date.Name = "TextBox_Date";
            this.TextBox_Date.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Date.TabIndex = 33;
            // 
            // TextBox_Home
            // 
            this.TextBox_Home.BackColor = System.Drawing.Color.Black;
            this.TextBox_Home.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Home.Location = new System.Drawing.Point(260, 336);
            this.TextBox_Home.Name = "TextBox_Home";
            this.TextBox_Home.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Home.TabIndex = 34;
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.BackColor = System.Drawing.Color.Black;
            this.TextBox_Email.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Email.Location = new System.Drawing.Point(260, 295);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Email.TabIndex = 35;
            // 
            // TextBox_Gender
            // 
            this.TextBox_Gender.BackColor = System.Drawing.Color.Black;
            this.TextBox_Gender.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Gender.Location = new System.Drawing.Point(260, 213);
            this.TextBox_Gender.Name = "TextBox_Gender";
            this.TextBox_Gender.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Gender.TabIndex = 36;
            // 
            // TextBox_Contact
            // 
            this.TextBox_Contact.BackColor = System.Drawing.Color.Black;
            this.TextBox_Contact.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Contact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Contact.Location = new System.Drawing.Point(260, 254);
            this.TextBox_Contact.Name = "TextBox_Contact";
            this.TextBox_Contact.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Contact.TabIndex = 36;
            // 
            // TextBox_Last
            // 
            this.TextBox_Last.BackColor = System.Drawing.Color.Black;
            this.TextBox_Last.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Last.Location = new System.Drawing.Point(260, 172);
            this.TextBox_Last.Name = "TextBox_Last";
            this.TextBox_Last.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Last.TabIndex = 37;
            // 
            // TextBox_Mid
            // 
            this.TextBox_Mid.BackColor = System.Drawing.Color.Black;
            this.TextBox_Mid.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Mid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Mid.Location = new System.Drawing.Point(260, 131);
            this.TextBox_Mid.Name = "TextBox_Mid";
            this.TextBox_Mid.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Mid.TabIndex = 38;
            // 
            // TextBox_First
            // 
            this.TextBox_First.BackColor = System.Drawing.Color.Black;
            this.TextBox_First.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_First.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_First.Location = new System.Drawing.Point(260, 90);
            this.TextBox_First.Name = "TextBox_First";
            this.TextBox_First.Size = new System.Drawing.Size(253, 35);
            this.TextBox_First.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(33, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 43);
            this.label1.TabIndex = 40;
            this.label1.Text = "COVID-19 CONTACT TRACING";
            // 
            // Second
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(562, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextBox_First);
            this.Controls.Add(this.TextBox_Mid);
            this.Controls.Add(this.TextBox_Last);
            this.Controls.Add(this.TextBox_Contact);
            this.Controls.Add(this.TextBox_Gender);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_Home);
            this.Controls.Add(this.TextBox_Date);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.HomeAddress);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MidInitial);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Second";
            this.Text = "COVID Contact Tracing App";
            this.Load += new System.EventHandler(this.COVID);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MidInitial;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label HomeAddress;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.TextBox TextBox_Date;
        private System.Windows.Forms.TextBox TextBox_Home;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_Gender;
        private System.Windows.Forms.TextBox TextBox_Last;
        private System.Windows.Forms.TextBox TextBox_Mid;
        private System.Windows.Forms.TextBox TextBox_First;
        private System.Windows.Forms.TextBox TextBox_Contact;
        private System.Windows.Forms.Label label1;
    }
}

