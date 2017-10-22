using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IPostCategoryRepository : IRepository<POSTCATEGORY>
    {
    }

    public class PostCategoryRepository : RepositoryBase<POSTCATEGORY>, IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}