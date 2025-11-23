using BlazorApp.Shared.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Hybrid.Services
{
    internal class HybridApiService : IApiService
    {
        public async Task<string> GetDataFromApi()
        {
            await Task.Delay(750); // Simuler un délai de traitement
            return "Valeur Api Hybrid";
        }
    }
}
