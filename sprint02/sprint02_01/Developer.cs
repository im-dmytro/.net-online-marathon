using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint02_1
{
    class Developer :Employee
    {
        private string programmingLanguage;
        public Developer(string name, DateTime hiringDate, string programmingLanguage) : base(name, hiringDate)
        {
            this.programmingLanguage = programmingLanguage;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"{name} is {programmingLanguage} programmer");
        }
    }
}
