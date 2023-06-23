using DigitalDMScreen.Api.Models;
using DigitalDMScreen.Shared.Domain;
using Microsoft.AspNetCore.Mvc;

namespace DigitalDMScreen.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MonsterController : Controller
    {
        private readonly IMonsterRepository _monsterRepository;
        public MonsterController(IMonsterRepository monsterRepository)
        {
            _monsterRepository = monsterRepository;
        }

        [HttpGet]
        public IActionResult GetAllMonsters()
        {
            return Ok(_monsterRepository.GetAllMonsters());
        }

        [HttpGet("{id}")]
        public IActionResult GetMonsterById(int id)
        {
            return Ok(_monsterRepository.GetMonsterById(id));
        }

        [HttpPost]
        public IActionResult CreateMonster([FromBody] Monster monster)
        {
            if (monster == null)
                return BadRequest();

            if (monster.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var createdMonster = _monsterRepository.AddMonster(monster);

            return Created("monster", createdMonster);
        }

        [HttpPut]
        public IActionResult UpdateMonster([FromBody] Monster monster)
        {
            if (monster == null)
                return BadRequest();

            if (monster.Name == string.Empty)
            {
                ModelState.AddModelError("Name", "The name shouldn't be empty");
            }

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var monsterToUpdate = _monsterRepository.GetMonsterById(monster.Id);

            if (monsterToUpdate == null)
                return NotFound();

            _monsterRepository.UpdateMonster(monster);

            return NoContent(); //success
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMonster(int id)
        {
            if (id == 0)
                return BadRequest();

            var monsterToDelete = _monsterRepository.GetMonsterById(id);
            if (monsterToDelete == null)
                return NotFound();

            _monsterRepository.DeleteMonster(id);

            return NoContent();//success
        }
    }
}
