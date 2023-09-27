using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class OurServiceRepository : MongoGenericRepository<Models.OurService>, IOurServiceRepository
    {
        public OurServiceRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
