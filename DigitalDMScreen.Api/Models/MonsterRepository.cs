using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public class MonsterRepository
    {
        private readonly AppDbContext _appDbContext;
        private Random random = new Random();

        public MonsterRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Monster> GetAllMonsters()
        {
            return _appDbContext.Monsters;
        }

        public Monster GetMonsterById(int Id)
        {
            return _appDbContext.Monsters.FirstOrDefault(c => c.Id == Id);
        }

        public Monster AddMonster(Monster monster)
        {
            var addedEntity = _appDbContext.Monsters.Add(monster);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Monster UpdateMonster(Monster monster)
        {
            var foundMonster = _appDbContext.Monsters.FirstOrDefault(e => e.Id == monster.Id);

            if (foundMonster != null)
            {
                foundMonster.Name = monster.Name;
				foundMonster.Level = monster.Level;
                foundMonster.Health = monster.Health;
				foundMonster.MaxHealth = monster.MaxHealth;
                foundMonster.TempHealth = monster.TempHealth;
				foundMonster.ArmourClass = monster.ArmourClass;
                foundMonster.PassivePerception = monster.PassivePerception;
				foundMonster.Attacks = monster.Attacks;
                foundMonster.Notes = monster.Notes;

                _appDbContext.SaveChanges();

                return foundMonster;
            }

            return null;
        }

        public void DeleteMonster(int Id)
        {
            var foundMonster = _appDbContext.Monsters.FirstOrDefault(e => e.Id == Id);
            if (foundMonster == null) return;

            _appDbContext.Monsters.Remove(foundMonster);
            _appDbContext.SaveChanges();
        }
    }
}
