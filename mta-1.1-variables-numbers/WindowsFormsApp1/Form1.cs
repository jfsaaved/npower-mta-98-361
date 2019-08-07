using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int myInteger;
            myInteger = 25;

            MessageBox.Show(myInteger.ToString());
        }

        private void BtnFloat_Click(object sender, EventArgs e)
        {
            float myFloat;
            myFloat = 0.42F; // Leave F on, otherwise C# will treat it as a double

            MessageBox.Show(myFloat.ToString()); 

            float myFloat2;
            myFloat2 = 12345.1245F; // Note float numbers can only hold 7 numbers
            MessageBox.Show(myFloat2.ToString());
        }

        private void BtnDouble_Click(object sender, EventArgs e)
        {
            double myDouble;

            myDouble = 0.007;

            MessageBox.Show(myDouble.ToString());
        }
    }
}
