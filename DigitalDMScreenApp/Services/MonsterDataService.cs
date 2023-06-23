using DigitalDMScreen.Shared.Domain;
using System.Text;
using System.Text.Json;

namespace DigitalDMScreenApp.Services
{
    public class MonsterDataService : IMonsterDataService
    {
        private readonly HttpClient _httpClient;

        public MonsterDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Monster> AddMonster(Monster monster)
        {
            // Using Json serialize the passed in Monster
            var monsterJson =
                new StringContent(JsonSerializer.Serialize(monster), Encoding.UTF8, "application/json");

            // Post it via HTTP client to api/monster, the api then runs the correct code
            var response = await _httpClient.PostAsync("api/monster", monsterJson);

            // If api is successful deserialize the response, otherwise return null
            // This means the calling code knows if it went correctly
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Monster>(await
                    response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteMonster(int Id)
        {
            // Via HTTP client call Delete in api/monster giving the Id of monster to be deleted
            await _httpClient.DeleteAsync($"api/monster/{Id}");
        }

        public async Task<IEnumerable<Monster>> GetAllMonsters()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Monster>>
                  (await _httpClient.GetStreamAsync($"api/monster"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Monster> GetMonsterDetails(int Id)
        {
            return await JsonSerializer.DeserializeAsync<Monster>
                (await _httpClient.GetStreamAsync($"api/monster/{Id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateMonster(Monster monster)
        {
            // Using Json serialize the passed in Monster
            var monsterJson =
                new StringContent(JsonSerializer.Serialize(monster), Encoding.UTF8,
                "application/json");

            // Via HTTP client put to api/monster, the api then runs the correct code
            await _httpClient.PutAsync("api/monster", monsterJson);
        }
    }
}
