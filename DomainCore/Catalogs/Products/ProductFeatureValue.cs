
using ECommerce.DomainCore.Base;
using ECommerce.DomainCore.Catalogs.Features;

namespace ECommerce.DomainCore.Catalogs.Products
{
    public class ProductFeatureValue : Entity<Guid>
    {
        public ProductId ProductId { get; private set; }
        public FeatureId FeatureId { get; private set; }
        public string Value { get; private set; }

        internal static ProductFeatureValue CreateNew(ProductId productId, FeatureId featureId, string value)
        {
            return new ProductFeatureValue(productId, featureId, value);
        }

        private ProductFeatureValue(ProductId productId, FeatureId featureId, string value)
        {
            ProductId = productId;
            FeatureId = featureId;
            Value = value;
        }

        private ProductFeatureValue()
        {

        }
    }
}