using BlazorApp.Shared.Services;
using System.Text.Json;
using System.Net.Http;


namespace BlazorApp.Hybrid.Services;

public class HybridDogService : IDogService
{
    private readonly HttpClient client;

    public HybridDogService(
        HttpClient client)
    {
        this.client = client;
    }

    public async Task<string> GetDogImage()
    {
        var data = await client.GetAsync("https://dog.ceo/api/breeds/image/random");
        if(data.IsSuccessStatusCode)
        {
            JsonDocument doc = JsonDocument.Parse(await data.Content.ReadAsStringAsync());
            return doc.RootElement.GetProperty("message").GetString();
        }
        return " ";
    }
}
