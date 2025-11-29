using BlazorApp.Shared.Services;
using System.Text.Json;

namespace BlazorApp.Server.Services;

public class ServerDogsService : IDogService
{
    public ServerDogsService(
        IHttpClientFactory httpClientFactory)
    {
        HttpClientFactory = httpClientFactory;
    }

    public IHttpClientFactory HttpClientFactory { get; }

    public async Task<string> GetDogImage()
    {
        using var client = HttpClientFactory.CreateClient("dogs");
        //var data = await client.GetAsync("https://dog.ceo/api/breeds/image/random"); //pour sans parametre
        var data = await client.GetAsync("/api/breeds/image/random");
        if (data.IsSuccessStatusCode)
        {
            JsonDocument doc = JsonDocument.Parse(await data.Content.ReadAsStringAsync());
            return doc.RootElement.GetProperty("message").GetString();
        }
        return " ";
    }
}

