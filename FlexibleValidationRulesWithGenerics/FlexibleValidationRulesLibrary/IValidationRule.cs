using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public interface IValidationRule<T>
    {
        ValidityResponse IsValid(T inputData);
    }
}
