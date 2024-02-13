
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using static LinqDenoG01.ListGenerators;
using static System.Net.Mime.MediaTypeNames;


namespace LinqDenoG01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(customer => customer.Address == "Washington").SelectMany(customer => customer.Orders).Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(customer => customer.Address == "Washington").SelectMany(customer => customer.Orders).Skip(2);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.TakeWhile((number, index) => number > index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile((number, index) => number > index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Grouping Operators

            //1.	Use group by to partition a list of numbers by their remainder when divided by 5
            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var result = numbers.GroupBy(numbers => numbers % 5);

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Numbers with a reminder of {group.Key} when divided by 5 ");
            //    foreach (var item in group)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.WriteLine("=======================================================================");
            //}


            //2.	Uses group by to partition a list of words by their first letter.
            //  Use dictionary_english.txt for Input

            //List<string> words = File.ReadAllLines("dictionary_english.txt").ToList();

            //var wordGroups = words.GroupBy(word => word[0]);


            //3.	Consider this Array as an Input
            String[] Arr = { "from", "salt", "earn", " last", "near", "form" };
         //   Use Group By with a custom comparer that matches words that are consists of the same Characters Together

            //???




            #endregion

        }
    }
}