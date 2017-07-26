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
        public static List<FoobarView> GetUsers() {
            var users = new List<FoobarView>();

			var foobar = new FoobarView();
			foobar.FirstName = "Caree";
			foobar.LastName = "Youngman";
			foobar.ProfileImagePath = "../Images/profile.jpg";
			foobar.formattedName = foobar.LastName + ", " + foobar.FirstName;

			//foobar.age = new Adder().Add(1).Add(1.0).Add(foobar.FirstName).GetSum();

            users.Add(foobar);

			return users;
        }
    }
}
