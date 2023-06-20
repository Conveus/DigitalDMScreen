using DigitalDMScreen.Api.Models;
using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DigitalDMScreen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NPCController : Controller
    {
        private readonly INPCRepository _npcRepository;
        public NPCController(INPCRepository npcRepository)
        {
            _npcRepository = npcRepository;
        }

        [HttpGet]
        public IActionResult GetAllNPCs()
        {
            return Ok(_npcRepository.GetAllNPCs());
        }

        [HttpGet("{id}")]
        public IActionResult GetNPCById(int id)
        {
            return Ok(_npcRepository.GetNPCById(id));
        }

        [HttpPost]
        public IActionResult CreateNPC([FromBody] NonPlayerCharacter npc)
        {
            if (npc == null)
                return BadRequest();

            if (npc.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdNPC = _npcRepository.AddNPC(npc);

            return Created("npc", createdNPC);
        }

        [HttpPut]
        public IActionResult UpdateNPC([FromBody] NonPlayerCharacter npc)
        {
            if (npc == null)
                return BadRequest();

            if (npc.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var npcToUpdate = _npcRepository.GetNPCById(npc.Id);

            if (npcToUpdate == null)
                return NotFound();

            _npcRepository.UpdateNPC(npc);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteNPC(int id)
        {
            if (id == 0)
                return BadRequest();

            var npcToDelete = _npcRepository.GetNPCById(id);
            if (npcToDelete == null)
                return NotFound();

            _npcRepository.DeleteNPC(id);

            return NoContent();//success
        }
    }
}
