// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Management
{
    /// <summary>
    /// Manages a Management Group.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/management_group.html.markdown.
    /// </summary>
    public partial class Group : Pulumi.CustomResource
    {
        /// <summary>
        /// A friendly name for this Management Group. If not specified, this'll be the same as the `group_id`.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The UUID for this Management Group, which needs to be unique across your tenant - which will be generated if not provided. Changing this forces a new resource to be created.
        /// </summary>
        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;

        /// <summary>
        /// The ID of the Parent Management Group. Changing this forces a new resource to be created.
        /// </summary>
        [Output("parentManagementGroupId")]
        public Output<string> ParentManagementGroupId { get; private set; } = null!;

        /// <summary>
        /// A list of Subscription GUIDs which should be assigned to the Management Group.
        /// </summary>
        [Output("subscriptionIds")]
        public Output<ImmutableArray<string>> SubscriptionIds { get; private set; } = null!;


        /// <summary>
        /// Create a Group resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Group(string name, GroupArgs? args = null, CustomResourceOptions? options = null)
            : base("azure:management/group:Group", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Group(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
            : base("azure:management/group:Group", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,                Aliases = { new Alias { Type = "azure:managementgroups/managementGroup:ManagementGroup" } },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Group resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Group Get(string name, Input<string> id, GroupState? state = null, CustomResourceOptions? options = null)
        {
            return new Group(name, id, state, options);
        }
    }

    public sealed class GroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A friendly name for this Management Group. If not specified, this'll be the same as the `group_id`.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The UUID for this Management Group, which needs to be unique across your tenant - which will be generated if not provided. Changing this forces a new resource to be created.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// The ID of the Parent Management Group. Changing this forces a new resource to be created.
        /// </summary>
        [Input("parentManagementGroupId")]
        public Input<string>? ParentManagementGroupId { get; set; }

        [Input("subscriptionIds")]
        private InputList<string>? _subscriptionIds;

        /// <summary>
        /// A list of Subscription GUIDs which should be assigned to the Management Group.
        /// </summary>
        public InputList<string> SubscriptionIds
        {
            get => _subscriptionIds ?? (_subscriptionIds = new InputList<string>());
            set => _subscriptionIds = value;
        }

        public GroupArgs()
        {
        }
    }

    public sealed class GroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A friendly name for this Management Group. If not specified, this'll be the same as the `group_id`.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The UUID for this Management Group, which needs to be unique across your tenant - which will be generated if not provided. Changing this forces a new resource to be created.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        /// <summary>
        /// The ID of the Parent Management Group. Changing this forces a new resource to be created.
        /// </summary>
        [Input("parentManagementGroupId")]
        public Input<string>? ParentManagementGroupId { get; set; }

        [Input("subscriptionIds")]
        private InputList<string>? _subscriptionIds;

        /// <summary>
        /// A list of Subscription GUIDs which should be assigned to the Management Group.
        /// </summary>
        public InputList<string> SubscriptionIds
        {
            get => _subscriptionIds ?? (_subscriptionIds = new InputList<string>());
            set => _subscriptionIds = value;
        }

        public GroupState()
        {
        }
    }
}
