using E_Commerce.Data;
using E_Commerce.Models.Interfaces;

namespace E_Commerce.Models.Services
{
    public class ProductRepository : IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        private List<Product> _products = new List<Product>()
        {
            new Product(){Id = 1, Name = "Coffe", Detail = "A Fresh coffe to build your day.", ImageUrl = "123.png", Price = 45000, IsTrending = true},
            new Product(){Id = 2, Name = "Capochino", Detail = "A Fresh Capochino to build your day.", ImageUrl = "123.png", Price = 55000, IsTrending = false},
            new Product(){Id = 3, Name = "Hot Chocolate", Detail = "A Fresh Hot chocolate to build your day.", ImageUrl = "123.png", Price = 60000, IsTrending = false}
        };
        private readonly ApplicationDbContext dbContext;

        public IEnumerable<Product> GetAll()
        {
            return dbContext.Products.ToList();
        }

        public IEnumerable<Product> GetAllTrending()
        {
            return dbContext.Products.Where(p => p.IsTrending == true).ToList();
        }

        public Product? GetById(int id)
        {
            return dbContext.Products.Where(p => p.Id == id).FirstOrDefault();
        }
    }
}
