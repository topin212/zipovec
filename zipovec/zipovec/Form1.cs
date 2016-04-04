using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zipovec {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void addNewFile_Click(object sender, EventArgs e) {
            DialogResult res = saveFileDialog.ShowDialog();
            if (res == DialogResult.OK) {
                MessageBox.Show(saveFileDialog.FileName);
            } else if (res == DialogResult.Cancel) {
                MessageBox.Show("Dialog canceled");
            }
        }

        private void openFileButton_Click(object sender, EventArgs e) {
            DialogResult res = openFileDialog.ShowDialog();
            if(res == DialogResult.OK) {
                MessageBox.Show(openFileDialog.FileName);
            }
        }
    }
}
