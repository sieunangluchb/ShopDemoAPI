using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface ISystemConfigRepository : IRepository<SYSTEMCONFIG>
    {
    }

    public class SystemConfigRepository : RepositoryBase<SYSTEMCONFIG>, ISystemConfigRepository
    {
        public SystemConfigRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}