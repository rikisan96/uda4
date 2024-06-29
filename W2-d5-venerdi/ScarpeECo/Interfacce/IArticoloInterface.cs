using ScarpeCo.Models;

namespace ScarpeCo.Interfaccia.Models

{
    public interface IArticoloService
    {
        List<Product> GetAllArticoli();
        void AddArticolo(Product articolo);
    }
}
