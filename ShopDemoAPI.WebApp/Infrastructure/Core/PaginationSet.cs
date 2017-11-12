using System.Collections.Generic;
using System.Linq;

namespace ShopDemoAPI.WebApp.Infrastructure.Core
{
    public class PaginationSet<T>
    {
        public int Page { get; set; }

        public int count
        {
            get
            {
                return (Items != null) ? Items.Count() : 0;
            }
        }

        public int TotalPages { get; set; }

        public int TotalCount { get; set; }

        public IEnumerable<T> Items { get; set; }
    }
}