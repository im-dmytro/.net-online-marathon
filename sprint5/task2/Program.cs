namespace Task2
{
    static class MyProgram
    {
        public static void SearchKeys(this Dictionary<string, string> persons)
        {
            PrintElements(persons.Keys);
        }
        public static void SearchValues(this Dictionary<string, string> persons)
        {
            PrintElements(persons.Values);
        }
        public static void SearchAdmin(this Dictionary<string, string> persons)
        {
            PrintPairs(persons.Where(x => x.Value == "Admin"));
        }
        public static void PrintElements(this IEnumerable<string> items)
        {
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
        public static void PrintPairs(this IEnumerable<KeyValuePair<string, string>> itemPairs)
        {
            if (itemPairs is null)
            {
                throw new ArgumentNullException(nameof(itemPairs));
            }

            foreach (var itemPair in itemPairs)
            {
                Console.WriteLine($"{itemPair.Key} {itemPair.Value}");
            }
        }
        static void Main(string[] args)
        {
            Dictionary<string, string> persons = new Dictionary<string, string>();
            {
                persons.Add("id11111", "Admin");
                persons.Add("id12345", "User1");
                persons.Add("id98765", "User2");
                persons.Add("id56743", "User3");
                persons.Add("id73920", "User4");
            }
            persons.SearchKeys();
        }
    }

}