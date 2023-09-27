using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
    [BsonCollection("VideoBanners")]
    public class VideoBanner : BaseEntity
	{
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Descripton { get; set; }
        public string? VideoUrl { get; set; }
    }
}
