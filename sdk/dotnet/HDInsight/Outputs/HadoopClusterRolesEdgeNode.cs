// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.HDInsight.Outputs
{

    [OutputType]
    public sealed class HadoopClusterRolesEdgeNode
    {
        /// <summary>
        /// A `install_script_action` block as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.HadoopClusterRolesEdgeNodeInstallScriptAction> InstallScriptActions;
        /// <summary>
        /// The number of instances which should be run for the Worker Nodes.
        /// </summary>
        public readonly int TargetInstanceCount;
        /// <summary>
        /// The Size of the Virtual Machine which should be used as the Edge Nodes. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string VmSize;

        [OutputConstructor]
        private HadoopClusterRolesEdgeNode(
            ImmutableArray<Outputs.HadoopClusterRolesEdgeNodeInstallScriptAction> installScriptActions,

            int targetInstanceCount,

            string vmSize)
        {
            InstallScriptActions = installScriptActions;
            TargetInstanceCount = targetInstanceCount;
            VmSize = vmSize;
        }
    }
}