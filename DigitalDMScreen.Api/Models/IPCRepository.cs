using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public interface IPCRepository
    {
        IEnumerable<PlayerCharacter> GetAllPCs();
        PlayerCharacter GetPCById(int Id);
        PlayerCharacter AddPC(PlayerCharacter pc);
        PlayerCharacter UpdatePC(PlayerCharacter pc);
        void DeletePC(int Id);
    }
}
