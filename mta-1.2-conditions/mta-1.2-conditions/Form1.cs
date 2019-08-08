using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._2_conditions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            bool buttonClicked = true;
            if (buttonClicked == true) {
                MessageBox.Show("The boolean is true");
            } else
            {
                MessageBox.Show("The boolean is false");
            }
        }
    }
}
