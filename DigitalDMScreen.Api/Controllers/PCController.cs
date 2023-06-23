using DigitalDMScreen.Api.Models;
using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DigitalDMScreen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PCController : Controller
    {
        private readonly IPCRepository _pcRepository;
        public PCController(IPCRepository pcRepository)
        {
            _pcRepository = pcRepository;
        }

        [HttpGet]
        public IActionResult GetAllPCs()
        {
            return Ok(_pcRepository.GetAllPCs());
        }

        [HttpGet("{id}")]
        public IActionResult GetPCById(int id)
        {
            return Ok(_pcRepository.GetPCById(id));
        }

        [HttpPost]
        public IActionResult CreatePC([FromBody] PlayerCharacter pc)
        {
            if (pc == null)
                return BadRequest();

            if (pc.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdPC = _pcRepository.AddPC(pc);

            return Created("pc", createdPC);
        }

        [HttpPut]
        public IActionResult UpdatePC([FromBody] PlayerCharacter pc)
        {
            if (pc == null)
                return BadRequest();

            if (pc.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var pcToUpdate = _pcRepository.GetPCById(pc.Id);

            if (pcToUpdate == null)
                return NotFound();

            _pcRepository.UpdatePC(pc);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePC(int id)
        {
            if (id == 0)
                return BadRequest();

            var pcToDelete = _pcRepository.GetPCById(id);
            if (pcToDelete == null)
                return NotFound();

            _pcRepository.DeletePC(id);

            return NoContent();//success
        }
    }
}
