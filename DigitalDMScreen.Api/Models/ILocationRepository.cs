using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetAllLocations();
        Location GetLocationById(int Id);
        Location AddLocation(Location location);
        Location UpdateLocation(Location location);
        void DeleteLocation(int Id);
    }
}
