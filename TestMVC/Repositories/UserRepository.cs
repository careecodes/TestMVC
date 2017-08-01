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
            var users = new List<UserModel>();

			var user1 = new UserModel();
			user1.FirstName = "George";
			user1.LastName = "Washington";
			user1.ProfileImagePath = "http://www.placehold.it/200x200";
            user1.presidentialTerm = "1789-1797";


            var user2 = new UserModel();
			user2.FirstName = "John";
			user2.LastName = "Adams";
			user2.ProfileImagePath = "http://www.placehold.it/200x200";
			user2.presidentialTerm = "1797-1801";


			var user3 = new UserModel();
			user3.FirstName = "Thomas";
			user3.LastName = "Jefferson";
			user3.ProfileImagePath = "http://www.placehold.it/200x200";
			user3.presidentialTerm = "1801-1809";


			users.Add(user1);
			users.Add(user2);
			users.Add(user3);


			return users;
        }
    }
}

// Testing my git configuration