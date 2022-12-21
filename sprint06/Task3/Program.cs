using System;

namespace Task3
{
    class ShowPower
    {
        public static IEnumerable<double> PowerRanger(int degree, int start, int finish)
        {
            if (start < 0 || finish < 0 || start > finish)
            {
                yield return 0;
                yield break;
            }
            else if (degree == 0)
            {
                yield return 1;
                yield break;
            }
            double res=0;
            for (int s = (int)Math.Ceiling(Math.Pow(start, 1d / degree)); true; s++)
            {
                res = Math.Pow(s, degree);
                if (res<=finish) yield return Math.Pow(s, degree);
                else yield break;
            }
        }
        public static IEnumerable<double> SuperPower(int number, int degree)
        {
            if (degree == 0) yield return 1;
            double result = ChooseCase(number, degree);
            for (int i = 0; i < Math.Abs(degree); i++)
            {
                yield return result;
                result *= ChooseCase(number, degree);
            }

        }
        public static double ChooseCase(int number, int degree) =>
            number < 0 && degree < 0 || number > 0 && degree < 0 ?
             1 / Convert.ToDouble(number) : number;

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            foreach (double num in ShowPower.PowerRanger(1, 50, 200))
            {
                Console.Write(num);
            }
            //foreach (var item in )
            //{
            //    Console.WriteLine(item.ToString());
            //}



        }


    }
}