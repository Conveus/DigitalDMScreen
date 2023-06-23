using DigitalDMScreen.Shared.Domain;
using System.Text;
using System.Text.Json;

namespace DigitalDMScreenApp.Services
{
    public class NPCDataService : INPCDataService
    {
        private readonly HttpClient _httpClient;

        public NPCDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<NonPlayerCharacter> AddNPC(NonPlayerCharacter npc)
        {
            // Using Json serialize the passed in NonPlayerCharacter
            var npcJson =
                new StringContent(JsonSerializer.Serialize(npc), Encoding.UTF8, "application/json");

            // Post it via HTTP client to api/pc, the api then runs the correct code
            var response = await _httpClient.PostAsync("api/npc", npcJson);

            // If api is successful deserialize the response, otherwise return null
            // This means the calling code knows if it went correctly
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<NonPlayerCharacter>(await
                    response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteNPC(int Id)
        {
            // Via HTTP client call Delete in api/pc giving the Id of pc to be deleted
            await _httpClient.DeleteAsync($"api/npc/{Id}");
        }

        public async Task<IEnumerable<NonPlayerCharacter>> GetAllNPCs()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<NonPlayerCharacter>>
                  (await _httpClient.GetStreamAsync($"api/npc"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<NonPlayerCharacter> GetNPCDetails(int Id)
        {
            return await JsonSerializer.DeserializeAsync<NonPlayerCharacter>
                (await _httpClient.GetStreamAsync($"api/npc/{Id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateNPC(NonPlayerCharacter npc)
        {
            // Using Json serialize the passed in PlayerCharacter
            var npcJson =
                new StringContent(JsonSerializer.Serialize(npc), Encoding.UTF8,
                "application/json");

            // Via HTTP client put to api/pc, the api then runs the correct code
            await _httpClient.PutAsync("api/npc", npcJson);
        }
    }
}
