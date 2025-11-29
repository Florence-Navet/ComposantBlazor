using BlazorApp.Server.Components;
using BlazorApp.Server.Services;
using BlazorApp.Shared.Abstractions;
using BlazorApp.Shared.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

//builder.Services.AddSingleton<IApiService, ServerApiService>();
builder.Services.AddScoped<IConsole, JConsole>();
builder.Services.AddTransient<IApiService, ServerApiService>();
//builder.Services.AddScoped<IApiService, ServerApiService>();
builder.Services.AddScoped<IDogService, ServerDogsService>();
//builder.Services.AddHttpClient(); // premiere methode sans parametrage


/*ci dessou avec "dogs" client nommé */
builder.Services.AddHttpClient("dogs", client =>
{
    client.BaseAddress = new Uri("https://dog.ceo");
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
