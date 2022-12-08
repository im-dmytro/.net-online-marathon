using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sprint03_03
{
    class Program
    {
        public static List<int> ListWithPositive(List<int> listOfNegPositElem)
        {
            return listOfNegPositElem.FindAll(elem => elem > 0 && elem <= 10);
        }
        static void Main(string[] args)
        {

        }
    }
}
