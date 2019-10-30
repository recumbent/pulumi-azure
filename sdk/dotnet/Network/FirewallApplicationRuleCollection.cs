// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    /// <summary>
    /// Manages an Application Rule Collection within an Azure Firewall.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/firewall_application_rule_collection.html.markdown.
    /// </summary>
    public partial class FirewallApplicationRuleCollection : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the action the rule will apply to matching traffic. Possible values are `Allow` and `Deny`.
        /// </summary>
        [Output("action")]
        public Output<string> Action { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Firewall in which the Application Rule Collection should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("azureFirewallName")]
        public Output<string> AzureFirewallName { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Application Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the priority of the rule collection. Possible values are between `100` - `65000`.
        /// </summary>
        [Output("priority")]
        public Output<int> Priority { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// One or more `rule` blocks as defined below.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.FirewallApplicationRuleCollectionRules>> Rules { get; private set; } = null!;


        /// <summary>
        /// Create a FirewallApplicationRuleCollection resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public FirewallApplicationRuleCollection(string name, FirewallApplicationRuleCollectionArgs args, CustomResourceOptions? options = null)
            : base("azure:network/firewallApplicationRuleCollection:FirewallApplicationRuleCollection", name, args, MakeResourceOptions(options, ""))
        {
        }

        private FirewallApplicationRuleCollection(string name, Input<string> id, FirewallApplicationRuleCollectionState? state = null, CustomResourceOptions? options = null)
            : base("azure:network/firewallApplicationRuleCollection:FirewallApplicationRuleCollection", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing FirewallApplicationRuleCollection resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static FirewallApplicationRuleCollection Get(string name, Input<string> id, FirewallApplicationRuleCollectionState? state = null, CustomResourceOptions? options = null)
        {
            return new FirewallApplicationRuleCollection(name, id, state, options);
        }
    }

    public sealed class FirewallApplicationRuleCollectionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the action the rule will apply to matching traffic. Possible values are `Allow` and `Deny`.
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Firewall in which the Application Rule Collection should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("azureFirewallName", required: true)]
        public Input<string> AzureFirewallName { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Application Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the priority of the rule collection. Possible values are between `100` - `65000`.
        /// </summary>
        [Input("priority", required: true)]
        public Input<int> Priority { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        [Input("rules", required: true)]
        private InputList<Inputs.FirewallApplicationRuleCollectionRulesArgs>? _rules;

        /// <summary>
        /// One or more `rule` blocks as defined below.
        /// </summary>
        public InputList<Inputs.FirewallApplicationRuleCollectionRulesArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.FirewallApplicationRuleCollectionRulesArgs>());
            set => _rules = value;
        }

        public FirewallApplicationRuleCollectionArgs()
        {
        }
    }

    public sealed class FirewallApplicationRuleCollectionState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the action the rule will apply to matching traffic. Possible values are `Allow` and `Deny`.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// Specifies the name of the Firewall in which the Application Rule Collection should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("azureFirewallName")]
        public Input<string>? AzureFirewallName { get; set; }

        /// <summary>
        /// Specifies the name of the Application Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the priority of the rule collection. Possible values are between `100` - `65000`.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        /// <summary>
        /// Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("rules")]
        private InputList<Inputs.FirewallApplicationRuleCollectionRulesGetArgs>? _rules;

        /// <summary>
        /// One or more `rule` blocks as defined below.
        /// </summary>
        public InputList<Inputs.FirewallApplicationRuleCollectionRulesGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.FirewallApplicationRuleCollectionRulesGetArgs>());
            set => _rules = value;
        }

        public FirewallApplicationRuleCollectionState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class FirewallApplicationRuleCollectionRulesArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("fqdnTags")]
        private InputList<string>? _fqdnTags;
        public InputList<string> FqdnTags
        {
            get => _fqdnTags ?? (_fqdnTags = new InputList<string>());
            set => _fqdnTags = value;
        }

        /// <summary>
        /// Specifies the name of the Application Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("protocols")]
        private InputList<FirewallApplicationRuleCollectionRulesProtocolsArgs>? _protocols;
        public InputList<FirewallApplicationRuleCollectionRulesProtocolsArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<FirewallApplicationRuleCollectionRulesProtocolsArgs>());
            set => _protocols = value;
        }

        [Input("sourceAddresses", required: true)]
        private InputList<string>? _sourceAddresses;
        public InputList<string> SourceAddresses
        {
            get => _sourceAddresses ?? (_sourceAddresses = new InputList<string>());
            set => _sourceAddresses = value;
        }

        [Input("targetFqdns")]
        private InputList<string>? _targetFqdns;
        public InputList<string> TargetFqdns
        {
            get => _targetFqdns ?? (_targetFqdns = new InputList<string>());
            set => _targetFqdns = value;
        }

        public FirewallApplicationRuleCollectionRulesArgs()
        {
        }
    }

    public sealed class FirewallApplicationRuleCollectionRulesGetArgs : Pulumi.ResourceArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("fqdnTags")]
        private InputList<string>? _fqdnTags;
        public InputList<string> FqdnTags
        {
            get => _fqdnTags ?? (_fqdnTags = new InputList<string>());
            set => _fqdnTags = value;
        }

        /// <summary>
        /// Specifies the name of the Application Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("protocols")]
        private InputList<FirewallApplicationRuleCollectionRulesProtocolsGetArgs>? _protocols;
        public InputList<FirewallApplicationRuleCollectionRulesProtocolsGetArgs> Protocols
        {
            get => _protocols ?? (_protocols = new InputList<FirewallApplicationRuleCollectionRulesProtocolsGetArgs>());
            set => _protocols = value;
        }

        [Input("sourceAddresses", required: true)]
        private InputList<string>? _sourceAddresses;
        public InputList<string> SourceAddresses
        {
            get => _sourceAddresses ?? (_sourceAddresses = new InputList<string>());
            set => _sourceAddresses = value;
        }

        [Input("targetFqdns")]
        private InputList<string>? _targetFqdns;
        public InputList<string> TargetFqdns
        {
            get => _targetFqdns ?? (_targetFqdns = new InputList<string>());
            set => _targetFqdns = value;
        }

        public FirewallApplicationRuleCollectionRulesGetArgs()
        {
        }
    }

    public sealed class FirewallApplicationRuleCollectionRulesProtocolsArgs : Pulumi.ResourceArgs
    {
        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public FirewallApplicationRuleCollectionRulesProtocolsArgs()
        {
        }
    }

    public sealed class FirewallApplicationRuleCollectionRulesProtocolsGetArgs : Pulumi.ResourceArgs
    {
        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public FirewallApplicationRuleCollectionRulesProtocolsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class FirewallApplicationRuleCollectionRules
    {
        public readonly string? Description;
        public readonly ImmutableArray<string> FqdnTags;
        /// <summary>
        /// Specifies the name of the Application Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<FirewallApplicationRuleCollectionRulesProtocols> Protocols;
        public readonly ImmutableArray<string> SourceAddresses;
        public readonly ImmutableArray<string> TargetFqdns;

        [OutputConstructor]
        private FirewallApplicationRuleCollectionRules(
            string? description,
            ImmutableArray<string> fqdnTags,
            string name,
            ImmutableArray<FirewallApplicationRuleCollectionRulesProtocols> protocols,
            ImmutableArray<string> sourceAddresses,
            ImmutableArray<string> targetFqdns)
        {
            Description = description;
            FqdnTags = fqdnTags;
            Name = name;
            Protocols = protocols;
            SourceAddresses = sourceAddresses;
            TargetFqdns = targetFqdns;
        }
    }

    [OutputType]
    public sealed class FirewallApplicationRuleCollectionRulesProtocols
    {
        public readonly int? Port;
        public readonly string Type;

        [OutputConstructor]
        private FirewallApplicationRuleCollectionRulesProtocols(
            int? port,
            string type)
        {
            Port = port;
            Type = type;
        }
    }
    }
}
