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
        /// Use this data source to access information about a set of existing Public IP Addresses.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/public_ips.html.markdown.
        /// </summary>
        public static Task<GetPublicIPsResult> GetPublicIPs(GetPublicIPsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPublicIPsResult>("azure:network/getPublicIPs:getPublicIPs", args, options.WithVersion());
    }

    public sealed class GetPublicIPsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Allocation Type for the Public IP Address. Possible values include `Static` or `Dynamic`.
        /// </summary>
        [Input("allocationType")]
        public Input<string>? AllocationType { get; set; }

        /// <summary>
        /// Filter to include IP Addresses which are attached to a device, such as a VM/LB (`true`) or unattached (`false`).
        /// </summary>
        [Input("attached")]
        public Input<bool>? Attached { get; set; }

        /// <summary>
        /// A prefix match used for the IP Addresses `name` field, case sensitive.
        /// </summary>
        [Input("namePrefix")]
        public Input<string>? NamePrefix { get; set; }

        /// <summary>
        /// Specifies the name of the resource group.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetPublicIPsArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetPublicIPsResult
    {
        public readonly string? AllocationType;
        public readonly bool? Attached;
        public readonly string? NamePrefix;
        /// <summary>
        /// A List of `public_ips` blocks as defined below filtered by the criteria above.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetPublicIPsPublicIpsResult> PublicIps;
        public readonly string ResourceGroupName;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetPublicIPsResult(
            string? allocationType,
            bool? attached,
            string? namePrefix,
            ImmutableArray<Outputs.GetPublicIPsPublicIpsResult> publicIps,
            string resourceGroupName,
            string id)
        {
            AllocationType = allocationType;
            Attached = attached;
            NamePrefix = namePrefix;
            PublicIps = publicIps;
            ResourceGroupName = resourceGroupName;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetPublicIPsPublicIpsResult
    {
        /// <summary>
        /// The Domain Name Label of the Public IP Address
        /// </summary>
        public readonly string DomainNameLabel;
        /// <summary>
        /// The FQDN of the Public IP Address
        /// </summary>
        public readonly string Fqdn;
        /// <summary>
        /// The ID of the Public IP Address
        /// </summary>
        public readonly string Id;
        public readonly string IpAddress;
        /// <summary>
        /// The Name of the Public IP Address
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetPublicIPsPublicIpsResult(
            string domainNameLabel,
            string fqdn,
            string id,
            string ipAddress,
            string name)
        {
            DomainNameLabel = domainNameLabel;
            Fqdn = fqdn;
            Id = id;
            IpAddress = ipAddress;
            Name = name;
        }
    }
    }
}
