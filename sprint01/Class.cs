﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint01
{
    class MyAccessModifiers
    {
        int birthYear;
        protected string personalInfo;
        private protected string IdNumber;
        public const byte averageMiddleAge = 50;

        public MyAccessModifiers(int birthYear, string IdNumber, string personalInfo)
        {
            this.birthYear = birthYear;
            this.IdNumber = IdNumber;
            this.personalInfo = personalInfo;
        }
        public int Age
        {
            get { return DateTime.Now.Year - birthYear; }
        }
        internal string Name
        {
            get; set;
        }
        public string NickName
        {
            internal set;
            get;
        }
        protected internal bool HasLivedHalfOfLife()
        {
            return false;
        }
        public static bool operator ==(MyAccessModifiers instance1, MyAccessModifiers instance2)
        {
            return instance1.Equals(instance2);
        }
        public static bool operator !=(MyAccessModifiers instance1, MyAccessModifiers instance2)
        {
            return !instance2.Equals(instance1);

        }

        public override bool Equals(object obj)
        {
            var item = obj as MyAccessModifiers;

            if (this.Name == item.Name && this.Age == item.Age && this.personalInfo == item.personalInfo)
            {
                return true;
            }
            else return false;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    class Point
    {
        int x, y;
        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int[] GetXYPair()
        {
            int[] point = new int[2];
            point[0] = x;
            point[1] = y;
            return point;
        }
        protected internal double Distance(int x, int y)
        {
            return Distance(this, new Point(x, y));
        }
        protected internal double Distance(Point point)
        {
            return Distance(this, point);
        }
        public static explicit operator double(Point point) => Distance(point, new Point(0, 0));
        static double Distance(Point point1, Point point2)
        {
            double distance = Math.Sqrt(Math.Pow(point2.x - point1.x, 2) + Math.Pow(point2.y - point1.y, 2));
            return distance;
        }
    }
    class Fraction
    {
        readonly int numerator, denominator;
        public Fraction(int numerator, int denominator)
        {

            if (numerator < 0 && denominator < 0)
            {
                numerator *= -1;
                denominator *= -1;
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public static Fraction operator !(Fraction fraction)
        {
            return SimplifyFraction(new Fraction(fraction.denominator, fraction.numerator));
        }
        public static Fraction operator *(Fraction fraction1, Fraction fraction2)
        {
            return SimplifyFraction(new Fraction(fraction1.numerator * fraction2.numerator,
                fraction1.denominator * fraction2.denominator));
        }
        public static Fraction operator /(Fraction fraction1, Fraction fraction2)
        {
            return SimplifyFraction(new Fraction(fraction1.numerator * fraction2.denominator,
                fraction1.denominator * fraction2.numerator));
        }
        public static Fraction operator +(Fraction fraction1, Fraction fraction2)
        {

            int lcm = Find_LCM(fraction1.denominator, fraction2.denominator);
            return new Fraction(fraction1.numerator * (lcm / fraction1.denominator) +
             fraction2.numerator * (lcm / fraction2.denominator), lcm);
        }
        public static Fraction operator -(Fraction fraction1, Fraction fraction2)
        {

            int lcm = Find_LCM(fraction1.denominator, fraction2.denominator);
            return new Fraction(fraction1.numerator * (lcm / fraction1.denominator) -
                fraction2.numerator * (lcm / fraction2.denominator), lcm);
        }
        public static Fraction operator +(Fraction fraction1)
        {

            return SimplifyFraction(fraction1);
        }
        public static Fraction operator -(Fraction fraction1)
        {
            return SimplifyFraction(new Fraction(fraction1.numerator * -1, fraction1.denominator));
        }
        public static bool operator ==(Fraction fraction1, Fraction fraction2)
        {

            return fraction1.Equals(fraction2);
        }
        public static bool operator !=(Fraction fraction1, Fraction fraction2)
        {
            return !fraction1.Equals(fraction2);
        }
        public static Fraction SimplifyFraction(Fraction fraction)
        {
            int hcf = Find_HCF(fraction.numerator, fraction.denominator);
            return new Fraction(fraction.numerator / hcf, fraction.denominator / hcf);
        }
        public static int Find_HCF(int a, int b)
        {
            int g;
            while (b != 0)
            {
                g = b;
                b = a % b;
                a = g;
            }
            return a;
        }
        public static int Find_LCM(int a, int b)
        {

            int lcm = (a * b) / Find_HCF(a, b);
            return lcm;
        }
        public override string ToString()
        {
            var fraction = SimplifyFraction(new Fraction(numerator, denominator));

            string output = $"{fraction.numerator} / ";
            if (fraction.denominator < 0) output = $"-{output}{-1 * fraction.denominator}";
            else output = output + fraction.denominator.ToString();
            return output;
        }
        public override bool Equals(object obj)
        {
            var item = obj as Fraction;
            item = SimplifyFraction(item);
            Fraction comparableFraction = SimplifyFraction(this);
            return item.numerator == comparableFraction.numerator &&
                item.denominator == comparableFraction.denominator;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
    public abstract class CloseableResource
    {
        public void Close()
        {

        }
    }
    class DisposePatternImplementer : CloseableResource, IDisposable
    {
        private bool disposed = false;
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }



        protected void Dispose(bool disposing)
        {
            if (!disposed)
            {

                if (disposing)
                {
                    Console.WriteLine("Disposing by developer");

                }
                else
                {
                    Console.WriteLine("Disposing by GC");
                }
                Close();
                disposed = true;
            }

        }
        ~DisposePatternImplementer()
        {
            Dispose(false);

        }

    }
}
