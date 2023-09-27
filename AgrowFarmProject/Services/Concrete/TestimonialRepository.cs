using AgrowFarmProject.Services.Abstract;
using AgrowFarmProject.Settings;

namespace AgrowFarmProject.Services.Concrete
{
    public class TestimonialRepository : MongoGenericRepository<Models.Testimonial>, ITestimonialRepository
    {
        public TestimonialRepository(IDatabaseSettings databaseSettings) : base(databaseSettings)
        {
        }
    }
}
