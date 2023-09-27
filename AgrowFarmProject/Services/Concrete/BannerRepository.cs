using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class BannerRepository : MongoGenericRepository<Models.Banner>, IBannerRepository
    {
        public BannerRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
