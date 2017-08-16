using System;
using System.Collections.Generic;
using System.Linq;
using TestMVC.Models;

namespace TestMVC.Repositories
{
    public static class UserRepository
    {
        private static List<UserModel> Users { get; set; }

        static UserRepository() {
            Users = new List<UserModel>
            {
                new UserModel()
                {
                    Id = 1,
                    FirstName = "George",
                    LastName = "Washington",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1789-1797"
                },

                new UserModel()
                {
                    Id = 2,
                    FirstName = "John",
                    LastName = "Adams",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1797-1801"
                },

                new UserModel()
                {
                    Id = 3,
                    FirstName = "Thomas",
                    LastName = "Jefferson",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1801-1809"
                },

                new UserModel()
                {
                    Id = 4,
                    FirstName = "James",
                    LastName = "Madison",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1809-1817"
                }
            };
        }

        internal static ApiResponse<UserModel> CreateUser(UserModel newUser)
        {
            throw new NotImplementedException();
        }

        internal static ApiResponse<UserModel> UpdateUser(long id, UserModel newUser)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the users from our magic Unicorn factory.
        /// </summary>
        /// <returns>The users.</returns>
        internal static ApiResponse<IEnumerable<UserModel>> GetUsers() {
            var response = new ApiResponse<IEnumerable<UserModel>>();
            response.Model = Users;
            response.Success = true;
            return response;
        }

        internal static ApiResponse<UserModel> GetUser(long id)
        {
            var response = new ApiResponse<UserModel>();

            var user = Users.FirstOrDefault(x => x.Id == id);

            if (user == null)
            {
                return ApiResponse<UserModel>.GetUserDoesNotExistResponse(id);
            }

            response.Model = user;
            response.Success = true;

            return response;
        }

        /// <summary>
        /// Gets the users from our magic Unicorn factory.
        /// </summary>
        /// <returns>The users.</returns>
        internal static ApiResponse<UserModel> RemoveUser(long id)
        {
            var response = new ApiResponse<UserModel>();

            var user = Users.FirstOrDefault(x => x.Id == id);

            if (user == null) {
                return ApiResponse<UserModel>.GetUserDoesNotExistResponse(id);
            }

            response.Success = Users.Remove(user);

            if (response.Success == false)
            {
                response.AdditionalDetails = "User could not be removed from collection.";
            }

            return response;
        }
    }
}