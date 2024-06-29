/*
 La ditta Scarpe & Co, che commercializza scarpe da tennis, commissiona lo sviluppo di un piccolo portale per la gestione e la vendita dei propri prodotti.
La WebApplication, che deve essere sviluppata in ASP.NET MVC CORE, deve poter consentire di archiviare una serie di informazioni relativi ad un articolo, in particolare:
- Nome dell'articolo,
- Il prezzo, 
- Una descrizione dettagliata,
- Una immagine di copertina,
- Due immagini aggiuntive,

La vetrina del sito, opportunamente e graficamente costruita, deve poter visualizzare l'elenco dei prodotti in vendita con l'opportunità di poter reindirizzare l'utente alla pagina del prodotto dove visualizzerà le informazioni secondarie al prodotto scelto.

La vetrina deve solo far visualizzare la immagine di copertina, il nome ed il prezzo del prodotto.

Dettagli sulla traccia:

 - Utilizzare i models appropriati,

 - Gradito uso di CSS e Layout,

 - Come repository per gli oggetti utilizzare liste statiche

 */


using ScarpeCo.Interfaccia.Models;
using ScarpeCo.Repository;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddSingleton<IArticoloService, ProductRepository>();



builder.Services.AddControllersWithViews();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();


app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");


app.UseStaticFiles();



app.Run();
