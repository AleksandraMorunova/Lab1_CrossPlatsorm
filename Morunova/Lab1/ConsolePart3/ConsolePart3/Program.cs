using System;

namespace ConsolePart3 {
    class Program {
        static void Main(string[] args) {
            int n;
            float a, x, eps;
            Console.WriteLine("Please Enter x: ");
            while (!float.TryParse(Console.ReadLine(), out x)) {
                Console.WriteLine("Data was entered incorrectly");
                Console.WriteLine("Check the data and repeat the entry:");
            }
            Console.WriteLine("Please Enter a: ");
            while (!float.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Data was entered incorrectly");
                Console.WriteLine("Check the data and repeat the entry:");
            }
            Console.WriteLine("Please Enter e: ");
            while (!float.TryParse(Console.ReadLine(), out eps)) {
                Console.WriteLine("Data was entered incorrectly");
                Console.WriteLine("Check the data and repeat the entry:");
            }
            Console.WriteLine("Please Enter n: ");
            while (!Int32.TryParse(Console.ReadLine(), out n)) {
                Console.WriteLine("Data was entered incorrectly");
                Console.WriteLine("Check the data and repeat the entry:");
            }
            double my_function = MyLib.MyFunction.Summ(x, a, eps, n); //Calling a method for calculating the Taylor series from the library
            double my_functions = MyLib.MyFunction.Function(a, x);
            double my_calculation_error = MyLib.MyFunction.CalculationError(my_functions, my_function); //Calculation error calculations
            Console.WriteLine("The sum of the Taylor series = {0}", my_function);
            Console.WriteLine("The results of the calculation are accurate function value = " + Math.Pow(a, x) + " " + my_functions);
            Console.WriteLine("Calculation error = " + my_calculation_error);
        }
    }
}
