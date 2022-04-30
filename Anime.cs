using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

public class Anime
{
    [BsonId]
    public ObjectId id { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }

    [BsonElement("description")]
    public string Description { get; set; }
}
