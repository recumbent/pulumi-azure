// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Containerservice
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to retrieve the version of Kubernetes supported by Azure Kubernetes Service.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/kubernetes_service_versions.html.markdown.
        /// </summary>
        public static Task<GetKubernetesServiceVersionsResult> GetKubernetesServiceVersions(GetKubernetesServiceVersionsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKubernetesServiceVersionsResult>("azure:containerservice/getKubernetesServiceVersions:getKubernetesServiceVersions", args, options.WithVersion());
    }

    public sealed class GetKubernetesServiceVersionsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the location in which to query for versions.
        /// </summary>
        [Input("location", required: true)]
        public Input<string> Location { get; set; } = null!;

        /// <summary>
        /// A prefix filter for the versions of Kubernetes which should be returned; for example `1.` will return `1.9` to `1.14`, whereas `1.12` will return `1.12.2`.
        /// </summary>
        [Input("versionPrefix")]
        public Input<string>? VersionPrefix { get; set; }

        public GetKubernetesServiceVersionsArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetKubernetesServiceVersionsResult
    {
        /// <summary>
        /// The most recent version available.
        /// </summary>
        public readonly string LatestVersion;
        public readonly string Location;
        public readonly string? VersionPrefix;
        /// <summary>
        /// The list of all supported versions.
        /// </summary>
        public readonly ImmutableArray<string> Versions;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetKubernetesServiceVersionsResult(
            string latestVersion,
            string location,
            string? versionPrefix,
            ImmutableArray<string> versions,
            string id)
        {
            LatestVersion = latestVersion;
            Location = location;
            VersionPrefix = versionPrefix;
            Versions = versions;
            Id = id;
        }
    }
}
