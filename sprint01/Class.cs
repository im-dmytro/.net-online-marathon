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

}
