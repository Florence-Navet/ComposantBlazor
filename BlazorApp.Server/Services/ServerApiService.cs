using BlazorApp.Shared.Services;

namespace BlazorApp.Server.Services;

public class ServerApiService : IApiService, IDisposable

{

    public ServerApiService()
    {
        Console.WriteLine("Ctor service");
    }

    public void Dispose()
    {
        Console.WriteLine("Dispose service");
    }

    public async Task<string> GetDataFromApi()
    {
       await Task.Delay(2000); // Simuler un délai de traitement
       return "Valeur Api serveur";
    }
}
