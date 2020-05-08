// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Network.Outputs
{

    [OutputType]
    public sealed class GetVirtualNetworkGatewayVpnClientConfigurationResult
    {
        /// <summary>
        /// The address space out of which ip addresses for
        /// vpn clients will be taken. You can provide more than one address space, e.g.
        /// in CIDR notation.
        /// </summary>
        public readonly ImmutableArray<string> AddressSpaces;
        /// <summary>
        /// The address of the Radius server.
        /// This setting is incompatible with the use of `root_certificate` and `revoked_certificate`.
        /// </summary>
        public readonly string RadiusServerAddress;
        /// <summary>
        /// The secret used by the Radius server.
        /// This setting is incompatible with the use of `root_certificate` and `revoked_certificate`.
        /// </summary>
        public readonly string RadiusServerSecret;
        /// <summary>
        /// One or more `revoked_certificate` blocks which
        /// are defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificateResult> RevokedCertificates;
        /// <summary>
        /// One or more `root_certificate` blocks which are
        /// defined below. These root certificates are used to sign the client certificate
        /// used by the VPN clients to connect to the gateway.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetVirtualNetworkGatewayVpnClientConfigurationRootCertificateResult> RootCertificates;
        /// <summary>
        /// List of the protocols supported by the vpn client.
        /// The supported values are `SSTP`, `IkeV2` and `OpenVPN`.
        /// </summary>
        public readonly ImmutableArray<string> VpnClientProtocols;

        [OutputConstructor]
        private GetVirtualNetworkGatewayVpnClientConfigurationResult(
            ImmutableArray<string> addressSpaces,

            string radiusServerAddress,

            string radiusServerSecret,

            ImmutableArray<Outputs.GetVirtualNetworkGatewayVpnClientConfigurationRevokedCertificateResult> revokedCertificates,

            ImmutableArray<Outputs.GetVirtualNetworkGatewayVpnClientConfigurationRootCertificateResult> rootCertificates,

            ImmutableArray<string> vpnClientProtocols)
        {
            AddressSpaces = addressSpaces;
            RadiusServerAddress = radiusServerAddress;
            RadiusServerSecret = radiusServerSecret;
            RevokedCertificates = revokedCertificates;
            RootCertificates = rootCertificates;
            VpnClientProtocols = vpnClientProtocols;
        }
    }
}