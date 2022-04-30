using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
public class Anime
{
    [BsonId]
    public ObjectId ObjectId { get; set; }

    [BsonElement("name")]
    public string Name { get; set; }
    [BsonElement("nota")]
    public string Nota { get; set; }
}
