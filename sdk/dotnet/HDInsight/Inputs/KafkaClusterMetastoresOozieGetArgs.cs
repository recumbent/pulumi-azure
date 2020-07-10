// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.HDInsight.Inputs
{

    public sealed class KafkaClusterMetastoresOozieGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The external Oozie metastore's existing SQL database.  Changing this forces a new resource to be created.
        /// </summary>
        [Input("databaseName", required: true)]
        public Input<string> DatabaseName { get; set; } = null!;

        /// <summary>
        /// The external Oozie metastore's existing SQL server admin password.  Changing this forces a new resource to be created.
        /// </summary>
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        /// <summary>
        /// The fully-qualified domain name (FQDN) of the SQL server to use for the external Oozie metastore.  Changing this forces a new resource to be created.
        /// </summary>
        [Input("server", required: true)]
        public Input<string> Server { get; set; } = null!;

        /// <summary>
        /// The external Oozie metastore's existing SQL server admin username.  Changing this forces a new resource to be created.
        /// </summary>
        [Input("username", required: true)]
        public Input<string> Username { get; set; } = null!;

        public KafkaClusterMetastoresOozieGetArgs()
        {
        }
    }
}
