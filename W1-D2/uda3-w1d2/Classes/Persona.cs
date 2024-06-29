/*
 Pratica S1/L2
Scrivere una classe Persona con le proprietà Nome, Cognome, Eta e con metodi GetNome, GetCognome, GetEta e GetDettagli che restituisca in una stringa le informazioni sulla persona in questione.
P.S.: GetDettagli restituisce tutti i dettagli (Nome, cognome ed età della persona).
Utilizzare una Console Application per stampare i dati dei metodi. Lasciare al candidato la scelta se utilizzare costruttori per la popolazione degli oggetti o istanziare le proprietà nella classe Program.
 */

using System;

public class Persona
{
    // Proprietà
    public string Nome { get; set; }
    public string Cognome { get; set; }
    public int Eta { get; set; }

    // Costruttore
    public Persona(string nome, string cognome, int eta)
    {
        Nome = nome;
        Cognome = cognome;
        Eta = eta;
    }

    // Metodi
    public string GetNome()
    {
        return Nome;
    }

    public string GetCognome()
    {
        return Cognome;
    }

    public int GetEta()
    {
        return Eta;
    }

    public string GetDettagli()
    {
        return $"Nome: {Nome}, Cognome: {Cognome}, Età: {Eta}";
    }
}