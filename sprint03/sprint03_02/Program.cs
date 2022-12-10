using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint03_02
{
    static class StringExtensions
    {
        public static int WordCount(this string value)
        {
            return value.Split(new char[] { ' ', ',', '.', '?', '!', '-', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("lkij jnjn-jknj;ijijm#$^^hgnk???:".WordCount());
            Console.ReadKey();
        }
    }
}
