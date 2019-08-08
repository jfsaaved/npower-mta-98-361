using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._1_calculator
{
    public partial class Form1 : Form
    {


        double total1 = 0;
        double total2 = 0;
        bool plusButtonClicked = false;
        bool minusButtonClicked = false;
        bool divideButtonClicked = false;
        bool multipleButtonClicked = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnOne.Text;
        }

        private void BtnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnTwo.Text;
        }

        private void TxtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnThree.Text;
        }

        private void BtnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFour.Text;
        }

        private void BtnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnFive.Text;
        }

        private void BtnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSix.Text;
        }

        private void BtnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnSeven.Text;
        }

        private void BtnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnEight.Text;
        }

        private void BtnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnNine.Text;
        }

        private void BtnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnPoint.Text;
        }

        private void BtnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text + btnZero.Text;
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            plusButtonClicked = false;
            minusButtonClicked = false;
            divideButtonClicked = false;
            multipleButtonClicked = false;
            txtDisplay.Clear();
        }

        private void BtnPlus_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = false;
            plusButtonClicked = true;
            divideButtonClicked = false;
            multipleButtonClicked = false;

        }

        private void BtnEquals_Click(object sender, EventArgs e)
        {
            if (plusButtonClicked == true)
            {
                total2 = total1 + double.Parse(txtDisplay.Text);
            }
            else if (minusButtonClicked == true)
            {
                total2 = total1 - double.Parse(txtDisplay.Text);
            }
            else if (multipleButtonClicked == true)
            {
                total2 = total1 * double.Parse(txtDisplay.Text);
            }
            else if (divideButtonClicked == true)
            {
                total2 = total1 / double.Parse(txtDisplay.Text);
            }

            txtDisplay.Text = total2.ToString();
            total1 = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = true;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multipleButtonClicked = false;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = false;
            plusButtonClicked = false;
            divideButtonClicked = false;
            multipleButtonClicked = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            total1 = total1 + double.Parse(txtDisplay.Text);
            txtDisplay.Clear();

            minusButtonClicked = false;
            plusButtonClicked = false;
            divideButtonClicked = true;
            multipleButtonClicked = false;
        }
    }
}
