﻿using System;

namespace Sorter.Model
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string OutputName
        {
            get {
                return String.Format("{0}, {1}", LastName, FirstName);
            }
        }

    }
}