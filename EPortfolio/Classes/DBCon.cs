using MongoDB.Driver;

namespace EPortfolio.Classes
{
    public class DBCon
    {
        private readonly IMongoDatabase _database;

        public DBCon()
        {
            var client = new MongoClient("mongodb://localhost:27017/");
            _database = client.GetDatabase("eportfolio"); // Your MongoDB database name
        }

        // Method to get a collection
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
