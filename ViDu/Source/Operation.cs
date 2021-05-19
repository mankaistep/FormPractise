using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViDu.Source {

    public abstract class Operation {

        public static Operation Add = new AddOperation("+");
        public static Operation Subtract = new SubtractOperation("-");
        public static Operation Multi = new MultiOperation("*");
        public static Operation Divide = new DivideOperation("/");

        private static List<Operation> list = new List<Operation>() {Add, Subtract, Multi, Divide};

        public static Operation Parse(String s) {
            foreach (var o in list) {
                if (o.Character.Equals(s)) return o;
            }
            return null;
        }

        public string Character { get; set; }

        public Operation(string character) {
            this.Character = character;
        }

        public abstract long Execute(long v1, long v2);

    }

    class AddOperation : Operation {

        public AddOperation(string character) : base(character) { }

        public override long Execute(long v1, long v2) {
            return v1 + v2;
        }
    }

    class SubtractOperation : Operation {

        public SubtractOperation(string character) : base(character) { }

        public override long Execute(long v1, long v2) {
            return v1 - v2;
        }
    }

    class MultiOperation : Operation {

        public MultiOperation(string character) : base(character) { }

        public override long Execute(long v1, long v2) {
            return v1 * v2;
        }
    }

    class DivideOperation : Operation {

        public DivideOperation(string character) : base(character) { }

        public override long Execute(long v1, long v2) {
            return v1 / v2;
        }
    }



}
