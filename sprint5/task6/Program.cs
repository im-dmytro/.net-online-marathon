using System;
using System.Collections.Generic;
using System.Linq;

namespace task6
{
    class MyReverseNotebook
    {
        public static Lookup<string,string> CreateNotebook(Dictionary<string, string> phonesToNames)
        {
            foreach (var item in phonesToNames)
                if (String.IsNullOrEmpty(item.Value)) phonesToNames[item.Key] = "";

            return (Lookup<string,string>)phonesToNames.ToLookup(x => x.Value, x => x.Key);
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
            MyReverseNotebook.CreateNotebook(dictionary);
        }

    }
}
