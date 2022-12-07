using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint01
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction frac1 = new Fraction(45, -25);
            Fraction frac2 = new Fraction(45, 25);

            Console.WriteLine($"{frac1.ToString()}  {frac2.GetHashCode()}");
/*            Fraction frac3 = null;
            Fraction frac4 = new Fraction(45, 25);
            Console.WriteLine(frac3 != frac4);*/
            Console.ReadLine();
        }
    }
}
