using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public abstract class ValidationRule
    {
        public abstract ValidityResponse IsValid<T>(T inputData);
    }
}
