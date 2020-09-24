
    using System.Linq;
using System.Collections.Generic;
using System;

namespace LINQ
{
    class Program
    {
        static void Main()
        {
            //LINQ- language intergrated query
            int[] numbers = {23, 34, 56, 12, 23, 87, 67, 10, 110, 334, 1, 2, 3, 45, 73, 11, 20};

            //Fetch numbers which are greater than 50 amd less than 70

            //using method syntax = lambda expression
             var numbersGreaterThan50 = numbers.Where(x => x >50 && x < 70);
            
            //using sql query syntax = query expression
            var numberGreaterThanFifty = from num in numbers
                                         where num > 50 && num<70
                                         select num;


            string[] names = {"suza", "abcd", "ram", "luffy", "zoro","ronaldo", "Royal", };
            // names having length>3 and starts with letter "r"
            var result3 = names.Where(y => y.Length > 3 && y.StartsWith("r"));
            var result4 = from y in names
                           where y.Length > 3 && y.ToLower().StartsWith("R")
                           select y;

             foreach(var name in result4)
             {
                 Console.WriteLine(name);
             }

            var countries = Country.GetCountries();

            var asianCountries = from country in countries 
                                  where country.Continent == "Asia"
                                  select countries;
            

        
        }
    }
}

