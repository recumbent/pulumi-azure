// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring
{
    /// <summary>
    /// Manages an Monitor Action Rule which type is action group.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West Europe",
    ///         });
    ///         var exampleActionGroup = new Azure.Monitoring.ActionGroup("exampleActionGroup", new Azure.Monitoring.ActionGroupArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             ShortName = "exampleactiongroup",
    ///         });
    ///         var exampleActionRuleActionGroup = new Azure.Monitoring.ActionRuleActionGroup("exampleActionRuleActionGroup", new Azure.Monitoring.ActionRuleActionGroupArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             ActionGroupId = exampleActionGroup.Id,
    ///             Scope = new Azure.Monitoring.Inputs.ActionRuleActionGroupScopeArgs
    ///             {
    ///                 Type = "ResourceGroup",
    ///                 ResourceIds = 
    ///                 {
    ///                     exampleResourceGroup.Id,
    ///                 },
    ///             },
    ///             Tags = 
    ///             {
    ///                 { "foo", "bar" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class ActionRuleActionGroup : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the resource id of monitor action group.
        /// </summary>
        [Output("actionGroupId")]
        public Output<string> ActionGroupId { get; private set; } = null!;

        /// <summary>
        /// A `condition` block as defined below.
        /// </summary>
        [Output("condition")]
        public Output<Outputs.ActionRuleActionGroupCondition?> Condition { get; private set; } = null!;

        /// <summary>
        /// Specifies a description for the Action Rule.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Is the Action Rule enabled? Defaults to `true`.
        /// </summary>
        [Output("enabled")]
        public Output<bool?> Enabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Monitor Action Rule. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A `scope` block as defined below.
        /// </summary>
        [Output("scope")]
        public Output<Outputs.ActionRuleActionGroupScope?> Scope { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a ActionRuleActionGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ActionRuleActionGroup(string name, ActionRuleActionGroupArgs args, CustomResourceOptions? options = null)
            : base("azure:monitoring/actionRuleActionGroup:ActionRuleActionGroup", name, args ?? new ActionRuleActionGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ActionRuleActionGroup(string name, Input<string> id, ActionRuleActionGroupState? state = null, CustomResourceOptions? options = null)
            : base("azure:monitoring/actionRuleActionGroup:ActionRuleActionGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ActionRuleActionGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ActionRuleActionGroup Get(string name, Input<string> id, ActionRuleActionGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new ActionRuleActionGroup(name, id, state, options);
        }
    }

    public sealed class ActionRuleActionGroupArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the resource id of monitor action group.
        /// </summary>
        [Input("actionGroupId", required: true)]
        public Input<string> ActionGroupId { get; set; } = null!;

        /// <summary>
        /// A `condition` block as defined below.
        /// </summary>
        [Input("condition")]
        public Input<Inputs.ActionRuleActionGroupConditionArgs>? Condition { get; set; }

        /// <summary>
        /// Specifies a description for the Action Rule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Is the Action Rule enabled? Defaults to `true`.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Specifies the name of the Monitor Action Rule. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `scope` block as defined below.
        /// </summary>
        [Input("scope")]
        public Input<Inputs.ActionRuleActionGroupScopeArgs>? Scope { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ActionRuleActionGroupArgs()
        {
        }
    }

    public sealed class ActionRuleActionGroupState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the resource id of monitor action group.
        /// </summary>
        [Input("actionGroupId")]
        public Input<string>? ActionGroupId { get; set; }

        /// <summary>
        /// A `condition` block as defined below.
        /// </summary>
        [Input("condition")]
        public Input<Inputs.ActionRuleActionGroupConditionGetArgs>? Condition { get; set; }

        /// <summary>
        /// Specifies a description for the Action Rule.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Is the Action Rule enabled? Defaults to `true`.
        /// </summary>
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        /// <summary>
        /// Specifies the name of the Monitor Action Rule. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the name of the resource group in which the Monitor Action Rule should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A `scope` block as defined below.
        /// </summary>
        [Input("scope")]
        public Input<Inputs.ActionRuleActionGroupScopeGetArgs>? Scope { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public ActionRuleActionGroupState()
        {
        }
    }
}
