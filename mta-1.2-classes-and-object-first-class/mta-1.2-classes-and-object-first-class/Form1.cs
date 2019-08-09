using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_1._2_classes_and_object_first_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            HappyBirthday birthdayMessage;
            birthdayMessage = new HappyBirthday();

            String returnMessage;
            birthdayMessage.MyProperty = "Julian";
            returnMessage = birthdayMessage.MyProperty;
            MessageBox.Show(returnMessage);
            //MessageBox.Show(birthdayMessage.getMessage("Julian"));
        }
    }
}
