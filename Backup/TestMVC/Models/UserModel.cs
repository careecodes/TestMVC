﻿using System;

namespace TestMVC.Models

{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImagePath { get; set; }
        public string presidentialTerm { get; set; }

        public string GetTerm() {
            return this.presidentialTerm;
        }
    }
}

