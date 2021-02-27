using System;

namespace ConsolePart1 {
    class Program {
        static void Main(string[] args) {
            int a, b;
            Console.WriteLine("Please Enter a:");
            while (!Int32.TryParse(Console.ReadLine(), out a)) {
                Console.WriteLine("Data was entered incorrectly");
                Console.WriteLine("Check the data and repeat the entry:");
            }
            Console.WriteLine("Please Enter b:");
            while (!Int32.TryParse(Console.ReadLine(), out b)) {
                Console.WriteLine("Data was entered incorrectly");
                Console.WriteLine("Check the data and repeat the entry:");
            }
            double my_sum = MyLib.MySum.Suma(a, b); //Calling a method for calculating the function from the library
            Console.WriteLine("Function (a + b)^2 = {0}", my_sum);
        }
    }
}
