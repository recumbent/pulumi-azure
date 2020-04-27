// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Core
{
    public static class GetResourceGroup
    {
        /// <summary>
        /// Use this data source to access information about an existing Resource Group.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetResourceGroupResult> InvokeAsync(GetResourceGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetResourceGroupResult>("azure:core/getResourceGroup:getResourceGroup", args ?? new GetResourceGroupArgs(), options.WithVersion());
    }


    public sealed class GetResourceGroupArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The Name of this Resource Group.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        public GetResourceGroupArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetResourceGroupResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The Azure Region where the Resource Group exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        /// <summary>
        /// A mapping of tags assigned to the Resource Group.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetResourceGroupResult(
            string id,

            string location,

            string name,

            ImmutableDictionary<string, string> tags)
        {
            Id = id;
            Location = location;
            Name = name;
            Tags = tags;
        }
    }
}
