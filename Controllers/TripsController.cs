using Microsoft.AspNetCore.Mvc;
using tripsApp.Data;
namespace tripsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _service;
        public TripsController(ITripService service)
        {
            this._service = service;
        }

        [HttpGet("[action]")]
        public IActionResult GetTrips()
        {
            var allTrips = _service.GetAllTrips();
            return Ok(allTrips);
        }

        [HttpGet("SingleTrip/{id}")]
        public IActionResult GetTripById(int id)
        {
            var trip = _service.GetTripById(id);
            return Ok(trip);
        }

        [HttpPost("[action]")]
        public IActionResult AddTrip([FromBody] Trip trip)
        {
            if (trip != null)
            {
                _service.AddTrip(trip);
            }
            return Ok();
        }

        [HttpPut("[action]/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody] Trip trip)
        {
            _service.UpdateTrip(id, trip);
            return Ok(trip);
        }

        [HttpDelete("[action]/{id}")]
        public IActionResult DeleteTrip(int id)
        {
            _service.DeteleTrip(id);
            return Ok();
        }
    }
}