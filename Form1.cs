using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class Second : Form
    {
        public Second()
        {
            InitializeComponent();
        }

        private void ContactTracingApp_Load(object sender, EventArgs e)
        {

        }

        private void COVID(object sender, EventArgs e)
        {

        }

        private void Reset_Button(object sender, EventArgs e)
        {
            TextBox_First.Text = "";
            TextBox_Mid.Text = "";
            TextBox_Last.Text = "";
            TextBox_Gender.Text = "";
            TextBox_Contact.Text = "";
            TextBox_Email.Text = "";
            TextBox_Home.Text = "";
            TextBox_Date.Text = "";
            MessageBox.Show("Your Information is secured. Stay safe and Godbless!", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Confirm_Click(object sender, EventArgs e)
        {
            StreamWriter ContactTracingInformation;
            ContactTracingInformation = File.AppendText(@"D:\BSCpE-2ND SEMESTER\COVID Contact Tracing App.txt");
            ContactTracingInformation.WriteLine(FirstName.Text + ":" + TextBox_First.Text);
            ContactTracingInformation.WriteLine(LastName.Text + ":" + TextBox_Last.Text);
            ContactTracingInformation.WriteLine(MidInitial.Text + ":" + TextBox_Mid.Text);
            ContactTracingInformation.WriteLine(Gender.Text + ":" + TextBox_Gender.Text);
            ContactTracingInformation.WriteLine(ContactNumber.Text + ":" + TextBox_Contact.Text);
            ContactTracingInformation.WriteLine(EmailAddress.Text + ":" + TextBox_Email.Text);
            ContactTracingInformation.WriteLine(HomeAddress.Text + ":" + TextBox_Home.Text);
            ContactTracingInformation.WriteLine(Date.Text + ":" + TextBox_Date.Text);
            ContactTracingInformation.WriteLine("........................................................");
            ContactTracingInformation.Close();

            MessageBox.Show("Thank you for cooperation. Stay safe and Godbless.", "Thank you!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Third ThirdPage = new Third();
            ThirdPage.Show();
        }
    }
}
