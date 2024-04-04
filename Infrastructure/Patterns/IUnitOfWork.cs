
namespace ECommerce.Infrastructure.Patterns
{
    public interface IUnitOfWork : IDisposable
    {
        Task SaveChanges();
    }
}
