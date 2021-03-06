// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Compute.Inputs
{

    public sealed class ScaleSetOsProfileSecretArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the key vault to use.
        /// </summary>
        [Input("sourceVaultId", required: true)]
        public Input<string> SourceVaultId { get; set; } = null!;

        [Input("vaultCertificates")]
        private InputList<Inputs.ScaleSetOsProfileSecretVaultCertificateArgs>? _vaultCertificates;

        /// <summary>
        /// A collection of Vault Certificates as documented below
        /// </summary>
        public InputList<Inputs.ScaleSetOsProfileSecretVaultCertificateArgs> VaultCertificates
        {
            get => _vaultCertificates ?? (_vaultCertificates = new InputList<Inputs.ScaleSetOsProfileSecretVaultCertificateArgs>());
            set => _vaultCertificates = value;
        }

        public ScaleSetOsProfileSecretArgs()
        {
        }
    }
}
