using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint02_04
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    abstract class ChessFigure
    {
        public abstract void Move();
    }
    class Bishop : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves by a diagonal!");
        }
    }
    class Rook : ChessFigure
    {
        public override void Move()
        {
            Console.WriteLine("Moves straight!");
        }
    }
}
