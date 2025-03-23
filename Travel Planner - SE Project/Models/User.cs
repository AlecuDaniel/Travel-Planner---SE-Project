using Microsoft.AspNetCore.Mvc;

namespace Travel_Planner___SE_Project.Models
{
    public class User : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
