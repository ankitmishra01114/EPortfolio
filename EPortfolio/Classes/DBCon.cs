using MongoDB.Driver;  // Import MongoDB driver

namespace EPortfolio.Classes
{
    public class DBCon
    {
        private readonly IMongoDatabase _database;

        // Constructor: Establish connection with MongoDB
        public DBCon()
        {
            var client = new MongoClient("mongodb://localhost:27017");  // Connect to local MongoDB
            _database = client.GetDatabase("EPortfolioDB");  // Use database named 'EPortfolioDB'
        }

        // Generic method to get MongoDB collection (table)
        public IMongoCollection<T> GetCollection<T>(string collectionName)
        {
            return _database.GetCollection<T>(collectionName);
        }
    }
}
