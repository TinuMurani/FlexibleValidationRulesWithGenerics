using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class StringRepresentNumberValidationRule : IValidationRule<string>
    {
        public ValidityResponse IsValid(string inputData)
        {
            if (string.IsNullOrEmpty(inputData))
            {
                return new ValidityResponse(false, "Input string is null");
            }

            foreach (Char c in inputData.ToCharArray())
            {
                if (!char.IsDigit(c))
                {
                    return new ValidityResponse(false, "At least one character is not a number");
                }
            }

            return new ValidityResponse(true, "");
        }
    }
}
