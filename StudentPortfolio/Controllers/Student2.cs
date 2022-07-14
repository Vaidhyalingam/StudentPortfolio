using Microsoft.AspNetCore.Mvc;

namespace StudentPortfolio.Controllers;
public class Student2 : Controller
{
    //Get: index
    public string Index()
    {
        return "Student 2 has been created";
    }

    //GET: customAction
    public string customAction()
    {
        return "Student 2 has been created from Custom Action Method";
    }
}
