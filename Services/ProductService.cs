using ProductAPI.Models;

namespace ProductAPI.Services
{
    public class ProductService
    {
        private readonly List<Product> _products = new() {
         new Product(){ Id=1, Name="Google", Price=2 },
           new Product(){ Id=2, Name="Walmart", Price=1 },
             new Product(){ Id=3, Name="Microsoft", Price=5 },
        };

        public List<Product> GetAll() => _products;
        public Product? Get(int id)=> _products.FirstOrDefault(p => p.Id == id);
        public void Add(Product product) => _products.Add(product);
        public void Remove(int id)=> _products.RemoveAll(p => p.Id == id);
    }
}
