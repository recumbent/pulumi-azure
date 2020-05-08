// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Batch.Inputs
{

    public sealed class PoolStartTaskUserIdentityAutoUserGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The elevation level of the user identity under which the start task runs. Possible values are `Admin` or `NonAdmin`. Defaults to `NonAdmin`.
        /// </summary>
        [Input("elevationLevel")]
        public Input<string>? ElevationLevel { get; set; }

        /// <summary>
        /// The scope of the user identity under which the start task runs. Possible values are `Task` or `Pool`. Defaults to `Task`.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public PoolStartTaskUserIdentityAutoUserGetArgs()
        {
        }
    }
}