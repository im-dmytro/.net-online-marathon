using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using static System.Reflection.Metadata.BlobBuilder;

namespace Task1
{
    public class Book { public int Id { get; set; } }
    public class Library
    {
        private Book[] books=new Book[10];

        //some code

        public IEnumerable<Book> GеtEnumeratоr()
        {
            for (int i = 0; i < books.Length; i++)
            {
                books[i]=new Book();
                books[i].Id = i;
                yield return books[i];
            }
        }
    }
    static class GetBook
    {
        public static void PrintBooks()
        {
            Library library = new Library();
            foreach (var item in library.GеtEnumeratоr())
            {
                Console.WriteLine(item.Id);
            }
        }
    }
    public class CircleOfChildren
    {

        List<string> circleOfChildren;
        public CircleOfChildren(IEnumerable<string> circleOfChildren)
        {
            this.circleOfChildren = circleOfChildren.ToList();
        }
        public IEnumerable GetChildrenInOrder(int syllablesCount, int countOfChildren)
        {
            bool isChildrenLeaveCrcl = false;
            syllablesCount--;
            List<string> exitOrder = new List<string>();

            if (syllablesCount <= 0)
                return exitOrder;

            if (countOfChildren >= circleOfChildren.Count || countOfChildren <= 0)
            {
                isChildrenLeaveCrcl = true;
                countOfChildren = circleOfChildren.Count;
            }



            for (int i = syllablesCount; true; i += syllablesCount)
            {
                while (i >= circleOfChildren.Count)
                    i = i - circleOfChildren.Count;

                exitOrder.Add(circleOfChildren[i]);
                circleOfChildren.RemoveAt(i);

                if ((isChildrenLeaveCrcl && circleOfChildren.Count == 0)
                    || (exitOrder.Count == countOfChildren && !isChildrenLeaveCrcl))
                    return exitOrder;
            }


        }
        public IEnumerable GetChildrenInOrder(int syllablesCount)
        {
            return GetChildrenInOrder(syllablesCount, circleOfChildren.Count);
        }
    }

    public class OutputUtils
    {
        public static void ExitOutput(CircleOfChildren circleOfChildren,
            int syllablesCount, int countOfChildren)
        {
            PrintCollection(circleOfChildren.GetChildrenInOrder(syllablesCount, countOfChildren));

        }
        public static void ExitOutput(CircleOfChildren circleOfChildren,
    int syllablesCount)
        {
            PrintCollection(circleOfChildren.GetChildrenInOrder(syllablesCount));
        }
        public static void PrintCollection(IEnumerable circleOfChildren)
        {
            foreach (var children in circleOfChildren)
            {
                Console.Write(children + " ");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            OutputUtils.ExitOutput(
                new CircleOfChildren(new List<string>() { "1", "2", "3", "4", "5", }), 3, 18);
            GetBook.PrintBooks();
        }


    }
}
