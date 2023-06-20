using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public interface INPCRepository
    {
        IEnumerable<NonPlayerCharacter> GetAllNPCs();
        NonPlayerCharacter GetNPCById(int Id);
        NonPlayerCharacter AddNPC(NonPlayerCharacter npc);
        NonPlayerCharacter UpdateNPC(NonPlayerCharacter npc);
        void DeleteNPC(int Id);
    }
}
