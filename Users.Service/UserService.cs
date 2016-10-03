using System;
using System.Linq;
using Users.DataModel.Models;
using Users.DataModel.MongoDB;

namespace Users.Service
{
    public class UserService : IUserService
    {

        private readonly MongoDBConnection _mongoDBConnection;

        public UserService()
        {
            _mongoDBConnection = new MongoDBConnection();
        }

        public void Insert(User user)
        {
            _mongoDBConnection.Users.Add(user);
        }

        public User GetUser(int id)
        {
            return _mongoDBConnection.Users.Get(id);
        }

        public IQueryable<Date> GetAllDates()
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int id)
        {
            _mongoDBConnection.Users.Delete(u => u.Id, id);
        }

        public void UpdateUser(User user)
        {
            _mongoDBConnection.Users.Update(u => u.Id, user.Id, user);
        }
    }
}
