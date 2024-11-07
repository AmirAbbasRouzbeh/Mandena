using Mandena.AdminDashboard;
using Mandena.AdminDashboard.Helper;
using Mandena.AdminDashboard.Helper.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using static System.Net.WebRequestMethods;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

//builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7056/api/") });
builder.Services.AddScoped<ProductService>();
builder.Services.AddScoped<CategoryService>();

await builder.Build().RunAsync();
