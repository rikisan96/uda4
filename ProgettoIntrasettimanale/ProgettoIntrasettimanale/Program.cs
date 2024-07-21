/*
 Una agenzia di spedizioni ha necessità di sviluppare il sistema di gestione delle varie spedizioni in tutto il territorio nazionale.
Il software richiesto è una applicazione web comprendente oltre alle funzionalità di seguito esposte, una home page di presentazione dell’azienda
ed un form contatti.
La parte back-end del software, accessibile solamente agli addetti della agenzia di spedizione, per mezzo di opportune credenziali, deve consentire di:


- Anagrafare i vari clienti (privati o aziende) che effettuano le varie spedizioni (inoltre per i clienti anagrafare 
    il codice fiscale, per le aziende invece la partita iva),
- Registrare le varie spedizioni indicando, oltre al cliente, un numero identificativo, la data di spedizione, il 
    peso, la città destinataria, l’indirizzo ed il nominativo del destinatario, il costo della spedizione, la data di consegna prevista.

Ogni spedizione prevede degli aggiornamenti dello stato della spedizione stessa.
Essi devono essere registrati per mezzo di una opportuna azione che ne descriva: lo stato (in transito, in consegna, consegnato, non consegnato), il luogo in cui si trova il pacco, una descrizione eventuale, oltre alla data e dell’ora in cui avviene l’aggiornamento.
Una pagina del software, accessibile liberamente da qualsiasi utente, deve consentire al cliente di verificare lo stato della propria spedizione. Inserendo il proprio codice fiscale (o partita IVA se azienda) ed il numero di spedizione, il cliente deve visualizzare tutti gli aggiornamenti annotati per la spedizione richiesta in ordine cronologico inverso (l’aggiornamento più recente è primo nella lista).
Gli aggiornamenti della spedizione devono essere visibili solo se il codice fiscale o la partita IVA inserita dal cliente è effettivamente associata al numero di spedizione inserito.
Infine, l’applicazione deve consentire agli addetti ai lavori di:
Individuare tutte le spedizioni in consegna nella data odierna, (GetShippingDeliveringToday)
Conoscere il numero delle spedizioni totali in attesa di consegna, (GetShippingWai)
Conoscere il numero totale delle spedizioni memorizzate raggruppate per città destinataria.
Istruzioni:
Tutti i dati devono essere salvati in un database SQL Server,
Gradito uso CSS e layout diversi da quelli standard,
Utilizzare le corrette impostazioni di protezione (autenticazione e autorizzazione per mezzo di ruoli).
 
 */



var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
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

app.Run();
