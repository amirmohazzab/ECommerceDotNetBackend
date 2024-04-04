
using ECommerce.DomainCore.Base;

namespace ECommerce.DomainCore.Catalogs.Products
{
    public sealed class ProductId : StronglyTypedId<ProductId>
    {
        public ProductId(Guid value):base(value)
        {

        }
    }
}