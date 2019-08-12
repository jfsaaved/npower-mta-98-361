﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._3_loops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int loopStart;
        int loopEnd;
        int multiplyBy;

        private void Button1_Click(object sender, EventArgs e)
        {
            int answer = 0;

            listBox1.Items.Clear();

            int outputVal = 0;
            if(int.TryParse(textBox1.Text, out outputVal) == false || int.TryParse(textBox2.Text, out outputVal) == false || int.TryParse(textBox3.Text, out outputVal) == false)
            {
                MessageBox.Show("Invalid numbers");
            } else
            {


            
                loopStart = int.Parse(textBox1.Text);
                loopEnd = int.Parse(textBox2.Text);
                multiplyBy = int.Parse(textBox3.Text);

                /*
                for (int i = loopStart; i < loopEnd + 1; i++) // or <= loopEnd
                {
                    answer = answer + i;
                    listBox1.Items.Add("i = " + i + " answer = " + answer.ToString());
                }*/


                for(int i = loopStart; i <= loopEnd; i++)
                {
                    answer = multiplyBy * i;
                    listBox1.Items.Add(i.ToString() + " times " + multiplyBy.ToString() + " = " + answer.ToString());
                }

                /*
                int i = 0;
                while(i <= loopEnd)
                {
                    answer = multiplyBy * i;
                    listBox1.Items.Add(i.ToString() + " times " + multiplyBy.ToString() + " = " + answer.ToString());
                    i++;
                }

                do
                {
                    answer = multiplyBy * if;
                    listBox1.Items.Add(i.ToString() + " times " + multiplyBy.ToString() + " = " + answer.ToString());
                    i++;
                } while (i <= loopEnd);
                */
            }

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}