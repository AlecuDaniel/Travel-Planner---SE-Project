using Microsoft.AspNetCore.Mvc;
using Travel_Planner___SE_Project.Models;
using Travel_Planner___SE_Project.Services;

namespace Travel_Planner___SE_Project.Controllers
{
    public class AdminController : Controller
    {
        private readonly IDestinationService _destinationService;

        public AdminController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public async Task<IActionResult> Index()
        {
            var destinations = await _destinationService.GetAllAsync();
            return View(destinations);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Destination destination)
        {
            if (!ModelState.IsValid) return View(destination);

            await _destinationService.AddAsync(destination);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            var destination = await _destinationService.GetByIdAsync(id);
            if (destination == null) return NotFound();
            return View(destination);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Destination destination)
        {
            if (id != destination.DestinationId || !ModelState.IsValid)
                return View(destination);

            await _destinationService.UpdateAsync(destination);
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Delete(int id)
        {
            var destination = await _destinationService.GetByIdAsync(id);
            if (destination == null) return NotFound();
            return View(destination);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _destinationService.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
