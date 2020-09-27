using System;
using System.Collections.Generic;
public class Country
{
    public string Name { get; set;}
    public string Continent { get; set;}
    public double Area { get; set;}
    public long Population { get; set;}
    public DateTime IndependenceDay { get; set;}
 
    
 
    public Country(string n, string c, double a,long p, DateTime i = default)
    {
        Name=  n;
        Continent = c;
        Area = a;
        Population = p;
        IndependenceDay = i;
     }
 
    public static List<Country> GetCountries()
    {
            Country c1 = new Country( "Nepal", "Asia", 2121212.121, 16783778);
            Country c2 = new Country( "India", "Asia", 112526.56, 3443683, DateTime.Parse("1947/1/1"));
            Country c3 = new Country( "Spain", "Europe", 6282627.89, 334244353534);
            Country c4 = new Country( "USA", "North America", 32224.56, 637383634);
            Country c5 = new Country( "Portugal", "Europe", 100000282.67, 242611);
            Country c6 = new Country( "Sweden", "Europe", 1111122211111.455, 82822);
            Country c7 = new Country( "Ukraine", "Europe", 78892728.1, 637382);
            Country c8 = new Country( "France", "Europe", 7132422.2324, 2342426);
            Country c9 = new Country( "Spain", "Europe", 10000, 1226222);
            Country c10 = new Country( "Norway", "Europe", 1212121.245,78893);
            Country c11= new Country( "Germany", "Europe", 45278922.2, 1445);
            Country c12= new Country( "Finland", "Europe", 111221231233.2, 334244353534);
            Country c13= new Country( "Poland", "Europe", 42561.0, 1234);
            Country c14= new Country( "Italy", "Europe", 122252.121, 53578473);
            Country c15= new Country( "Uk", "Europe", 2122.121, 334244353534);
            Country c16= new Country( "Romania", "Europe", 2121212.121, 33442582);
            Country c17= new Country( "Greece", "Europe",34537728.121, 689262435);
            Country c18= new Country( "Austria", "Europe", 100.121, 123232);
            Country c19= new Country( "Serbia", "Europe", 4162728.121, 3435327);
            Country c20= new Country( "Croatia", "Europe", 2123141.121, 12234252);
 
            var countries = new List<Country> {c1,c2,c3,c4,c5,c6,c7,c8,c9,c10,c11,c12,c13,c14,c15,c16,c17,c18,c19,c20};
 
            return countries; 
    }
 
}
