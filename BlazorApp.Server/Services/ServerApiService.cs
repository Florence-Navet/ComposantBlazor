using BlazorApp.Shared.Services;

namespace BlazorApp.Server.Services;

public class ServerApiService : IApiService
{
    public async Task<string> GetDataFromApi()
    {
       await Task.Delay(2000); // Simuler un délai de traitement
       return "Valeur Api serveur";
    }
}
