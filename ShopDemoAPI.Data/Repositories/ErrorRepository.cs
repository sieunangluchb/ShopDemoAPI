using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IErrorRepository : IRepository<ERROR>
    {

    }
    public class ErrorRepository : RepositoryBase<ERROR>, IErrorRepository
    {
        public ErrorRepository(IDbFactory dbFactory) : base(dbFactory)
        {

        }
    }
}
