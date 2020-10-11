using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class EmployeeController : Controller
{
    public ActionResult Index()
    {


        //Object Initializer Syntax
        Person emp1 = new Person() { FirstName = "Saroj", Surname = "Bdr", Address = "kalimati", Salary = 20000.0 };
        Person emp2 = new Person() { FirstName = "Ram", Surname = "Shrestha", Address = "Bhaktapur", Salary = 20000.0 };
        Person emp3 = new Person() { FirstName = "Raju", Surname = "lionel", Address = "Jorpati", Salary = 20000.0 };
        Person emp4 = new Person() { FirstName = "Ram", Surname = "Grg", Address = "Canada", Salary = 20000.0 };
        Person emp5 = new Person() { FirstName = "Shyam", Surname = "Limbu", Address = "Nepal", Salary = 20000.0 };
        Person emp6 = new Person() { FirstName = "Raju", Surname = "Lama", Address = "Australia", Salary = 20000.0 };
        Person emp7 = new Person() { FirstName = "Nayan", Surname = "Limbu", Address = "Ktm", Salary = 20000.0 };
        Person emp8 = new Person() { FirstName = "Ram", Surname = "Bahadur", Address = "Pkr", Salary = 20000.0 };

        List<Person> employees = new List<Person>() { emp1, emp2, emp3, emp4, emp5, emp6, emp7, emp8};

        return View(employees);
    }


public ActionResult Detail(string firstName)
{
    return View();
}
}