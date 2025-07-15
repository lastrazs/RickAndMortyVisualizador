using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RickAndMortyVisualizador;
using RickAndMortyVisualizador.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://rickandmortyapi.com/") });
builder.Services.AddScoped<CharacterService>();
builder.Services.AddScoped<LocalStorageService>();

await builder.Build().RunAsync();
