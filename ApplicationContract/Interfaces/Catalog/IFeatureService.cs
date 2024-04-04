
using ECommerce.ApplicationContract.Dto.Catalog;

namespace ECommerce.ApplicationContract.Interfaces.Catalog
{
    public interface IFeatureService
    {
        Task<List<FeatureDto>> GetAll();
        Task<FeatureDto> GetById(Guid id);
        Task Add(FeatureDto model);
        Task Edit(FeatureDto model);
        Task Remove(Guid id);

    }
}
