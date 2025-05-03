using Microsoft.AspNetCore.Mvc;
using Travel_Planner___SE_Project.Models;
using Travel_Planner___SE_Project.Services;

namespace Travel_Planner___SE_Project.Controllers
{
    public class DestinationController : Controller
    {
        private readonly IDestinationService _destinationService;

        public DestinationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Destination()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Search(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return PartialView("Destination", new List<Destination>());

            var results = await _destinationService.SearchAsync(query);
            return PartialView("Destination", results);
        }
    }
}
