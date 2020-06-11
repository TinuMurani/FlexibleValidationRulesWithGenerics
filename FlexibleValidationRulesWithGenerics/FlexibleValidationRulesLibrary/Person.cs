using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class Person
    {
        public Person(string firstName, string lastName, string cnp, DateTime dateOfBirth)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CNP = CNP;
            this.DateOfBirth = dateOfBirth;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string CNP { get; }
        public DateTime DateOfBirth { get; }
        public int Age 
        { 
            get
            {
                return DateTime.Now.Year - this.DateOfBirth.Year;
            }
        }
    }
}
