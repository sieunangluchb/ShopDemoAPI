using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IProductTagRepository : IRepository<PRODUCTTAG>
    {
    }

    public class ProductTagRepository : RepositoryBase<PRODUCTTAG>, IProductTagRepository
    {
        public ProductTagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}