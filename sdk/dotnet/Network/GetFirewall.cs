// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    public static class GetFirewall
    {
        /// <summary>
        /// Use this data source to access information about an existing Azure Firewall.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetFirewallResult> InvokeAsync(GetFirewallArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFirewallResult>("azure:network/getFirewall:getFirewall", args ?? new GetFirewallArgs(), options.WithVersion());
    }


    public sealed class GetFirewallArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Azure Firewall exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        public GetFirewallArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetFirewallResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// A `ip_configuration` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetFirewallIpConfigurationResult> IpConfigurations;
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        public readonly ImmutableDictionary<string, string> Tags;

        [OutputConstructor]
        private GetFirewallResult(
            string id,

            ImmutableArray<Outputs.GetFirewallIpConfigurationResult> ipConfigurations,

            string location,

            string name,

            string resourceGroupName,

            ImmutableDictionary<string, string> tags)
        {
            Id = id;
            IpConfigurations = ipConfigurations;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
        }
    }
}
