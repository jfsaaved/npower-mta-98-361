using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_2._1_string_manipulation {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            string stringVar = textBox1.Text;
            textBox1.Text = stringVar.ToUpper();
        }

        private void Button2_Click(object sender, EventArgs e) {
            string strinTrim = textBox2.Text;
            strinTrim = strinTrim.Trim();
            int stringLength = strinTrim.Length;
            textBox2.Text = strinTrim;
            MessageBox.Show(stringLength.ToString());
        }
    }
}
