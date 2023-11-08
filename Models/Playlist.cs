using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;


namespace WebApplication1.Models;

public class Playlist
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id {  get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
 
}
