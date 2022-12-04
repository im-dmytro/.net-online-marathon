using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint02_03
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    class Science
    {
        public virtual void Awards()
        {
            Console.WriteLine("We can obtain the Nobel Prize");
        }
    }
    class Mathematics : Science
    {
        public override void Awards()
        {
            Console.WriteLine("We dont't need any awards, but we can still obtain Able Prize that nobody else can");
        }
    }
    class Physics : Science
    {

    }
}
