using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class StringIsNotNullOrEmptyValidationRule : IValidationRule<string>
    {
        public ValidityResponse IsValid(string inputData)
        {
            if (inputData is null)
            {
                return new ValidityResponse(false, "Input string is null");
            }

            return new ValidityResponse(true, "");
        }
    }
}
