using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestMVC.Models;
using TestMVC.Repositories;

namespace TestMVC.Controllers
{
    public class UsersController : ApiController
    {
        // GET api/Users
        public ApiResponse<IEnumerable<UserModel>> Get()
        {
            return UserRepository.GetUsers();
        }

        // GET api/Users/5
        public ApiResponse<UserModel> Get(long id)
        {
            return UserRepository.GetUser(id);
        }

        // POST api/Users
        public ApiResponse<UserModel> Post(UserModel newUser)
        {
            if (newUser == null) {
                return new ApiResponse<UserModel>() {
                    Success = false,
                    ErrorMessage = "User object must be provided"
                };
            }

            return UserRepository.CreateUser(newUser);
        }

        // PUT api/Users/5
        public ApiResponse<UserModel> Put(long id, UserModel newUser)
        {
            var existingUser = Get(id);
            if (existingUser == null) {
                return ApiResponse<UserModel>.GetUserDoesNotExistResponse(id);
            }

            return UserRepository.UpdateUser(id, newUser);
        }

        // DELETE api/Users/5
        public ApiResponse<UserModel> Delete(long id)
        {
            return UserRepository.RemoveUser(id);
        }
    }
}