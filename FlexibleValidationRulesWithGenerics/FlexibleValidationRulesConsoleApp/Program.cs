using FlexibleValidationRulesLibrary;
using System;
using System.Collections.Generic;

namespace FlexibleValidationRulesConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ValidationEngine validationEngine = new ValidationEngine(new List<ValidationRule>()
            {
                new PersonValidationRule()
            });
            
            PersonListProcessor processor = new PersonListProcessor(validationEngine);

            processor.Process(new List<Person>
            {
                new Person ("Tinu", "Murani", "23153546", new DateTime(1984, 08, 03)),
                new Person ("Leontin", "", "23153546", new DateTime(1995, 11, 05)),
                null
            });

            Console.ReadLine();
        }
    }
}
