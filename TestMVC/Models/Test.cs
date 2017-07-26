using System;

// QUESTION
// Declaring namespace ---? Why is this necessary? Ask Cole/Taryn
// organization
namespace TestMVC.Models

{
    public class FoobarView
    {
        // Declaring variables? What is this?
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImagePath { get; set; }
        public string formattedName { get; set; }
        public decimal age { get; set; }
    }

    public class SomeNewClass {
        public SomeNewClass() {
            throw new NotSupportedException("I don't even know why I'm here");
        }
    }
}

namespace TestMVC.OtherModels {
    public class SomeNewClass {
        public SomeNewClass() {
            throw new NotSupportedException("I don't even know why I'm here, but I'm in the other namespace");
        }
    }
}

// QUESTION
// public vs private - "same thing" as immutable vs mutable?
// NO, no immutable in C# unless you write it as such, which is a pain in the ass