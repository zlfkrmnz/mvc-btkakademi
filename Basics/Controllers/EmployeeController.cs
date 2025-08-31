using Basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace Basics.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index1()
        {
            string message = $"Hello Selin. {DateTime.Now.ToString()}";
            return View("Index1", message);
        }

        public ViewResult Index2()
        {
            var names = new String[]
            {
                "Selin",
                "Zülfükar",
                "Berk"
            };
            return View(names);
        }

        public IActionResult Index3()
        {
            var list = new List<Employee>()
            {
                new Employee() {Id=1, FirstName="Selin", LastName="Altuntaş", Age=22 },
                new Employee() {Id=2, FirstName="Zülfükar", LastName="Minaz", Age=24 },
                new Employee() {Id=3, FirstName="Berk", LastName="İçli", Age=22 },
            };
            return View(list);
        }
    }
}
