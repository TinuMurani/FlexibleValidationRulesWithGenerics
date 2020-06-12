using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class StringRepresentNumberValidationRule : ValidationRule   //IValidationRule<string>
    {
        public override ValidityResponse IsValid<T>(T inputData)
        {
            string dataAsString = inputData as string;

            if (string.IsNullOrEmpty(dataAsString))
            {
                return new ValidityResponse(false, $"Input string for <{nameof(inputData)}> is null or empty");
            }

            foreach (Char c in dataAsString.ToCharArray())
            {
                if (!char.IsDigit(c))
                {
                    return new ValidityResponse(false, $"At least one character in <{nameof(inputData)}> is not a number");
                }
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

            foreach (Char c in inputData.ToCharArray())
            {
                if (!char.IsDigit(c))
                {
                    return new ValidityResponse(false, $"At least one character in <{nameof(inputData)}> is not a number");
                }
            }

            return new ValidityResponse(true, "");
        }
        */
    }
}
