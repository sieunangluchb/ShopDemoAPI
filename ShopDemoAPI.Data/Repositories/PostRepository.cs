using System;
using System.Linq.Expressions;
using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IPostRepository : IRepository<POST>
    {
    }

    public class PostRepository : RepositoryBase<POST>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}