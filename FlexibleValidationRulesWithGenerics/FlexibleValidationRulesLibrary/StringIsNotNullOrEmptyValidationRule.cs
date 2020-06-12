using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class StringIsNotNullOrEmptyValidationRule : ValidationRule//IValidationRule<string>
    {
        public override ValidityResponse IsValid<T>(T inputData)
        {
            string dataAsString = inputData as string;

            if (string.IsNullOrEmpty(dataAsString))
            {
                return new ValidityResponse(false, $"Input string for <{nameof(inputData)}> is null or empty");
            }

            return new ValidityResponse(true, "");
        }


        /*
        public ValidityResponse IsValid(string inputData)
        {
            if (string.IsNullOrEmpty(inputData))
            {
                return new ValidityResponse(false, $"Input string for <{nameof(inputData)}> is null or empty");
            }

            return new ValidityResponse(true, "");
        }
        */
    }
}
