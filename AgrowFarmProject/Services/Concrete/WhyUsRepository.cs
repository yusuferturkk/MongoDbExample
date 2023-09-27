using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class WhyUsRepository : MongoGenericRepository<Models.WhyUs>, IWhyUsRepository
    {
        public WhyUsRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
