// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network.Inputs
{

    public sealed class VirtualNetworkGatewayVpnClientConfigurationGetArgs : Pulumi.ResourceArgs
    {
        [Input("addressSpaces", required: true)]
        private InputList<string>? _addressSpaces;

        /// <summary>
        /// The address space out of which ip addresses for
        /// vpn clients will be taken. You can provide more than one address space, e.g.
        /// in CIDR notation.
        /// </summary>
        public InputList<string> AddressSpaces
        {
            get => _addressSpaces ?? (_addressSpaces = new InputList<string>());
            set => _addressSpaces = value;
        }

        /// <summary>
        /// The address of the Radius server.
        /// This setting is incompatible with the use of `root_certificate` and `revoked_certificate`.
        /// </summary>
        [Input("radiusServerAddress")]
        public Input<string>? RadiusServerAddress { get; set; }

        /// <summary>
        /// The secret used by the Radius server.
        /// This setting is incompatible with the use of `root_certificate` and `revoked_certificate`.
        /// </summary>
        [Input("radiusServerSecret")]
        public Input<string>? RadiusServerSecret { get; set; }

        [Input("revokedCertificates")]
        private InputList<Inputs.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificateGetArgs>? _revokedCertificates;

        /// <summary>
        /// One or more `revoked_certificate` blocks which
        /// are defined below.
        /// This setting is incompatible with the use of `radius_server_address` and `radius_server_secret`.
        /// </summary>
        public InputList<Inputs.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificateGetArgs> RevokedCertificates
        {
            get => _revokedCertificates ?? (_revokedCertificates = new InputList<Inputs.VirtualNetworkGatewayVpnClientConfigurationRevokedCertificateGetArgs>());
            set => _revokedCertificates = value;
        }

        [Input("rootCertificates")]
        private InputList<Inputs.VirtualNetworkGatewayVpnClientConfigurationRootCertificateGetArgs>? _rootCertificates;

        /// <summary>
        /// One or more `root_certificate` blocks which are
        /// defined below. These root certificates are used to sign the client certificate
        /// used by the VPN clients to connect to the gateway.
        /// This setting is incompatible with the use of `radius_server_address` and `radius_server_secret`.
        /// </summary>
        public InputList<Inputs.VirtualNetworkGatewayVpnClientConfigurationRootCertificateGetArgs> RootCertificates
        {
            get => _rootCertificates ?? (_rootCertificates = new InputList<Inputs.VirtualNetworkGatewayVpnClientConfigurationRootCertificateGetArgs>());
            set => _rootCertificates = value;
        }

        [Input("vpnClientProtocols")]
        private InputList<string>? _vpnClientProtocols;

        /// <summary>
        /// List of the protocols supported by the vpn client.
        /// The supported values are `SSTP`, `IkeV2` and `OpenVPN`.
        /// </summary>
        public InputList<string> VpnClientProtocols
        {
            get => _vpnClientProtocols ?? (_vpnClientProtocols = new InputList<string>());
            set => _vpnClientProtocols = value;
        }

        public VirtualNetworkGatewayVpnClientConfigurationGetArgs()
        {
        }
    }
}
