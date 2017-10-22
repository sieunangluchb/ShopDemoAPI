using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IOrderRepository : IRepository<ORDER>
    {
    }

    public class OrderRepository : RepositoryBase<ORDER>, IOrderRepository
    {
        public OrderRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}