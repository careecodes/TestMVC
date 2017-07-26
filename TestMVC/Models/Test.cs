using System;

namespace TestMVC.Models

{
    public class FoobarView
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ProfileImagePath { get; set; }
        public string formattedName { get; set; }
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
