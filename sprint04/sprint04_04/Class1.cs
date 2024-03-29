﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint04_04
{
    interface IShape : ICloneable
    {
        double Area()
        {
            return 0f;
        }
    }
    class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Length { get; set; }
        public double Area() => Width * Length;
        public object Clone() => new Rectangle()
        {
            Length = Length,
            Width = Width
        };

    }
    class Room<T> : ICloneable, IComparable where T : IShape
    {
        public double Height { get; set; }
        public T Floor { get; set; }

        public double Volume()
        {
            return Floor.Area() * Height;
        }
        public object Clone() => new Room<T> { Height = Height, Floor = (T)Floor.Clone() };
        public int CompareTo(object other)
        {
            var myRoom = other as Room<T>;
            if (myRoom is null)
                throw new ArgumentException("Not correct values");
            else
                return Floor.Area().CompareTo(myRoom.Floor.Area());
        }
    }
    class RoomComparerByVolume<T> : IComparer<Room<T>> where T : IShape
    {
        public int Compare(Room<T> room1, Room<T> room2)
        {
            if (room1 is null || room2 is null)
                throw new ArgumentException("Not correct values");
            else
                return room1.Volume().CompareTo(room2.Volume());
        }
    }
    class Trapezoid : IShape
    {
        public double Length1 { get; set; }
        public double Length2 { get; set; }
        public double Width { get; set; }
        public double Area() => (Length1 + Length2) * 0.5f * Width;
        public object Clone() => new Trapezoid()
        {
            Length1 = Length1,
            Length2 = Length2,
            Width = Width
        };


    }
}
