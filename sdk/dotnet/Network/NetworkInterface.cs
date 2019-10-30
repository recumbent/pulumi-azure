// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network
{
    /// <summary>
    /// Manages a Network Interface located in a Virtual Network, usually attached to a Virtual Machine.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/network_interface.html.markdown.
    /// </summary>
    public partial class NetworkInterface : Pulumi.CustomResource
    {
        /// <summary>
        /// If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set
        /// </summary>
        [Output("appliedDnsServers")]
        public Output<ImmutableArray<string>> AppliedDnsServers { get; private set; } = null!;

        /// <summary>
        /// List of DNS servers IP addresses to use for this NIC, overrides the VNet-level server list
        /// </summary>
        [Output("dnsServers")]
        public Output<ImmutableArray<string>> DnsServers { get; private set; } = null!;

        /// <summary>
        /// Enables Azure Accelerated Networking using SR-IOV. Only certain VM instance sizes are supported. Refer to [Create a Virtual Machine with Accelerated Networking](https://docs.microsoft.com/en-us/azure/virtual-network/create-vm-accelerated-networking-cli). Defaults to `false`.
        /// </summary>
        [Output("enableAcceleratedNetworking")]
        public Output<bool?> EnableAcceleratedNetworking { get; private set; } = null!;

        /// <summary>
        /// Enables IP Forwarding on the NIC. Defaults to `false`.
        /// </summary>
        [Output("enableIpForwarding")]
        public Output<bool?> EnableIpForwarding { get; private set; } = null!;

        /// <summary>
        /// Relative DNS name for this NIC used for internal communications between VMs in the same VNet
        /// </summary>
        [Output("internalDnsNameLabel")]
        public Output<string> InternalDnsNameLabel { get; private set; } = null!;

        [Output("internalFqdn")]
        public Output<string> InternalFqdn { get; private set; } = null!;

        /// <summary>
        /// One or more `ip_configuration` associated with this NIC as documented below.
        /// </summary>
        [Output("ipConfigurations")]
        public Output<ImmutableArray<Outputs.NetworkInterfaceIpConfigurations>> IpConfigurations { get; private set; } = null!;

        /// <summary>
        /// The location/region where the network interface is created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The media access control (MAC) address of the network interface.
        /// </summary>
        [Output("macAddress")]
        public Output<string> MacAddress { get; private set; } = null!;

        /// <summary>
        /// The name of the network interface. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the Network Security Group to associate with the network interface.
        /// </summary>
        [Output("networkSecurityGroupId")]
        public Output<string?> NetworkSecurityGroupId { get; private set; } = null!;

        /// <summary>
        /// The first private IP address of the network interface.
        /// </summary>
        [Output("privateIpAddress")]
        public Output<string> PrivateIpAddress { get; private set; } = null!;

        /// <summary>
        /// The private IP addresses of the network interface.
        /// </summary>
        [Output("privateIpAddresses")]
        public Output<ImmutableArray<string>> PrivateIpAddresses { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the network interface. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// Reference to a VM with which this NIC has been associated.
        /// </summary>
        [Output("virtualMachineId")]
        public Output<string> VirtualMachineId { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkInterface resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkInterface(string name, NetworkInterfaceArgs args, CustomResourceOptions? options = null)
            : base("azure:network/networkInterface:NetworkInterface", name, args, MakeResourceOptions(options, ""))
        {
        }

        private NetworkInterface(string name, Input<string> id, NetworkInterfaceState? state = null, CustomResourceOptions? options = null)
            : base("azure:network/networkInterface:NetworkInterface", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NetworkInterface resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkInterface Get(string name, Input<string> id, NetworkInterfaceState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkInterface(name, id, state, options);
        }
    }

    public sealed class NetworkInterfaceArgs : Pulumi.ResourceArgs
    {
        [Input("appliedDnsServers")]
        private InputList<string>? _appliedDnsServers;

        /// <summary>
        /// If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set
        /// </summary>
        public InputList<string> AppliedDnsServers
        {
            get => _appliedDnsServers ?? (_appliedDnsServers = new InputList<string>());
            set => _appliedDnsServers = value;
        }

        [Input("dnsServers")]
        private InputList<string>? _dnsServers;

        /// <summary>
        /// List of DNS servers IP addresses to use for this NIC, overrides the VNet-level server list
        /// </summary>
        public InputList<string> DnsServers
        {
            get => _dnsServers ?? (_dnsServers = new InputList<string>());
            set => _dnsServers = value;
        }

        /// <summary>
        /// Enables Azure Accelerated Networking using SR-IOV. Only certain VM instance sizes are supported. Refer to [Create a Virtual Machine with Accelerated Networking](https://docs.microsoft.com/en-us/azure/virtual-network/create-vm-accelerated-networking-cli). Defaults to `false`.
        /// </summary>
        [Input("enableAcceleratedNetworking")]
        public Input<bool>? EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Enables IP Forwarding on the NIC. Defaults to `false`.
        /// </summary>
        [Input("enableIpForwarding")]
        public Input<bool>? EnableIpForwarding { get; set; }

        /// <summary>
        /// Relative DNS name for this NIC used for internal communications between VMs in the same VNet
        /// </summary>
        [Input("internalDnsNameLabel")]
        public Input<string>? InternalDnsNameLabel { get; set; }

        [Input("internalFqdn")]
        public Input<string>? InternalFqdn { get; set; }

        [Input("ipConfigurations", required: true)]
        private InputList<Inputs.NetworkInterfaceIpConfigurationsArgs>? _ipConfigurations;

        /// <summary>
        /// One or more `ip_configuration` associated with this NIC as documented below.
        /// </summary>
        public InputList<Inputs.NetworkInterfaceIpConfigurationsArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.NetworkInterfaceIpConfigurationsArgs>());
            set => _ipConfigurations = value;
        }

        /// <summary>
        /// The location/region where the network interface is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The media access control (MAC) address of the network interface.
        /// </summary>
        [Input("macAddress")]
        public Input<string>? MacAddress { get; set; }

        /// <summary>
        /// The name of the network interface. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the Network Security Group to associate with the network interface.
        /// </summary>
        [Input("networkSecurityGroupId")]
        public Input<string>? NetworkSecurityGroupId { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the network interface. Changing this forces a new resource to be created.
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

        /// <summary>
        /// Reference to a VM with which this NIC has been associated.
        /// </summary>
        [Input("virtualMachineId")]
        public Input<string>? VirtualMachineId { get; set; }

        public NetworkInterfaceArgs()
        {
        }
    }

    public sealed class NetworkInterfaceState : Pulumi.ResourceArgs
    {
        [Input("appliedDnsServers")]
        private InputList<string>? _appliedDnsServers;

        /// <summary>
        /// If the VM that uses this NIC is part of an Availability Set, then this list will have the union of all DNS servers from all NICs that are part of the Availability Set
        /// </summary>
        public InputList<string> AppliedDnsServers
        {
            get => _appliedDnsServers ?? (_appliedDnsServers = new InputList<string>());
            set => _appliedDnsServers = value;
        }

        [Input("dnsServers")]
        private InputList<string>? _dnsServers;

        /// <summary>
        /// List of DNS servers IP addresses to use for this NIC, overrides the VNet-level server list
        /// </summary>
        public InputList<string> DnsServers
        {
            get => _dnsServers ?? (_dnsServers = new InputList<string>());
            set => _dnsServers = value;
        }

        /// <summary>
        /// Enables Azure Accelerated Networking using SR-IOV. Only certain VM instance sizes are supported. Refer to [Create a Virtual Machine with Accelerated Networking](https://docs.microsoft.com/en-us/azure/virtual-network/create-vm-accelerated-networking-cli). Defaults to `false`.
        /// </summary>
        [Input("enableAcceleratedNetworking")]
        public Input<bool>? EnableAcceleratedNetworking { get; set; }

        /// <summary>
        /// Enables IP Forwarding on the NIC. Defaults to `false`.
        /// </summary>
        [Input("enableIpForwarding")]
        public Input<bool>? EnableIpForwarding { get; set; }

        /// <summary>
        /// Relative DNS name for this NIC used for internal communications between VMs in the same VNet
        /// </summary>
        [Input("internalDnsNameLabel")]
        public Input<string>? InternalDnsNameLabel { get; set; }

        [Input("internalFqdn")]
        public Input<string>? InternalFqdn { get; set; }

        [Input("ipConfigurations")]
        private InputList<Inputs.NetworkInterfaceIpConfigurationsGetArgs>? _ipConfigurations;

        /// <summary>
        /// One or more `ip_configuration` associated with this NIC as documented below.
        /// </summary>
        public InputList<Inputs.NetworkInterfaceIpConfigurationsGetArgs> IpConfigurations
        {
            get => _ipConfigurations ?? (_ipConfigurations = new InputList<Inputs.NetworkInterfaceIpConfigurationsGetArgs>());
            set => _ipConfigurations = value;
        }

        /// <summary>
        /// The location/region where the network interface is created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The media access control (MAC) address of the network interface.
        /// </summary>
        [Input("macAddress")]
        public Input<string>? MacAddress { get; set; }

        /// <summary>
        /// The name of the network interface. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the Network Security Group to associate with the network interface.
        /// </summary>
        [Input("networkSecurityGroupId")]
        public Input<string>? NetworkSecurityGroupId { get; set; }

        /// <summary>
        /// The first private IP address of the network interface.
        /// </summary>
        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        [Input("privateIpAddresses")]
        private InputList<string>? _privateIpAddresses;

        /// <summary>
        /// The private IP addresses of the network interface.
        /// </summary>
        public InputList<string> PrivateIpAddresses
        {
            get => _privateIpAddresses ?? (_privateIpAddresses = new InputList<string>());
            set => _privateIpAddresses = value;
        }

        /// <summary>
        /// The name of the resource group in which to create the network interface. Changing this forces a new resource to be created.
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

        /// <summary>
        /// Reference to a VM with which this NIC has been associated.
        /// </summary>
        [Input("virtualMachineId")]
        public Input<string>? VirtualMachineId { get; set; }

        public NetworkInterfaceState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class NetworkInterfaceIpConfigurationsArgs : Pulumi.ResourceArgs
    {
        [Input("applicationGatewayBackendAddressPoolsIds")]
        private InputList<string>? _applicationGatewayBackendAddressPoolsIds;
        public InputList<string> ApplicationGatewayBackendAddressPoolsIds
        {
            get => _applicationGatewayBackendAddressPoolsIds ?? (_applicationGatewayBackendAddressPoolsIds = new InputList<string>());
            set => _applicationGatewayBackendAddressPoolsIds = value;
        }

        [Input("applicationSecurityGroupIds")]
        private InputList<string>? _applicationSecurityGroupIds;
        public InputList<string> ApplicationSecurityGroupIds
        {
            get => _applicationSecurityGroupIds ?? (_applicationSecurityGroupIds = new InputList<string>());
            set => _applicationSecurityGroupIds = value;
        }

        [Input("loadBalancerBackendAddressPoolsIds")]
        private InputList<string>? _loadBalancerBackendAddressPoolsIds;
        public InputList<string> LoadBalancerBackendAddressPoolsIds
        {
            get => _loadBalancerBackendAddressPoolsIds ?? (_loadBalancerBackendAddressPoolsIds = new InputList<string>());
            set => _loadBalancerBackendAddressPoolsIds = value;
        }

        [Input("loadBalancerInboundNatRulesIds")]
        private InputList<string>? _loadBalancerInboundNatRulesIds;
        public InputList<string> LoadBalancerInboundNatRulesIds
        {
            get => _loadBalancerInboundNatRulesIds ?? (_loadBalancerInboundNatRulesIds = new InputList<string>());
            set => _loadBalancerInboundNatRulesIds = value;
        }

        /// <summary>
        /// The name of the network interface. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("primary")]
        public Input<bool>? Primary { get; set; }

        /// <summary>
        /// The first private IP address of the network interface.
        /// </summary>
        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        [Input("privateIpAddressAllocation", required: true)]
        public Input<string> PrivateIpAddressAllocation { get; set; } = null!;

        [Input("privateIpAddressVersion")]
        public Input<string>? PrivateIpAddressVersion { get; set; }

        [Input("publicIpAddressId")]
        public Input<string>? PublicIpAddressId { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public NetworkInterfaceIpConfigurationsArgs()
        {
        }
    }

    public sealed class NetworkInterfaceIpConfigurationsGetArgs : Pulumi.ResourceArgs
    {
        [Input("applicationGatewayBackendAddressPoolsIds")]
        private InputList<string>? _applicationGatewayBackendAddressPoolsIds;
        public InputList<string> ApplicationGatewayBackendAddressPoolsIds
        {
            get => _applicationGatewayBackendAddressPoolsIds ?? (_applicationGatewayBackendAddressPoolsIds = new InputList<string>());
            set => _applicationGatewayBackendAddressPoolsIds = value;
        }

        [Input("applicationSecurityGroupIds")]
        private InputList<string>? _applicationSecurityGroupIds;
        public InputList<string> ApplicationSecurityGroupIds
        {
            get => _applicationSecurityGroupIds ?? (_applicationSecurityGroupIds = new InputList<string>());
            set => _applicationSecurityGroupIds = value;
        }

        [Input("loadBalancerBackendAddressPoolsIds")]
        private InputList<string>? _loadBalancerBackendAddressPoolsIds;
        public InputList<string> LoadBalancerBackendAddressPoolsIds
        {
            get => _loadBalancerBackendAddressPoolsIds ?? (_loadBalancerBackendAddressPoolsIds = new InputList<string>());
            set => _loadBalancerBackendAddressPoolsIds = value;
        }

        [Input("loadBalancerInboundNatRulesIds")]
        private InputList<string>? _loadBalancerInboundNatRulesIds;
        public InputList<string> LoadBalancerInboundNatRulesIds
        {
            get => _loadBalancerInboundNatRulesIds ?? (_loadBalancerInboundNatRulesIds = new InputList<string>());
            set => _loadBalancerInboundNatRulesIds = value;
        }

        /// <summary>
        /// The name of the network interface. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("primary")]
        public Input<bool>? Primary { get; set; }

        /// <summary>
        /// The first private IP address of the network interface.
        /// </summary>
        [Input("privateIpAddress")]
        public Input<string>? PrivateIpAddress { get; set; }

        [Input("privateIpAddressAllocation", required: true)]
        public Input<string> PrivateIpAddressAllocation { get; set; } = null!;

        [Input("privateIpAddressVersion")]
        public Input<string>? PrivateIpAddressVersion { get; set; }

        [Input("publicIpAddressId")]
        public Input<string>? PublicIpAddressId { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        public NetworkInterfaceIpConfigurationsGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class NetworkInterfaceIpConfigurations
    {
        public readonly ImmutableArray<string> ApplicationGatewayBackendAddressPoolsIds;
        public readonly ImmutableArray<string> ApplicationSecurityGroupIds;
        public readonly ImmutableArray<string> LoadBalancerBackendAddressPoolsIds;
        public readonly ImmutableArray<string> LoadBalancerInboundNatRulesIds;
        /// <summary>
        /// The name of the network interface. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly bool Primary;
        /// <summary>
        /// The first private IP address of the network interface.
        /// </summary>
        public readonly string? PrivateIpAddress;
        public readonly string PrivateIpAddressAllocation;
        public readonly string? PrivateIpAddressVersion;
        public readonly string? PublicIpAddressId;
        public readonly string? SubnetId;

        [OutputConstructor]
        private NetworkInterfaceIpConfigurations(
            ImmutableArray<string> applicationGatewayBackendAddressPoolsIds,
            ImmutableArray<string> applicationSecurityGroupIds,
            ImmutableArray<string> loadBalancerBackendAddressPoolsIds,
            ImmutableArray<string> loadBalancerInboundNatRulesIds,
            string name,
            bool primary,
            string? privateIpAddress,
            string privateIpAddressAllocation,
            string? privateIpAddressVersion,
            string? publicIpAddressId,
            string? subnetId)
        {
            ApplicationGatewayBackendAddressPoolsIds = applicationGatewayBackendAddressPoolsIds;
            ApplicationSecurityGroupIds = applicationSecurityGroupIds;
            LoadBalancerBackendAddressPoolsIds = loadBalancerBackendAddressPoolsIds;
            LoadBalancerInboundNatRulesIds = loadBalancerInboundNatRulesIds;
            Name = name;
            Primary = primary;
            PrivateIpAddress = privateIpAddress;
            PrivateIpAddressAllocation = privateIpAddressAllocation;
            PrivateIpAddressVersion = privateIpAddressVersion;
            PublicIpAddressId = publicIpAddressId;
            SubnetId = subnetId;
        }
    }
    }
}
