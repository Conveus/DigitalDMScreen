using DigitalDMScreen.Api.Models;
using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DigitalDMScreen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : Controller
    {
        private readonly ILocationRepository _locationRepository;
        public LocationController(ILocationRepository locationRepository)
        {
            _locationRepository = locationRepository;
        }

        [HttpGet]
        public IActionResult GetAllLocations()
        {
            return Ok(_locationRepository.GetAllLocations());
        }

        [HttpGet("{id}")]
        public IActionResult GetLocationById(int id)
        {
            return Ok(_locationRepository.GetLocationById(id));
        }

        [HttpPost]
        public IActionResult CreateLocation([FromBody] Location location)
        {
            if (location == null)
                return BadRequest();

            if (location.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdLocation = _locationRepository.AddLocation(location);

            return Created("location", createdLocation);
        }

        [HttpPut]
        public IActionResult UpdateLocation([FromBody] Location location)
        {
            if (location == null)
                return BadRequest();

            if (location.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var locationToUpdate = _locationRepository.GetLocationById(location.Id);

            if (locationToUpdate == null)
                return NotFound();

            _locationRepository.UpdateLocation(location);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteLocation(int id)
        {
            if (id == 0)
                return BadRequest();

            var locationToDelete = _locationRepository.GetLocationById(id);
            if (locationToDelete == null)
                return NotFound();

            _locationRepository.DeleteLocation(id);

            return NoContent();//success
        }
    }
}
