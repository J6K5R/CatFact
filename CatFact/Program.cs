using System.Text.Json;
using System.IO;
using CatFact;

var client = new HttpClient();

try
{ 
    var response = await client.GetAsync("https://catfact.ninja/fact");

    response.EnsureSuccessStatusCode();

    var content = await response.Content.ReadAsStringAsync();

    CatFactDto? catfact = JsonSerializer.Deserialize<CatFactDto>(content);

    if (catfact == null)
    {
        Console.WriteLine("Nie udalo sie pobrac danych");
        
        return;
    }

    using (StreamWriter outputFile = new StreamWriter("CatFact.txt", true))
    {
        outputFile.WriteLine($"Length: {catfact.length} Fact: {catfact.fact}");
    }

}
catch (HttpRequestException ex)
{
    Console.WriteLine($"{ex.StatusCode} {ex.Message}");
}