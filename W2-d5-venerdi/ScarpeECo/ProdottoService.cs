using ScarpeCo.Models;
using ScarpeCo.Interfaccia.Models;


namespace ScarpeCo.Repository
{

    public class ProductRepository : IArticoloService
                                     
    {
        private static List<Product> _products = new List<Product>
        {
            new Product {
            Id = 1,
            Name = "Scarpe Neon",
            Price = 59.99m,
            Description = "Scarpe con luci, ricarica USB",
            CoverImageUrl = "./Images/scarpe-clown.jpg",
            ImageUrl1 = "./Images/scarpe-clown.jpg",
            ImageUrl2 = "./Images/scarpe-clown.jpg"

        },
            new Product {
            Id = 2,
            Name = "Sneakers alla moda",
            Price = 79.99m,
            Description = "Sneakers comode e alla moda.",
            CoverImageUrl = "./Images/scarpe-clown.jpg",
            ImageUrl1 = "./Images/scarpe-clown.jpg",
            ImageUrl2 = "./Images/scarpe-clown.jpg"

        }
        };
        public  List<Product> GetAllArticoli()
        {    
            return _products;
        }

        public void AddArticolo(Product articolo)
        {
            _products.Add(articolo);
        }
    
    }
}
