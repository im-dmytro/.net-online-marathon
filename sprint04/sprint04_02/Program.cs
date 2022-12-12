using System;

namespace sprint04_02
{
    interface IAnimal
    {
        void Voice();

        void Feed();
        public string Name { get; set; }
    }
    class Cat : IAnimal
    {
        public string Name { get; set; }
        public void Voice()
        {
            Console.WriteLine("Mew");
        }
        public void Feed()
        {
            Console.WriteLine("I eat mice");
        }
    }
    class Dog : IAnimal
    {
        public string Name { get; set; }
        public void Voice()
        {
            Console.WriteLine("Woof");
        }
        public void Feed()
        {
            Console.WriteLine("I eat meat");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IAnimal animal = new Cat();
            Cat animal1 = new Cat();
            animal.Feed();
            animal1.Feed();
        }
    }
}
