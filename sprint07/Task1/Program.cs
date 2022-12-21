using System.Linq;

namespace Task1
{
    public class Program
    {
        static double EvaluateSumOfElementsOddPositions(double[] inputData)
        {
            return inputData.Select((x, y) => y % 2 == 1 ? inputData[y] : 0).Sum();
        }
        public static double EvaluateSumOfElementsOddPositions2(double[] inputData)
        {
            return inputData.Where((x, y) => y % 2 == 1).Sum();
        }
        public static double EvaluateAggregate(double[] inputData,
            Func<double, double, double> aggregate,
            Func<double, int, bool> predicate)
        {
            return inputData.Where((x, y) => predicate(x, y)).Aggregate(aggregate);
        }
        public static int ProductWithCondition(List<int> list, Func<int, bool> condition)
        {
            var outputList = list.Where(x => condition(x));
            return outputList.Any() ? outputList.Aggregate((result, num) => result * num) : 1;
        }
        public static string GetWord(string input, string seed)
        {
            string largestString = "";

            if (input.Any())
            {
                largestString = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).
                    OrderByDescending(x => x.Length).First();
                largestString = largestString.Length > seed.Length
                ? largestString : seed;
            }
            else largestString = seed;

            var stringOutput = new string(largestString?.SkipWhile(x => x != 'a').ToArray());

            return stringOutput.Any() ? stringOutput : string.Empty;
        }


        public static void Main(string[] args)
        {
            Console.WriteLine(GetWord("erfef errrtgrt adddadsjkmrmergtma ajfremk wrfeaaa", "erfererf"));

            EvaluateSumOfElementsOddPositions(new double[] { 1, 34, 54, 223, 12, 54 });
        }
    }
}