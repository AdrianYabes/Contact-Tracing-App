using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class ContactTracingApp : Form
    {
        public ContactTracingApp()
        {
            InitializeComponent();
        }

        private void ContactTracingApp_Load(object sender, EventArgs e)
        {

        }


        private void COVID(object sender, EventArgs e)
        {

        }




        private void Information_Click(object sender, EventArgs e)
        {

        }

        private void FirstName_Click(object sender, EventArgs e)
        {

        }

        private void MidInitial_Click(object sender, EventArgs e)
        {

        }

        private void LastName_Click(object sender, EventArgs e)
        {

        }

        private void Gender_Click(object sender, EventArgs e)
        {

        }

        private void ContactNumber_Click(object sender, EventArgs e)
        {

        }

        private void EmailAddress_Click(object sender, EventArgs e)
        {

        }


        private void HomeAddress_Click_1(object sender, EventArgs e)
        {

        }
        private void Confirm_Click(object sender, EventArgs e)
        {

        }

        private void Reset_Click(object sender, EventArgs e)
        {
            
        }

        private void TextBox_First_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Mid_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Gender_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_Last_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Contact_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox_Home_TextChanged(object sender, EventArgs e)
        {

        }

        private void Reset_Button(object sender, EventArgs e)
        {
            TextBox_First.Text = "";
            TextBox_Mid.Text = "";
            textBox_Last.Text = "";
            TextBox_Gender.Text = "";
            TextBox_Contact.Text = "";
            TextBox_Email.Text = "";
            TextBox_Home.Text = "";
            MessageBox.Show("Your Information is secured. Stay safe and Godbless!");
        }
    }
}
