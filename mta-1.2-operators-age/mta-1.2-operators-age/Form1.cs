using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._2_operators_age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AgeButton_Click(object sender, EventArgs e)
        {
            String msg = "";
            if (int.TryParse(input.Text, out int n) == true)
            {
                int val = int.Parse(input.Text);
                if (val <= 16) msg = "You're still a youngster!";
                else if (val > 16 && val <= 25) msg = "Fame beckons!";
                else if (val > 25 && val <= 40) msg = "There's still time.";
                else if (val > 40) msg = "Oh dear, you've probably missed it!";
            } else
            {
                msg = "Invalid age! Please type in a number.";
            }


            MessageBox.Show(msg);
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
