using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Creacionales
{
    public interface ICarBuilder
    {
        void BuildEngine();
        void BuildChassis();
        void BuildInterior();
    }

    public class CarBuilder : ICarBuilder
    {
        private Car _car = new Car();

        public void BuildEngine()
        {
            _car.AddPart("Powerful Engine");
        }

        public void BuildChassis()
        {
            _car.AddPart("Sturdy Chassis");
        }

        public void BuildInterior()
        {
            _car.AddPart("Luxurious Interior");
        }

        public Car GetCar()
        {
            return _car;
        }
    }

    public class Car
    {
        private List<string> _parts = new List<string>();

        public void AddPart(string part)
        {
            _parts.Add(part);
        }

        public string ListParts()
        {
            return "Car parts: " + string.Join(", ", _parts) + "\n";
        }
    }

    public class CarManufacturer
    {
        private ICarBuilder _builder;

        public CarManufacturer(ICarBuilder builder)
        {
            _builder = builder;
        }

        public void BuildStandardCar()
        {
            _builder.BuildEngine();
            _builder.BuildChassis();
            _builder.BuildInterior();
        }
    }
}
