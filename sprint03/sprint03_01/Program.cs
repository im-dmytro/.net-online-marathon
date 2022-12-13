using System;
using System.Collections.Generic;


namespace sprint03_01
{
    class CalcProgram
    {
        public delegate double CalcDelegate(double num1, double num2, char operatorSign);
        public CalcDelegate funcCalc = Calc;

        public static double Calc(double num1, double num2, char operatorSign)
        {
            return operatorSign switch
            {
                '+' => num1 + num2,
                '-' => num1 - num2,
                '/' => num2 == 0 ? 0 : num1 / num2,
                '*' => num1 * num2,
                _ => 0
            };
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
