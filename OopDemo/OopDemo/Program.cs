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
            
            foreach (var p in people) {
                Console.WriteLine(p.FullName);
            }
        }
    }
}
