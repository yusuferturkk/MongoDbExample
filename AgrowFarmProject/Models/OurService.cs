using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
    [BsonCollection("OurServices")]
    public class OurService : BaseEntity
	{
		public string Description { get; set; }
		public string Services { get; set; }
		public string ImageUrl { get; set; }
	}
}
