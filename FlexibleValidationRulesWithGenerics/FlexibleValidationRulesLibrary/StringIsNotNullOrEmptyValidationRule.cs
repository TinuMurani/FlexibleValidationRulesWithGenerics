using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class StringIsNotNullOrEmptyValidationRule : IValidationRule<string>
    {
        public ValidityResponse IsValid(string inputData)
        {
            if (string.IsNullOrEmpty(inputData))
            {
                return new ValidityResponse(false, $"Input string for <{nameof(inputData)}> is null or empty");
            }

            return new ValidityResponse(true, "");
        }
    }
}
