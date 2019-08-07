using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._1_variables_arithmetic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            int firstNumber;
            int secondNumber;
            int integerAnswer;

            firstNumber = 10;
            secondNumber = 32;

            integerAnswer = firstNumber + secondNumber;

            MessageBox.Show(integerAnswer.ToString());
        }
    }
}
