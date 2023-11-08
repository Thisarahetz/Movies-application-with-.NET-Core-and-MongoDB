using WebApplication1.Models;

using Microsoft.Extensions.Options;

using MongoDB.Driver;

using MongoDB.Bson;


namespace WebApplication1.Services;

public class MongoDBservice
{
    private readonly IMongoCollection<Playlist> _playListCollection;

    public MongoDBservice(IOptions<MongoDBSettings> mongoDBsetting){
        MongoClient client = new MongoClient(mongoDBsetting.Value.ConnectionUrl);
        IMongoDatabase database = client.GetDatabase(mongoDBsetting.Value.DatabaseName);
        _playListCollection = database.GetCollection<Playlist>(mongoDBsetting.Value.CollectionName);
    }


    public async Task<List<Playlist>> GetAsyncd(){
        return await _playListCollection.Find(new BsonDocument()).ToListAsync();
 }

    public async Task CreateAsync(Playlist playlist)
    {
        await _playListCollection.InsertOneAsync(playlist);
        return;
    }







} 