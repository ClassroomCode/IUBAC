using System;
using System.Collections.Generic;

namespace OopDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>();
            var per = new Person() { FirstName = "Bill", LastName = "Gates" };

            people.Add(per);

            var emp = new Employee() { FirstName = "Steve", LastName = "Jobs", Salary = 50000 };
            
            people.Add(emp);

            foreach (Person p in people) {
                double s = 0;
                if (p is Employee) s = (p as Employee).Salary;

                Console.WriteLine(p.FullName + " - " + s);
            }
            Console.WriteLine("=============");

            var payables = new List<IPayable>();

            payables.Add(emp);
            payables.Add(new Vendor { CompanyName = "Acme" });

            foreach(var payable in payables) {
                payable.PayMoney();
            }
        }
    }
}
