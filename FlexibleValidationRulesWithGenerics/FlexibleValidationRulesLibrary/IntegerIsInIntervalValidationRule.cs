using System;
using System.Collections.Generic;
using System.Text;

namespace FlexibleValidationRulesLibrary
{
    public class IntegerIsInIntervalValidationRule : ValidationRule  //IValidationRule<int>
    {
        public IntegerIsInIntervalValidationRule(int from, int to)
        {
            this.From = from;
            this.To = to;
        }

        public int From { get; }
        public int To { get; }

        public override ValidityResponse IsValid<T>(T inputData)
        {
            if (inputData is int dataAsint)
            {
                if (!(this.From <= dataAsint && dataAsint <= this.To))
                {
                    return new ValidityResponse(false, $"Number represented by <{nameof(inputData)}> is not within the specified interval");
                }
            }

            return new ValidityResponse(true, "");
        }

        /*
        public IntegerIsInIntervalValidationRule(int from, int to)
        {
            this.From = from;
            this.To = to;
        }

        public int From { get; }
        public int To { get; }

        public ValidityResponse IsValid(int inputData)
        {
            if (!(this.From <= inputData && inputData <= this.To))
            {
                return new ValidityResponse(false, $"Number represented by <{nameof(inputData)}> is not within the specified interval");
            }

            return new ValidityResponse(true, "");
        }
        */

    }
}
