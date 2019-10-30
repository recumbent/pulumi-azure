// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Containerservice
{
    /// <summary>
    /// Manages an Azure Container Service Instance
    /// 
    /// &gt; **NOTE:** All arguments including the client secret will be stored in the raw state as plain-text.
    /// [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    /// 
    /// &gt; **DEPRECATED:** [Azure Container Service (ACS) has been deprecated by Azure in favour of Azure (Managed) Kubernetes Service (AKS)](https://azure.microsoft.com/en-us/updates/azure-container-service-will-retire-on-january-31-2020/). Support for ACS will be removed in the next major version of the AzureRM Provider (2.0) - and we **strongly recommend** you consider using Azure Kubernetes Service (AKS) for new deployments.
    /// 
    /// ## Example Usage (DCOS)
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/container_service.html.markdown.
    /// </summary>
    public partial class Service : Pulumi.CustomResource
    {
        /// <summary>
        /// A Agent Pool Profile's block as documented below.
        /// </summary>
        [Output("agentPoolProfile")]
        public Output<Outputs.ServiceAgentPoolProfile> AgentPoolProfile { get; private set; } = null!;

        /// <summary>
        /// A VM Diagnostics Profile block as documented below.
        /// </summary>
        [Output("diagnosticsProfile")]
        public Output<Outputs.ServiceDiagnosticsProfile> DiagnosticsProfile { get; private set; } = null!;

        /// <summary>
        /// A Linux Profile block as documented below.
        /// </summary>
        [Output("linuxProfile")]
        public Output<Outputs.ServiceLinuxProfile> LinuxProfile { get; private set; } = null!;

        /// <summary>
        /// The location where the Container Service instance should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// A Master Profile block as documented below.
        /// </summary>
        [Output("masterProfile")]
        public Output<Outputs.ServiceMasterProfile> MasterProfile { get; private set; } = null!;

        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the Container Orchestration Platform to use. Currently can be either `DCOS`, `Kubernetes` or `Swarm`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("orchestrationPlatform")]
        public Output<string> OrchestrationPlatform { get; private set; } = null!;

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A Service Principal block as documented below.
        /// </summary>
        [Output("servicePrincipal")]
        public Output<Outputs.ServiceServicePrincipal?> ServicePrincipal { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Service resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Service(string name, ServiceArgs args, CustomResourceOptions? options = null)
            : base("azure:containerservice/service:Service", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Service(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
            : base("azure:containerservice/service:Service", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Service resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Service Get(string name, Input<string> id, ServiceState? state = null, CustomResourceOptions? options = null)
        {
            return new Service(name, id, state, options);
        }
    }

    public sealed class ServiceArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A Agent Pool Profile's block as documented below.
        /// </summary>
        [Input("agentPoolProfile", required: true)]
        public Input<Inputs.ServiceAgentPoolProfileArgs> AgentPoolProfile { get; set; } = null!;

        /// <summary>
        /// A VM Diagnostics Profile block as documented below.
        /// </summary>
        [Input("diagnosticsProfile", required: true)]
        public Input<Inputs.ServiceDiagnosticsProfileArgs> DiagnosticsProfile { get; set; } = null!;

        /// <summary>
        /// A Linux Profile block as documented below.
        /// </summary>
        [Input("linuxProfile", required: true)]
        public Input<Inputs.ServiceLinuxProfileArgs> LinuxProfile { get; set; } = null!;

        /// <summary>
        /// The location where the Container Service instance should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// A Master Profile block as documented below.
        /// </summary>
        [Input("masterProfile", required: true)]
        public Input<Inputs.ServiceMasterProfileArgs> MasterProfile { get; set; } = null!;

        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the Container Orchestration Platform to use. Currently can be either `DCOS`, `Kubernetes` or `Swarm`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("orchestrationPlatform", required: true)]
        public Input<string> OrchestrationPlatform { get; set; } = null!;

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A Service Principal block as documented below.
        /// </summary>
        [Input("servicePrincipal")]
        public Input<Inputs.ServiceServicePrincipalArgs>? ServicePrincipal { get; set; }

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

        public ServiceArgs()
        {
        }
    }

    public sealed class ServiceState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A Agent Pool Profile's block as documented below.
        /// </summary>
        [Input("agentPoolProfile")]
        public Input<Inputs.ServiceAgentPoolProfileGetArgs>? AgentPoolProfile { get; set; }

        /// <summary>
        /// A VM Diagnostics Profile block as documented below.
        /// </summary>
        [Input("diagnosticsProfile")]
        public Input<Inputs.ServiceDiagnosticsProfileGetArgs>? DiagnosticsProfile { get; set; }

        /// <summary>
        /// A Linux Profile block as documented below.
        /// </summary>
        [Input("linuxProfile")]
        public Input<Inputs.ServiceLinuxProfileGetArgs>? LinuxProfile { get; set; }

        /// <summary>
        /// The location where the Container Service instance should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// A Master Profile block as documented below.
        /// </summary>
        [Input("masterProfile")]
        public Input<Inputs.ServiceMasterProfileGetArgs>? MasterProfile { get; set; }

        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the Container Orchestration Platform to use. Currently can be either `DCOS`, `Kubernetes` or `Swarm`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("orchestrationPlatform")]
        public Input<string>? OrchestrationPlatform { get; set; }

        /// <summary>
        /// Specifies the resource group where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// A Service Principal block as documented below.
        /// </summary>
        [Input("servicePrincipal")]
        public Input<Inputs.ServiceServicePrincipalGetArgs>? ServicePrincipal { get; set; }

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

        public ServiceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class ServiceAgentPoolProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// The DNS Prefix given to Agents in this Agent Pool.
        /// </summary>
        [Input("dnsPrefix", required: true)]
        public Input<string> DnsPrefix { get; set; } = null!;

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The VM Size of each of the Agent Pool VM's (e.g. Standard_F1 / Standard_D2v2).
        /// </summary>
        [Input("vmSize", required: true)]
        public Input<string> VmSize { get; set; } = null!;

        public ServiceAgentPoolProfileArgs()
        {
        }
    }

    public sealed class ServiceAgentPoolProfileGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// The DNS Prefix given to Agents in this Agent Pool.
        /// </summary>
        [Input("dnsPrefix", required: true)]
        public Input<string> DnsPrefix { get; set; } = null!;

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The VM Size of each of the Agent Pool VM's (e.g. Standard_F1 / Standard_D2v2).
        /// </summary>
        [Input("vmSize", required: true)]
        public Input<string> VmSize { get; set; } = null!;

        public ServiceAgentPoolProfileGetArgs()
        {
        }
    }

    public sealed class ServiceDiagnosticsProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Should VM Diagnostics be enabled for the Container Service VM's
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("storageUri")]
        public Input<string>? StorageUri { get; set; }

        public ServiceDiagnosticsProfileArgs()
        {
        }
    }

    public sealed class ServiceDiagnosticsProfileGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Should VM Diagnostics be enabled for the Container Service VM's
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        [Input("storageUri")]
        public Input<string>? StorageUri { get; set; }

        public ServiceDiagnosticsProfileGetArgs()
        {
        }
    }

    public sealed class ServiceLinuxProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Admin Username for the Cluster.
        /// </summary>
        [Input("adminUsername", required: true)]
        public Input<string> AdminUsername { get; set; } = null!;

        /// <summary>
        /// An SSH Key block as documented below.
        /// </summary>
        [Input("sshKey", required: true)]
        public Input<ServiceLinuxProfileSshKeyArgs> SshKey { get; set; } = null!;

        public ServiceLinuxProfileArgs()
        {
        }
    }

    public sealed class ServiceLinuxProfileGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Admin Username for the Cluster.
        /// </summary>
        [Input("adminUsername", required: true)]
        public Input<string> AdminUsername { get; set; } = null!;

        /// <summary>
        /// An SSH Key block as documented below.
        /// </summary>
        [Input("sshKey", required: true)]
        public Input<ServiceLinuxProfileSshKeyGetArgs> SshKey { get; set; } = null!;

        public ServiceLinuxProfileGetArgs()
        {
        }
    }

    public sealed class ServiceLinuxProfileSshKeyArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Public SSH Key used to access the cluster.
        /// </summary>
        [Input("keyData", required: true)]
        public Input<string> KeyData { get; set; } = null!;

        public ServiceLinuxProfileSshKeyArgs()
        {
        }
    }

    public sealed class ServiceLinuxProfileSshKeyGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The Public SSH Key used to access the cluster.
        /// </summary>
        [Input("keyData", required: true)]
        public Input<string> KeyData { get; set; } = null!;

        public ServiceLinuxProfileSshKeyGetArgs()
        {
        }
    }

    public sealed class ServiceMasterProfileArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// The DNS Prefix given to Agents in this Agent Pool.
        /// </summary>
        [Input("dnsPrefix", required: true)]
        public Input<string> DnsPrefix { get; set; } = null!;

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        public ServiceMasterProfileArgs()
        {
        }
    }

    public sealed class ServiceMasterProfileGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        [Input("count")]
        public Input<int>? Count { get; set; }

        /// <summary>
        /// The DNS Prefix given to Agents in this Agent Pool.
        /// </summary>
        [Input("dnsPrefix", required: true)]
        public Input<string> DnsPrefix { get; set; } = null!;

        [Input("fqdn")]
        public Input<string>? Fqdn { get; set; }

        public ServiceMasterProfileGetArgs()
        {
        }
    }

    public sealed class ServiceServicePrincipalArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID for the Service Principal.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The secret password associated with the service principal.
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        public ServiceServicePrincipalArgs()
        {
        }
    }

    public sealed class ServiceServicePrincipalGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID for the Service Principal.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The secret password associated with the service principal.
        /// </summary>
        [Input("clientSecret", required: true)]
        public Input<string> ClientSecret { get; set; } = null!;

        public ServiceServicePrincipalGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class ServiceAgentPoolProfile
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        public readonly int? Count;
        /// <summary>
        /// The DNS Prefix given to Agents in this Agent Pool.
        /// </summary>
        public readonly string DnsPrefix;
        public readonly string Fqdn;
        /// <summary>
        /// Unique name of the agent pool profile in the context of the subscription and resource group.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// The VM Size of each of the Agent Pool VM's (e.g. Standard_F1 / Standard_D2v2).
        /// </summary>
        public readonly string VmSize;

        [OutputConstructor]
        private ServiceAgentPoolProfile(
            int? count,
            string dnsPrefix,
            string fqdn,
            string name,
            string vmSize)
        {
            Count = count;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
            Name = name;
            VmSize = vmSize;
        }
    }

    [OutputType]
    public sealed class ServiceDiagnosticsProfile
    {
        /// <summary>
        /// Should VM Diagnostics be enabled for the Container Service VM's
        /// </summary>
        public readonly bool Enabled;
        public readonly string StorageUri;

        [OutputConstructor]
        private ServiceDiagnosticsProfile(
            bool enabled,
            string storageUri)
        {
            Enabled = enabled;
            StorageUri = storageUri;
        }
    }

    [OutputType]
    public sealed class ServiceLinuxProfile
    {
        /// <summary>
        /// The Admin Username for the Cluster.
        /// </summary>
        public readonly string AdminUsername;
        /// <summary>
        /// An SSH Key block as documented below.
        /// </summary>
        public readonly ServiceLinuxProfileSshKey SshKey;

        [OutputConstructor]
        private ServiceLinuxProfile(
            string adminUsername,
            ServiceLinuxProfileSshKey sshKey)
        {
            AdminUsername = adminUsername;
            SshKey = sshKey;
        }
    }

    [OutputType]
    public sealed class ServiceLinuxProfileSshKey
    {
        /// <summary>
        /// The Public SSH Key used to access the cluster.
        /// </summary>
        public readonly string KeyData;

        [OutputConstructor]
        private ServiceLinuxProfileSshKey(string keyData)
        {
            KeyData = keyData;
        }
    }

    [OutputType]
    public sealed class ServiceMasterProfile
    {
        /// <summary>
        /// Number of agents (VMs) to host docker containers. Allowed values must be in the range of 1 to 100 (inclusive). The default value is 1.
        /// </summary>
        public readonly int? Count;
        /// <summary>
        /// The DNS Prefix given to Agents in this Agent Pool.
        /// </summary>
        public readonly string DnsPrefix;
        public readonly string Fqdn;

        [OutputConstructor]
        private ServiceMasterProfile(
            int? count,
            string dnsPrefix,
            string fqdn)
        {
            Count = count;
            DnsPrefix = dnsPrefix;
            Fqdn = fqdn;
        }
    }

    [OutputType]
    public sealed class ServiceServicePrincipal
    {
        /// <summary>
        /// The ID for the Service Principal.
        /// </summary>
        public readonly string ClientId;
        /// <summary>
        /// The secret password associated with the service principal.
        /// </summary>
        public readonly string ClientSecret;

        [OutputConstructor]
        private ServiceServicePrincipal(
            string clientId,
            string clientSecret)
        {
            ClientId = clientId;
            ClientSecret = clientSecret;
        }
    }
    }
}
