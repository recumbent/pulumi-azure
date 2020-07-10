// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.HDInsight.Inputs
{

    public sealed class SparkClusterMetastoresArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An `ambari` block as defined below.
        /// </summary>
        [Input("ambari")]
        public Input<Inputs.SparkClusterMetastoresAmbariArgs>? Ambari { get; set; }

        /// <summary>
        /// A `hive` block as defined below.
        /// </summary>
        [Input("hive")]
        public Input<Inputs.SparkClusterMetastoresHiveArgs>? Hive { get; set; }

        /// <summary>
        /// An `oozie` block as defined below.
        /// </summary>
        [Input("oozie")]
        public Input<Inputs.SparkClusterMetastoresOozieArgs>? Oozie { get; set; }

        public SparkClusterMetastoresArgs()
        {
        }
    }
}
