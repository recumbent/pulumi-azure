// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Automation
{
    /// <summary>
    /// Manages a Automation Account.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/automation_account.html.markdown.
    /// </summary>
    public partial class Account : Pulumi.CustomResource
    {
        /// <summary>
        /// The Primary Access Key for the DSC Endpoint associated with this Automation Account.
        /// </summary>
        [Output("dscPrimaryAccessKey")]
        public Output<string> DscPrimaryAccessKey { get; private set; } = null!;

        /// <summary>
        /// The Secondary Access Key for the DSC Endpoint associated with this Automation Account.
        /// </summary>
        [Output("dscSecondaryAccessKey")]
        public Output<string> DscSecondaryAccessKey { get; private set; } = null!;

        /// <summary>
        /// The DSC Server Endpoint associated with this Automation Account.
        /// </summary>
        [Output("dscServerEndpoint")]
        public Output<string> DscServerEndpoint { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Automation Account. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Automation Account is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// ) A `sku` block as described below.
        /// </summary>
        [Output("sku")]
        public Output<Outputs.AccountSku> Sku { get; private set; } = null!;

        /// <summary>
        /// The SKU name of the account - only `Basic` is supported at this time.
        /// </summary>
        [Output("skuName")]
        public Output<string> SkuName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Account resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Account(string name, AccountArgs args, CustomResourceOptions? options = null)
            : base("azure:automation/account:Account", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Account(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
            : base("azure:automation/account:Account", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Account resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Account Get(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
        {
            return new Account(name, id, state, options);
        }
    }

    public sealed class AccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Automation Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Automation Account is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// ) A `sku` block as described below.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.AccountSkuArgs>? Sku { get; set; }

        /// <summary>
        /// The SKU name of the account - only `Basic` is supported at this time.
        /// </summary>
        [Input("skuName")]
        public Input<string>? SkuName { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public AccountArgs()
        {
        }
    }

    public sealed class AccountState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Primary Access Key for the DSC Endpoint associated with this Automation Account.
        /// </summary>
        [Input("dscPrimaryAccessKey")]
        public Input<string>? DscPrimaryAccessKey { get; set; }

        /// <summary>
        /// The Secondary Access Key for the DSC Endpoint associated with this Automation Account.
        /// </summary>
        [Input("dscSecondaryAccessKey")]
        public Input<string>? DscSecondaryAccessKey { get; set; }

        /// <summary>
        /// The DSC Server Endpoint associated with this Automation Account.
        /// </summary>
        [Input("dscServerEndpoint")]
        public Input<string>? DscServerEndpoint { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Automation Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the Automation Account is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// ) A `sku` block as described below.
        /// </summary>
        [Input("sku")]
        public Input<Inputs.AccountSkuGetArgs>? Sku { get; set; }

        /// <summary>
        /// The SKU name of the account - only `Basic` is supported at this time.
        /// </summary>
        [Input("skuName")]
        public Input<string>? SkuName { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public AccountState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class AccountSkuArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Automation Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public AccountSkuArgs()
        {
        }
    }

    public sealed class AccountSkuGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Automation Account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        public AccountSkuGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class AccountSku
    {
        /// <summary>
        /// Specifies the name of the Automation Account. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string? Name;

        [OutputConstructor]
        private AccountSku(string? name)
        {
            Name = name;
        }
    }
    }
}
