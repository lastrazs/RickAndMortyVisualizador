using System.Net.Http.Json;
using RickAndMortyVisualizador.Models;

namespace RickAndMortyVisualizador.Services
{
    public class CharacterService
    {
        private readonly HttpClient _http;

        public CharacterService(HttpClient http)
        {
            _http = http;
        }

        public async Task<List<Character>> GetCharactersAsync()
        {
            var response = await _http.GetFromJsonAsync<ApiResponse>("https://rickandmortyapi.com/api/character");
            return response?.Results ?? new List<Character>();
        }

        public class ApiResponse 
        {
            public List<Character> Results { get; set; } = new List<Character>();
        }
    }

}
