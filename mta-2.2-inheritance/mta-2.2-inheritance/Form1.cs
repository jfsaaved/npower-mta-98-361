using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_2._2_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e) {
            BirthdayParty partyOn = new BirthdayParty();

            MessageBox.Show(partyOn.getMessage("Julian"));
            MessageBox.Show(partyOn.getPresents(8));
            MessageBox.Show(partyOn.getParty(true));
        }

        private void Button2_Click(object sender, EventArgs e) {
            string answer;
            answer = stats.addUp(5, 4).ToString();
            MessageBox.Show(answer);
        }
    }
}
