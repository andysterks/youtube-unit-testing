using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTesting.Domain
{
    public class CarCreationService
    {
        public Car CreateTesla(string model)
        {
            var car = new Car
            {
                Make = "Tesla",
                Model = model
            };

            return car;
        }

        public Car CreateFord(string model)
        {
            var car = new Car
            {
                Make = "Ford",
                Model = model
            };

            return car;
        }
    }
}
