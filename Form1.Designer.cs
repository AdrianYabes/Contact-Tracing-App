
namespace Contact_Tracing_App
{
    partial class ContactTracingApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContactTracingApp));
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.MidInitial = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.Label();
            this.EmailAddress = new System.Windows.Forms.Label();
            this.Confirm = new System.Windows.Forms.Button();
            this.Reset = new System.Windows.Forms.Button();
            this.HomeAddress = new System.Windows.Forms.Label();
            this.TextBox_First = new System.Windows.Forms.TextBox();
            this.TextBox_Mid = new System.Windows.Forms.TextBox();
            this.textBox_Last = new System.Windows.Forms.TextBox();
            this.TextBox_Gender = new System.Windows.Forms.TextBox();
            this.TextBox_Contact = new System.Windows.Forms.TextBox();
            this.TextBox_Email = new System.Windows.Forms.TextBox();
            this.TextBox_Home = new System.Windows.Forms.TextBox();
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Yu Gothic", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(33, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(498, 42);
            this.label8.TabIndex = 13;
            this.label8.Text = "COVID-19 CONTRACT TRACING";
            this.label8.Click += new System.EventHandler(this.COVID);
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.BackColor = System.Drawing.Color.Transparent;
            this.FirstName.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FirstName.Location = new System.Drawing.Point(49, 95);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(131, 30);
            this.FirstName.TabIndex = 16;
            this.FirstName.Text = "First Name";
            this.FirstName.Click += new System.EventHandler(this.FirstName_Click);
            // 
            // MidInitial
            // 
            this.MidInitial.AutoSize = true;
            this.MidInitial.BackColor = System.Drawing.Color.Transparent;
            this.MidInitial.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MidInitial.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MidInitial.Location = new System.Drawing.Point(49, 136);
            this.MidInitial.Name = "MidInitial";
            this.MidInitial.Size = new System.Drawing.Size(151, 30);
            this.MidInitial.TabIndex = 17;
            this.MidInitial.Text = "Middle Initial";
            this.MidInitial.Click += new System.EventHandler(this.MidInitial_Click);
            // 
            // LastName
            // 
            this.LastName.AutoSize = true;
            this.LastName.BackColor = System.Drawing.Color.Transparent;
            this.LastName.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LastName.Location = new System.Drawing.Point(50, 177);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(130, 30);
            this.LastName.TabIndex = 18;
            this.LastName.Text = "Last Name";
            this.LastName.Click += new System.EventHandler(this.LastName_Click);
            // 
            // Gender
            // 
            this.Gender.AutoSize = true;
            this.Gender.BackColor = System.Drawing.Color.Transparent;
            this.Gender.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Gender.Location = new System.Drawing.Point(49, 224);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(90, 30);
            this.Gender.TabIndex = 19;
            this.Gender.Text = "Gender";
            this.Gender.Click += new System.EventHandler(this.Gender_Click);
            // 
            // ContactNumber
            // 
            this.ContactNumber.AutoSize = true;
            this.ContactNumber.BackColor = System.Drawing.Color.Transparent;
            this.ContactNumber.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ContactNumber.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContactNumber.Location = new System.Drawing.Point(49, 265);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(187, 30);
            this.ContactNumber.TabIndex = 20;
            this.ContactNumber.Text = "Contact Number";
            this.ContactNumber.Click += new System.EventHandler(this.ContactNumber_Click);
            // 
            // EmailAddress
            // 
            this.EmailAddress.AutoSize = true;
            this.EmailAddress.BackColor = System.Drawing.Color.Transparent;
            this.EmailAddress.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.EmailAddress.Location = new System.Drawing.Point(49, 306);
            this.EmailAddress.Name = "EmailAddress";
            this.EmailAddress.Size = new System.Drawing.Size(165, 30);
            this.EmailAddress.TabIndex = 21;
            this.EmailAddress.Text = "Email Address";
            this.EmailAddress.Click += new System.EventHandler(this.EmailAddress_Click);
            // 
            // Confirm
            // 
            this.Confirm.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Confirm.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Confirm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Confirm.Location = new System.Drawing.Point(353, 425);
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
            this.Reset.Location = new System.Drawing.Point(134, 425);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(94, 29);
            this.Reset.TabIndex = 23;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = false;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // HomeAddress
            // 
            this.HomeAddress.AutoSize = true;
            this.HomeAddress.BackColor = System.Drawing.Color.Transparent;
            this.HomeAddress.Font = new System.Drawing.Font("Yu Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HomeAddress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.HomeAddress.Location = new System.Drawing.Point(49, 348);
            this.HomeAddress.Name = "HomeAddress";
            this.HomeAddress.Size = new System.Drawing.Size(175, 30);
            this.HomeAddress.TabIndex = 24;
            this.HomeAddress.Text = "Homel Address";
            this.HomeAddress.Click += new System.EventHandler(this.HomeAddress_Click_1);
            // 
            // TextBox_First
            // 
            this.TextBox_First.BackColor = System.Drawing.Color.Black;
            this.TextBox_First.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_First.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_First.Location = new System.Drawing.Point(260, 90);
            this.TextBox_First.Name = "TextBox_First";
            this.TextBox_First.Size = new System.Drawing.Size(253, 35);
            this.TextBox_First.TabIndex = 25;
            this.TextBox_First.TextChanged += new System.EventHandler(this.TextBox_First_TextChanged);
            // 
            // TextBox_Mid
            // 
            this.TextBox_Mid.BackColor = System.Drawing.Color.Black;
            this.TextBox_Mid.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Mid.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Mid.Location = new System.Drawing.Point(260, 131);
            this.TextBox_Mid.Name = "TextBox_Mid";
            this.TextBox_Mid.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Mid.TabIndex = 26;
            this.TextBox_Mid.TextChanged += new System.EventHandler(this.TextBox_Mid_TextChanged);
            // 
            // textBox_Last
            // 
            this.textBox_Last.BackColor = System.Drawing.Color.Black;
            this.textBox_Last.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Last.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Last.Location = new System.Drawing.Point(260, 172);
            this.textBox_Last.Name = "textBox_Last";
            this.textBox_Last.Size = new System.Drawing.Size(253, 35);
            this.textBox_Last.TabIndex = 27;
            this.textBox_Last.TextChanged += new System.EventHandler(this.textBox_Last_TextChanged);
            // 
            // TextBox_Gender
            // 
            this.TextBox_Gender.BackColor = System.Drawing.Color.Black;
            this.TextBox_Gender.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Gender.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Gender.Location = new System.Drawing.Point(260, 213);
            this.TextBox_Gender.Name = "TextBox_Gender";
            this.TextBox_Gender.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Gender.TabIndex = 28;
            this.TextBox_Gender.TextChanged += new System.EventHandler(this.TextBox_Gender_TextChanged);
            // 
            // TextBox_Contact
            // 
            this.TextBox_Contact.BackColor = System.Drawing.Color.Black;
            this.TextBox_Contact.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Contact.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Contact.Location = new System.Drawing.Point(260, 254);
            this.TextBox_Contact.Name = "TextBox_Contact";
            this.TextBox_Contact.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Contact.TabIndex = 29;
            this.TextBox_Contact.TextChanged += new System.EventHandler(this.TextBox_Contact_TextChanged);
            // 
            // TextBox_Email
            // 
            this.TextBox_Email.BackColor = System.Drawing.Color.Black;
            this.TextBox_Email.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Email.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Email.Location = new System.Drawing.Point(260, 295);
            this.TextBox_Email.Name = "TextBox_Email";
            this.TextBox_Email.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Email.TabIndex = 30;
            this.TextBox_Email.TextChanged += new System.EventHandler(this.TextBox_Email_TextChanged);
            // 
            // TextBox_Home
            // 
            this.TextBox_Home.BackColor = System.Drawing.Color.Black;
            this.TextBox_Home.Font = new System.Drawing.Font("Yu Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Home.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TextBox_Home.Location = new System.Drawing.Point(260, 336);
            this.TextBox_Home.Name = "TextBox_Home";
            this.TextBox_Home.Size = new System.Drawing.Size(253, 35);
            this.TextBox_Home.TabIndex = 31;
            this.TextBox_Home.TextChanged += new System.EventHandler(this.TextBox_Home_TextChanged);
            // 
            // ContactTracingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(564, 496);
            this.Controls.Add(this.TextBox_Home);
            this.Controls.Add(this.TextBox_Email);
            this.Controls.Add(this.TextBox_Contact);
            this.Controls.Add(this.TextBox_Gender);
            this.Controls.Add(this.textBox_Last);
            this.Controls.Add(this.TextBox_Mid);
            this.Controls.Add(this.TextBox_First);
            this.Controls.Add(this.HomeAddress);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Confirm);
            this.Controls.Add(this.EmailAddress);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.MidInitial);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Name = "ContactTracingApp";
            this.Text = "COVID Contact Tracing App";
            this.Load += new System.EventHandler(this.ContactTracingApp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label MiddleInitial;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Label MidInitial;
        private System.Windows.Forms.Label LastName;
        private System.Windows.Forms.Label Gender;
        private System.Windows.Forms.Label ContactNumber;
        private System.Windows.Forms.Label EmailAddress;
        private System.Windows.Forms.Button Confirm;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Label HomeAddress;
        private System.Windows.Forms.TextBox TextBox_First;
        private System.Windows.Forms.TextBox TextBox_Mid;
        private System.Windows.Forms.TextBox textBox_Last;
        private System.Windows.Forms.TextBox TextBox_Gender;
        private System.Windows.Forms.TextBox TextBox_Contact;
        private System.Windows.Forms.TextBox TextBox_Email;
        private System.Windows.Forms.TextBox TextBox_Home;
    }
}

