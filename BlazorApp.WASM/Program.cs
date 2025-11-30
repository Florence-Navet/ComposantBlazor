using BlazorApp.Shared.Abstractions;
using BlazorApp.Shared.Services;
using BlazorApp.WASM;
using BlazorApp.WASM.Models;
using BlazorApp.WASM.Services;
using BlazorApp.WASM.Validation;
using FluentValidation;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<IConsole, JConsole>();
builder.Services.AddSingleton<IApiService, WASMApiService>();
builder.Services.AddScoped<IDogService, WASMDogService>( _=> new WASMDogService(new 
    HttpClient { BaseAddress = new Uri("https://dog.ceo")}));

builder.Services.AddScoped<IValidator<Personne>, PersonneValidator>();

await builder.Build().RunAsync();
