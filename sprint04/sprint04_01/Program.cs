using System;

namespace sprint04_01
{
    interface ISimmable
    {
        void Swim()
        {
            Console.WriteLine("I can swim!");
        }
    }
    interface IFlyable
    {
        public int MaxHeight { get { return 0; }  }
        void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height");
        }
    }
    interface ISimmeble
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
