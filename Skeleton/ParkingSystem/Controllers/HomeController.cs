using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data.Models;

namespace ParkingSystem.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult index()
        {
            return View(DataAccess.Cars);
        }
    }
}