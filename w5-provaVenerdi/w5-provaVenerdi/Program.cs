//Esercitazione settimanale

//Il corpo di polizia municipale al quale abbiamo elaborato il database per la gestione delle contravvenzioni, apprezzando il corretto funzionamento ed il lavoro da noi effettuato, decide di commissionarci lo sviluppo di una applicazione Web che consenta di poter memorizzare i dati all’interno del DB già in possesso.

//La applicazione verrà gestita privatamente presso una rete locale, non vi è necessità quindi di una procedura di login.

//La applicazione deve essere così sviluppata:

//-Una sezione che consenta di anagrafare i trasgressori,

//- Una sezione che consenta di avere l’elenco delle violazioni che è possibile contestare,

//- Una sezione per la compilazione del verbale.

//I campi da anagrafare per ogni sezione sono gli stessi presenti nel DB.

//Inoltre, una ulteriore pagina deve dare accesso a diversi link che reindirizzino a pagine diverse che consentano:

//-Di visualizzare il totale dei verbali trascritti raggruppati per trasgressore,

//- Di visualizzare il totale dei punti decurtati raggruppati per trasgressore,

//- Di visualizzare importo, cognome, nome, data di violazione e decurtamento punti delle violazioni che superano i 10 punti,

//- Le violazioni il cui importo è maggiore di 400 euro.

//Istruzioni:

//-Utilizzare il database già creato nelle settimane precedenti,

//- Gradito uso di CSS e layout

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();


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
