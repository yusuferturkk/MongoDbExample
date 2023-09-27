using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class AboutRepository : MongoGenericRepository<Models.About>, IAboutRepository
    {
        public AboutRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
