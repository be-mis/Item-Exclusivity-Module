using ItemExclusivity.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using System.Net;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<IMyDataConnection, MyDataConnection>();
var configuration = builder.Configuration.AddJsonFile("appsettings.json").Build();
builder.Services.AddSingleton(configuration);
builder.Services.AddHttpContextAccessor();
builder.Services.AddOptions<FormOptions>().Configure(options =>
{
    options.MultipartBodyLengthLimit = 1024 * 1024 * 100; // 100MB
});
builder.Services.Configure<KestrelServerOptions>(options =>
    {
        options.Listen(IPAddress.Loopback, 5020);
    });

// Configure logging to filter out information logs from Blazor
builder.Logging.ClearProviders(); // Optionally clear default providers
builder.Logging.AddConsole();
builder.Logging.AddFilter("Microsoft.AspNetCore.Components.Server.Circuits.CircuitHost", LogLevel.Error);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
