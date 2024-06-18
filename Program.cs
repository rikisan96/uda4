using System;

class Program
{
    static void Main(string[] args)
    {
        // Creazione di un'istanza della classe Persona
        Persona persona = new Persona("Mario", "Rossi", 30);

        // Stampa dei dati 
        Console.WriteLine("Nome: " + persona.GetNome());
        Console.WriteLine("Cognome: " + persona.GetCognome());
        Console.WriteLine("Eta: " + persona.GetEta());
        Console.WriteLine("Dettagli: " + persona.GetDettagli());

    }
}