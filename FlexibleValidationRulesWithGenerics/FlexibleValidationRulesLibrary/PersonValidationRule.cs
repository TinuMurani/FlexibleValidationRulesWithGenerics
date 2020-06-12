using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class PersonValidationRule : ValidationRule //IValidationRule<Person>
    {
        private readonly ValidationRule stringIsNotNullOrEmptyRule = new StringIsNotNullOrEmptyValidationRule();
        private readonly ValidationRule stringRepresentsNumberRule = new StringRepresentNumberValidationRule();
        private readonly ValidationRule numberIsInIntervalRule = new IntegerIsInIntervalValidationRule(18, 150);

        public override ValidityResponse IsValid<T> (T inputData)
        {
            Person person = inputData as Person;

            StringBuilder responseList = new StringBuilder();

            if (inputData is null)
            {
                return new ValidityResponse(false, "Person is not instantiated");
            }

            if (!stringIsNotNullOrEmptyRule.IsValid(person.FirstName).Result &&
                !stringIsNotNullOrEmptyRule.IsValid(person.LastName).Result &&
                !stringRepresentsNumberRule.IsValid(person.CNP).Result &&
                !numberIsInIntervalRule.IsValid(person.Age).Result)
            {
                List<ValidityResponse> results = new List<ValidityResponse>
                {
                    new ValidityResponse(stringIsNotNullOrEmptyRule.IsValid(person.FirstName).Result, stringIsNotNullOrEmptyRule.IsValid(person.FirstName).Reason),
                    new ValidityResponse(stringIsNotNullOrEmptyRule.IsValid(person.LastName).Result, stringIsNotNullOrEmptyRule.IsValid(person.LastName).Reason),
                    new ValidityResponse(stringRepresentsNumberRule.IsValid(person.CNP).Result, stringRepresentsNumberRule.IsValid(person.CNP).Reason),
                    new ValidityResponse(numberIsInIntervalRule.IsValid(person.Age).Result, numberIsInIntervalRule.IsValid(person.Age).Reason)
                };

                //responseList.AppendLine(results.Where(r => r.Result is false).Select(r => r.Reason).ToString());

                foreach (var result in results)
                {
                    responseList.AppendLine(result.Reason);
                }

                return new ValidityResponse(false, responseList.ToString());
            }

            return new ValidityResponse(true, "Person is valid");
        }


        /*
        public ValidityResponse IsValid(Person inputData)
        {
            StringBuilder responseList = new StringBuilder();
            List<bool> resultList = new List<bool>();

            if (inputData is null)
            {
                return new ValidityResponse(false, "Person is not instantiated");
            }

            if (!stringIsNotNullOrEmptyRule.IsValid(inputData.FirstName).Result ||
                !stringIsNotNullOrEmptyRule.IsValid(inputData.LastName).Result ||
                !stringRepresentsNumberRule.IsValid(inputData.CNP).Result ||
                !numberIsInIntervalRule.IsValid(inputData.Age).Result)
            {
                List<ValidityResponse> results = new List<ValidityResponse>
                {
                    new ValidityResponse(stringIsNotNullOrEmptyRule.IsValid(inputData.FirstName).Result, stringIsNotNullOrEmptyRule.IsValid(inputData.FirstName).Reason),
                    new ValidityResponse(stringIsNotNullOrEmptyRule.IsValid(inputData.LastName).Result, stringIsNotNullOrEmptyRule.IsValid(inputData.LastName).Reason),
                    new ValidityResponse(stringRepresentsNumberRule.IsValid(inputData.CNP).Result, stringRepresentsNumberRule.IsValid(inputData.CNP).Reason),
                    new ValidityResponse(numberIsInIntervalRule.IsValid(inputData.Age).Result, numberIsInIntervalRule.IsValid(inputData.Age).Reason)
                };

                responseList.AppendLine(results.Where(r => r.Result is false).Select(r => r.Reason).ToString());

                return new ValidityResponse(false, responseList.ToString());
            }

            return new ValidityResponse(true, "Person is valid");
        }
        */
    }
}
