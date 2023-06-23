using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreenApp.Services
{
    public interface INPCDataService
    {
        Task<IEnumerable<NonPlayerCharacter>> GetAllNPCs();
        Task<NonPlayerCharacter> GetNPCDetails(int Id);
        Task<NonPlayerCharacter> AddNPC(NonPlayerCharacter npc);
        Task UpdateNPC(NonPlayerCharacter npc);
        Task DeleteNPC(int Id);
    }
}
