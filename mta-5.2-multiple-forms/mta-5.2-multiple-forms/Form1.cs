using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_5._2_multiple_forms {
    public partial class Form1 : Form {

        Form2 secondForm;
        public static TextBox tb = new TextBox();

        public Form1() {
            InitializeComponent();
            secondForm = new Form2();
        }

        private void BtnFormTwo_Click(object sender, EventArgs e) {


            if(secondForm.ShowDialog() == DialogResult.OK) {
                MessageBox.Show("OK Button Clicked");
            }
        }

        private void Form1_Load(object sender, EventArgs e) {
            tb = txtChangeCase;
        }
    }
}
