// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Cdn
{
    /// <summary>
    /// A CDN Endpoint is the entity within a CDN Profile containing configuration information regarding caching behaviors and origins. The CDN Endpoint is exposed using the URL format &lt;endpointname&gt;.azureedge.net.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/cdn_endpoint.html.markdown.
    /// </summary>
    public partial class Endpoint : Pulumi.CustomResource
    {
        /// <summary>
        /// An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.
        /// </summary>
        [Output("contentTypesToCompresses")]
        public Output<ImmutableArray<string>> ContentTypesToCompresses { get; private set; } = null!;

        /// <summary>
        /// A set of Geo Filters for this CDN Endpoint. Each `geo_filter` block supports fields documented below.
        /// </summary>
        [Output("geoFilters")]
        public Output<ImmutableArray<Outputs.EndpointGeoFilters>> GeoFilters { get; private set; } = null!;

        [Output("hostName")]
        public Output<string> HostName { get; private set; } = null!;

        /// <summary>
        /// Indicates whether compression is to be enabled. Defaults to false.
        /// </summary>
        [Output("isCompressionEnabled")]
        public Output<bool?> IsCompressionEnabled { get; private set; } = null!;

        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        [Output("isHttpAllowed")]
        public Output<bool?> IsHttpAllowed { get; private set; } = null!;

        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        [Output("isHttpsAllowed")]
        public Output<bool?> IsHttpsAllowed { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// What types of optimization should this CDN Endpoint optimize for? Possible values include `DynamicSiteAcceleration`, `GeneralMediaStreaming`, `GeneralWebDelivery`, `LargeFileDownload` and `VideoOnDemandMediaStreaming`.
        /// </summary>
        [Output("optimizationType")]
        public Output<string?> OptimizationType { get; private set; } = null!;

        /// <summary>
        /// The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each `origin` block supports fields documented below.
        /// </summary>
        [Output("origins")]
        public Output<ImmutableArray<Outputs.EndpointOrigins>> Origins { get; private set; } = null!;

        /// <summary>
        /// The host header CDN provider will send along with content requests to origins. Defaults to the host name of the origin.
        /// </summary>
        [Output("originHostHeader")]
        public Output<string> OriginHostHeader { get; private set; } = null!;

        /// <summary>
        /// The path used at for origin requests.
        /// </summary>
        [Output("originPath")]
        public Output<string> OriginPath { get; private set; } = null!;

        /// <summary>
        /// the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the `origin_path`.
        /// </summary>
        [Output("probePath")]
        public Output<string> ProbePath { get; private set; } = null!;

        /// <summary>
        /// The CDN Profile to which to attach the CDN Endpoint.
        /// </summary>
        [Output("profileName")]
        public Output<string> ProfileName { get; private set; } = null!;

        /// <summary>
        /// Sets query string caching behavior. Allowed values are `IgnoreQueryString`, `BypassCaching` and `UseQueryString`. Defaults to `IgnoreQueryString`.
        /// </summary>
        [Output("querystringCachingBehaviour")]
        public Output<string?> QuerystringCachingBehaviour { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the CDN Endpoint.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Endpoint resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Endpoint(string name, EndpointArgs args, CustomResourceOptions? options = null)
            : base("azure:cdn/endpoint:Endpoint", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Endpoint(string name, Input<string> id, EndpointState? state = null, CustomResourceOptions? options = null)
            : base("azure:cdn/endpoint:Endpoint", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Endpoint resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Endpoint Get(string name, Input<string> id, EndpointState? state = null, CustomResourceOptions? options = null)
        {
            return new Endpoint(name, id, state, options);
        }
    }

    public sealed class EndpointArgs : Pulumi.ResourceArgs
    {
        [Input("contentTypesToCompresses")]
        private InputList<string>? _contentTypesToCompresses;

        /// <summary>
        /// An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.
        /// </summary>
        public InputList<string> ContentTypesToCompresses
        {
            get => _contentTypesToCompresses ?? (_contentTypesToCompresses = new InputList<string>());
            set => _contentTypesToCompresses = value;
        }

        [Input("geoFilters")]
        private InputList<Inputs.EndpointGeoFiltersArgs>? _geoFilters;

        /// <summary>
        /// A set of Geo Filters for this CDN Endpoint. Each `geo_filter` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.EndpointGeoFiltersArgs> GeoFilters
        {
            get => _geoFilters ?? (_geoFilters = new InputList<Inputs.EndpointGeoFiltersArgs>());
            set => _geoFilters = value;
        }

        /// <summary>
        /// Indicates whether compression is to be enabled. Defaults to false.
        /// </summary>
        [Input("isCompressionEnabled")]
        public Input<bool>? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        [Input("isHttpAllowed")]
        public Input<bool>? IsHttpAllowed { get; set; }

        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        [Input("isHttpsAllowed")]
        public Input<bool>? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// What types of optimization should this CDN Endpoint optimize for? Possible values include `DynamicSiteAcceleration`, `GeneralMediaStreaming`, `GeneralWebDelivery`, `LargeFileDownload` and `VideoOnDemandMediaStreaming`.
        /// </summary>
        [Input("optimizationType")]
        public Input<string>? OptimizationType { get; set; }

        [Input("origins", required: true)]
        private InputList<Inputs.EndpointOriginsArgs>? _origins;

        /// <summary>
        /// The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each `origin` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.EndpointOriginsArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.EndpointOriginsArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// The host header CDN provider will send along with content requests to origins. Defaults to the host name of the origin.
        /// </summary>
        [Input("originHostHeader")]
        public Input<string>? OriginHostHeader { get; set; }

        /// <summary>
        /// The path used at for origin requests.
        /// </summary>
        [Input("originPath")]
        public Input<string>? OriginPath { get; set; }

        /// <summary>
        /// the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the `origin_path`.
        /// </summary>
        [Input("probePath")]
        public Input<string>? ProbePath { get; set; }

        /// <summary>
        /// The CDN Profile to which to attach the CDN Endpoint.
        /// </summary>
        [Input("profileName", required: true)]
        public Input<string> ProfileName { get; set; } = null!;

        /// <summary>
        /// Sets query string caching behavior. Allowed values are `IgnoreQueryString`, `BypassCaching` and `UseQueryString`. Defaults to `IgnoreQueryString`.
        /// </summary>
        [Input("querystringCachingBehaviour")]
        public Input<string>? QuerystringCachingBehaviour { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the CDN Endpoint.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

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

        public EndpointArgs()
        {
        }
    }

    public sealed class EndpointState : Pulumi.ResourceArgs
    {
        [Input("contentTypesToCompresses")]
        private InputList<string>? _contentTypesToCompresses;

        /// <summary>
        /// An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.
        /// </summary>
        public InputList<string> ContentTypesToCompresses
        {
            get => _contentTypesToCompresses ?? (_contentTypesToCompresses = new InputList<string>());
            set => _contentTypesToCompresses = value;
        }

        [Input("geoFilters")]
        private InputList<Inputs.EndpointGeoFiltersGetArgs>? _geoFilters;

        /// <summary>
        /// A set of Geo Filters for this CDN Endpoint. Each `geo_filter` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.EndpointGeoFiltersGetArgs> GeoFilters
        {
            get => _geoFilters ?? (_geoFilters = new InputList<Inputs.EndpointGeoFiltersGetArgs>());
            set => _geoFilters = value;
        }

        [Input("hostName")]
        public Input<string>? HostName { get; set; }

        /// <summary>
        /// Indicates whether compression is to be enabled. Defaults to false.
        /// </summary>
        [Input("isCompressionEnabled")]
        public Input<bool>? IsCompressionEnabled { get; set; }

        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        [Input("isHttpAllowed")]
        public Input<bool>? IsHttpAllowed { get; set; }

        /// <summary>
        /// Defaults to `true`.
        /// </summary>
        [Input("isHttpsAllowed")]
        public Input<bool>? IsHttpsAllowed { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// What types of optimization should this CDN Endpoint optimize for? Possible values include `DynamicSiteAcceleration`, `GeneralMediaStreaming`, `GeneralWebDelivery`, `LargeFileDownload` and `VideoOnDemandMediaStreaming`.
        /// </summary>
        [Input("optimizationType")]
        public Input<string>? OptimizationType { get; set; }

        [Input("origins")]
        private InputList<Inputs.EndpointOriginsGetArgs>? _origins;

        /// <summary>
        /// The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each `origin` block supports fields documented below.
        /// </summary>
        public InputList<Inputs.EndpointOriginsGetArgs> Origins
        {
            get => _origins ?? (_origins = new InputList<Inputs.EndpointOriginsGetArgs>());
            set => _origins = value;
        }

        /// <summary>
        /// The host header CDN provider will send along with content requests to origins. Defaults to the host name of the origin.
        /// </summary>
        [Input("originHostHeader")]
        public Input<string>? OriginHostHeader { get; set; }

        /// <summary>
        /// The path used at for origin requests.
        /// </summary>
        [Input("originPath")]
        public Input<string>? OriginPath { get; set; }

        /// <summary>
        /// the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the `origin_path`.
        /// </summary>
        [Input("probePath")]
        public Input<string>? ProbePath { get; set; }

        /// <summary>
        /// The CDN Profile to which to attach the CDN Endpoint.
        /// </summary>
        [Input("profileName")]
        public Input<string>? ProfileName { get; set; }

        /// <summary>
        /// Sets query string caching behavior. Allowed values are `IgnoreQueryString`, `BypassCaching` and `UseQueryString`. Defaults to `IgnoreQueryString`.
        /// </summary>
        [Input("querystringCachingBehaviour")]
        public Input<string>? QuerystringCachingBehaviour { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the CDN Endpoint.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

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

        public EndpointState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class EndpointGeoFiltersArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("countryCodes", required: true)]
        private InputList<string>? _countryCodes;
        public InputList<string> CountryCodes
        {
            get => _countryCodes ?? (_countryCodes = new InputList<string>());
            set => _countryCodes = value;
        }

        [Input("relativePath", required: true)]
        public Input<string> RelativePath { get; set; } = null!;

        public EndpointGeoFiltersArgs()
        {
        }
    }

    public sealed class EndpointGeoFiltersGetArgs : Pulumi.ResourceArgs
    {
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        [Input("countryCodes", required: true)]
        private InputList<string>? _countryCodes;
        public InputList<string> CountryCodes
        {
            get => _countryCodes ?? (_countryCodes = new InputList<string>());
            set => _countryCodes = value;
        }

        [Input("relativePath", required: true)]
        public Input<string> RelativePath { get; set; } = null!;

        public EndpointGeoFiltersGetArgs()
        {
        }
    }

    public sealed class EndpointOriginsArgs : Pulumi.ResourceArgs
    {
        [Input("hostName", required: true)]
        public Input<string> HostName { get; set; } = null!;

        [Input("httpPort")]
        public Input<int>? HttpPort { get; set; }

        [Input("httpsPort")]
        public Input<int>? HttpsPort { get; set; }

        /// <summary>
        /// Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public EndpointOriginsArgs()
        {
        }
    }

    public sealed class EndpointOriginsGetArgs : Pulumi.ResourceArgs
    {
        [Input("hostName", required: true)]
        public Input<string> HostName { get; set; } = null!;

        [Input("httpPort")]
        public Input<int>? HttpPort { get; set; }

        [Input("httpsPort")]
        public Input<int>? HttpsPort { get; set; }

        /// <summary>
        /// Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public EndpointOriginsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class EndpointGeoFilters
    {
        public readonly string Action;
        public readonly ImmutableArray<string> CountryCodes;
        public readonly string RelativePath;

        [OutputConstructor]
        private EndpointGeoFilters(
            string action,
            ImmutableArray<string> countryCodes,
            string relativePath)
        {
            Action = action;
            CountryCodes = countryCodes;
            RelativePath = relativePath;
        }
    }

    [OutputType]
    public sealed class EndpointOrigins
    {
        public readonly string HostName;
        public readonly int? HttpPort;
        public readonly int? HttpsPort;
        /// <summary>
        /// Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private EndpointOrigins(
            string hostName,
            int? httpPort,
            int? httpsPort,
            string name)
        {
            HostName = hostName;
            HttpPort = httpPort;
            HttpsPort = httpsPort;
            Name = name;
        }
    }
    }
}
