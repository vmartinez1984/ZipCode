using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using ZipCode.Core.Entities;

namespace ZipCode.RepositoryMongoDb
{
    public class ZipCodeModel
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string? _id { get; set; }

        public int Id { get; set; }

        public string? ZipCode { get; set; }

        public string? State { get; set; }

        public string? Municipality { get; set; }

        public string? SettementType { get; set; }

        public string? Settement { get; set; }

        public string? City { get; set; }
    }
}