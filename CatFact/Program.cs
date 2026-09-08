using System.Text.Json;
using CatFact;

var client = new HttpClient();

var response = await client.GetAsync("https://catfact.ninja/fact");

Console.WriteLine(response.StatusCode);

var content = await response.Content.ReadAsStringAsync();

CatFactDto? catfact = JsonSerializer.Deserialize<CatFactDto>(content);

if (catfact == null)
{
    return;
}

Console.WriteLine($"{catfact.length} : {catfact.fact}");