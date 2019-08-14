using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mta_5._1_add_menus_to_your_forms {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void MnuSave_Click(object sender, EventArgs e) {
            string savedFile = "";

            saveFD.InitialDirectory = "C:";
            saveFD.Title = "Save a text file";
            saveFD.FileName = "";

            saveFD.Filter = "TextFiles|*.txt|All Files|*.*";

            if(saveFD.ShowDialog() != DialogResult.Cancel) {
                savedFile = saveFD.FileName;
                richTextBox1.SaveFile(savedFile, RichTextBoxStreamType.PlainText);
            }
        }

        private void MnuQuit_Click(object sender, EventArgs e) {
            if(MessageBox.Show("Really Quit?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
                Application.Exit();
        }

        private void MnuCut_Click(object sender, EventArgs e) {
            if (textBox1.SelectedText != "") {
                textBox1.Cut();
            }
        }

        private void MnuUndo_Click(object sender, EventArgs e) {
            if (textBox1.CanUndo == true) {
                textBox1.Undo();
                textBox1.ClearUndo();
            }
        }

        private void MnuCopy_Click(object sender, EventArgs e) {
            if (textBox1.SelectionLength > 0) {
                textBox1.Copy();
            }
        }

        private void MnuPaste_Click(object sender, EventArgs e) {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true) {
                textBox2.Paste();
                Clipboard.Clear();
            }
        }

        private void MnuViewTextBoxes_Click(object sender, EventArgs e) {
            if (mnuViewTextboxes.Checked) {
                textBox1.Visible = true;
                textBox2.Visible = true;
            }
            else {
                textBox1.Visible = false;
                textBox2.Visible = false;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e) {

        }

        private void MnuViewImages_Click(object sender, EventArgs e) {
            string chosenFile = "";
            openFD.InitialDirectory = "C:";
            openFD.Title = "Insert an Image";
            openFD.FileName = "";
            openFD.Filter = "JPEG Images|*.jpg|All Files|*.*";
            openFD.ShowDialog();

            if(openFD.ShowDialog() == DialogResult.Cancel) {
                MessageBox.Show("Operation Cancelled");
            } else { 
                chosenFile = openFD.FileName;
                pictureBox1.Image = Image.FromFile(chosenFile);
            }
        }

        private void MnuOpen_Click(object sender, EventArgs e) {
            string Chosen_File = "";
            openFD.InitialDirectory = "C:";
            openFD.Title = "Open a Text File";
            openFD.FileName = "";
            if (openFD.ShowDialog() != DialogResult.Cancel) {
                Chosen_File = openFD.FileName;
                richTextBox1.LoadFile(Chosen_File, RichTextBoxStreamType.PlainText);
            }
        }
    }
}
