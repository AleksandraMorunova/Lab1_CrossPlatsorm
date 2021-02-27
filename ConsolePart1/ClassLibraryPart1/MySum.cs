using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib {
    public class MySum {
        /// <summary>
        /// function (a+b)^2
        /// </summary>
        /// <param name="a">the first integer</param>
        /// <param name="b">the second integer</param>
        /// <returns>returns the value of the function (a+b)^2</returns>
        public static double Suma(int a, int b) { //A method for calculating the function
            double result = Math.Pow((a + b), 2);
            return result;
        }
    }
}
