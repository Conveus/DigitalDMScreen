using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public class NPCRepository
    {
        private readonly AppDbContext _appDbContext;
        private Random random = new Random();

        public NPCRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<NonPlayerCharacter> GetAllNPCs()
        {
            return _appDbContext.NPCs;
        }

        public NonPlayerCharacter GetNPCById(int Id)
        {
            return _appDbContext.NPCs.FirstOrDefault(c => c.Id == Id);
        }

        public NonPlayerCharacter AddNPC(NonPlayerCharacter npc)
        {
            var addedEntity = _appDbContext.NPCs.Add(npc);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public NonPlayerCharacter UpdateNPC(NonPlayerCharacter npc)
        {
            var foundNPC = _appDbContext.NPCs.FirstOrDefault(e => e.Id == npc.Id);

            if (foundNPC != null)
            {
                foundNPC.Name = npc.Name;
				foundNPC.Level = npc.Level;
                foundNPC.Gender = npc.Gender;
                foundNPC.Race = npc.Race;
                foundNPC.Role = npc.Role;
                foundNPC.Appearance = npc.Appearance;
                foundNPC.Health = npc.Health;
				foundNPC.MaxHealth = npc.MaxHealth;
                foundNPC.TempHealth = npc.TempHealth;
				foundNPC.ArmourClass = npc.ArmourClass;
                foundNPC.PassivePerception = npc.PassivePerception;
				foundNPC.Attacks = npc.Attacks;
				foundNPC.Notes = npc.Notes;

                _appDbContext.SaveChanges();

                return foundNPC;
            }

            return null;
        }

        public void DeleteNPC(int Id)
        {
            var foundNPC = _appDbContext.NPCs.FirstOrDefault(e => e.Id == Id);
            if (foundNPC == null) return;

            _appDbContext.NPCs.Remove(foundNPC);
            _appDbContext.SaveChanges();
        }
    }
}
