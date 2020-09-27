using System;
using System.Linq;
using System.Collections.Generic;
 
namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ - Language Integrated Query
            //LINQ to objects
            int[] numbers = { 23, 34, 56, 12, 23, 89, 65, 10, 44, 33, 66, 69 };
            //fetch numbers which are greater than 50
            var result1 = numbers.Where(x => x > 50 && x < 70);
            //Using Sql query syntax - query expression
            var result2 = from x in numbers where x > 50 && x < 70 select x;
 
            string[] names = { "Sandy", "Ram", "Luffy", "Zoro", "Ronaldo", "Robbon"};
            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("R"));
            var result4 = from y in names where y.Length > 3 && y.ToLower().StartsWith("r") select y;
         // foreach (var name in result4)
         // {
           //   Console.WriteLine(name);
          //}
            var result5 = numbers.Select(x=> x*x);
            //ordering
           
            var result6 = from num in numbers
                          orderby num
                          select num;
        //var result7 = numbers.Take<5>;
        //partitioning
        var result7 = numbers.Skip(5).Take(5);
        //quantifier
        var result8 = numbers.Any(x => x % 2 == 0);
        var result9 = numbers.All(x => x % 2 == 0);
var result10 = numbers.Contains(34);
var result11 = Enumerable.Range(1, 1000);
var result12 = Enumerable.Repeat("Hello World!", 10);

        
    foreach (var num in result12)
    {
        Console.WriteLine(num);

    }
 
           // var countries = Country.GetCountries();
            //var EuCountries = from country in countries where country.Continent == "Europe" && country.Population  < 100000 select country.Name;
           // foreach(var country in EuCountries)
            //{
              //  Console.WriteLine(country);
           // }
            //var result7 = from c in countries 
              //            where c.Continent == "Asia" && c.IndependenceDay == default
                //          select c;
                  // foreach(var country in result7)
            //{
              //  Console.WriteLine(country);
           // }
            

 
//List countries in Europe which has population less than 100k.
//List countries in Asia which are not ever invaded.


        }
    }
}