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
			user1.FirstName = "Caree";
			user1.LastName = "Youngman";
			user1.ProfileImagePath = "../Images/profile.jpg";
            user1.formattedName = $"{user1.LastName}, {user1.FirstName}"; //foobar.LastName + ", " + foobar.FirstName;

			var user2 = new UserModel();
			user2.FirstName = "Johnny";
			user2.LastName = "Appleseed";
			user2.ProfileImagePath = "../Images/profile.jpg";
			user2.formattedName = $"{user2.LastName}, {user2.FirstName}"; //foobar.LastName + ", " + foobar.FirstName;

			users.Add(user1);
			users.Add(user2);

			return users;
        }
    }
}

// Testing my git configuration