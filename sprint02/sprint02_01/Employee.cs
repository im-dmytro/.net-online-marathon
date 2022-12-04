using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint02_1
{
    class Employee
    {
        internal string name;
        private DateTime hiringDate;
        public Employee(string name, DateTime hiringDate)
        {
            this.name = name;
            this.hiringDate = hiringDate;
        }
       
        public int Experience()
        {
            int experienceYears = DateTime.Now.Subtract(hiringDate).Days / 365;
            return experienceYears;
            
        }
        public virtual void ShowInfo() {
            Console.WriteLine($"{name} has {Experience()} years of experience");
        }
    }
}
