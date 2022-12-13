using System;
using System.Collections.Generic;

namespace sprint04_04
{
    


    class Program
    {
        static void Main(string[] args)
        {
            var trapezoids = new List<Trapezoid>
            {
                 new Trapezoid() { Length1 = 10, Length2 = 13, Width = 40 },
              new Trapezoid() { Length1 = 10, Length2 = 4, Width = 43 },
              new Trapezoid() { Length1 = 2, Length2 = 103, Width = 10 },
              new Trapezoid() { Length1 = 4, Length2 = 13, Width = 10 },

             new Trapezoid() { Length1 = 10, Length2 = 6, Width = 13 }
        };
            var rooms = new List<Room<Trapezoid>>();
            foreach (var item in trapezoids)
            {
                rooms.Add(new Room<Trapezoid> { Floor = item, Height = 10 });
            }
            rooms.Sort(new RoomComparerByVolume<Trapezoid>());
            
            foreach (var room in rooms)
            {
                Console.WriteLine($"{room.Floor.Area()}");
            }
            IShape shape = new Trapezoid() { Length1 = 10, Length2 = 13, Width = 40 };
            Trapezoid trapezoid = new Trapezoid() { Length1 = 10, Length2 = 13, Width = 40 };
            Console.WriteLine(shape.Area()  );
            Console.WriteLine(trapezoid.Area());
        }
    }
}
