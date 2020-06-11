using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class ValidityResponse
    {
        public ValidityResponse(bool result, string reason)
        {
            this.Result = result;
            this.Reason = reason;
        }

        public bool Result { get; }
        public string Reason { get; }
    }
}
