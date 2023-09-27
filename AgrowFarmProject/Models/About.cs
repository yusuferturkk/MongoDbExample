using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
	[BsonCollection("Abouts")]
	public class About : BaseEntity
	{
		public string Title { get; set; }
		public string Service1 { get; set; }
		public string Service2 { get; set; }
		public string Service3 { get; set; }
		public string ImageUrl1 { get; set; }
		public string ImageUrl2 { get; set; }
		public string ImageUrl3 { get; set; }
		public string Description { get; set; }
		
    }
}
