// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Eventhub
{
    /// <summary>
    /// Manages an Disaster Recovery Config for an Event Hub Namespace.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/eventhub_namespace_disaster_recovery_config.html.markdown.
    /// </summary>
    public partial class EventhubNamespaceDisasterRecoveryConfig : Pulumi.CustomResource
    {
        /// <summary>
        /// An alternate name to use when the Disaster Recovery Config's name is the same as the replicated namespace's name. 
        /// </summary>
        [Output("alternateName")]
        public Output<string?> AlternateName { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Disaster Recovery Config. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the primary EventHub Namespace to replicate. Changing this forces a new resource to be created.
        /// </summary>
        [Output("namespaceName")]
        public Output<string> NamespaceName { get; private set; } = null!;

        /// <summary>
        /// The ID of the EventHub Namespace to replicate to.
        /// </summary>
        [Output("partnerNamespaceId")]
        public Output<string> PartnerNamespaceId { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Disaster Recovery Config exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;


        /// <summary>
        /// Create a EventhubNamespaceDisasterRecoveryConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public EventhubNamespaceDisasterRecoveryConfig(string name, EventhubNamespaceDisasterRecoveryConfigArgs args, CustomResourceOptions? options = null)
            : base("azure:eventhub/eventhubNamespaceDisasterRecoveryConfig:EventhubNamespaceDisasterRecoveryConfig", name, args, MakeResourceOptions(options, ""))
        {
        }

        private EventhubNamespaceDisasterRecoveryConfig(string name, Input<string> id, EventhubNamespaceDisasterRecoveryConfigState? state = null, CustomResourceOptions? options = null)
            : base("azure:eventhub/eventhubNamespaceDisasterRecoveryConfig:EventhubNamespaceDisasterRecoveryConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing EventhubNamespaceDisasterRecoveryConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static EventhubNamespaceDisasterRecoveryConfig Get(string name, Input<string> id, EventhubNamespaceDisasterRecoveryConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new EventhubNamespaceDisasterRecoveryConfig(name, id, state, options);
        }
    }

    public sealed class EventhubNamespaceDisasterRecoveryConfigArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An alternate name to use when the Disaster Recovery Config's name is the same as the replicated namespace's name. 
        /// </summary>
        [Input("alternateName")]
        public Input<string>? AlternateName { get; set; }

        /// <summary>
        /// Specifies the name of the Disaster Recovery Config. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the name of the primary EventHub Namespace to replicate. Changing this forces a new resource to be created.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// The ID of the EventHub Namespace to replicate to.
        /// </summary>
        [Input("partnerNamespaceId", required: true)]
        public Input<string> PartnerNamespaceId { get; set; } = null!;

        /// <summary>
        /// The name of the resource group in which the Disaster Recovery Config exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public EventhubNamespaceDisasterRecoveryConfigArgs()
        {
        }
    }

    public sealed class EventhubNamespaceDisasterRecoveryConfigState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An alternate name to use when the Disaster Recovery Config's name is the same as the replicated namespace's name. 
        /// </summary>
        [Input("alternateName")]
        public Input<string>? AlternateName { get; set; }

        /// <summary>
        /// Specifies the name of the Disaster Recovery Config. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the name of the primary EventHub Namespace to replicate. Changing this forces a new resource to be created.
        /// </summary>
        [Input("namespaceName")]
        public Input<string>? NamespaceName { get; set; }

        /// <summary>
        /// The ID of the EventHub Namespace to replicate to.
        /// </summary>
        [Input("partnerNamespaceId")]
        public Input<string>? PartnerNamespaceId { get; set; }

        /// <summary>
        /// The name of the resource group in which the Disaster Recovery Config exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        public EventhubNamespaceDisasterRecoveryConfigState()
        {
        }
    }
}
