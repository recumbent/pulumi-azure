// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Automation
{
    /// <summary>
    /// Manages a Automation DSC Configuration.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/automation_dsc_configuration.html.markdown.
    /// </summary>
    public partial class DscConfiguration : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("automationAccountName")]
        public Output<string> AutomationAccountName { get; private set; } = null!;

        /// <summary>
        /// The PowerShell DSC Configuration script.
        /// </summary>
        [Output("contentEmbedded")]
        public Output<string> ContentEmbedded { get; private set; } = null!;

        /// <summary>
        /// Description to go with DSC Configuration.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// Must be the same location as the Automation Account.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Verbose log option.
        /// </summary>
        [Output("logVerbose")]
        public Output<bool?> LogVerbose { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        [Output("state")]
        public Output<string> State { get; private set; } = null!;


        /// <summary>
        /// Create a DscConfiguration resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DscConfiguration(string name, DscConfigurationArgs args, CustomResourceOptions? options = null)
            : base("azure:automation/dscConfiguration:DscConfiguration", name, args, MakeResourceOptions(options, ""))
        {
        }

        private DscConfiguration(string name, Input<string> id, DscConfigurationState? state = null, CustomResourceOptions? options = null)
            : base("azure:automation/dscConfiguration:DscConfiguration", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DscConfiguration resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DscConfiguration Get(string name, Input<string> id, DscConfigurationState? state = null, CustomResourceOptions? options = null)
        {
            return new DscConfiguration(name, id, state, options);
        }
    }

    public sealed class DscConfigurationArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("automationAccountName", required: true)]
        public Input<string> AutomationAccountName { get; set; } = null!;

        /// <summary>
        /// The PowerShell DSC Configuration script.
        /// </summary>
        [Input("contentEmbedded", required: true)]
        public Input<string> ContentEmbedded { get; set; } = null!;

        /// <summary>
        /// Description to go with DSC Configuration.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Must be the same location as the Automation Account.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Verbose log option.
        /// </summary>
        [Input("logVerbose")]
        public Input<bool>? LogVerbose { get; set; }

        /// <summary>
        /// Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public DscConfigurationArgs()
        {
        }
    }

    public sealed class DscConfigurationState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("automationAccountName")]
        public Input<string>? AutomationAccountName { get; set; }

        /// <summary>
        /// The PowerShell DSC Configuration script.
        /// </summary>
        [Input("contentEmbedded")]
        public Input<string>? ContentEmbedded { get; set; }

        /// <summary>
        /// Description to go with DSC Configuration.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// Must be the same location as the Automation Account.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Verbose log option.
        /// </summary>
        [Input("logVerbose")]
        public Input<bool>? LogVerbose { get; set; }

        /// <summary>
        /// Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        [Input("state")]
        public Input<string>? State { get; set; }

        public DscConfigurationState()
        {
        }
    }
}
