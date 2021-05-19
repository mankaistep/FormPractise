using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu.Source {

    public class Manager {

        private Calculation cal;

        public Manager(Calculation cal) {
            this.cal = cal;
        }

        public Calculation GetCalculation() {
            return this.cal;
        }

        public void SetOperation(Operation o) {
            cal.Operation = o;

            // Switch main vs sub
            long t = cal.SecondValue;
            cal.SecondValue = cal.FirstValue;
            cal.FirstValue = t;
        }

        public void SetValue(long value) {
            cal.SecondValue = value;
        }

        public bool CanExecute() {
            if (cal.Operation == null) return false;
            if (cal.Operation == Operation.Divide && cal.SecondValue == 0) return false;
            return true;
        }

        public long ToLong(string old, string add) {
            return Convert.ToInt64(old + add);
        }

        public long Enter() {
            long value = cal.Operation.Execute(cal.FirstValue, cal.SecondValue);
            cal.Operation = null;
            cal.SecondValue = value;
            cal.FirstValue = 0;
            return value;
        }

        // Just github test
        // Shut the fuck up
    }

}
