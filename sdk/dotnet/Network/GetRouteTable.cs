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
        /// Use this data source to access information about an existing Route Table.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/route_table.html.markdown.
        /// </summary>
        public static Task<GetRouteTableResult> GetRouteTable(GetRouteTableArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRouteTableResult>("azure:network/getRouteTable:getRouteTable", args, options.WithVersion());
    }

    public sealed class GetRouteTableArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Route Table.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Route Table exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetRouteTableArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetRouteTableResult
    {
        /// <summary>
        /// The Azure Region in which the Route Table exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the Route.
        /// </summary>
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// One or more `route` blocks as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRouteTableRoutesResult> Routes;
        /// <summary>
        /// The collection of Subnets associated with this route table.
        /// </summary>
        public readonly ImmutableArray<string> Subnets;
        /// <summary>
        /// A mapping of tags assigned to the Route Table.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetRouteTableResult(
            string location,
            string name,
            string resourceGroupName,
            ImmutableArray<Outputs.GetRouteTableRoutesResult> routes,
            ImmutableArray<string> subnets,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Routes = routes;
            Subnets = subnets;
            Tags = tags;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetRouteTableRoutesResult
    {
        /// <summary>
        /// The destination CIDR to which the route applies.
        /// </summary>
        public readonly string AddressPrefix;
        /// <summary>
        /// The name of the Route Table.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Contains the IP address packets should be forwarded to.
        /// </summary>
        public readonly string NextHopInIpAddress;
        /// <summary>
        /// The type of Azure hop the packet should be sent to.
        /// </summary>
        public readonly string NextHopType;

        [OutputConstructor]
        private GetRouteTableRoutesResult(
            string addressPrefix,
            string name,
            string nextHopInIpAddress,
            string nextHopType)
        {
            AddressPrefix = addressPrefix;
            Name = name;
            NextHopInIpAddress = nextHopInIpAddress;
            NextHopType = nextHopType;
        }
    }
    }
}
