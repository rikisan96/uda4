using w5_progettoVenerdi.Services;
using w5_progettoVenerdi.Models;
using w5_progettoVenerdi.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IAnagraficheService, AnagraficheService>();
//builder.Services.AddSingleton<ITipoViolazioneService , TipoViolazioneService>();
//builder.Services.AddSingleton<IVerbaleService , VerbaleService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
