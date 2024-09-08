using E_Commerce.Data;
using E_Commerce.Models.Interfaces;

namespace E_Commerce.Models.Services
{
    public class OrderRepository : IOrderRepository
    {
        private readonly ApplicationDbContext dbContext;
        private readonly IShoppingCartItemRepository cartItemRepository;

        public OrderRepository(ApplicationDbContext dbContext,
            IShoppingCartItemRepository cartItemRepository)
        {
            this.dbContext = dbContext;
            this.cartItemRepository = cartItemRepository;
        }
        public void PlaceOrder(Order order)
        {
            var shoppingItems = cartItemRepository.GetShoppingCartItems();
            foreach(var item in shoppingItems)
            {
                order.OrderDetails.Add(new OrderDetail()
                {
                    Quantity = item.Qty,
                    ProductId = item.Product.Id,
                    Price = item.Product.Price
                });
            }
            order.OrderPlaced = DateTime.Now;
            order.OrderTotal = cartItemRepository.GetShoppingCartTotal();
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }
    }
}
