using System;
using System.Collections.Generic;
using TestMVC.Models;

namespace TestMVC.Repositories
{
    public class UserRepository
    {
        /// <summary>
        /// Gets the users from our magic Unicorn factory.
        /// </summary>
        /// <returns>The users.</returns>
        public static List<UserModel> GetUsers() {
            return new List<UserModel>
            {
                new UserModel()
                {
                    FirstName = "George",
                    LastName = "Washington",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1789-1797"
                },

                new UserModel()
                {
                    FirstName = "John",
                    LastName = "Adams",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1797-1801"
                },

                new UserModel()
                {
                    FirstName = "Thomas",
                    LastName = "Jefferson",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1801-1809"
                },

                new UserModel()
                {
                    FirstName = "James",
                    LastName = "Madison",
                    ProfileImagePath = "http://www.placehold.it/200x200",
                    presidentialTerm = "1809-1817"
                }
            };
        }
    }
}