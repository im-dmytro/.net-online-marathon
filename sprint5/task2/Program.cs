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
            foreach (var person in persons)
            {
                Console.WriteLine(person.Value);
            }
        }
        public static void SearchAdmin(this Dictionary<string, string> persons)
        {
            foreach (var person in persons)
            {
                if(person.Value=="Admin")
                    Console.WriteLine($"{person.Key} {person.Value}");
            }
        }
        public static void PrintElements(this IEnumerable<string> persons)
        {
            foreach (var item in persons)
            {
                Console.WriteLine(item);
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