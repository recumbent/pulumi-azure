// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Policy
{
    /// <summary>
    /// Configures the specified Policy Definition at the specified Scope. Also, Policy Set Definitions are supported.
    /// </summary>
    public partial class Assignment : Pulumi.CustomResource
    {
        /// <summary>
        /// A description to use for this Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// A friendly display name to use for this Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Output("displayName")]
        public Output<string?> DisplayName { get; private set; } = null!;

        /// <summary>
        /// An `identity` block.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.AssignmentIdentity> Identity { get; private set; } = null!;

        /// <summary>
        /// The Azure location where this policy assignment should exist. This is required when an Identity is assigned. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A list of the Policy Assignment's excluded scopes. The list must contain Resource IDs (such as Subscriptions e.g. `/subscriptions/00000000-0000-0000-000000000000` or Resource Groups e.g.`/subscriptions/00000000-0000-0000-000000000000/resourceGroups/myResourceGroup`).
        /// </summary>
        [Output("notScopes")]
        public Output<ImmutableArray<string>> NotScopes { get; private set; } = null!;

        /// <summary>
        /// Parameters for the policy definition. This field is a JSON object that maps to the Parameters field from the Policy Definition. Changing this forces a new resource to be created.
        /// </summary>
        [Output("parameters")]
        public Output<string?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The ID of the Policy Definition to be applied at the specified Scope.
        /// </summary>
        [Output("policyDefinitionId")]
        public Output<string> PolicyDefinitionId { get; private set; } = null!;

        /// <summary>
        /// The Scope at which the Policy Assignment should be applied, which must be a Resource ID (such as Subscription e.g. `/subscriptions/00000000-0000-0000-000000000000` or a Resource Group e.g.`/subscriptions/00000000-0000-0000-000000000000/resourceGroups/myResourceGroup`). Changing this forces a new resource to be created.
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;


        /// <summary>
        /// Create a Assignment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Assignment(string name, AssignmentArgs args, CustomResourceOptions? options = null)
            : base("azure:policy/assignment:Assignment", name, args ?? new AssignmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Assignment(string name, Input<string> id, AssignmentState? state = null, CustomResourceOptions? options = null)
            : base("azure:policy/assignment:Assignment", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Assignment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Assignment Get(string name, Input<string> id, AssignmentState? state = null, CustomResourceOptions? options = null)
        {
            return new Assignment(name, id, state, options);
        }
    }

    public sealed class AssignmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description to use for this Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A friendly display name to use for this Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// An `identity` block.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.AssignmentIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// The Azure location where this policy assignment should exist. This is required when an Identity is assigned. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("notScopes")]
        private InputList<string>? _notScopes;

        /// <summary>
        /// A list of the Policy Assignment's excluded scopes. The list must contain Resource IDs (such as Subscriptions e.g. `/subscriptions/00000000-0000-0000-000000000000` or Resource Groups e.g.`/subscriptions/00000000-0000-0000-000000000000/resourceGroups/myResourceGroup`).
        /// </summary>
        public InputList<string> NotScopes
        {
            get => _notScopes ?? (_notScopes = new InputList<string>());
            set => _notScopes = value;
        }

        /// <summary>
        /// Parameters for the policy definition. This field is a JSON object that maps to the Parameters field from the Policy Definition. Changing this forces a new resource to be created.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        /// <summary>
        /// The ID of the Policy Definition to be applied at the specified Scope.
        /// </summary>
        [Input("policyDefinitionId", required: true)]
        public Input<string> PolicyDefinitionId { get; set; } = null!;

        /// <summary>
        /// The Scope at which the Policy Assignment should be applied, which must be a Resource ID (such as Subscription e.g. `/subscriptions/00000000-0000-0000-000000000000` or a Resource Group e.g.`/subscriptions/00000000-0000-0000-000000000000/resourceGroups/myResourceGroup`). Changing this forces a new resource to be created.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        public AssignmentArgs()
        {
        }
    }

    public sealed class AssignmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A description to use for this Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// A friendly display name to use for this Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// An `identity` block.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.AssignmentIdentityGetArgs>? Identity { get; set; }

        /// <summary>
        /// The Azure location where this policy assignment should exist. This is required when an Identity is assigned. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the Policy Assignment. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("notScopes")]
        private InputList<string>? _notScopes;

        /// <summary>
        /// A list of the Policy Assignment's excluded scopes. The list must contain Resource IDs (such as Subscriptions e.g. `/subscriptions/00000000-0000-0000-000000000000` or Resource Groups e.g.`/subscriptions/00000000-0000-0000-000000000000/resourceGroups/myResourceGroup`).
        /// </summary>
        public InputList<string> NotScopes
        {
            get => _notScopes ?? (_notScopes = new InputList<string>());
            set => _notScopes = value;
        }

        /// <summary>
        /// Parameters for the policy definition. This field is a JSON object that maps to the Parameters field from the Policy Definition. Changing this forces a new resource to be created.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        /// <summary>
        /// The ID of the Policy Definition to be applied at the specified Scope.
        /// </summary>
        [Input("policyDefinitionId")]
        public Input<string>? PolicyDefinitionId { get; set; }

        /// <summary>
        /// The Scope at which the Policy Assignment should be applied, which must be a Resource ID (such as Subscription e.g. `/subscriptions/00000000-0000-0000-000000000000` or a Resource Group e.g.`/subscriptions/00000000-0000-0000-000000000000/resourceGroups/myResourceGroup`). Changing this forces a new resource to be created.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        public AssignmentState()
        {
        }
    }
}
