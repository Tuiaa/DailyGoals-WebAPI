using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Users.DataModel.Models;
using Users.Service;

namespace DailyGoals_WebAPI.Controllers
{
    public class UsersController : ApiController
    {
        private readonly IUserService _userService;

        public UsersController()
        {
            _userService = new UserService();
        }

        // GET api/student/id
        public HttpResponseMessage Get(int id)
        {
            var user = _userService.GetUser(id);
            if (user != null)
                return Request.CreateResponse(HttpStatusCode.OK, user);

            return Request.CreateErrorResponse(HttpStatusCode.NotFound, "User not found for provided id");
        }

        public HttpResponseMessage GetAll()
        {
            throw new NotImplementedException();
        }

        public void Post([FromBody]User user)
        {
            _userService.Insert(user);
        }

        public void Delete(int id)
        {
            _userService.DeleteUser(id);
        }

        public void Put([FromBody]User user)
        {
            _userService.UpdateUser(user);
        }
    }
}
