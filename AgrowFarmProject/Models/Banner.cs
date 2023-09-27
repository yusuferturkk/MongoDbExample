using Microsoft.CodeAnalysis.CSharp.Syntax;
using MongoDB.Bson.Serialization.Attributes;

namespace AgrowFarmProject.Models
{
    [BsonCollection("Banners")]
    public class Banner : BaseEntity
	{
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
    }
}
