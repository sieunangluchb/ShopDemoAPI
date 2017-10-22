using System;
using System.Linq.Expressions;
using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface ITagRepository : IRepository<TAG>
    {
    }

    public class TagRepository : RepositoryBase<TAG>, ITagRepository
    {
        public TagRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}