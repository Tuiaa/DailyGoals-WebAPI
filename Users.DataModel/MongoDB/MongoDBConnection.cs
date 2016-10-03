using MongoDB.Driver;
using Users.DataModel.Models;
using Users.DataModel.GenericRepository;
using System.Configuration;


namespace Users.DataModel.MongoDB
{
    public class MongoDBConnection
    {
        private MongoDatabase _database;
        protected Repository<User> _users;

        public MongoDBConnection()
        {
            var connectionString = ConfigurationManager.AppSettings["MongoDBConnectionString"];
            var client = new MongoClient(connectionString);
            var server = client.GetServer();
            var databaseName = ConfigurationManager.AppSettings["MongoDBDatabaseName"];
            _database = server.GetDatabase(databaseName);
        }

        public Repository<User> Users
        {
            get
            {
                if (_users == null)
                    _users = new Repository<User>(_database, "users");
                return _users;
            }
        }
    }
}
