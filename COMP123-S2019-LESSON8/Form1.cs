using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_LESSON8
{
    public partial class Form1 : Form
    {
        public Form1()
        { 

        InitializeComponent();
        }
        public string UserName { get; set; }
        public float userAge { get; set; }
        
        /// <summary>
        /// this is the event handler for the SumbitButton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;
            userAge = float.Parse(AgeTextBox.Text);
            OutputLabel1.Text = NameTextBox.Text + "" + AgeTextBox.Text;
            NameTextBox.Text = string.Empty;
            AgeTextBox.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SumbitButton.Enabled = true;
        }

        private void info_TextChanged(object sender, EventArgs e)
        {
            SumbitButton.Enabled = false;

        }
    }
}
