using DigitalDMScreen.Shared.Domain;
using System.Text;
using System.Text.Json;

namespace DigitalDMScreenApp.Services
{
    public class NoteDataService : INoteDataService
    {
        private readonly HttpClient _httpClient;

        public NoteDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Note> AddNote(Note note)
        {
            // Using Json serialize the passed in Note
            var noteJson =
                new StringContent(JsonSerializer.Serialize(note), Encoding.UTF8, "application/json");

            // Post it via HTTP client to api/note, the api then runs the correct code
            var response = await _httpClient.PostAsync("api/note", noteJson);

            // If api is successful deserialize the response, otherwise return null
            // This means the calling code knows if it went correctly
            if (response.IsSuccessStatusCode)
            {
                return await JsonSerializer.DeserializeAsync<Note>(await
                    response.Content.ReadAsStreamAsync());
            }

            return null;
        }

        public async Task DeleteNote(int Id)
        {
            // Via HTTP client call Delete in api/note giving the Id of note to be deleted
            await _httpClient.DeleteAsync($"api/note/{Id}");
        }

        public async Task<IEnumerable<Note>> GetAllNotes()
        {
            return await JsonSerializer.DeserializeAsync<IEnumerable<Note>>
                  (await _httpClient.GetStreamAsync($"api/note"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Note> GetNoteDetails(int Id)
        {
            return await JsonSerializer.DeserializeAsync<Note>
                (await _httpClient.GetStreamAsync($"api/note/{Id}"), new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task UpdateNote(Note note)
        {
            // Using Json serialize the passed in Note
            var noteJson =
                new StringContent(JsonSerializer.Serialize(note), Encoding.UTF8,
                "application/json");

            // Via HTTP client put to api/note, the api then runs the correct code
            await _httpClient.PutAsync("api/note", noteJson);
        }
    }
}
