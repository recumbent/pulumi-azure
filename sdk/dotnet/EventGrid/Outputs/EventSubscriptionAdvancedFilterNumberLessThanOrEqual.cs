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
    public sealed class EventSubscriptionAdvancedFilterNumberLessThanOrEqual
    {
        /// <summary>
        /// Specifies the field within the event data that you want to use for filtering. Type of the field can be a number, boolean, or string.
        /// </summary>
        public readonly string Key;
        /// <summary>
        /// Specifies a single value to compare to when using a single value operator. 
        /// </summary>
        public readonly double Value;

        [OutputConstructor]
        private EventSubscriptionAdvancedFilterNumberLessThanOrEqual(
            string key,

            double value)
        {
            Key = key;
            Value = value;
        }
    }
}
