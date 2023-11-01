namespace WebApplication1.Models
{
    public class MongoDBSettings
    {
        public string ConnectionUrl { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;

        public string CollectionName { get; set; } = null!;
    }
}
