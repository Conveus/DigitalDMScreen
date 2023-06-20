using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public class PCRepository
    {
        private readonly AppDbContext _appDbContext;
        private Random random = new Random();

        public PCRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<PlayerCharacter> GetAllPCs()
        {
            return _appDbContext.PCs;
        }

        public PlayerCharacter GetPCById(int Id)
        {
            return _appDbContext.PCs.FirstOrDefault(c => c.Id == Id);
        }

        public PlayerCharacter AddPC(PlayerCharacter pc)
        {
            var addedEntity = _appDbContext.PCs.Add(pc);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public PlayerCharacter UpdatePC(PlayerCharacter pc)
        {
            var foundPC = _appDbContext.PCs.FirstOrDefault(e => e.Id == pc.Id);

            if (foundPC != null)
            {
                foundPC.Name = pc.Name;
				foundPC.Level = pc.Level;
                foundPC.Gender = pc.Gender;
                foundPC.Race = pc.Race;
                foundPC.Class = pc.Class;
                foundPC.Player = pc.Player;
                foundPC.Health = pc.Health;
				foundPC.MaxHealth = pc.MaxHealth;
                foundPC.TempHealth = pc.TempHealth;
				foundPC.ArmourClass = pc.ArmourClass;
                foundPC.PassivePerception = pc.PassivePerception;
				foundPC.Attacks = pc.Attacks;
                foundPC.Notes = pc.Notes;

                _appDbContext.SaveChanges();

                return foundPC;
            }

            return null;
        }

        public void DeletePC(int Id)
        {
            var foundPC = _appDbContext.PCs.FirstOrDefault(e => e.Id == Id);
            if (foundPC == null) return;

            _appDbContext.PCs.Remove(foundPC);
            _appDbContext.SaveChanges();
        }
    }
}
