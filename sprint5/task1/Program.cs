
using System.Collections.Generic;

namespace task1
{
    static class MyProgram
    {
        public static void Position(this List<int> numbers)
        {
            PrintList(Enumerable.Range(0, numbers.Count).Where(i => numbers[i] == 5).Select(x => x += 1).ToList());

        }
        public static void Remove(this List<int> numbers)
        {
            numbers.RemoveAll(x => x > 20);
            PrintList(numbers);
        }
        public static void PrintList(this List<int> numbers)
        {
            foreach (var position in numbers)
            {
                Console.WriteLine($"{position}");
            }
        }
        public static void Insert(this List<int> numbers)
        {
            Dictionary<int, int> pos = new Dictionary<int, int>() {
                {3,-5 },
                {6,-6 },
                {8,-7},
            };
            foreach (var p in pos) {
                if(p.Key<numbers.Count)
            numbers.Insert(p.Key, p.Value);
            }  
            PrintList(numbers);
        }
        public static void Sort(this List<int> numbers)
        {
            numbers.Sort();
            PrintList(numbers);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 3, 5, 9, 11, 5, 5, 20, 22, 25 };
            MyProgram.Position(numbers);

        }
    }
}