using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IProductCategoryRepository
    {
        IEnumerable<PRODUCTCATEGORY> GetByAlias(string alias);
    }

    public class ProductCategoryRepository : RepositoryBase<PRODUCTCATEGORY>, IProductCategoryRepository
    {
        public ProductCategoryRepository(IDbFactory dbFactory)
            : base(dbFactory)
        {
        }

        public IEnumerable<PRODUCTCATEGORY> GetByAlias(string alias)
        {
            return this.DbContext.PRODUCTCATEGORYs.Where(x => x.ALIAS == alias);
        }
    }
}