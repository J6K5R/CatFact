# Cat Fact API
Minimal .NET Console App for reading Cat Facts from external REST API and saving them to a local file.

App is using https://catfact.ninja/fact endpoint, deserializes JSON response into C# object, handles HTTP errors and saves each received cat fact and its length as a new line in a local text file.

## Run
Run the application from Visual Studio or using the .NET CLI.

## Technologies
- C#
- .NET 10
- System.Text.Json
- HttpClient
- Dependency Injection
