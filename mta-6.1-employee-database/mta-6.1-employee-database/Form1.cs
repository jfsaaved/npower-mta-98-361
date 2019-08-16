using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_6._1_employee_database {
    public partial class Form1 : Form {

        DatabaseConnection objConnection;
        string conString;

        DataSet ds;
        DataRow dRow;

        int maxRows;
        int inc = 0;


        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            try {
                objConnection = new DatabaseConnection();
                conString = Properties.Settings.Default.EmployeeConnectionString;

                objConnection.connection_string = conString;
                objConnection.Sql = Properties.Settings.Default.SQL;

                ds = objConnection.GetConnection;
                maxRows = ds.Tables[0].Rows.Count;

                NavigateRecords();

            } catch (Exception err) {
                MessageBox.Show(err.Message);
            }
        }

        private void NavigateRecords () {
            dRow = ds.Tables[0].Rows[0];
            textBox1.Text = dRow.ItemArray.GetValue(1).ToString();
            textBox2.Text = dRow.ItemArray.GetValue(2).ToString();
            textBox3.Text = dRow.ItemArray.GetValue(3).ToString();
            textBox4.Text = dRow.ItemArray.GetValue(4).ToString();
        }
    }
}
