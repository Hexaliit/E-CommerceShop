namespace E_Commerce.Models.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAllTrending();
        Product? GetById(int id);

    }
}
