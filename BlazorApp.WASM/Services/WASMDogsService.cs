using BlazorApp.Shared.Services;
using System.Text.Json;
using System.Net.Http;


namespace BlazorApp.WASM.Services;

public class WASMDogService : IDogService
{
    private readonly HttpClient client;

    public WASMDogService(
        HttpClient client)
    {
        this.client = client;
    }

    public async Task<string> GetDogImage()
    {
        var data = await client.GetAsync("/api/breeds/image/random");
        if(data.IsSuccessStatusCode)
        {
            JsonDocument doc = JsonDocument.Parse(await data.Content.ReadAsStringAsync());
            return doc.RootElement.GetProperty("message").GetString();
        }
        return " ";
    }
}
