using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopDemo
{
    public class Employee : Person, IPayable
    {
        public override string FullName => $"{LastName}, {FirstName}";

        public double Salary { get; set; }

        public void PayMoney()
        {
            Console.WriteLine($"{FullName} has been paid");
        }
    }
}
