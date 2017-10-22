using System;

namespace ShopDemoAPI.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        ShopDemoAPIDbContext Init();
    }
}