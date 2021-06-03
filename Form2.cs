using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class First : Form
    {
        public First()
        {
            InitializeComponent();
        }

        private void Next_Button_Click(object sender, EventArgs e)
        {
            {
                Second SecondPage = new Second();
                SecondPage.Show();
            }
        }
    }
}
