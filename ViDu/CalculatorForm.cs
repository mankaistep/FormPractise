using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViDu.Source;

namespace ViDu {

    public partial class CalculatorForm : Form {

        private Manager manager;

        public CalculatorForm() {
            InitializeComponent();

            // Init manager
            var cal = new Calculation();
            this.manager = new Manager(cal);
        }

        private void SetValue() {
            this.tbSecondValue.Text = manager.GetCalculation().SecondValue + "";
            this.tbFirstValue.Text = manager.GetCalculation().FirstValue + "";
            if (manager.GetCalculation().Operation != null) this.tbOperator.Text = manager.GetCalculation().Operation.Character;
            else this.tbOperator.Text = "";
        }

        private void OnNumberClick(object sender, EventArgs e) {
            var button = (Button) sender;
            string add = button.Text;
            long value = this.manager.ToLong(this.tbSecondValue.Text, add);
            this.manager.SetValue(value);
            SetValue();
        }

        private void OnOperationClick(object sender, EventArgs e) {
            var button = (Button) sender;
            string operation = button.Text;
            this.manager.SetOperation(Operation.Parse(operation));
            SetValue();
        }

        private void OnClearClick(object sender, EventArgs e) {
            this.manager.SetValue(0);
            SetValue();
        }

        private void OnEnterClick(object sender, EventArgs e) {
            if (!this.manager.CanExecute()) {
                MessageBox.Show("Xảy ra lỗi!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.manager.Enter();
            SetValue();
        }

    }

}
