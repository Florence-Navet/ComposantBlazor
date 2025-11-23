using BlazorApp.Shared.Abstractions;
using BlazorApp.Shared.Services;

namespace BlazorApp.WASM.Services
{
    public class WASMApiService : IApiService, IDisposable
    {
        private readonly IConsole console;
        /// <summary>
        /// pour avoir une trace de la création du service
        /// </summary>
        /// <param name="console"></param>
        public WASMApiService(IConsole console)
        {
            this.console = console;
            Console.WriteLine("ctor service");
        }

        public void Dispose()
        {
            Console.WriteLine("dispose service");
        }

        public async Task<string> GetDataFromApi()
        {
            await Task.Delay(500); // Simuler un délai de traitement
            return "Valeur Api WASM";
        }
    }
}
