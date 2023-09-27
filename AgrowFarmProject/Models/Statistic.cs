using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
    [BsonCollection("Statistics")]
    public class Statistic : BaseEntity
	{
        public string Icon { get; set; }
        public int Size { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
