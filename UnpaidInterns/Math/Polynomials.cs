using System.Security.Cryptography;

public static class polyMath {
    class term {
        char variable;
        int coefficient;
        int exponent;

        public term(char v, int c, int e) {
            this.variable = v;
            this.coefficient = c;
            this.exponent = e;
        }

        void derivative() {
            this.coefficient *= this.exponent;
            this.exponent -= 1;
        }
    }

    class polyNomial {
        List<term> terms = new List<term>();

        public polyNomial(List<term> ins) {
            foreach(term x in ins) {
                terms.Add(x);
            }
        }
    }
}