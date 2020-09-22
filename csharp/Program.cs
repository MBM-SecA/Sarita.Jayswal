using System;
using System.IO;
using System.Linq;
//using LearnCollections;

public class Program
{
    static void Main()
    {
        // Collections collections = new Collections();
        // collections.LearnDictionary();
       // var square= new Square(20);
       // square.Display();   //var squareArea=square.GetArea();
        
        //square.GetDiagonal();
        // var rectangle =new Rectangle(20,30);
        // var rectangleArea=rectangle.GetArea();

        // var circle= new Circle(20);
        // var circleArea= circle.GetArea();
            //    var square = new Square(35);
       // square.Display();
 
      // var rectangle = new Rectangle(44,32);
     // rectangle.Display();
 

        //FileIO fileIO = new FileIO();
        //fileIO.LearnDirectories();
       var countryText = File.ReadAllText("country.txt");
       string[] country = countryText.Split("\r\n");

    var countryWithNInitial = country.Where(x => x.StartsWith("N")).Select( x => x);
     foreach (var coutry in countryWithNInitial)
     {
         Console.WriteLine(coutry);
     }
      
    }
}