using DigitalDMScreen.Shared.Domain;

namespace DigitalDMScreen.Api.Models
{
    public class LocationRepository : ILocationRepository
    {
        private readonly AppDbContext _appDbContext;
        private Random random = new Random();

        public LocationRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Location> GetAllLocations()
        {
            return _appDbContext.Locations;
        }

        public Location GetLocationById(int Id)
        {
            return _appDbContext.Locations.FirstOrDefault(c => c.Id == Id);
        }

        public Location AddLocation(Location location)
        {
            var addedEntity = _appDbContext.Locations.Add(location);
            _appDbContext.SaveChanges();
            return addedEntity.Entity;
        }

        public Location UpdateLocation(Location location)
        {
            var foundLocation = _appDbContext.Locations.FirstOrDefault(e => e.Id == location.Id);

            if (foundLocation != null)
            {
                foundLocation.Name = location.Name;
                foundLocation.Type = location.Type;
                foundLocation.Description = location.Description;
                foundLocation.Notes = location.Notes;

                _appDbContext.SaveChanges();

                return foundLocation;
            }

            return null;
        }

        public void DeleteLocation(int Id)
        {
            var foundLocation = _appDbContext.Locations.FirstOrDefault(e => e.Id == Id);
            if (foundLocation == null) return;

            _appDbContext.Locations.Remove(foundLocation);
            _appDbContext.SaveChanges();
        }
    }
}
