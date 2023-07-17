using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){ Id = 1, Name = "Kenan", Surname = "Elekberov", Point = 55},
                new Student(){ Id = 2, Name = "Elvin", Surname = "Kamilov", Point = 55},
                new Student() {Id = 3, Name = "Ilqar", Surname = "Ebdurrehimov", Point = 35}
            };

            //string name = "Leman";

            //ViewBag.Name = name;
            //ViewData["Name"] = name;
            //TempData["Name"] = name
;
            return View(students);
            //return RedirectToAction("Test");
        }

        public IActionResult Test()
        {
            return View();
        }
    }
}
