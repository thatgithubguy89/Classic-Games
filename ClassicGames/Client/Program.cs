using ClassicGames.Client;
using ClassicGames.Client.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<ITicTacToeService, TicTacToeService>();
builder.Services.AddScoped<IRockPaperScissorsService, RockPaperScissorsService>();
builder.Services.AddScoped<IHangmanService, HangmanService>();
await builder.Build().RunAsync();
