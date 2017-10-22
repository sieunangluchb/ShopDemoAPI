namespace ShopDemoAPI.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopDemoAPIDbContext dbContext;

        public ShopDemoAPIDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopDemoAPIDbContext());
        }
        
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                dbContext.Dispose();
            }
        }
    }
}