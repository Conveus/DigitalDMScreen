using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreenApp.Services
{
    public interface IMonsterDataService
    {
        Task<IEnumerable<Monster>> GetAllMonsters();
        Task<Monster> GetMonsterDetails(int Id);
        Task<Monster> AddMonster(Monster monster);
        Task UpdateMonster(Monster monster);
        Task DeleteMonster(int Id);
    }
}
