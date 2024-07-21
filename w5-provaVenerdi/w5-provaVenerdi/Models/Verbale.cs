namespace w5_provaVenerdi.Models
{
    public class Verbale
    {
        public int Id { get; set; }
        public DateTime DataViolazione { get; set; }
        public int TrasgressoreId { get; set; }
        public Trasgressore Trasgressore { get; set; }
        public int ViolazioneId { get; set; }
        public Violazione Violazione { get; set; }
        // Altri campi necessari
    }

}
