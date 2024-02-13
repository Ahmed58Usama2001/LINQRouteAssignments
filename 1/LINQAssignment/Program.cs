
using static LinqDenoG01.ListGenerators;


namespace LinqDenoG01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Question 1

            //  var OutOfStock = ProductList.Where(product => product.UnitsInStock == 0);

            //var OutOfStock = from product in ProductList
            //                 where product.UnitsInStock == 0
            //                 select product;

            //foreach (var product in OutOfStock)
            //{
            //    Console.WriteLine(product);
            //}

            #endregion

            #region Question 2

            //var InStock = ProductList.Where(product => product.UnitsInStock != 0 && product.UnitPrice > 3);

            //InStock= from product in ProductList
            //         where product.UnitsInStock != 0 && product.UnitPrice > 3
            //         select product;


            //foreach (var product in InStock)
            //{
            //    Console.WriteLine(product);
            //}


            #endregion

            #region Question 3

            string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var NamesShorterThanValue = Arr.Where((digitName, index) => digitName.Length < index);

            foreach (var digitName in NamesShorterThanValue)
            {
                Console.WriteLine(digitName);
            }

            #endregion

        }
    }
}