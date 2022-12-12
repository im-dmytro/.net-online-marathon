using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint04_01
{
    public class Cat: IAnimal, IRunnable
    {
        int maxSpeed = 12;
        public int MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
        int lifeDuration = 14;
        public int LifeDuration { get { return lifeDuration; } set { lifeDuration = value; } }

        public void Voice()
        {
            Console.WriteLine("Meow!");
        }
    }
    public class Shark : IAnimal, ISwimmable
    {
        int lifeDuration = 25;
        public int LifeDuration { get { return lifeDuration; } set { lifeDuration = value; } }

    }
    public class Eagle : IAnimal, IFlyable
    {
        int lifeDuration = 25;
        public int LifeDuration { get { return lifeDuration; } set { lifeDuration = value; } }

        int maxHeight = 320;
        public int MaxHeight { get { return maxHeight; } set { maxHeight = value; } }

    }
}
