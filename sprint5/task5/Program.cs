using System;
using System.Collections.Generic;
using System.Linq;

namespace task5
{
    class MyReverseNotebook
    {
        public static Dictionary<string, List<string>> ReverseNotebook(Dictionary<string, string> phonesToNames)
        {

           return 
               phonesToNames
                .ToLookup(x => x.Value ?? "", x => x.Key)
                .ToDictionary(x => x.Key, x => x.ToList());

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, string>() {
                { null , "Petro" },
                { "0467654321" , "Ivan" },
                { "0667654321" , "Petro" },
                { "0367654321" , "Ivan" },
                { "0867654321" , "Mark" }};
            MyReverseNotebook.ReverseNotebook(dictionary);

        }
    }
}
