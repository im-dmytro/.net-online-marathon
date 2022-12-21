using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint04_01
{
    public class Cat : IAnimal, IRunnable
    {
        public int MaxSpeed { get; set; } = 12;
        public int LifeDuration { get; set; } = 14;
        public void Voice()
        {
            Console.WriteLine("Meow!");
        }
    }
    public class Shark : IAnimal, ISwimmable
    {
        public int LifeDuration { get; set; } = 24;
    }
    public class Eagle : IAnimal, IFlyable
    {
        public int LifeDuration { get; set; } = 12;
        public int MaxHeight { get; set; } = 210;

    }
}
