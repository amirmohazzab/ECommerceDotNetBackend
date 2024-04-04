
using ECommerce.DomainCore.Base;

namespace ECommerce.DomainCore.Catalogs.Features
{
    public sealed class FeatureId: StronglyTypedId<FeatureId>
    {
        public FeatureId(Guid value): base(value)
        {

        }
    }
}
