using System;


public class User
{
    public int Id { get; set; }
    public required string  Username { get; set; }
    public required string Password { get; set; }
    public string? Email { get; set; }
    public List<string>? UserType { get; set; } = [];       //Gli utenti base saranno aziende e privati, gli admin saranno gli amministratori del sito

    public User()
    {
        // Inizializzazione delle proprietà, se necessario
    }
}
