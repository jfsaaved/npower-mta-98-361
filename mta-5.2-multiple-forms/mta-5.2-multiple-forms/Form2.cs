using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Threading;

namespace mta_5._2_multiple_forms {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {

            string changeCase = Form1.tb.Text;
            CultureInfo properCase = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfoObject = properCase.TextInfo;

            if (radioButton1.Checked)
                changeCase = changeCase.ToUpper();
            else if (radioButton2.Checked)
                changeCase = changeCase.ToLower();
            else if (radioButton3.Checked)
                changeCase = textInfoObject.ToTitleCase(changeCase);

            Form1.tb.Text = changeCase;

            this.DialogResult = DialogResult.OK;
        }

        private void Button2_Click(object sender, EventArgs e) {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
