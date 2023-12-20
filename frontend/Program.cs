using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using frontend;
using frontend.services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
builder.Services.AddScoped<IHttpService, HttpService>();
builder.Services.AddScoped(x =>
{
    var apiUrl = new Uri(builder.Configuration["apiUrl"]);
    return new HttpClient() { BaseAddress = apiUrl };
});
await builder.Build().RunAsync();

// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });