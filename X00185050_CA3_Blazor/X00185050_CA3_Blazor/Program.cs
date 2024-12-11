using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using X00185050_CA3_Blazor;
using X00185050_CA3_Blazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<WatchlistService>();

builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

builder.Logging.SetMinimumLevel(LogLevel.Debug);

await builder.Build().RunAsync();


