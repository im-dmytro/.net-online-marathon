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
        void IColoured()
        {

        }
    }
    public interface IDocument
    {
        static string defaultText = "Lorem ipsum";
         int Pages { get; set; }
         string Name { set; get; }
        void AddPages(int value)
        {
            Pages+=value;
        }
        void Rename(string value)
        {
            Name = value;
        }
        void IDocument()
        {
            
        }
    }
  
    public class ColouredDocument : IDocument, IColoured
    {
        string name;
        public string Name { get=>name; set=>name=value; }
        public ColourEnum Colour { get; set; }
        int pages = 0;
        public int Pages { get => pages; set=>pages=value; }
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
            IDocument doc1 = new ColouredDocument(ColourEnum.Blue) {Name="Document1"};
            Console.WriteLine(doc1.Name);
            doc1.Rename("Document2");
            Console.WriteLine(doc1.Name);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Example.Do();
        }
    }
}
