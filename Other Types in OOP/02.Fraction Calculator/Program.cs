using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Fraction_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction fraction1 = new Fraction(17, 8);
            Fraction fraction2 = new Fraction(34, 13);
            Fraction result = fraction1 + fraction2;
            Console.WriteLine(result.Numerator);
            Console.WriteLine(result.Denumerator);
            Console.WriteLine(result);
           
        }
    }
}
