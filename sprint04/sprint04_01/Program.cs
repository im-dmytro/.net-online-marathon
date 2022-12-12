using System;

namespace sprint04_01
{

    class Program
    {
        static void Main(string[] args)
        {
            IAnimal cat = new Cat();
            cat.Voice();
            cat.ShowInfo();
            
            IRunnable cat1 = new Cat();
            cat1.Run();
           
            var kitty = new Cat();
           
            Console.ReadLine();

        }
    }
}
