using System.Text.Json;
using System.IO;
using CatFact;

var client = new HttpClient();

var catFactService = new CatFactService(client);

var catFact = await catFactService.GetCatFact();

var catFactFileWriter = new CatFactFileWriter();

if (catFact == null)
{
    Console.WriteLine("Nie mozna pobrac danych");
    return;
}

catFactFileWriter.Save(catFact);