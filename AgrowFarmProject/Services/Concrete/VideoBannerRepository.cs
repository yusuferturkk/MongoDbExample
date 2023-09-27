using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class VideoBannerRepository : MongoGenericRepository<Models.VideoBanner>, IVideoBannerRepository
    {
        public VideoBannerRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
