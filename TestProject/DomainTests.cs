using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using WebApi.Services;
using Xunit;

namespace TestProject
{
    public class DomainTests
    {
        [Fact]
        public void TestPassengerType()
        {
            //arrange
            const int passengers = 3;
            const Person.VehicleType vehicle = Person.VehicleType.Car;
            
            //Act
            var person = new Person()
            {
                PassengersAmount = passengers,
                Vehicle = vehicle
            };
            
            //Assert
            Assert.IsType<Person>(person);
            Assert.IsType<Person.VehicleType>(vehicle);
            Assert.IsType<int>(passengers);
            

        }
    }
}
