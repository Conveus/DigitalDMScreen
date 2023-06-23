using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreenApp.Services
{
    public interface ILocationDataService
    {
        Task<IEnumerable<Location>> GetAllLocations();
        Task<Location> GetLocationDetails(int Id);
        Task<Location> AddLocation(Location location);
        Task UpdateLocation(Location location);
        Task DeleteLocation(int Id);
    }
}
