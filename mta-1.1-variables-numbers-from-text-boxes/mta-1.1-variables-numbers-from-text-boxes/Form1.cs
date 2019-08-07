using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._1_variables_numbers_from_text_boxes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, EventArgs e)
        {
            int firstTextBoxNumber;
            int answer;

            firstTextBoxNumber = int.Parse(tbFirstNumber.Text);

            MessageBox.Show(firstTextBoxNumber.ToString());
        }
    }
}
