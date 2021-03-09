using System;

namespace RefOutDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "Bill";
            p.LastName = "Gates";

            Console.WriteLine(p.FirstName + " " + p.LastName);
            DoSomething(p);
            Console.WriteLine(p.FirstName + " " + p.LastName);
        }

        // value type by value               // ref type by value
        // value type by ref                 // ref type by ref
        // value type by ref using out

        // 1) You want to return multiple values
        // 2) Avoid the copy (perf)

        static void DoSomething(Person per)
        {
            per = new Person();
        }
    }
}
