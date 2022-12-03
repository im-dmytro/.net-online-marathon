using System;
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


}
