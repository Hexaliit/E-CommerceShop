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
