// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.MSSql
{
    public static class GetDatabase
    {
        /// <summary>
        /// Use this data source to access information about an existing SQL database.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetDatabaseResult> InvokeAsync(GetDatabaseArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseResult>("azure:mssql/getDatabase:getDatabase", args ?? new GetDatabaseArgs(), options.WithVersion());
    }


    public sealed class GetDatabaseArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// The name of the Ms SQL Database.
        /// </summary>
        [Input("name", required: true)]
        public string Name { get; set; } = null!;

        /// <summary>
        /// The id of the Ms SQL Server on which to create the database.
        /// </summary>
        [Input("serverId", required: true)]
        public string ServerId { get; set; } = null!;

        public GetDatabaseArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetDatabaseResult
    {
        /// <summary>
        /// The collation of the database. 
        /// </summary>
        public readonly string Collation;
        /// <summary>
        /// The id of the elastic pool containing this database.
        /// </summary>
        public readonly string ElasticPoolId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        /// <summary>
        /// The license type to apply for this database.
        /// </summary>
        public readonly string LicenseType;
        /// <summary>
        /// The max size of the database in gigabytes.
        /// </summary>
        public readonly int MaxSizeGb;
        public readonly string Name;
        /// <summary>
        /// The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. 
        /// </summary>
        public readonly int ReadReplicaCount;
        /// <summary>
        /// If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica.
        /// </summary>
        public readonly bool ReadScale;
        public readonly string ServerId;
        /// <summary>
        /// The name of the sku of the database.
        /// </summary>
        public readonly string SkuName;
        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones.
        /// </summary>
        public readonly bool ZoneRedundant;

        [OutputConstructor]
        private GetDatabaseResult(
            string collation,

            string elasticPoolId,

            string id,

            string licenseType,

            int maxSizeGb,

            string name,

            int readReplicaCount,

            bool readScale,

            string serverId,

            string skuName,

            ImmutableDictionary<string, string> tags,

            bool zoneRedundant)
        {
            Collation = collation;
            ElasticPoolId = elasticPoolId;
            Id = id;
            LicenseType = licenseType;
            MaxSizeGb = maxSizeGb;
            Name = name;
            ReadReplicaCount = readReplicaCount;
            ReadScale = readScale;
            ServerId = serverId;
            SkuName = skuName;
            Tags = tags;
            ZoneRedundant = zoneRedundant;
        }
    }
}
