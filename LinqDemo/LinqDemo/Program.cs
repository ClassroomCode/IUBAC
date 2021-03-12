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

            var evens = from n in nums
                        where n % 2 == 0
                        select n;

            var bigEvens = from n in evens
                           where n > 2
                           select n;

            var bigSortedEvens = from n in bigEvens
                                 orderby n descending
                                 select n;

            bigSortedEvens.ToList().ForEach(n => Console.WriteLine(n));

            Console.WriteLine("================");

            nums.Add(8);

            bigSortedEvens.ToList().ForEach(n => Console.WriteLine(n));
        }
    } 
} 
