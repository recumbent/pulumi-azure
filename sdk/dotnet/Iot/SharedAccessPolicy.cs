// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Iot
{
    /// <summary>
    /// Manages an IotHub Shared Access Policy
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/iothub_shared_access_policy.html.markdown.
    /// </summary>
    public partial class SharedAccessPolicy : Pulumi.CustomResource
    {
        /// <summary>
        /// Adds `DeviceConnect` permission to this Shared Access Account. It allows sending and receiving on the device-side endpoints.
        /// </summary>
        [Output("deviceConnect")]
        public Output<bool?> DeviceConnect { get; private set; } = null!;

        /// <summary>
        /// The name of the IoTHub to which this Shared Access Policy belongs. Changing this forces a new resource to be created.
        /// </summary>
        [Output("iothubName")]
        public Output<string> IothubName { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub Shared Access Policy resource. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The primary connection string of the Shared Access Policy.
        /// </summary>
        [Output("primaryConnectionString")]
        public Output<string> PrimaryConnectionString { get; private set; } = null!;

        /// <summary>
        /// The primary key used to create the authentication token.
        /// </summary>
        [Output("primaryKey")]
        public Output<string> PrimaryKey { get; private set; } = null!;

        /// <summary>
        /// Adds `RegistryRead` permission to this Shared Access Account. It allows read access to the identity registry.
        /// </summary>
        [Output("registryRead")]
        public Output<bool?> RegistryRead { get; private set; } = null!;

        /// <summary>
        /// Adds `RegistryWrite` permission to this Shared Access Account. It allows write access to the identity registry.
        /// </summary>
        [Output("registryWrite")]
        public Output<bool?> RegistryWrite { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group under which the IotHub Shared Access Policy resource has to be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The secondary connection string of the Shared Access Policy.
        /// </summary>
        [Output("secondaryConnectionString")]
        public Output<string> SecondaryConnectionString { get; private set; } = null!;

        /// <summary>
        /// The secondary key used to create the authentication token.
        /// </summary>
        [Output("secondaryKey")]
        public Output<string> SecondaryKey { get; private set; } = null!;

        /// <summary>
        /// Adds `ServiceConnect` permission to this Shared Access Account. It allows sending and receiving on the cloud-side endpoints.
        /// </summary>
        [Output("serviceConnect")]
        public Output<bool?> ServiceConnect { get; private set; } = null!;


        /// <summary>
        /// Create a SharedAccessPolicy resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SharedAccessPolicy(string name, SharedAccessPolicyArgs args, CustomResourceOptions? options = null)
            : base("azure:iot/sharedAccessPolicy:SharedAccessPolicy", name, args, MakeResourceOptions(options, ""))
        {
        }

        private SharedAccessPolicy(string name, Input<string> id, SharedAccessPolicyState? state = null, CustomResourceOptions? options = null)
            : base("azure:iot/sharedAccessPolicy:SharedAccessPolicy", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing SharedAccessPolicy resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SharedAccessPolicy Get(string name, Input<string> id, SharedAccessPolicyState? state = null, CustomResourceOptions? options = null)
        {
            return new SharedAccessPolicy(name, id, state, options);
        }
    }

    public sealed class SharedAccessPolicyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Adds `DeviceConnect` permission to this Shared Access Account. It allows sending and receiving on the device-side endpoints.
        /// </summary>
        [Input("deviceConnect")]
        public Input<bool>? DeviceConnect { get; set; }

        /// <summary>
        /// The name of the IoTHub to which this Shared Access Policy belongs. Changing this forces a new resource to be created.
        /// </summary>
        [Input("iothubName", required: true)]
        public Input<string> IothubName { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the IotHub Shared Access Policy resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Adds `RegistryRead` permission to this Shared Access Account. It allows read access to the identity registry.
        /// </summary>
        [Input("registryRead")]
        public Input<bool>? RegistryRead { get; set; }

        /// <summary>
        /// Adds `RegistryWrite` permission to this Shared Access Account. It allows write access to the identity registry.
        /// </summary>
        [Input("registryWrite")]
        public Input<bool>? RegistryWrite { get; set; }

        /// <summary>
        /// The name of the resource group under which the IotHub Shared Access Policy resource has to be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Adds `ServiceConnect` permission to this Shared Access Account. It allows sending and receiving on the cloud-side endpoints.
        /// </summary>
        [Input("serviceConnect")]
        public Input<bool>? ServiceConnect { get; set; }

        public SharedAccessPolicyArgs()
        {
        }
    }

    public sealed class SharedAccessPolicyState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Adds `DeviceConnect` permission to this Shared Access Account. It allows sending and receiving on the device-side endpoints.
        /// </summary>
        [Input("deviceConnect")]
        public Input<bool>? DeviceConnect { get; set; }

        /// <summary>
        /// The name of the IoTHub to which this Shared Access Policy belongs. Changing this forces a new resource to be created.
        /// </summary>
        [Input("iothubName")]
        public Input<string>? IothubName { get; set; }

        /// <summary>
        /// Specifies the name of the IotHub Shared Access Policy resource. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The primary connection string of the Shared Access Policy.
        /// </summary>
        [Input("primaryConnectionString")]
        public Input<string>? PrimaryConnectionString { get; set; }

        /// <summary>
        /// The primary key used to create the authentication token.
        /// </summary>
        [Input("primaryKey")]
        public Input<string>? PrimaryKey { get; set; }

        /// <summary>
        /// Adds `RegistryRead` permission to this Shared Access Account. It allows read access to the identity registry.
        /// </summary>
        [Input("registryRead")]
        public Input<bool>? RegistryRead { get; set; }

        /// <summary>
        /// Adds `RegistryWrite` permission to this Shared Access Account. It allows write access to the identity registry.
        /// </summary>
        [Input("registryWrite")]
        public Input<bool>? RegistryWrite { get; set; }

        /// <summary>
        /// The name of the resource group under which the IotHub Shared Access Policy resource has to be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The secondary connection string of the Shared Access Policy.
        /// </summary>
        [Input("secondaryConnectionString")]
        public Input<string>? SecondaryConnectionString { get; set; }

        /// <summary>
        /// The secondary key used to create the authentication token.
        /// </summary>
        [Input("secondaryKey")]
        public Input<string>? SecondaryKey { get; set; }

        /// <summary>
        /// Adds `ServiceConnect` permission to this Shared Access Account. It allows sending and receiving on the cloud-side endpoints.
        /// </summary>
        [Input("serviceConnect")]
        public Input<bool>? ServiceConnect { get; set; }

        public SharedAccessPolicyState()
        {
        }
    }
}