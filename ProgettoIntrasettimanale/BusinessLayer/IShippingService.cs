namespace BusinessLayer
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Tipo { get; set; } // Privato o Azienda
        public string CodiceFiscale { get; set; }
        public string PartitaIva { get; set; }
        public ICollection<Spedizione> Spedizioni { get; set; }
    }


    public class Spedizione
    {
        public int Id { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public string NumeroIdentificativo { get; set; }
        public DateTime DataSpedizione { get; set; }
        public double Peso { get; set; }
        public string CittaDestinataria { get; set; }
        public string IndirizzoDestinatario { get; set; }
        public string NominativoDestinatario { get; set; }
        public decimal CostoSpedizione { get; set; }
        public DateTime DataConsegnaPrevista { get; set; }
        public ICollection<AggiornamentoSpedizione> Aggiornamenti { get; set; }
    }

    public class AggiornamentoSpedizione
    {
        public int Id { get; set; }
        public int SpedizioneId { get; set; }
        public Spedizione Spedizione { get; set; }
        public string Stato { get; set; } // In transito, In consegna, Consegnato, Non consegnato
        public string Luogo { get; set; }
        public string Descrizione { get; set; }
        public DateTime DataAggiornamento { get; set; }
    }
    public interface IShippingService
    {
        public Spedizione GetSpedizioneById(int id);

        public List<Spedizione> GetSpedizioneByClient(string client);

        public List<Spedizione> GetSpedizioneByCity(string city);


    }
}
