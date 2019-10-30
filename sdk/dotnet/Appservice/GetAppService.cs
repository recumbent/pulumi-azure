// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Appservice
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing App Service.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/app_service.html.markdown.
        /// </summary>
        public static Task<GetAppServiceResult> GetAppService(GetAppServiceArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetAppServiceResult>("azure:appservice/getAppService:getAppService", args, options.WithVersion());
    }

    public sealed class GetAppServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the App Service.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The Name of the Resource Group where the App Service exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetAppServiceArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetAppServiceResult
    {
        /// <summary>
        /// The ID of the App Service Plan within which the App Service exists.
        /// </summary>
        public readonly string AppServicePlanId;
        /// <summary>
        /// A key-value pair of App Settings for the App Service.
        /// </summary>
        public readonly ImmutableDictionary<string, string> AppSettings;
        /// <summary>
        /// Does the App Service send session affinity cookies, which route client requests in the same session to the same instance?
        /// </summary>
        public readonly bool ClientAffinityEnabled;
        /// <summary>
        /// Does the App Service require client certificates for incoming requests?
        /// </summary>
        public readonly bool ClientCertEnabled;
        /// <summary>
        /// An `connection_string` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAppServiceConnectionStringsResult> ConnectionStrings;
        /// <summary>
        /// The Default Hostname associated with the App Service - such as `mysite.azurewebsites.net`
        /// </summary>
        public readonly string DefaultSiteHostname;
        /// <summary>
        /// Is the App Service Enabled?
        /// </summary>
        public readonly bool Enabled;
        /// <summary>
        /// Can the App Service only be accessed via HTTPS?
        /// </summary>
        public readonly bool HttpsOnly;
        /// <summary>
        /// The Azure location where the App Service exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the Connection String.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`
        /// </summary>
        public readonly string OutboundIpAddresses;
        /// <summary>
        /// A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outbound_ip_addresses`.
        /// </summary>
        public readonly string PossibleOutboundIpAddresses;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A `site_config` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetAppServiceSiteConfigsResult> SiteConfigs;
        public readonly ImmutableArray<Outputs.GetAppServiceSiteCredentialsResult> SiteCredentials;
        public readonly ImmutableArray<Outputs.GetAppServiceSourceControlsResult> SourceControls;
        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetAppServiceResult(
            string appServicePlanId,
            ImmutableDictionary<string, string> appSettings,
            bool clientAffinityEnabled,
            bool clientCertEnabled,
            ImmutableArray<Outputs.GetAppServiceConnectionStringsResult> connectionStrings,
            string defaultSiteHostname,
            bool enabled,
            bool httpsOnly,
            string location,
            string name,
            string outboundIpAddresses,
            string possibleOutboundIpAddresses,
            string resourceGroupName,
            ImmutableArray<Outputs.GetAppServiceSiteConfigsResult> siteConfigs,
            ImmutableArray<Outputs.GetAppServiceSiteCredentialsResult> siteCredentials,
            ImmutableArray<Outputs.GetAppServiceSourceControlsResult> sourceControls,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            AppServicePlanId = appServicePlanId;
            AppSettings = appSettings;
            ClientAffinityEnabled = clientAffinityEnabled;
            ClientCertEnabled = clientCertEnabled;
            ConnectionStrings = connectionStrings;
            DefaultSiteHostname = defaultSiteHostname;
            Enabled = enabled;
            HttpsOnly = httpsOnly;
            Location = location;
            Name = name;
            OutboundIpAddresses = outboundIpAddresses;
            PossibleOutboundIpAddresses = possibleOutboundIpAddresses;
            ResourceGroupName = resourceGroupName;
            SiteConfigs = siteConfigs;
            SiteCredentials = siteCredentials;
            SourceControls = sourceControls;
            Tags = tags;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetAppServiceConnectionStringsResult
    {
        /// <summary>
        /// The name of the App Service.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The type of the Connection String.
        /// </summary>
        public readonly string Type;
        /// <summary>
        /// The value for the Connection String.
        /// </summary>
        public readonly string Value;

        [OutputConstructor]
        private GetAppServiceConnectionStringsResult(
            string name,
            string type,
            string value)
        {
            Name = name;
            Type = type;
            Value = value;
        }
    }

    [OutputType]
    public sealed class GetAppServiceSiteConfigsCorsResult
    {
        /// <summary>
        /// A list of origins which are able to make cross-origin calls.
        /// </summary>
        public readonly ImmutableArray<string> AllowedOrigins;
        /// <summary>
        /// Are credentials supported?
        /// </summary>
        public readonly bool SupportCredentials;

        [OutputConstructor]
        private GetAppServiceSiteConfigsCorsResult(
            ImmutableArray<string> allowedOrigins,
            bool supportCredentials)
        {
            AllowedOrigins = allowedOrigins;
            SupportCredentials = supportCredentials;
        }
    }

    [OutputType]
    public sealed class GetAppServiceSiteConfigsIpRestrictionsResult
    {
        /// <summary>
        /// The IP Address used for this IP Restriction.
        /// </summary>
        public readonly string IpAddress;
        /// <summary>
        /// The Subnet mask used for this IP Restriction.
        /// </summary>
        public readonly string SubnetMask;
        public readonly string VirtualNetworkSubnetId;

        [OutputConstructor]
        private GetAppServiceSiteConfigsIpRestrictionsResult(
            string ipAddress,
            string subnetMask,
            string virtualNetworkSubnetId)
        {
            IpAddress = ipAddress;
            SubnetMask = subnetMask;
            VirtualNetworkSubnetId = virtualNetworkSubnetId;
        }
    }

    [OutputType]
    public sealed class GetAppServiceSiteConfigsResult
    {
        /// <summary>
        /// Is the app be loaded at all times?
        /// </summary>
        public readonly bool AlwaysOn;
        /// <summary>
        /// App command line to launch.
        /// </summary>
        public readonly string AppCommandLine;
        /// <summary>
        /// A `cors` block as defined above.
        /// </summary>
        public readonly GetAppServiceSiteConfigsCorsResult Cors;
        /// <summary>
        /// The ordering of default documents to load, if an address isn't specified.
        /// </summary>
        public readonly ImmutableArray<string> DefaultDocuments;
        /// <summary>
        /// The version of the .net framework's CLR used in this App Service.
        /// </summary>
        public readonly string DotnetFrameworkVersion;
        /// <summary>
        /// State of FTP / FTPS service for this AppService.
        /// </summary>
        public readonly string FtpsState;
        /// <summary>
        /// Is HTTP2 Enabled on this App Service?
        /// </summary>
        public readonly bool Http2Enabled;
        /// <summary>
        /// One or more `ip_restriction` blocks as defined above.
        /// </summary>
        public readonly ImmutableArray<GetAppServiceSiteConfigsIpRestrictionsResult> IpRestrictions;
        /// <summary>
        /// The Java Container in use.
        /// </summary>
        public readonly string JavaContainer;
        /// <summary>
        /// The version of the Java Container in use.
        /// </summary>
        public readonly string JavaContainerVersion;
        /// <summary>
        /// The version of Java in use.
        /// </summary>
        public readonly string JavaVersion;
        /// <summary>
        /// Linux App Framework and version for the AppService.
        /// </summary>
        public readonly string LinuxFxVersion;
        /// <summary>
        /// Is "MySQL In App" Enabled? This runs a local MySQL instance with your app and shares resources from the App Service plan.
        /// </summary>
        public readonly bool LocalMysqlEnabled;
        /// <summary>
        /// The Managed Pipeline Mode used in this App Service.
        /// </summary>
        public readonly string ManagedPipelineMode;
        /// <summary>
        /// The minimum supported TLS version for this App Service.
        /// </summary>
        public readonly string MinTlsVersion;
        /// <summary>
        /// The version of PHP used in this App Service.
        /// </summary>
        public readonly string PhpVersion;
        /// <summary>
        /// The version of Python used in this App Service.
        /// </summary>
        public readonly string PythonVersion;
        /// <summary>
        /// Is Remote Debugging Enabled in this App Service?
        /// </summary>
        public readonly bool RemoteDebuggingEnabled;
        /// <summary>
        /// Which version of Visual Studio is the Remote Debugger compatible with?
        /// </summary>
        public readonly string RemoteDebuggingVersion;
        /// <summary>
        /// The type of Source Control enabled for this App Service.
        /// </summary>
        public readonly string ScmType;
        /// <summary>
        /// Does the App Service run in 32 bit mode, rather than 64 bit mode?
        /// </summary>
        public readonly bool Use32BitWorkerProcess;
        /// <summary>
        /// The name of the Virtual Network which this App Service is attached to.
        /// </summary>
        public readonly string VirtualNetworkName;
        /// <summary>
        /// Are WebSockets enabled for this App Service?
        /// </summary>
        public readonly bool WebsocketsEnabled;
        /// <summary>
        /// Windows Container Docker Image for the AppService.
        /// </summary>
        public readonly string WindowsFxVersion;

        [OutputConstructor]
        private GetAppServiceSiteConfigsResult(
            bool alwaysOn,
            string appCommandLine,
            GetAppServiceSiteConfigsCorsResult cors,
            ImmutableArray<string> defaultDocuments,
            string dotnetFrameworkVersion,
            string ftpsState,
            bool http2Enabled,
            ImmutableArray<GetAppServiceSiteConfigsIpRestrictionsResult> ipRestrictions,
            string javaContainer,
            string javaContainerVersion,
            string javaVersion,
            string linuxFxVersion,
            bool localMysqlEnabled,
            string managedPipelineMode,
            string minTlsVersion,
            string phpVersion,
            string pythonVersion,
            bool remoteDebuggingEnabled,
            string remoteDebuggingVersion,
            string scmType,
            bool use32BitWorkerProcess,
            string virtualNetworkName,
            bool websocketsEnabled,
            string windowsFxVersion)
        {
            AlwaysOn = alwaysOn;
            AppCommandLine = appCommandLine;
            Cors = cors;
            DefaultDocuments = defaultDocuments;
            DotnetFrameworkVersion = dotnetFrameworkVersion;
            FtpsState = ftpsState;
            Http2Enabled = http2Enabled;
            IpRestrictions = ipRestrictions;
            JavaContainer = javaContainer;
            JavaContainerVersion = javaContainerVersion;
            JavaVersion = javaVersion;
            LinuxFxVersion = linuxFxVersion;
            LocalMysqlEnabled = localMysqlEnabled;
            ManagedPipelineMode = managedPipelineMode;
            MinTlsVersion = minTlsVersion;
            PhpVersion = phpVersion;
            PythonVersion = pythonVersion;
            RemoteDebuggingEnabled = remoteDebuggingEnabled;
            RemoteDebuggingVersion = remoteDebuggingVersion;
            ScmType = scmType;
            Use32BitWorkerProcess = use32BitWorkerProcess;
            VirtualNetworkName = virtualNetworkName;
            WebsocketsEnabled = websocketsEnabled;
            WindowsFxVersion = windowsFxVersion;
        }
    }

    [OutputType]
    public sealed class GetAppServiceSiteCredentialsResult
    {
        public readonly string Password;
        public readonly string Username;

        [OutputConstructor]
        private GetAppServiceSiteCredentialsResult(
            string password,
            string username)
        {
            Password = password;
            Username = username;
        }
    }

    [OutputType]
    public sealed class GetAppServiceSourceControlsResult
    {
        public readonly string Branch;
        public readonly string RepoUrl;

        [OutputConstructor]
        private GetAppServiceSourceControlsResult(
            string branch,
            string repoUrl)
        {
            Branch = branch;
            RepoUrl = repoUrl;
        }
    }
    }
}
