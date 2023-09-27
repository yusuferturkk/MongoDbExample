using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
    [BsonCollection("Testimonials")]
    public class Testimonial : BaseEntity
	{
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
