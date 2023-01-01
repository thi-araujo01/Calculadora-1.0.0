namespace Calculadora_1._0._0 {
    class Calc {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        public double Result { get; set; }

        public Calc(double num1, double num2) {
            Num1 = num1;
            Num2 = num2;
        }

        public double Soma(double num1, double num2) {
            return num1 + num2;
        }

        public double Subt(double num1, double num2) {
            return num1 - num2;
        }

        public double Multip(double num1, double num2) {
            return num1 * num2;
        }

        public double Divisao(double num1, double num2) {
            return num1 / num2;
        }
    }
}
