using System;

namespace sprint04_03
{
    public enum ColourEnum
    {
        Red,
        Green,
        Blue
    }
    public interface IColoured
    {
        ColourEnum Colour { get { return ColourEnum.Red; } }
    }
    public interface IDocument
    {
        static string defaultText = "Lorem ipsum";
        int Pages { get { return 0; } set { } }
        string Name { set; get; }
        void AddPages(int value)
        {
            Pages += value;
        }
        void Rename(string value)
        {
            Name = value;
        }
    }

    public class ColouredDocument : IDocument, IColoured
    {
        public string Name { get; set; }
        public ColourEnum Colour { get; }
        public int Pages { get; set; }
        public ColouredDocument(ColourEnum colour)
        {
            Colour = colour;
        }
        public ColouredDocument()
        {

        }
    }
    public class Example
    {
        public static void Do()
        {
            IDocument doc1 = new ColouredDocument(ColourEnum.Blue) { Name = "Document1" };
            Console.WriteLine(doc1.Name);
            doc1.Rename("Document2");
            doc1.Pages = 234;
            Console.WriteLine(doc1.Name+" "+ doc1.Pages);
        }
    }

    interface A
    {
        void Hello() { Console.WriteLine("Eaa"); }

    }
    interface B
    {
        void Hello() { Console.WriteLine("EEEE"); }
    }
    class Test : A, B
    {
        public void Hello()
        {
            Console.WriteLine("MoewAAA");

        }
        void B.Hello()
        {
            Console.WriteLine("MoewB");

        }
        void A.Hello()
        {
            Console.WriteLine("MoewA");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test();
            test.Hello();
            Console.WriteLine("Hello World!");
            Example.Do();
        }
    }
}
