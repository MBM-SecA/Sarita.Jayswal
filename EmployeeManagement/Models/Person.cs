using System;
using System.Collections.Generic;
public class Person
{
    public Guid Id {get; set;}
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Address { get; set; }
    public char Gender { get; set; } = 'M';
    public double Salary { get; set; }
    public static List<Person> GetEmployees()
    {
        Person emp1 = new Person() {Id= Guid.NewGuid(), FirstName = "Saroj", Surname = "Bdr", Address = "kalimati", Salary = 20000.0 };
        Person emp2 = new Person() { Id= Guid.NewGuid(), FirstName = "Ram", Surname = "Shrestha", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp3 = new Person() { Id= Guid.NewGuid(), FirstName = "Raju", Surname = "lionel", Address = "Jorpati", Salary = 20000.0 };
        Person emp4 = new Person() { Id= Guid.NewGuid(), FirstName = "Ram", Surname = "Grg", Address = "Canada", Salary = 20000.0 };
        Person emp5 = new Person() {Id= Guid.NewGuid(), FirstName = "Shyam", Surname = "Limbu", Address = "Nepal", Salary = 20000.0 };
        Person emp6 = new Person() { Id= Guid.NewGuid(), FirstName = "Raju", Surname = "Lama", Address = "Australia", Salary = 20000.0 };
        Person emp7 = new Person() { Id= Guid.NewGuid(), FirstName = "Nayan", Surname = "Limbu", Address = "Ktm", Salary = 20000.0 };
        Person emp8 = new Person() {Id= Guid.NewGuid(), FirstName = "Ram", Surname = "Bahadur", Address = "Pkr", Salary = 20000.0 };

        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8};
        return employees;

    }

}