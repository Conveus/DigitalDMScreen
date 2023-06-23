using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public interface IMonsterRepository
    {
        IEnumerable<Monster> GetAllMonsters();
        Monster GetMonsterById(int Id);
        Monster AddMonster(Monster monster);
        Monster UpdateMonster(Monster monster);
        void DeleteMonster(int Id);
    }
}
