using System;
using System.Linq.Expressions;
using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IMenuGroupRepository : IRepository<MENUGROUP>
    {
    }

    public class MenuGroupRepository : RepositoryBase<MENUGROUP>, IMenuGroupRepository
    {
        public MenuGroupRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}