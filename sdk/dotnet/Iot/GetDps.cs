// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Iot
{
    public static class GetDps
    {
        /// <summary>
        /// Use this data source to access information about an existing IotHub Device Provisioning Service.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDpsResult> InvokeAsync(GetDpsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDpsResult>("azure:iot/getDps:getDps", args ?? new GetDpsArgs(), options.WithVersion());
    }


    public sealed class GetDpsArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the name of the Iot Device Provisioning Service resource.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The name of the resource group under which the Iot Device Provisioning Service is located in.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        [Input("tags")]
        private Dictionary<string, string>? _tags;
        public Dictionary<string, string> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, string>());
            set => _tags = value;
        }

        public GetDpsArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDpsResult
    {
        /// <summary>
        /// The allocation policy of the IoT Device Provisioning Service.
        /// </summary>
        public readonly string AllocationPolicy;
        /// <summary>
        /// The device endpoint of the IoT Device Provisioning Service.
        /// </summary>
        public readonly string DeviceProvisioningHostName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The unique identifier of the IoT Device Provisioning Service.
        /// </summary>
        public readonly string IdScope;
        /// <summary>
        /// Specifies the supported Azure location where the IoT Device Provisioning Service exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// The service endpoint of the IoT Device Provisioning Service.
        /// </summary>
        public readonly string ServiceOperationsHostName;
        public readonly ImmutableDictionary<string, string>? Tags;

        [OutputConstructor]
        private GetDpsResult(
            string allocationPolicy,

            string deviceProvisioningHostName,

            string id,

            string idScope,

            string location,

            string name,

            string resourceGroupName,

            string serviceOperationsHostName,

            ImmutableDictionary<string, string>? tags)
        {
            AllocationPolicy = allocationPolicy;
            DeviceProvisioningHostName = deviceProvisioningHostName;
            Id = id;
            IdScope = idScope;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            ServiceOperationsHostName = serviceOperationsHostName;
            Tags = tags;
        }
    }
}
