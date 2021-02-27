using System;

namespace ConsolePart2 {
    class Program {
        static void Main(string[] args) {
            int n;
            Console.WriteLine("Please Enter n:");
            while ((!Int32.TryParse(Console.ReadLine(), out n)) || (!(n >= 3))) {
                    Console.WriteLine("Data was entered incorrectly");
                    Console.WriteLine("Check the data and repeat the entry:");
            }
            double my_natural_number = MyLib.MyNaturalNumber.NaturalNumber(n); //Calling a method for calculating the Taylor series from the library
            Console.WriteLine("The sum of the Taylor series = {0}", my_natural_number);
        }
    }
}
