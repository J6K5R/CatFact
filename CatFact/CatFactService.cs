using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace CatFact
{
    public class CatFactService
    {
        private HttpClient _httpClient;
        public CatFactService(HttpClient httpclient)
        {
            _httpClient = httpclient;
        }

        public async Task<CatFactDto?> GetCatFact()
        {
            try
            {
                var response = await _httpClient.GetAsync("https://catfact.ninja/fact");

                response.EnsureSuccessStatusCode();

                var content = await response.Content.ReadAsStringAsync();

                CatFactDto? catfact = JsonSerializer.Deserialize<CatFactDto>(content);

                if (catfact == null)
                {
                    Console.WriteLine("Nie udalo sie pobrac danych");
                    return null;
                }

                return catfact;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"{ex.StatusCode} {ex.Message}");
                return null;
            }
        }
    }
}
