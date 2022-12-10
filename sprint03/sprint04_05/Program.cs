using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint03_05
{
    
     class EventProgram
    {
        public event EventHandler Show;
        public EventProgram()
        {
            Show += Dog;
            Show += Cat;
            Show += Mouse;
            Show += Elephant;
            Show(this, null);
        }
        public static void Dog(object sender, EventArgs e)=> Console.WriteLine("Dog");
        public static void Cat(object sender, EventArgs e)=> Console.WriteLine("Cat");
        public static void Mouse(object sender, EventArgs e)=> Console.WriteLine("Mouse");
        public static void Elephant(object sender, EventArgs e)=> Console.WriteLine("Elephant");
    }
    class Program
    {
        static void Main(string[] args)
        {
            EventProgram eventProgram = new EventProgram();

            Console.ReadKey();
        }
    }
}
