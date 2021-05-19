using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu.Source {

    public class Calculation {

        public long SecondValue { get; set; }
        public long FirstValue { get; set; }
        public Operation Operation { get; set; }

        public Calculation() {
            this.SecondValue = 0;
            this.FirstValue = 0;
        }

    }


}
