// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    public static class GetApi
    {
        /// <summary>
        /// Use this data source to access information about an existing API Management API.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetApiResult> InvokeAsync(GetApiArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetApiResult>("azure:apimanagement/getApi:getApi", args ?? new GetApiArgs(), options.WithVersion());
    }


    public sealed class GetApiArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management API exists.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public string ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management API.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group in which the API Management Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public string ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The Revision of the API Management API.
        /// </summary>
        [Input("revision", required: true)]
        public string Revision { get; set; } = null!;

        public GetApiArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetApiResult
    {
        public readonly string ApiManagementName;
        /// <summary>
        /// A description of the API Management API, which may include HTML formatting tags.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The display name of the API.
        /// </summary>
        public readonly string DisplayName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// Is this the current API Revision?
        /// </summary>
        public readonly bool IsCurrent;
        /// <summary>
        /// Is this API Revision online/accessible via the Gateway?
        /// </summary>
        public readonly bool IsOnline;
        public readonly string Name;
        /// <summary>
        /// The Path for this API Management API.
        /// </summary>
        public readonly string Path;
        /// <summary>
        /// A list of protocols the operations in this API can be invoked.
        /// </summary>
        public readonly ImmutableArray<string> Protocols;
        public readonly string ResourceGroupName;
        public readonly string Revision;
        /// <summary>
        /// Absolute URL of the backend service implementing this API.
        /// </summary>
        public readonly string ServiceUrl;
        /// <summary>
        /// Should this API expose a SOAP frontend, rather than a HTTP frontend?
        /// </summary>
        public readonly bool SoapPassThrough;
        /// <summary>
        /// A `subscription_key_parameter_names` block as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetApiSubscriptionKeyParameterNameResult> SubscriptionKeyParameterNames;
        /// <summary>
        /// The Version number of this API, if this API is versioned.
        /// </summary>
        public readonly string Version;
        /// <summary>
        /// The ID of the Version Set which this API is associated with.
        /// </summary>
        public readonly string VersionSetId;

        [OutputConstructor]
        private GetApiResult(
            string apiManagementName,

            string description,

            string displayName,

            string id,

            bool isCurrent,

            bool isOnline,

            string name,

            string path,

            ImmutableArray<string> protocols,

            string resourceGroupName,

            string revision,

            string serviceUrl,

            bool soapPassThrough,

            ImmutableArray<Outputs.GetApiSubscriptionKeyParameterNameResult> subscriptionKeyParameterNames,

            string version,

            string versionSetId)
        {
            ApiManagementName = apiManagementName;
            Description = description;
            DisplayName = displayName;
            Id = id;
            IsCurrent = isCurrent;
            IsOnline = isOnline;
            Name = name;
            Path = path;
            Protocols = protocols;
            ResourceGroupName = resourceGroupName;
            Revision = revision;
            ServiceUrl = serviceUrl;
            SoapPassThrough = soapPassThrough;
            SubscriptionKeyParameterNames = subscriptionKeyParameterNames;
            Version = version;
            VersionSetId = versionSetId;
        }
    }
}
