using FlexibleValidationRulesLibrary;
using System;
using System.Collections.Generic;

namespace FlexibleValidationRulesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationEngine validationEngine = new ValidationEngine(new IValidationRule<object>[]
            {
                
            });
            
            
            

            //PersonListProcessor processor = new PersonListProcessor(validationEngine);

            //processor.Process(new List<Person>
            //{
            //    new Person
            //    {
            //        FirstName = "John",
            //        LastName = "Doe",
            //        CNP = "123433443",
            //        DateOfBirth = new DateTime(1980, 1, 20)
            //    },
            //    new Person
            //    {
            //        FirstName = "Johnny",
            //        LastName = "Deep",
            //        CNP = "",
            //        DateOfBirth = new DateTime(1976, 5, 20)
            //    }
            //});

            Console.ReadLine();
        }
    }
}
