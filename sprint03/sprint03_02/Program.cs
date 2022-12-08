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
            var words=value.Split(' ',',','.', '?', '!', '-', ';', ':', ',').ToList();
            int wordCount = 0;
            foreach (var item in words)
            {
                if (item.Length > 0) { wordCount++; }
            }
            return wordCount;
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
