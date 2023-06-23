using DigitalDMScreen.Shared.Domain;
using System.Text;
using System.Text.Json;

namespace DigitalDMScreenApp.Services
{
    public class PCDataService : IPCDataService
    {
        private readonly HttpClient _httpClient;

        public PCDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<PlayerCharacter> AddPC(PlayerCharacter pc)
        {
            // Using Json serialize the passed in PlayerCharacter
            var pcJson =
                new StringContent(JsonSerializer.Serialize(pc), Encoding.UTF8, "application/json");

            // Post it via HTTP client to api/pc, the api then runs the correct code
            var response = await _httpClient.PostAsync("api/pc", pcJson);

            // If api is successful deserialize the response, otherwise return null
            // This means the calling code knows if it went correctly
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<PlayerCharacter>(await
                    response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeletePC(int Id)
        {
            // Via HTTP client call Delete in api/pc giving the Id of pc to be deleted
            await _httpClient.DeleteAsync($"api/pc/{Id}");
        }

        public async Task<IEnumerable<PlayerCharacter>> GetAllPCs()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<PlayerCharacter>>
                  (await _httpClient.GetStreamAsync($"api/pc"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<PlayerCharacter> GetPCDetails(int Id)
        {
            return await JsonSerializer.DeserializeAsync<PlayerCharacter>
                (await _httpClient.GetStreamAsync($"api/pc/{Id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdatePC(PlayerCharacter pc)
        {
            // Using Json serialize the passed in PlayerCharacter
            var pcJson =
                new StringContent(JsonSerializer.Serialize(pc), Encoding.UTF8,
                "application/json");

            // Via HTTP client put to api/pc, the api then runs the correct code
            await _httpClient.PutAsync("api/pc", pcJson);
        }
    }
}
