
using System.Text.RegularExpressions;
using static LinqDenoG01.ListGenerators;


namespace LinqDenoG01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            #region Element Operators
            //1. Get first Product out of Stock 
            //var result = ProductList.First(product => product.UnitsInStock == 0);
            //Console.WriteLine(result);


            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(product => product.UnitPrice > 1000);
            //Console.WriteLine(result);

            //3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(num => num > 5).OrderBy(num => num).Skip(1).FirstOrDefault();
            //Console.WriteLine(result);

            #endregion

            #region Ordering Operators

            //1. Sort a list of products by name
            //var result = ProductList.OrderBy(product => product.ProductName);
            //foreach (var item in result) 
            //    Console.WriteLine(item);


            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();
            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}

            //3. Sort a list of products by units in stock from highest to lowest.
            //var result=ProductList.OrderByDescending(product=>product.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res = Arr.OrderBy(digit => digit.Length).ThenBy(digit => digit);
            //;
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}




            //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res = words.OrderBy(digit => digit.Length).ThenBy(digit => digit, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}



            //6. Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(product => product.Category).ThenByDescending(product => product.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var res = Arr.OrderBy(digit => digit.Length).ThenByDescending(digit => digit, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            //8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var res = Arr.Where(digit => digit[1]=='i').Reverse().ToList();
            //foreach (var item in res)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation Operators

            //1. Return a sequence of just the names of a list of products.
            //var result=ProductList.Select(product=>product.ProductName);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var result = words.Select(word => new
            //{
            //    LowerCase = word.ToLower(),
            //    UpperCase = word.ToUpper(),
            //});

            //foreach (var word in result)
            //{
            //    Console.WriteLine($"Uppercase: {word.UpperCase}, Lowercase: {word.LowerCase}");
            //}

            //3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var result = ProductList.Select(product => new
            //{
            //    productName = product.ProductName,
            //    Price = product.UnitPrice,
            //    InStock = product.UnitsInStock
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine("Number:In Place?");
            //var result = Arr.Select((index, number) =>new {Number=index,
            //    InPlace=number == index });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var result = from numberA in numbersA
            //             from numberB in numbersB
            //             where numberA < numberB
            //             select new
            //             {
            //               res= $"{numberA} is Less than {numberB}"
            //             };

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //6. Select all orders where the order total is less than 500.00.
            //var result = CustomerList.SelectMany(customer => customer.Orders.Where(order => order.Total < 500));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //7. Select all orders where the order was made in 1998 or later.
            //var result = CustomerList.SelectMany(customer => customer.Orders.Where(order => order.OrderDate.Year >=1998));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion


            //Part 2
            #region Set Operators

            //1. Find the unique Category names from Product List
            //var result=ProductList.Select(product=>product.Category).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Produce a Sequence containing the unique first letter from both product and customer names.
            //var result = ProductList.Select(product => product.ProductName[0]).Union(CustomerList.Select(customer => customer.CustomerName[0])).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //    .Intersect(CustomerList.Select(customer => customer.CustomerName[0])).Distinct();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.
            //var result = ProductList.Select(product => product.ProductName[0])
            //    .Except(CustomerList.Select(customer => customer.CustomerName[0]));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates
            //var result = ProductList.Select(product => product.ProductName.Substring(product.ProductName.Length - 3))
            //    .Concat(CustomerList.Select(customer => customer.CustomerName.Substring(customer.CustomerName.Length - 3)));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region Aggregate Operators

            //1. Get the total units in stock for each product category.
            //var result = ProductList.GroupBy(product => product.Category).Select(group => new
            //{
            //    category = group.Key,
            //    unitsInStock = group.Sum(unit => unit.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(product => product.Category).Select(group => new
            //{
            //    category = group.Key,
            //    CheapestProduct = group.Min(product => product.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Get the products with the cheapest price in each category (Use Let)
            //var result = from product in ProductList
            //             group product by product.Category into categoryGroup
            //             let minPrice = categoryGroup.Min(p => p.UnitPrice)
            //             from product in categoryGroup
            //             where product.UnitPrice == minPrice
            //             select product;
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4. Get the most expensive price among each category's products.
            //var result = ProductList.GroupBy(product => product.Category).Select(group => new
            //{
            //    category = group.Key,
            //    MostExpensive = group.Max(product => product.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Get the products with the most expensive price in each category.
            //var result = ProductList.GroupBy(product => product.Category).SelectMany(
            //    group => group.Where(product => product.UnitPrice == group.Max(p => p.UnitPrice)));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //6. Get the average price of each category's products.
            //var result = ProductList.GroupBy(product => product.Category).Select(group => new
            //{
            //    category = group.Key,
            //    CheapestProduct = group.Average(product => product.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}



            #endregion

            #region Partitioning Operators
            //1. Get the first 3 orders from customers in Washington
            //var result = CustomerList.Where(customer => customer.City == "Washington").SelectMany(customer => customer.Orders.Take(3));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //2. Get all but the first 2 orders from customers in Washington.
            //var result = CustomerList.Where(customer => customer.City == "Washington").SelectMany(customer => customer.Orders.Skip(2));
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //3. Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers
            //            .TakeWhile((num, index) => num >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var result = numbers.SkipWhile(num => num % 3 != 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = numbers
            //            .SkipWhile((num, index) => num >= index);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}




            #endregion

            #region Quantifiers

            //1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            //string[] dictionaryWords = File.ReadAllLines("dictionary_english.txt"); //The text file wasn't attached to the assignment
            //bool containsSubstringEI = dictionaryWords.Any(word => word.Contains("ei"));
            //if (containsSubstringEI)
            //{
            //    Console.WriteLine("At least one word contains the substring 'ei'.");
            //}
            //else
            //{
            //    Console.WriteLine("No word contains the substring 'ei'.");
            //}


            //2. Return a grouped a list of products only for categories that have at least one product that is out of stock.
            //var result = ProductList.GroupBy(product => product.Category).Where(group => group.Any(product => product.UnitsInStock == 0));


            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //    }
            //}

            // 3.Return a grouped a list of products only for categories that have all of their products in stock.
            //var result = ProductList.GroupBy(product => product.Category).Where(group => group.All(product => product.UnitsInStock != 0));
            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    foreach (var product in group)
            //    {
            //        Console.WriteLine($"  Product: {product.ProductName}, UnitsInStock: {product.UnitsInStock}");
            //    }
            //}

            #endregion

        }
    }
}