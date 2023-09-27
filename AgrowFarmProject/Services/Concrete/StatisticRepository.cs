using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class StatisticRepository : MongoGenericRepository<Models.Statistic>, IStatisticRepository
    {
        public StatisticRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
