using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Users.DataModel.Models;

namespace Users.Service
{
    public interface IUserService
    {
        void Insert(User user);
        User GetUser(int id);
        IQueryable<Date> GetAllDates();
        void DeleteUser(int id);
        void UpdateUser(User user);
    }
}
