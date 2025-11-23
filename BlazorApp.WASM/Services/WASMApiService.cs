using BlazorApp.Shared.Services;

namespace BlazorApp.WASM.Services
{
    public class WASMApiService : IApiService
    {
        public async Task<string> GetDataFromApi()
        {
            await Task.Delay(500); // Simuler un délai de traitement
            return "Valeur Api WASM";
        }
    }
}
