using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint04_01
{
    public interface ISwimmable
    {
        void Swim()
        {
            Console.WriteLine("I can swim!");
        }
    }
    public interface IFlyable
    {
        public int MaxHeight { get { return 0; } }
        void Fly()
        {
            Console.WriteLine($"I can fly at {MaxHeight} meters height!");
        }
    }
    public interface IRunnable
    {
        public int MaxSpeed { get { return 0; }  }
        public void Run()
        {
            Console.WriteLine($"I can run up to {MaxSpeed} kilometers per hour!");
        }

    }
    public interface IAnimal
    {
        int LifeDuration { get { return 0; } }
        void Voice()
        {
            Console.WriteLine("No voice!");
        }
        void ShowInfo()
        {
            Console.WriteLine($"I am a {GetType().Name} and I live approximately {LifeDuration} years.");
        }
    }
}