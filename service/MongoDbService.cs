using WebApplication1.Models;

using Microsoft.Extensions.Options;

using MongoDB.Driver;

using MongoDB.Bson;


namespace WebApplication1.Services;

public class MongoDBservice
{
    private readonly IMongoCollection<palylist> _playListCollection;

    public MongoDBservice(IOptions<MongoDBSettings> mongoDBsetting){
        MongoClient client = new MongoClient(mongoDBsetting.Value.ConnectionUrl);
        IMongoDatabase database = client.GetDatabase(mongoDBsetting.Value.DatabaseName);
        _playListCollection = database.GetCollection<palylist>(mongoDBsetting.Value.CollectionName);
    }
} 