using FlexibleValidationRulesLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexibleValidationRulesConsoleApp
{
    public class PersonListProcessor
    {
        public PersonListProcessor(ValidationEngine validationEngine)
        {
            this.ValidationEngine = validationEngine;
        }

        public ValidationEngine ValidationEngine { get; }

        public void Process(List<Person> people)
        {
            foreach (Person person in people ?? new List<Person>())
            {
                bool isValid = ValidationEngine.IsValid(person ?? new Person()).Result;

                if (isValid)
                {
                    Console.WriteLine($"Person processed succesfully: { person.FirstName } { person.LastName }, CNP: { person.CNP }, Age: { person.Age }");
                }
                else
                {
                    Console.WriteLine("Eroare de validare");
                }
            }
        }
    }
}
