namespace LinqDenoG02;
using LinqDenoG02;

class program
{
    static void Main(String[] args)
    {
        #region Transformation (Projection Operators) - Select/Select Many

        //var result= ListGenerators.ProductList.Select(product => product.ProductName);
        //var result=from product in ListGenerators.ProductList
        //          select product.ProductName;


        // foreach (var product  in result)
        // {
        //     Console.WriteLine(product);
        // }

        //var result = ListGenerators.CustomerList.SelectMany(Customer => Customer.Orders);

        //foreach (var Customer in result)
        //{
        //    Console.WriteLine(Customer);
        //}

        //var discountProducts = from product in ListGenerators.ProductList
        //                       select new
        //                       {
        //                           Id = product.ProductID,
        //                           ProductName = product.ProductName,
        //                           Category = product.Category,
        //                           count = product.UnitsInStock,
        //                           newPrice = product.UnitPrice * 0.8M
        //                       } into NewProduct
        //                       where NewProduct.count > 10
        //                       select NewProduct;

        //var result = ListGenerators.ProductList.Select((product, index) => new { Index = index, ProductName = product.ProductName, });

        //foreach (var product in result)
        //    Console.WriteLine(product);


        //Indexed select and indexed where are only available at fluent syntax

        #endregion

        #region Ordering Operators

        //var result = ListGenerators.ProductList.Select(product => new { productName = product.ProductName, count = product.UnitsInStock }).OrderBy(product => product.count);

        //var result=ListGenerators.ProductList.OrderBy(product=>product.UnitsInStock).ThenBy(Product=>Product.UnitPrice)
        //    .Select(product => new { ProductName=product.ProductName,count=product.UnitsInStock,price=product.UnitPrice });


        //result = from product in ListGenerators.ProductList
        //         orderby product.UnitsInStock, product.UnitPrice descending
        //         select new { ProductName = product.ProductName, count = product.UnitsInStock, price = product.UnitPrice };

        //foreach (var product in result)
        //{
        //    Console.WriteLine(product);
        //}

        #endregion

        #region Element Operators - Immdeiate execution
        //valid only at fluent syntax

        //List<Product> products = new List<Product>();
        ////First and last throws exceptions if sequence is empty

        ////  var result = products.First();
        ////  result = ListGenerators.ProductList.Last();

        //var result = products.FirstOrDefault();
        ////returns the first value or the default value if the sequence is null based on the datatype

        //result = ListGenerators.ProductList.First(product => product.UnitPrice == 10);
        //first item matches the condition
        //if no element matches the condition, it throws exception

        //var result=ListGenerators.ProductList.ElementAt(0);

        //result = ListGenerators.ProductList.ElementAt(10000);
        ////if there is no element it thriws exception. Out of range

        //result = ListGenerators.ProductList.ElementAtOrDefault(-10);
        //will return null not exception


        //var result = ListGenerators.ProductList.Single();
        ////returns the only element in sequence and throws exception if there is no elements or there more than one element

        //var result = ListGenerators.ProductList.SingleOrDefault();
        //returns null if sequence is empty bt still throws exception if there is more than one element

        //both of them can take the condition and work with exactly the same way without condition



        //Hybrid syntax
        //var result=(from product in ListGenerators.ProductList
        //           where product.ProductID==10
        //           select new{ ProductId= product.ProductID,ProductName=product.ProductName }).FirstOrDefault();

        //Console.WriteLine(result);

        #endregion

        #region Aggregate Operators - Immdeiate execution

        //var result = ListGenerators.ProductList.Count();

        //var result = ListGenerators.ProductList.Count(product=>product.ProductID==10);
        //count based on a condition


        // var result = ListGenerators.ProductList.Min(product=>product.ProductID);
        //will return the min id

        //  var result = ListGenerators.ProductList.MinBy(product => product.ProductID);
        //will return the product that has the min id

        //var result = ListGenerators.ProductList.Min(product => product.ProductName.Length);

        //var result = (from Product in ListGenerators.ProductList
        //          where Product.ProductName.Length == ListGenerators.ProductList.Min(product => product.ProductName.Length)
        //          select Product).FirstOrDefault();

        // Console.WriteLine(ListGenerators.ProductList.Sum(product=>product.UnitsInStock));
        //  Console.WriteLine(ListGenerators.ProductList.Average(product => product.UnitsInStock));



        #endregion

        #region Casting Operators - Immediate execution

        // var product= ListGenerators.ProductList.Where(product => product.UnitsInStock==0).ToList();

        //   var product = ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID);
        //we should choose a key that isn't dublicated or it will be an error
        //   Dictionary<long,string> dic= ListGenerators.ProductList.Where(product => product.UnitsInStock == 0).ToDictionary(product => product.ProductID, product => product.ProductName);


        #endregion

        #region Generator Operators
        //the only way to invoke them is as static methods from IEnumerable claas
        // var result = Enumerable.Range(0, 100);

        // var result=Enumerable.Repeat('%', 100);

        //var result=Enumerable.Empty<Product>().ToList(); //New list of products

        #endregion

        #region Set Operators

        //var seq1=Enumerable.Range(0, 100); //0:99
        //var seq2 = Enumerable.Range(50, 150);//50:199

        //var result=seq1.Union(seq2).ToList(); //Remove dublicates

        //result = seq1.Concat(seq2).ToList(); //doesn't remove dublicates

        //result= seq1.Concat(seq2).Distinct().ToList();

        //result = seq1.Intersect(seq2).ToList();

        //result = seq1.Except(seq2).ToList();


        #endregion

        #region Quantifiers Operators

        //  var result = ListGenerators.ProductList.Any(); //returns a bool, Have any element?
        //  var result = ListGenerators.ProductList.Any(product=>product.UnitPrice==2); //does any element matches the condition

        //  var result=ListGenerators.ProductList.All(product => product.UnitPrice > 2); //does all element matche the condition



        var seq1=Enumerable.Range(0, 100); //0:99
        var seq2 = Enumerable.Range(50, 150);//50:199

        var result=seq1.SequenceEqual(seq2);  //exactly same no of elements and the same elements values


        #endregion

    }
}