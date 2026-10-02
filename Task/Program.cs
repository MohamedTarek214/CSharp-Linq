
using System.Diagnostics;
using System.Numerics;
using static System.Runtime.InteropServices.JavaScript.JSType;
 using static Task.ListGenerators;
namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region LINQ - Restriction Operators 
            //1. Find all products that are out of stock.
            //var result = ProductList.Where(e => e.UnitsInStock == 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //---------------------------------------------------------------------

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProductList.Where(e => e.UnitPrice > 30 && e.UnitsInStock != 0);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //---------------------------------------------------------------------

            //3. Returns digits whose name is shorter than their value. 

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Where((e,index) => e.Length < index);  

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region LINQ - Element Operators 
            //1. Get first Product out of Stock 
            //var result = ProductList.FirstOrDefault(e => e.UnitsInStock == 0);
            //Console.WriteLine(result);
            //--------------------------------------------------------------

            //2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProductList.FirstOrDefault(e => e.UnitPrice > 1000);
            //Console.WriteLine(result);
            //--------------------------------------------------------------
            // 3.Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(x => x > 5).Skip(1).First();
            //Console.WriteLine(result);
            #endregion

            #region LINQ - Aggregate Operators

            //1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Count(e => e % 2 !=0);
            //Console.WriteLine(result);
            //--------------------------------------------------------------

            //2. Return a list of customers and how many orders each has.
            //var result = CustomerList.Select(e => new
            //{
            //    ID = e.Id,
            //    Name = e.Name,
            //    OrderCount = e.Orders.Count()
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            // 3.Return a list of categories and how many products each has
            //var result = ProductList.GroupBy(e => e.Category).Select(e => new
            //{
            //    Category = e.Key,
            //    ProductCount = e.Count()
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            // 4.Get the total of the numbers in an array. 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            //--------------------------------------------------------------

            //6.Get the total units in stock for each product category. 
            //var result = ProductList.GroupBy(e => e.Category).Select(a => new
            //{
            //    Name = a.Key,
            //    TotalUnitsInStock = a.Sum(e=> e.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            //8. Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(e => e.Category).Select(e => new
            //{
            //    CategoryName = e.Key,
            //    MinPrice = e.Min(e => e.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            //9. Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let minPrice = g.Min(p => p.UnitPrice)
            //             from product in g
            //             where product.UnitPrice == minPrice
            //             select product;

            //foreach (var product in result)
            //{
            //    Console.WriteLine(product);
            //}
            //--------------------------------------------------------------
            //11. Get the most expensive price among each category's products. 

            //var result = ProductList
            //             .GroupBy(p => p.Category)
            //             .Select(g => new
            //             {
            //                 Category = g.Key,
            //                 MaxPrice = g.Max(p => p.UnitPrice)
            //             });

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Max Price: {item.MaxPrice}");
            //}
            #endregion

            #region LINQ - Ordering Operators
            //1. Sort a list of products by name
            //var result = ProductList.OrderBy(e => e.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item.ProductName);
            //}
            //--------------------------------------------------------------

            //2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x, StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            //3. Sort a list of products by units in stock from highest to lowest. 
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //var result = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //--------------------------------------------------------------

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Where(x => x.Length > 1 && x[1] == 'i').Reverse().ToList();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion

            #region LINQ - Aggregate Operators

            //1. Uses Count to get the number of odd numbers in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int count = Arr.Count(x => x % 2 != 0);
            //Console.WriteLine($"Number of odd numbers: {count}");
            //--------------------------------------------------------------

            //2.Return a list of customers and how many orders each has. 
            //var result = CustomerList.Select(c => new
            //{
            //    CustomerName = c.Name,
            //    OrdersCount = c.Orders.Count()
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine( $"Customer: {item.CustomerName}, Orders: {item.OrdersCount}" );
            //       
            //   
            //}
            //--------------------------------------------------------------

            //4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = Arr.Sum();
            //Console.WriteLine($"Total: {total}");
            //-------------------------------------------------------------

            //6. Get the total units in stock for each product category.

            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Total Units: {item.TotalUnitsInStock}");
            //}
            //--------------------------------------------------------------

            //8.Get the cheapest price among each category's products
            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    CheapestPrice = g.Min(p => p.UnitPrice)
            //});
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Cheapest Price: {item.CheapestPrice}" );
            //        
            //   
            //}
            //-------------------------------------------------------------

            //9. Get the products with the cheapest price in each category (Use Let)

            //var result = from p in ProductList
            //             group p by p.Category into g
            //             let MinPrice = g.Min(p => p.UnitPrice)
            //             from product in g
            //             where product.UnitPrice == MinPrice
            //             select product;

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //-------------------------------------------------------------

            //11. Get the most expensive price among each category's products.

            //var result = ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    ExpensivePrice = g.Max(p => p.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category},  Expensive Price: {item.ExpensivePrice}");
            // 
            //
            //}
            //-------------------------------------------------------------

            //12. Get the products with the most expensive price in each category.

            //var result = ProductList.GroupBy(p => p.Category)
            //    .SelectMany(g => g.Where(p => p.UnitPrice == g.Max(x => x.UnitPrice)));

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            //-------------------------------------------------------------

            //14. Get the average price of each category's products.

            //var result = ListGenerators.ProductList.GroupBy(p => p.Category).Select(g => new
            //{
            //    Category = g.Key,
            //    AveragePrice = g.Average(p => p.UnitPrice)
            //});

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Category: {item.Category}, Average Price: {item.AveragePrice}");

            //}
            #endregion


            Console.ReadKey();



        }
    }
}
