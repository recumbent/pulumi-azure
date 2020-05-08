// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Compute.Outputs
{

    [OutputType]
    public sealed class ScaleSetOsProfileWindowsConfig
    {
        /// <summary>
        /// An Additional Unattended Config block as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.ScaleSetOsProfileWindowsConfigAdditionalUnattendConfig> AdditionalUnattendConfigs;
        /// <summary>
        /// Indicates whether virtual machines in the scale set are enabled for automatic updates.
        /// </summary>
        public readonly bool? EnableAutomaticUpgrades;
        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual machines in the scale set.
        /// </summary>
        public readonly bool? ProvisionVmAgent;
        /// <summary>
        /// A collection of WinRM configuration blocks as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.ScaleSetOsProfileWindowsConfigWinrm> Winrms;

        [OutputConstructor]
        private ScaleSetOsProfileWindowsConfig(
            ImmutableArray<Outputs.ScaleSetOsProfileWindowsConfigAdditionalUnattendConfig> additionalUnattendConfigs,

            bool? enableAutomaticUpgrades,

            bool? provisionVmAgent,

            ImmutableArray<Outputs.ScaleSetOsProfileWindowsConfigWinrm> winrms)
        {
            AdditionalUnattendConfigs = additionalUnattendConfigs;
            EnableAutomaticUpgrades = enableAutomaticUpgrades;
            ProvisionVmAgent = provisionVmAgent;
            Winrms = winrms;
        }
    }
}