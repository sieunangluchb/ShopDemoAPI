using System;
using System.Linq.Expressions;
using ShopDemoAPI.Data.Infrastructure;
using ShopDemoAPI.Model.Models;
using System.Collections.Generic;
using System.Linq;

namespace ShopDemoAPI.Data.Repositories
{
    public interface IPostRepository : IRepository<POST>
    {
        IEnumerable<POST> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow);
    }

    public class PostRepository : RepositoryBase<POST>, IPostRepository
    {
        public PostRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }

        public IEnumerable<POST> GetAllByTag(string tag, int pageIndex, int pageSize, out int totalRow)
        {
            //join 2 bảng
            //chỉ chuyển ra câu lệnh sql chứ chưa thực thi
            var query = from p in DbContext.POSTs
                        join pt in DbContext.POSTTAGs
                        on p.ID_POST equals pt.ID_POST
                        where pt.ID_TAG == tag && p.STATUS == true
                        orderby p.CREATEDDAY descending
                        select p;

            //khi thực hiện một hành động nào đó ( VD: .Count() ) thì câu lệnh query mới được thực thi đến database
            totalRow = query.Count();

            //Cách phân trang
            query = query.Skip((pageIndex - 1) * pageSize).Take(pageSize);
            return query;
        }
    }
}