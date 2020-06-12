using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class ValidationEngine
    {
        public ValidationEngine(IValidationRule<object>[] rules)
        {
            this.Rules = rules;
        }
        public IValidationRule<object>[] Rules { get; }

        public ValidityResponse IsValid(object data)
        {
            foreach (var rule in this.Rules)
            {
                if (rule is null)
                {
                    continue;
                }

                bool isValid = rule.IsValid(data).Result;

                if (!isValid)
                {
                    return new ValidityResponse(false, rule.IsValid(data).Reason);
                }
            }

            return new ValidityResponse(true, "Data is valid");
        }
    }
}
