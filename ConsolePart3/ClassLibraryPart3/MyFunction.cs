using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib {
    public class MyFunction {
        /// <summary>
        /// Calculate the Taylor series with a given accuracy
        /// </summary>
        /// <param name="x">the actual value of the argument</param>
        /// <param name="a">given number</param>
        /// <param name="eps">set accuracy</param>
        /// <param name="n">number of repetitions of the function</param>
        /// <returns>Returns the value of the sum of the Taylor series</returns>
        public static double Summ(float x, float a, float eps, int n) { //A method for calculating the Taylor series
            double sum = 0;
            for (int i = 0; i <= n; i++) {
                sum += ((Math.Pow(x * Math.Log(a), i)) / F(i)); //Counting a series using a method call to calculate the factorial
                if (Math.Abs(sum) <= eps) { break; } //Check the range for accuracy
            }
            return sum;
        }
        static double F(int n) { //A method for calculating the factorial
            double tmp = 1;
            for (int index = 1; index <= n; index++) {
                tmp *= index;
            }
            return tmp;
        }
        public static double Function(float a, float x) { //A method for calculating the exact value of the function
            double k = Math.Pow(a, x);
            return k;
        }
        public static double CalculationError(double k, double sum) { //A method for calculating the calculation error
            double calculation_error = Math.Abs(sum - k) / k;
            return calculation_error;
        }
    }
}
