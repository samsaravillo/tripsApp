using Microsoft.AspNetCore.Mvc;
using tripsApp.Data;
namespace tripsApp.Controllers
{
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
    }
}