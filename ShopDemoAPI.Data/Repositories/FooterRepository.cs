using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IFooterRepository : IRepository<FOOTER>
    {
    }

    public class FooterRepository : RepositoryBase<FOOTER>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}