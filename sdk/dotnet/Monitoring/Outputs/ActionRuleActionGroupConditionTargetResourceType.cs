// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring.Outputs
{

    [OutputType]
    public sealed class ActionRuleActionGroupConditionTargetResourceType
    {
        /// <summary>
        /// The operator for a given condition. Possible values are `Equals` and `NotEquals`.
        /// </summary>
        public readonly string Operator;
        /// <summary>
        /// A list of values to match for a given condition. The values should be valid resource types.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private ActionRuleActionGroupConditionTargetResourceType(
            string @operator,

            ImmutableArray<string> values)
        {
            Operator = @operator;
            Values = values;
        }
    }
}
