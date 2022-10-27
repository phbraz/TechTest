using Domain;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Services;

public class PassengersService
{
    public ActionResult PassengersHandler(int passengerAmount, Person.VehicleType vehicleType)
    {
        var passenger = new Person()
        {
            PassengersAmount = passengerAmount,
            Vehicle = vehicleType
        };

        switch (passenger.Vehicle)
        {
            case Person.VehicleType.Car:
                var car = new Car();
                car.Start(passenger);
                return new JsonResult(car.CarRunning);

            case Person.VehicleType.MotorBike:
                var motorBike = new MotorBike();
                motorBike.Start(passenger);
                return new JsonResult(motorBike.MotorBikeRunning);
            
            case Person.VehicleType.Coach:
                var coach = new Coach();
                coach.Start(passenger);
                return new JsonResult(coach.CoachRunning);

            default:
                return new BadRequestResult();
        }
    }
}