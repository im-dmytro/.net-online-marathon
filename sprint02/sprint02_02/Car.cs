using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint02_02
{
    abstract class Car
    {
        internal string mark;
        internal int prodYear;
        public Car(string mark, int prodYear)
        {
            this.mark = mark;
            this.prodYear = prodYear;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Mark :{mark},\nProducted in {prodYear}");
        }
    }
    class Lory : Car
    {
        double loadCapacity;
        public double LoadCapacity { get { return loadCapacity; } set { loadCapacity = value; } }

        public Lory(string mark, int prodYear, double loadCapacity) : base(mark, prodYear)
        {
            this.loadCapacity = loadCapacity;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"The load capacitry is {loadCapacity}");
        }
    }
    class SportCar : Car
    {
        int maxSpeed;
        public int MaxSpeed { get { return maxSpeed; } set { maxSpeed = value; } }
        public SportCar(string mark, int prodYear, int maxSpeed):base(mark,prodYear)
        {
            this.maxSpeed = maxSpeed;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Maximum speed in {maxSpeed}");
        }
    }
}
