using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class ValidationEngine
    {
        public IValidationRule<object>[] Rules { get; }
    }
}
