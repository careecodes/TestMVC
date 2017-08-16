﻿using System;

namespace TestMVC.Models

{
    public class UserModel
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImagePath { get; set; }
        public string presidentialTerm { get; set; }

        public string GetTerm() {
            return this.presidentialTerm;
        }

        public string UnusedField1 { get; set; }
    }
}

