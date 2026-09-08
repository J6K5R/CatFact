
var client = new HttpClient();

var response = await client.GetAsync("https://catfact.ninja/fact");

var content = await response.Content.ReadAsStringAsync();

Console.WriteLine(content);