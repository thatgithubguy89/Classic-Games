using ClassicGames.Client;
using ClassicGames.Client.Repositories;
using ClassicGames.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITicTacToeRepository, TicTacToeRepository>();
builder.Services.AddScoped<IRockPaperScissorsRepository, RockPaperScissorsRepository>();
builder.Services.AddScoped<IHangmanService, HangmanService>();
await builder.Build().RunAsync();
