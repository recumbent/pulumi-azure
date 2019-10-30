// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Notificationhub
{
    /// <summary>
    /// Manages a Notification Hub within a Notification Hub Namespace.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/notification_hub.html.markdown.
    /// </summary>
    public partial class Hub : Pulumi.CustomResource
    {
        /// <summary>
        /// A `apns_credential` block as defined below.
        /// </summary>
        [Output("apnsCredential")]
        public Output<Outputs.HubApnsCredential?> ApnsCredential { get; private set; } = null!;

        /// <summary>
        /// A `gcm_credential` block as defined below.
        /// </summary>
        [Output("gcmCredential")]
        public Output<Outputs.HubGcmCredential?> GcmCredential { get; private set; } = null!;

        /// <summary>
        /// The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name to use for this Notification Hub. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.
        /// </summary>
        [Output("namespaceName")]
        public Output<string> NamespaceName { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;


        /// <summary>
        /// Create a Hub resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Hub(string name, HubArgs args, CustomResourceOptions? options = null)
            : base("azure:notificationhub/hub:Hub", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Hub(string name, Input<string> id, HubState? state = null, CustomResourceOptions? options = null)
            : base("azure:notificationhub/hub:Hub", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Hub resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Hub Get(string name, Input<string> id, HubState? state = null, CustomResourceOptions? options = null)
        {
            return new Hub(name, id, state, options);
        }
    }

    public sealed class HubArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `apns_credential` block as defined below.
        /// </summary>
        [Input("apnsCredential")]
        public Input<Inputs.HubApnsCredentialArgs>? ApnsCredential { get; set; }

        /// <summary>
        /// A `gcm_credential` block as defined below.
        /// </summary>
        [Input("gcmCredential")]
        public Input<Inputs.HubGcmCredentialArgs>? GcmCredential { get; set; }

        /// <summary>
        /// The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name to use for this Notification Hub. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.
        /// </summary>
        [Input("namespaceName", required: true)]
        public Input<string> NamespaceName { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public HubArgs()
        {
        }
    }

    public sealed class HubState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A `apns_credential` block as defined below.
        /// </summary>
        [Input("apnsCredential")]
        public Input<Inputs.HubApnsCredentialGetArgs>? ApnsCredential { get; set; }

        /// <summary>
        /// A `gcm_credential` block as defined below.
        /// </summary>
        [Input("gcmCredential")]
        public Input<Inputs.HubGcmCredentialGetArgs>? GcmCredential { get; set; }

        /// <summary>
        /// The Azure Region in which this Notification Hub Namespace exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name to use for this Notification Hub. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Notification Hub Namespace in which to create this Notification Hub. Changing this forces a new resource to be created.
        /// </summary>
        [Input("namespaceName")]
        public Input<string>? NamespaceName { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the Notification Hub Namespace exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        public HubState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class HubApnsCredentialArgs : Pulumi.ResourceArgs
    {
        [Input("applicationMode", required: true)]
        public Input<string> ApplicationMode { get; set; } = null!;

        [Input("bundleId", required: true)]
        public Input<string> BundleId { get; set; } = null!;

        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        [Input("teamId", required: true)]
        public Input<string> TeamId { get; set; } = null!;

        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        public HubApnsCredentialArgs()
        {
        }
    }

    public sealed class HubApnsCredentialGetArgs : Pulumi.ResourceArgs
    {
        [Input("applicationMode", required: true)]
        public Input<string> ApplicationMode { get; set; } = null!;

        [Input("bundleId", required: true)]
        public Input<string> BundleId { get; set; } = null!;

        [Input("keyId", required: true)]
        public Input<string> KeyId { get; set; } = null!;

        [Input("teamId", required: true)]
        public Input<string> TeamId { get; set; } = null!;

        [Input("token", required: true)]
        public Input<string> Token { get; set; } = null!;

        public HubApnsCredentialGetArgs()
        {
        }
    }

    public sealed class HubGcmCredentialArgs : Pulumi.ResourceArgs
    {
        [Input("apiKey", required: true)]
        public Input<string> ApiKey { get; set; } = null!;

        public HubGcmCredentialArgs()
        {
        }
    }

    public sealed class HubGcmCredentialGetArgs : Pulumi.ResourceArgs
    {
        [Input("apiKey", required: true)]
        public Input<string> ApiKey { get; set; } = null!;

        public HubGcmCredentialGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class HubApnsCredential
    {
        public readonly string ApplicationMode;
        public readonly string BundleId;
        public readonly string KeyId;
        public readonly string TeamId;
        public readonly string Token;

        [OutputConstructor]
        private HubApnsCredential(
            string applicationMode,
            string bundleId,
            string keyId,
            string teamId,
            string token)
        {
            ApplicationMode = applicationMode;
            BundleId = bundleId;
            KeyId = keyId;
            TeamId = teamId;
            Token = token;
        }
    }

    [OutputType]
    public sealed class HubGcmCredential
    {
        public readonly string ApiKey;

        [OutputConstructor]
        private HubGcmCredential(string apiKey)
        {
            ApiKey = apiKey;
        }
    }
    }
}
