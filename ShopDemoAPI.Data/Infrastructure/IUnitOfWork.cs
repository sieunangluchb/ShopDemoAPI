namespace ShopDemoAPI.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}