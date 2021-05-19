using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViDu {
    public partial class BaiTap1 : Form {
        public BaiTap1() {
            InitializeComponent();
        }


        private void onButtonC1Click(object sender, EventArgs e) {
            int input = 0;
            try {
                input = Int32.Parse(this.tbInput.Text);
            }
            catch (FormatException exception) {
                MessageBox.Show("Vui lòng nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Solution 1: " + input);
        }

        private void onButtonC2Click(object sender, EventArgs e) {
            int input = 0;
            try {
                input = Int32.Parse(this.tbInput.Text);
            }
            catch (FormatException exception) {
                MessageBox.Show("Vui lòng nhập số!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Solution 2: " + input);
        }

        private void onButtonC3Click(object sender, EventArgs e) {

        }
    }
}
