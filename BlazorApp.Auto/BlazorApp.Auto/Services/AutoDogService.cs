using BlazorApp.Shared.Services;
using System.Text.Json;

namespace BlazorApp.Auto.Services;

public class AutoDogService : IDogService
{
    public AutoDogService(
        IHttpClientFactory httpClientFactory)
    {
        HttpClientFactory = httpClientFactory;
    }

    public IHttpClientFactory HttpClientFactory { get; }

    public async Task<string> GetDogImage()
    {
        using var client = HttpClientFactory.CreateClient();
        var data = await client.GetAsync("https://dog.ceo/api/breeds/image/random"); 
        if (data.IsSuccessStatusCode)
        {
            JsonDocument doc = JsonDocument.Parse(await data.Content.ReadAsStringAsync());
            return doc.RootElement.GetProperty("message").GetString();
        }
        return " ";
    }
}

