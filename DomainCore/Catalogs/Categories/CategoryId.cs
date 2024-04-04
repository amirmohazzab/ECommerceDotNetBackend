
using ECommerce.DomainCore.Base;

namespace ECommerce.DomainCore.Catalogs.Categories
{
    public sealed class CategoryId : StronglyTypedId<CategoryId>
    {
        public CategoryId(Guid value) : base(value)
        {
        }
    }
}