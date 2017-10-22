using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IVisitorStatisticRepository : IRepository<VISITORSTATISTIC>
    {
    }

    public class VisitorStatisticRepository : RepositoryBase<VISITORSTATISTIC>, IVisitorStatisticRepository
    {
        public VisitorStatisticRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}