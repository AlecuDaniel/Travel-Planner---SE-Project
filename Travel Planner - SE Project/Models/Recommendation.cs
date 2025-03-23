using Microsoft.AspNetCore.Mvc;

namespace Travel_Planner___SE_Project.Models
{
    public class Recommendation : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
