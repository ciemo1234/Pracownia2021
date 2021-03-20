using System;

namespace Automotive
{
    public class Car
    {
        private string _color;
        private string _make;
        private double _fuelConsumption;
        private int _tankCapacity;

        public Car(string color, string make, double fuelConsumption, int tankCapacity)
        {
            _color = color;
            _make = make;
            _fuelConsumption = fuelConsumption;
            _tankCapacity = tankCapacity;
        }

        public string Make => _make;

        public string Color => _color;
    }
}
