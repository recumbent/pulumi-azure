// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Managementgroups
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Management Group.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/management_group_legacy.html.markdown.
        /// </summary>
        public static Task<GetManagementGroupResult> GetManagementGroup(GetManagementGroupArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetManagementGroupResult>("azure:managementgroups/getManagementGroup:getManagementGroup", args, options.WithVersion());
    }

    public sealed class GetManagementGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the UUID of this Management Group.
        /// </summary>
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        public GetManagementGroupArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetManagementGroupResult
    {
        /// <summary>
        /// A friendly name for the Management Group.
        /// </summary>
        public readonly string DisplayName;
        public readonly string GroupId;
        /// <summary>
        /// The ID of any Parent Management Group.
        /// </summary>
        public readonly string ParentManagementGroupId;
        /// <summary>
        /// A list of Subscription ID's which are assigned to the Management Group.
        /// </summary>
        public readonly ImmutableArray<string> SubscriptionIds;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetManagementGroupResult(
            string displayName,
            string groupId,
            string parentManagementGroupId,
            ImmutableArray<string> subscriptionIds,
            string id)
        {
            DisplayName = displayName;
            GroupId = groupId;
            ParentManagementGroupId = parentManagementGroupId;
            SubscriptionIds = subscriptionIds;
            Id = id;
        }
    }
}