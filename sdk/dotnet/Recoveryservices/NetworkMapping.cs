// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Recoveryservices
{
    /// <summary>
    /// Manages a site recovery network mapping on Azure. A network mapping decides how to translate connected netwroks when a VM is migrated from one region to another.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/recovery_network_mapping.html.markdown.
    /// </summary>
    public partial class NetworkMapping : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the network mapping.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the vault that should be updated.
        /// </summary>
        [Output("recoveryVaultName")]
        public Output<string> RecoveryVaultName { get; private set; } = null!;

        /// <summary>
        /// Name of the resource group where the vault that should be updated is located.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The id of the primary network.
        /// </summary>
        [Output("sourceNetworkId")]
        public Output<string> SourceNetworkId { get; private set; } = null!;

        /// <summary>
        /// Specifies the ASR fabric where mapping should be created.
        /// </summary>
        [Output("sourceRecoveryFabricName")]
        public Output<string> SourceRecoveryFabricName { get; private set; } = null!;

        /// <summary>
        /// The id of the recovery network.
        /// </summary>
        [Output("targetNetworkId")]
        public Output<string> TargetNetworkId { get; private set; } = null!;

        /// <summary>
        /// The Azure Site Recovery fabric object corresponding to the recovery Azure region.
        /// </summary>
        [Output("targetRecoveryFabricName")]
        public Output<string> TargetRecoveryFabricName { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkMapping resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkMapping(string name, NetworkMappingArgs args, CustomResourceOptions? options = null)
            : base("azure:recoveryservices/networkMapping:NetworkMapping", name, args, MakeResourceOptions(options, ""))
        {
        }

        private NetworkMapping(string name, Input<string> id, NetworkMappingState? state = null, CustomResourceOptions? options = null)
            : base("azure:recoveryservices/networkMapping:NetworkMapping", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NetworkMapping resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkMapping Get(string name, Input<string> id, NetworkMappingState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkMapping(name, id, state, options);
        }
    }

    public sealed class NetworkMappingArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the network mapping.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the vault that should be updated.
        /// </summary>
        [Input("recoveryVaultName", required: true)]
        public Input<string> RecoveryVaultName { get; set; } = null!;

        /// <summary>
        /// Name of the resource group where the vault that should be updated is located.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The id of the primary network.
        /// </summary>
        [Input("sourceNetworkId", required: true)]
        public Input<string> SourceNetworkId { get; set; } = null!;

        /// <summary>
        /// Specifies the ASR fabric where mapping should be created.
        /// </summary>
        [Input("sourceRecoveryFabricName", required: true)]
        public Input<string> SourceRecoveryFabricName { get; set; } = null!;

        /// <summary>
        /// The id of the recovery network.
        /// </summary>
        [Input("targetNetworkId", required: true)]
        public Input<string> TargetNetworkId { get; set; } = null!;

        /// <summary>
        /// The Azure Site Recovery fabric object corresponding to the recovery Azure region.
        /// </summary>
        [Input("targetRecoveryFabricName", required: true)]
        public Input<string> TargetRecoveryFabricName { get; set; } = null!;

        public NetworkMappingArgs()
        {
        }
    }

    public sealed class NetworkMappingState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the network mapping.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the vault that should be updated.
        /// </summary>
        [Input("recoveryVaultName")]
        public Input<string>? RecoveryVaultName { get; set; }

        /// <summary>
        /// Name of the resource group where the vault that should be updated is located.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The id of the primary network.
        /// </summary>
        [Input("sourceNetworkId")]
        public Input<string>? SourceNetworkId { get; set; }

        /// <summary>
        /// Specifies the ASR fabric where mapping should be created.
        /// </summary>
        [Input("sourceRecoveryFabricName")]
        public Input<string>? SourceRecoveryFabricName { get; set; }

        /// <summary>
        /// The id of the recovery network.
        /// </summary>
        [Input("targetNetworkId")]
        public Input<string>? TargetNetworkId { get; set; }

        /// <summary>
        /// The Azure Site Recovery fabric object corresponding to the recovery Azure region.
        /// </summary>
        [Input("targetRecoveryFabricName")]
        public Input<string>? TargetRecoveryFabricName { get; set; }

        public NetworkMappingState()
        {
        }
    }
}
