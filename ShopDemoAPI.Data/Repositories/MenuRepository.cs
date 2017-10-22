using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IMenuRepository : IRepository<MENU>
    {
    }

    public class MenuRepository : RepositoryBase<MENU>, IMenuRepository
    {
        public MenuRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}