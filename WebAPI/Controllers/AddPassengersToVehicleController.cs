using System.Text.Json.Nodes;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Services;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]/[action]/{passengers}")]
    [ApiController]
    public class AddPassengersToVehicleController : ControllerBase
    {
        private static PassengersService PassengersServiceService => new PassengersService();

        [HttpPost]
        public IActionResult AddPassengersToCar(int passengers)
        {
            try
            {
                var request = PassengersServiceService.PassengersHandler(passengers, Person.VehicleType.Car);

                return request;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPassengersToMotorBike(int passengers)
        {
            try
            {
                var request = PassengersServiceService.PassengersHandler(passengers, Person.VehicleType.MotorBike);
                
                return request;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        public IActionResult AddPassengersToCoach(int passengers)
        {
            try
            {
                var request = PassengersServiceService.PassengersHandler(passengers, Person.VehicleType.Coach);

                return request;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
