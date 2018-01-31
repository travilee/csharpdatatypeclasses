using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Library
{
    public class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public float Weight { get; set; }

        public Vehicle()
        {

        }

        public Vehicle(string make, string model, int year, float weight)
        {
            Make = make;
            Model = model;
            Year = year;
            Weight = weight;
        }

        public override string ToString()
        {
            return string.Format($"Vehicle Make and Model: {Make} {Model}\nYear: {Year}\nWeight: {Weight:n} lb");
        }
    }
}
