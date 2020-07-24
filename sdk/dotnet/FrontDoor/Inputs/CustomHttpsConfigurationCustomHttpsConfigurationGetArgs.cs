// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.FrontDoor.Inputs
{

    public sealed class CustomHttpsConfigurationCustomHttpsConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the Key Vault secret representing the full certificate PFX.
        /// </summary>
        [Input("azureKeyVaultCertificateSecretName")]
        public Input<string>? AzureKeyVaultCertificateSecretName { get; set; }

        /// <summary>
        /// The version of the Key Vault secret representing the full certificate PFX.
        /// </summary>
        [Input("azureKeyVaultCertificateSecretVersion")]
        public Input<string>? AzureKeyVaultCertificateSecretVersion { get; set; }

        /// <summary>
        /// The ID of the Key Vault containing the SSL certificate.
        /// </summary>
        [Input("azureKeyVaultCertificateVaultId")]
        public Input<string>? AzureKeyVaultCertificateVaultId { get; set; }

        /// <summary>
        /// Certificate source to encrypted `HTTPS` traffic with. Allowed values are `FrontDoor` or `AzureKeyVault`. Defaults to `FrontDoor`.
        /// </summary>
        [Input("certificateSource")]
        public Input<string>? CertificateSource { get; set; }

        /// <summary>
        /// Minimum client TLS version supported.
        /// </summary>
        [Input("minimumTlsVersion")]
        public Input<string>? MinimumTlsVersion { get; set; }

        [Input("provisioningState")]
        public Input<string>? ProvisioningState { get; set; }

        [Input("provisioningSubstate")]
        public Input<string>? ProvisioningSubstate { get; set; }

        public CustomHttpsConfigurationCustomHttpsConfigurationGetArgs()
        {
        }
    }
}
