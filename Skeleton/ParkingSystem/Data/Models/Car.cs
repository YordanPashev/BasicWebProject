using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace ParkingSystem.Data.Models
{
    public class Car
    {
        [Required]
        public string CarMake { get; set; }
        [Required]
        public string PlateNumber { get; set; }
        public string ArivalTime { get; set; } = DateTime.Now.ToString(@"HH:mm dd.MM.yyyy");

    }
}