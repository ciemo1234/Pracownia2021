using Automotive;
using System;
using Xunit;
using FluentAssertions;
namespace AutomotiveTests
{
    public class CarTest
    {
        [Fact]
        public void Can_create_valid_car()
        {
            var car = new Car("Red", "Ford Focus",5.5, 60);

            car.Should().NotBeNull();
            car.Make.Should().Be("Ford Focus");
            car.Color.Should().Be("Red");
            car.FuelConsumption.Should().Be(5.5);
            car.TankCapacity.Should().Be(60);

        }
        public void Tankuj() 
        { 

        }


        


    }
}
