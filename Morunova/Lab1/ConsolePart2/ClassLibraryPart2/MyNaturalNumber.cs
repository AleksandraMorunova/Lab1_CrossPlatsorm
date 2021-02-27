using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib { 
    public class MyNaturalNumber {
        /// <summary>
        /// Taylor series calculation
        /// </summary>
        /// <param name="n">number of repetitions of the function</param>
        /// <returns>Returns the value of the sum of the Taylor series</returns>
        public static double NaturalNumber(int n) { //A method for calculating the Taylor series
            double P = 1;
           for (int i = 3; i <= n; i++) { //Counting series
                P *= ( 1 - (1 / Math.Pow(i,2))); 
           }
           return P;
        }
    }
}
