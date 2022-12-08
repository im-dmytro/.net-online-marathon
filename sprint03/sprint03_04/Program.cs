using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sprint03_04
{
    static class IListExtensions
    {
        public static void IncreaseWith(this IList<int> enumeration,int addingNum)
        {
            for (int i = 0; i < enumeration.Count; i++)
            {
                enumeration[i] += addingNum;
            }
        }
    }
        static class IEnumerableExtensions
    {
        public static string Join<T>(this IEnumerable<T> enumeration, string separator) => string.Join(separator, enumeration);
        public static string ToString<T>(this IEnumerable<T> instance)
        {
            string result = instance.Join<T>(", ");
            return $"[{result}]";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(numbers.ToString<int>());

            numbers.IncreaseWith(32);
            Console.WriteLine(numbers.ToString<int>());
            Console.ReadLine();
        }
    }
}
