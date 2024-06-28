using System;

public class Contribuente
{
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public DateTime DataNascita { get; set; }
    public string CodiceFiscale { get; set; }
    public char Sesso { get; set; }
    public string ComuneResidenza { get; set; }
    public decimal RedditoAnnuale { get; set; }

    public Contribuente(string nome, string cognome, DateTime dataNascita, string codiceFiscale, char sesso, string comuneResidenza, decimal redditoAnnuale)
    {
        Nome = nome;
        Cognome = cognome;
        DataNascita = dataNascita;
        CodiceFiscale = codiceFiscale;
        Sesso = sesso;
        ComuneResidenza = comuneResidenza;
        RedditoAnnuale = redditoAnnuale;
    }

    public decimal CalcolaImposta()
    {
        decimal imposta = 0;

        if (RedditoAnnuale <= 15000)
        {
            imposta = RedditoAnnuale * 0.23m;
        }
        else if (RedditoAnnuale <= 28000)
        {
            imposta = 3450 + (RedditoAnnuale - 15000) * 0.27m;
        }
        else if (RedditoAnnuale <= 55000)
        {
            imposta = 6960 + (RedditoAnnuale - 28000) * 0.38m;
        }
        else if (RedditoAnnuale <= 75000)
        {
            imposta = 17220 + (RedditoAnnuale - 55000) * 0.41m;
        }
        else
        {
            imposta = 25420 + (RedditoAnnuale - 75000) * 0.43m;
        }

        return imposta;
    }

    public void StampaRiepilogo()
    {
        Console.WriteLine("===============================================");
        Console.WriteLine("CALCOLO DELL'IMPOSTA DA VERSARE:");
        Console.WriteLine($"Contribuente: {Nome} {Cognome},");
        Console.WriteLine($"nato il {DataNascita.ToShortDateString()} ({Sesso}),");
        Console.WriteLine($"residente in {ComuneResidenza},");
        Console.WriteLine($"codice fiscale: {CodiceFiscale}");
        Console.WriteLine($"Reddito dichiarato: {RedditoAnnuale:C}");
        Console.WriteLine($"IMPOSTA DA VERSARE: {CalcolaImposta():C}");
        Console.WriteLine("===============================================");
    }
}

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Cognome: ");
        string cognome = Console.ReadLine();
        Console.Write("Data di nascita (dd/MM/yyyy): ");
        DateTime dataNascita = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.Write("Codice Fiscale: ");
        string codiceFiscale = Console.ReadLine();
        Console.Write("Sesso (M/F): ");
        char sesso = char.Parse(Console.ReadLine());
        Console.Write("Comune di Residenza: ");
        string comuneResidenza = Console.ReadLine();
        Console.Write("Reddito Annuale: ");
        decimal redditoAnnuale = decimal.Parse(Console.ReadLine());

        Contribuente contribuente = new Contribuente(nome, cognome, dataNascita, codiceFiscale, sesso, comuneResidenza, redditoAnnuale);
        contribuente.StampaRiepilogo();
    }
}
