using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    public class Vendor : IPayable
    {
        public string CompanyName { get; set; }

        public void PayMoney()
        {
            Console.WriteLine($"{CompanyName} has been paid");
        }
    }
}
