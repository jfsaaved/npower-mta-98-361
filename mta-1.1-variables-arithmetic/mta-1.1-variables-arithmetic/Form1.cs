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

        private void Button1_Click(object sender, EventArgs e)
        {
            float firstNumber;
            float secondNumber;
            float floatAnswer;
            int someInteger = 20;

            firstNumber = 10.5F;
            secondNumber = 32.5F;

            floatAnswer = firstNumber + secondNumber + someInteger;

            MessageBox.Show(floatAnswer.ToString());
        }

        private void BtnSubtract_Click(object sender, EventArgs e)
        {
            int answerSubtract;
            int numberOne = 12;
            int numberTwo = 4;

            answerSubtract = 50 - 25;

            MessageBox.Show(answerSubtract.ToString());

            answerSubtract = 50 - numberOne - numberTwo;

            MessageBox.Show(answerSubtract.ToString());



            /*
             * 
             * 
             * Skipping all the other operators 
             */
        }
    }
}
