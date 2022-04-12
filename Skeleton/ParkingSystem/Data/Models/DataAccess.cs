using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace ParkingSystem.Data.Models
{
    public class DataAccess
    {
        public static List<Car> Cars { get; set; } = new List<Car>();
    }
}
