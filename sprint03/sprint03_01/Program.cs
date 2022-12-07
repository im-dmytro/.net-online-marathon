using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint03_01
{
    class CalcProgram
    {
        public delegate double CalcDelegate(double num1, double num2, char operatorSign);
        public CalcDelegate funcCalc = Calc;

        public static double Calc(double num1, double num2, char operatorSign)
        {
            if (num2 == 0) { return 0; }
            switch (operatorSign)
            {
                case '+':
                    return num1 + num2;
                   
                case '-':
                    return num1 - num2;
                case '/':
                    return num1 / num2;
                case '*':
                    return num1 * num2;
                default:
                    return 0;
                   
            }
        }

    }
    class Program
    {

        static void Main(string[] args)
        {

            CalcProgram calc = new CalcProgram();
            Console.WriteLine(calc.funcCalc(24, 25, '+'));
            Console.ReadLine();
            
  
    }
    }
}
