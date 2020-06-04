// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.EventGrid.Outputs
{

    [OutputType]
    public sealed class EventSubscriptionAdvancedFilterStringContain
    {
        /// <summary>
        /// Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Specifies an array of values to compare to when using a multiple values operator.
        /// </summary>
        public readonly ImmutableArray<string> Values;

        [OutputConstructor]
        private EventSubscriptionAdvancedFilterStringContain(
            string key,

            ImmutableArray<string> values)
        {
            Key = key;
            Values = values;
        }
    }
}
