using System;

namespace AllAboutClasses
{
    public class Country
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public readonly double AREA = 4323.76;
        public static readonly bool IsOnEarth;
        //instance constructor
        //Default constructor
        public Country()
        {

        }
        // Parameterized constructor
        public Country(string name)
        {
            Name = name;
        }
        public Country(string name, int population, double area)
        {
            Name = name;
            Population = population;
            AREA = area;
        }
        //static constructor
        static Country()
        {
             IsOnEarth = true;
        }
        //Finalizer or destructor
        ~Country()
        {
            Console.WriteLine ("I am dying");
;
        }
    }
    public class Demo
    {
        void DoSomething()
        {
            Country country1 = new Country();
            Country country2 = new Country("Nepal");

        }
    }
}
