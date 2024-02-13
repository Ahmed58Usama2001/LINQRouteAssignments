namespace LinqDenoG02;
using LinqDenoG02;
using System.Text.RegularExpressions;

class program
{
    static void Main(String[] args)
    {

        #region Zip operator

        //List<string>names=new List<string> { "Ahmed","Usama","Ali","Omar","Nashwa"};
        //List<int>numbers=Enumerable.Range(0,10).ToList();

        //var result = names.Zip(numbers, (name, index) => new { Index = index,Name = name });

        //foreach (var item in result) 
        //{
        //    Console.WriteLine(item);
        //}

        #endregion

        #region Grouping Operator

        //var result = ListGenerators.ProductList.Where(product => product.UnitsInStock > 0)
        //    .GroupBy(product => product.Category)
        //    .Where(productGroup => productGroup.Count() > 10)
        //    .OrderByDescending(productGroup => productGroup.Count())
        //    .Select(productGroup => new { Category = productGroup.Key, count = productGroup.Count() });


        //var result = from product in ListGenerators.ProductList
        //             where product.UnitsInStock > 0
        //             group product by product.Category
        //        into productGroup
        //             where productGroup.Count() > 10
        //             orderby productGroup.Count() descending
        //             select new { Category = productGroup.Key, count = productGroup.Count() };

        //foreach (var group in result)
        //{
        //    //Console.WriteLine(group.Key);
        //    //foreach (var item in group)
        //    //{
        //    //    Console.WriteLine(item);
        //    //}
        //    //Console.WriteLine("====================================");
        //    Console.WriteLine(group);
        //}

        #endregion

        #region Partitioning Operators

        // var result=ListGenerators.ProductList.Where(product=>product.UnitsInStock==0).Take(3);

        // var result = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).TakeLast(3);

        //var result = ListGenerators.ProductList.Where(product => product.UnitsInStock > 0).Skip(2);

        // var result = ListGenerators.ProductList.Where(product => product.UnitsInStock > 0).SkipLast(2);




        //foreach (var item in result)
        //{
        //    Console.WriteLine(result);
        //}

        #endregion


        #region Let - Into
        //List<string>names=new List<string> { "Ahmed","Usama","Ali","Omar","Nashwa"};

        //var result=from name in names
        //           select Regex.Replace(name, "[aeiouAEIOU]" ,string.Empty)
        //           into newName
        //           where newName.Length>3
        //           select newName;

        //result= from name in names
        //        let newName =Regex.Replace(name, "[aeiouAEIOU]", string.Empty)
        //        where newName.Length > 3
        //        select newName;

        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}



        #endregion

    }
}