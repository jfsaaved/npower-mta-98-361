using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._1_variables
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string firstName;
            string messageText;

            messageText = "Your Name Is: ";

            firstName = textBox1.Text;
            MessageBox.Show(messageText + firstName);

            /*
            firstName = textBox1.Text;
            MessageBox.Show(firstName);

            firstName = "Home and Learn";
            MessageBox.Show(firstName);*/
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
