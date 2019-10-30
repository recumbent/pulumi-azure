// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Azure Firewall.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/firewall.html.markdown.
        /// </summary>
        public static Task<GetFirewallResult> GetFirewall(GetFirewallArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetFirewallResult>("azure:network/getFirewall:getFirewall", args, options.WithVersion());
    }

    public sealed class GetFirewallArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Azure Firewall exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetFirewallArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetFirewallResult
    {
        /// <summary>
        /// A `ip_configuration` block as defined below.
        /// </summary>
        public readonly Outputs.GetFirewallIpConfigurationResult IpConfiguration;
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetFirewallResult(
            Outputs.GetFirewallIpConfigurationResult ipConfiguration,
            string location,
            string name,
            string resourceGroupName,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            IpConfiguration = ipConfiguration;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetFirewallIpConfigurationResult
    {
        public readonly string InternalPublicIpAddressId;
        /// <summary>
        /// The name of the Azure Firewall.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The private IP address of the Azure Firewall.
        /// </summary>
        public readonly string PrivateIpAddress;
        public readonly string PublicIpAddressId;
        /// <summary>
        /// The Resource ID of the subnet where the Azure Firewall is deployed.
        /// </summary>
        public readonly string SubnetId;

        [OutputConstructor]
        private GetFirewallIpConfigurationResult(
            string internalPublicIpAddressId,
            string name,
            string privateIpAddress,
            string publicIpAddressId,
            string subnetId)
        {
            InternalPublicIpAddressId = internalPublicIpAddressId;
            Name = name;
            PrivateIpAddress = privateIpAddress;
            PublicIpAddressId = publicIpAddressId;
            SubnetId = subnetId;
        }
    }
    }
}
