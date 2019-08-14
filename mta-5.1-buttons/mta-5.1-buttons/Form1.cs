using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_5._1_buttons {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            string movies = "";
            if(checkBox1.Checked) {
                movies += checkBox1.Text + Environment.NewLine;
            }
            if (checkBox2.Checked) {
                movies += checkBox2.Text + Environment.NewLine;
            }
            if (checkBox3.Checked) {
                movies += checkBox3.Text + Environment.NewLine;
            }
            if (checkBox4.Checked) {
                movies += checkBox4.Text + Environment.NewLine;
            }
            if (checkBox5.Checked) {
                movies += checkBox5.Text + Environment.NewLine;
            }

            MessageBox.Show(movies);
        }

        private void Button2_Click(object sender, EventArgs e) {
            string chosenMovies = "";
            if (radioButton1.Checked) {
                chosenMovies = radioButton1.Text;
            }
            else if (radioButton2.Checked) {
                chosenMovies = radioButton2.Text;
            }
            else if (radioButton3.Checked) {
                chosenMovies = radioButton3.Text;
            }
            else if (radioButton4.Checked) {
                chosenMovies = radioButton4.Text;
            }
            else if (radioButton5.Checked) {
                chosenMovies = radioButton5.Text;
            }

            MessageBox.Show("Your favourite type of movie is: " + chosenMovies);
        }
    }
}
