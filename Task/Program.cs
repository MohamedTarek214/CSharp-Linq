
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

            Console.ReadKey();


        }
    }
}
