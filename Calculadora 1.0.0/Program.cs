using System;
using System.Globalization;

namespace Calculadora_1._0._0 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Selecione o tipo de operação a ser realizada: ");
            Console.WriteLine("[1] Soma");
            Console.WriteLine("[2] Subtração");
            Console.WriteLine("[3] Multiplicação");
            Console.WriteLine("[4] Divisão");
            Console.WriteLine("[0] Finaliza o programa a qualquer momento");
            Console.WriteLine();
            Console.Write("> ");

            var choice = (Console.ReadLine());

            double num1, num2, result;
            Console.Write("\nPrimeiro valor: ");
            num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Segundo valor: ");
            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Calc calculator = new Calc(num1, num2);

            switch (choice) {
                case "1":
                    Console.WriteLine("\nOpção soma selecionada.\n");
                    result = calculator.Soma(num1, num2);
                    Console.WriteLine($"Resultado: {result.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case "2":
                    Console.WriteLine("\nOpção soma selecionada.\n");
                    result = calculator.Subt(num1, num2);
                    Console.WriteLine($"Resultado: {result.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case "3":
                    Console.WriteLine("\nOpção soma selecionada.\n");
                    result = calculator.Multip(num1, num2);
                    Console.WriteLine($"Resultado: {result.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case "4":
                    Console.WriteLine("\nOpção soma selecionada.\n");
                    result = calculator.Divisao(num1, num2);
                    Console.WriteLine($"Resultado: {result.ToString("F2", CultureInfo.InvariantCulture)}");
                    break;
                case "0":
                    Console.WriteLine("Programa encerrado.");
                    break;
                default:
                    Console.WriteLine("Valor incorreto, operação cancelada.");
                    break;
            }

        }
    }
}
