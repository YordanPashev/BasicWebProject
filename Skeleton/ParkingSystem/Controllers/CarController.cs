using Microsoft.AspNetCore.Mvc;
using ParkingSystem.Data.Models;
using System.Linq;

namespace ParkingSystem.Controllers
{
    public class CarController : Controller
    {
        [HttpPost]
        public IActionResult AddCar(Car car)
        {
            DataAccess.Cars.Add(car);
            return Redirect("/");
        }

        [HttpPost]
        public IActionResult DeleteCar(string plateNumber)
        {
            Car car = DataAccess.Cars.FirstOrDefault(c => c.PlateNumber == plateNumber);
            DataAccess.Cars.Remove(car);
            return Redirect("/");
        }

    }
}