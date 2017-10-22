using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IOrderDetailRepository : IRepository<ORDERDETAIL>
    {
    }

    public class OrderDetailRepository : RepositoryBase<ORDERDETAIL>, IOrderDetailRepository
    {
        public OrderDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}