
using ECommerce.Infrastructure.Patterns;
using ECommerce.InfrastructureDatabase.Context;

namespace DevTubeCommerce.Infrastructure.Patterns
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly CommerceContext context;

        public UnitOfWork(CommerceContext context)
        {
            this.context = context;
        }
        public void Dispose()
        {
            context.Dispose();
        }

        public async Task SaveChanges()
        {
            await context.SaveChangesAsync();
        }
    }
}