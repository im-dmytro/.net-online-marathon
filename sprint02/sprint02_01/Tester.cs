using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint02_1
{
    class Tester :Employee
    {
        private bool isAuthomation;
        public Tester(string name,DateTime hiringDate,bool isAuthomation):base(name,hiringDate)
        {
            this.isAuthomation = isAuthomation;
        }
        public override void ShowInfo()
        {
            string testerType = !isAuthomation ? "manual tester" : "authomated tester";
            Console.WriteLine($"{name} is {testerType} and has {Experience()} year(s) of experience");
        }

    }
}
