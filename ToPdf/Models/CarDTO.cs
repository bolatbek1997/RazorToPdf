
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToPdf.Models
{
    public class CarDTO
    {
        public string NameOfCar { get; set; }
        public int NumberOfDoors { get; set; }
        public DateTime FirstRegistration { get; set; }
        public double MaxSpeed { get; set; }
    }
}
