using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Contact_Tracing_App
{
    public partial class Third : Form
    {
        public Third()
        {
            InitializeComponent();
        }

        private void HumanDisplayOfInformation_TextChanged(object sender, EventArgs e)
        {
            StreamReader HumanInformation;
            HumanInformation = File.OpenText(@"D:\BSCpE-2ND SEMESTER\COVID Contact Tracing App.txt");
            while (!HumanInformation.EndOfStream)
            {
                HumanDisplayOfInformation.Text = (HumanInformation.ReadToEnd());
            }
        }
    }
}
