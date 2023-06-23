using DigitalDMScreen.Shared.Domain;
using System.Text;
using System.Text.Json;

namespace DigitalDMScreenApp.Services
{
    public class LocationDataService : ILocationDataService
    {
        private readonly HttpClient _httpClient;

        public LocationDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Location> AddLocation(Location location)
        {
            // Using Json serialize the passed in Location
            var locationJson =
                new StringContent(JsonSerializer.Serialize(location), Encoding.UTF8, "application/json");

            // Post it via HTTP client to api/location, the api then runs the correct code
            var response = await _httpClient.PostAsync("api/location", locationJson);

            // If api is successful deserialize the response, otherwise return null
            // This means the calling code knows if it went correctly
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Location>(await
                    response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteLocation(int Id)
        {
            // Via HTTP client call Delete in api/location giving the Id of location to be deleted
            await _httpClient.DeleteAsync($"api/location/{Id}");
        }

        public async Task<IEnumerable<Location>> GetAllLocations()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Location>>
                  (await _httpClient.GetStreamAsync($"api/location"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Location> GetLocationDetails(int Id)
        {
            return await JsonSerializer.DeserializeAsync<Location>
                (await _httpClient.GetStreamAsync($"api/location/{Id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateLocation(Location location)
        {
            // Using Json serialize the passed in Location
            var locationJson =
                new StringContent(JsonSerializer.Serialize(location), Encoding.UTF8,
                "application/json");

            // Via HTTP client put to api/location, the api then runs the correct code
            await _httpClient.PutAsync("api/location", locationJson);
        }
    }
}
