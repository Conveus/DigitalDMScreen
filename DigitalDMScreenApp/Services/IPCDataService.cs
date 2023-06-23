using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreenApp.Services
{
    public interface IPCDataService
    {
        Task<IEnumerable<PlayerCharacter>> GetAllPCs();
        Task<PlayerCharacter> GetPCDetails(int Id);
        Task<PlayerCharacter> AddPC(PlayerCharacter pc);
        Task UpdatePC(PlayerCharacter pc);
        Task DeletePC(int Id);
    }
}
