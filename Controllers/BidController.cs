using BidCalculationProjectMVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BidCalculationProjectMVC.Controllers
{
    public class BidController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CalculateBid(VehicleViewModel vehicle)
        {
            try
            {
                var bidCalculator = new BidCalculator();
                var totalCost = bidCalculator.CalculateTotalCost(vehicle);

                ViewBag.TotalCost = totalCost;
                ViewBag.Vehicle = vehicle;                

                // Calculate fees and pass them to the view
                var fees = bidCalculator.GetFeesDetails(vehicle);
                ViewBag.Fees = fees;

                return View("Result");
            }
            catch (FormatException)
            {
                ModelState.AddModelError(string.Empty, "Error: Invalid input format. Please enter valid numeric values.");
                return View("Index");
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An unexpected error occurred: {ex.Message}");
                return View("Index");
            }
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
