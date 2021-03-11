using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var evens2 = from n in nums
                        where n % 2 == 0 && n > 2
                        orderby n descending
                        select n;

            var evens = nums.Where(n => n % 2 == 0 && n > 2)
                .OrderByDescending(n => n);

            evens.ToList().ForEach(n => Console.WriteLine(n));
        }
    }
}
