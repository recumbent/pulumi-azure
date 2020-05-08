// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a MS SQL Database.
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mssql_database.html.markdown.
 */
export class Database extends pulumi.CustomResource {
    /**
     * Get an existing Database resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DatabaseState, opts?: pulumi.CustomResourceOptions): Database {
        return new Database(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:mssql/database:Database';

    /**
     * Returns true if the given object is an instance of Database.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Database {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Database.__pulumiType;
    }

    /**
     * Time in minutes after which database is automatically paused. A value of `-1` means that automatic pause is disabled. This property is only settable for General Purpose Serverless databases.
     */
    public readonly autoPauseDelayInMinutes!: pulumi.Output<number>;
    /**
     * Specifies the collation of the database. Changing this forces a new resource to be created.
     */
    public readonly collation!: pulumi.Output<string>;
    /**
     * The create mode of the database. Possible values are `Copy`, `Default`, `OnlineSecondary`, `PointInTimeRestore`, `Restore`, `RestoreExternalBackup`, `RestoreExternalBackupSecondary`, `RestoreLongTermRetentionBackup` and `Secondary`. 
     */
    public readonly createMode!: pulumi.Output<string>;
    /**
     * The id of the source database to be referred to create the new database. This should only be used for databases with `createMode` values that use another database as reference. Changing this forces a new resource to be created.
     */
    public readonly creationSourceDatabaseId!: pulumi.Output<string>;
    /**
     * Specifies the ID of the elastic pool containing this database. Changing this forces a new resource to be created.
     */
    public readonly elasticPoolId!: pulumi.Output<string | undefined>;
    /**
     * A `extendedAuditingPolicy` block as defined below.
     */
    public readonly extendedAuditingPolicy!: pulumi.Output<outputs.mssql.DatabaseExtendedAuditingPolicy | undefined>;
    /**
     * Specifies the license type applied to this database. Possible values are `LicenseIncluded` and `BasePrice`.
     */
    public readonly licenseType!: pulumi.Output<string>;
    /**
     * The max size of the database in gigabytes. 
     */
    public readonly maxSizeGb!: pulumi.Output<number>;
    /**
     * Minimal capacity that database will always have allocated, if not paused. This property is only settable for General Purpose Serverless databases.
     */
    public readonly minCapacity!: pulumi.Output<number>;
    /**
     * The name of the Ms SQL Database. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases.
     */
    public readonly readReplicaCount!: pulumi.Output<number>;
    /**
     * If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases.
     */
    public readonly readScale!: pulumi.Output<boolean>;
    /**
     * Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. This property is only settable for `createMode`= `PointInTimeRestore`  databases.
     */
    public readonly restorePointInTime!: pulumi.Output<string>;
    /**
     * Specifies the name of the sample schema to apply when creating this database. Possible value is `AdventureWorksLT`.
     */
    public readonly sampleName!: pulumi.Output<string>;
    /**
     * The id of the Ms SQL Server on which to create the database. Changing this forces a new resource to be created.
     */
    public readonly serverId!: pulumi.Output<string>;
    /**
     * Specifies the name of the sku used by the database. Changing this forces a new resource to be created. For example, `GP_S_Gen5_2`,`HS_Gen4_1`,`BC_Gen5_2`, `ElasticPool`, `Basic`,`S0`, `P2` ,`DW100c`, `DS100`.
     */
    public readonly skuName!: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Threat detection policy configuration. The `threatDetectionPolicy` block supports fields documented below.
     */
    public readonly threatDetectionPolicy!: pulumi.Output<outputs.mssql.DatabaseThreatDetectionPolicy>;
    /**
     * Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. This property is only settable for Premium and Business Critical databases.
     */
    public readonly zoneRedundant!: pulumi.Output<boolean>;

    /**
     * Create a Database resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DatabaseArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DatabaseArgs | DatabaseState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as DatabaseState | undefined;
            inputs["autoPauseDelayInMinutes"] = state ? state.autoPauseDelayInMinutes : undefined;
            inputs["collation"] = state ? state.collation : undefined;
            inputs["createMode"] = state ? state.createMode : undefined;
            inputs["creationSourceDatabaseId"] = state ? state.creationSourceDatabaseId : undefined;
            inputs["elasticPoolId"] = state ? state.elasticPoolId : undefined;
            inputs["extendedAuditingPolicy"] = state ? state.extendedAuditingPolicy : undefined;
            inputs["licenseType"] = state ? state.licenseType : undefined;
            inputs["maxSizeGb"] = state ? state.maxSizeGb : undefined;
            inputs["minCapacity"] = state ? state.minCapacity : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["readReplicaCount"] = state ? state.readReplicaCount : undefined;
            inputs["readScale"] = state ? state.readScale : undefined;
            inputs["restorePointInTime"] = state ? state.restorePointInTime : undefined;
            inputs["sampleName"] = state ? state.sampleName : undefined;
            inputs["serverId"] = state ? state.serverId : undefined;
            inputs["skuName"] = state ? state.skuName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["threatDetectionPolicy"] = state ? state.threatDetectionPolicy : undefined;
            inputs["zoneRedundant"] = state ? state.zoneRedundant : undefined;
        } else {
            const args = argsOrState as DatabaseArgs | undefined;
            if (!args || args.serverId === undefined) {
                throw new Error("Missing required property 'serverId'");
            }
            inputs["autoPauseDelayInMinutes"] = args ? args.autoPauseDelayInMinutes : undefined;
            inputs["collation"] = args ? args.collation : undefined;
            inputs["createMode"] = args ? args.createMode : undefined;
            inputs["creationSourceDatabaseId"] = args ? args.creationSourceDatabaseId : undefined;
            inputs["elasticPoolId"] = args ? args.elasticPoolId : undefined;
            inputs["extendedAuditingPolicy"] = args ? args.extendedAuditingPolicy : undefined;
            inputs["licenseType"] = args ? args.licenseType : undefined;
            inputs["maxSizeGb"] = args ? args.maxSizeGb : undefined;
            inputs["minCapacity"] = args ? args.minCapacity : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["readReplicaCount"] = args ? args.readReplicaCount : undefined;
            inputs["readScale"] = args ? args.readScale : undefined;
            inputs["restorePointInTime"] = args ? args.restorePointInTime : undefined;
            inputs["sampleName"] = args ? args.sampleName : undefined;
            inputs["serverId"] = args ? args.serverId : undefined;
            inputs["skuName"] = args ? args.skuName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["threatDetectionPolicy"] = args ? args.threatDetectionPolicy : undefined;
            inputs["zoneRedundant"] = args ? args.zoneRedundant : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Database.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Database resources.
 */
export interface DatabaseState {
    /**
     * Time in minutes after which database is automatically paused. A value of `-1` means that automatic pause is disabled. This property is only settable for General Purpose Serverless databases.
     */
    readonly autoPauseDelayInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the collation of the database. Changing this forces a new resource to be created.
     */
    readonly collation?: pulumi.Input<string>;
    /**
     * The create mode of the database. Possible values are `Copy`, `Default`, `OnlineSecondary`, `PointInTimeRestore`, `Restore`, `RestoreExternalBackup`, `RestoreExternalBackupSecondary`, `RestoreLongTermRetentionBackup` and `Secondary`. 
     */
    readonly createMode?: pulumi.Input<string>;
    /**
     * The id of the source database to be referred to create the new database. This should only be used for databases with `createMode` values that use another database as reference. Changing this forces a new resource to be created.
     */
    readonly creationSourceDatabaseId?: pulumi.Input<string>;
    /**
     * Specifies the ID of the elastic pool containing this database. Changing this forces a new resource to be created.
     */
    readonly elasticPoolId?: pulumi.Input<string>;
    /**
     * A `extendedAuditingPolicy` block as defined below.
     */
    readonly extendedAuditingPolicy?: pulumi.Input<inputs.mssql.DatabaseExtendedAuditingPolicy>;
    /**
     * Specifies the license type applied to this database. Possible values are `LicenseIncluded` and `BasePrice`.
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * The max size of the database in gigabytes. 
     */
    readonly maxSizeGb?: pulumi.Input<number>;
    /**
     * Minimal capacity that database will always have allocated, if not paused. This property is only settable for General Purpose Serverless databases.
     */
    readonly minCapacity?: pulumi.Input<number>;
    /**
     * The name of the Ms SQL Database. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases.
     */
    readonly readReplicaCount?: pulumi.Input<number>;
    /**
     * If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases.
     */
    readonly readScale?: pulumi.Input<boolean>;
    /**
     * Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. This property is only settable for `createMode`= `PointInTimeRestore`  databases.
     */
    readonly restorePointInTime?: pulumi.Input<string>;
    /**
     * Specifies the name of the sample schema to apply when creating this database. Possible value is `AdventureWorksLT`.
     */
    readonly sampleName?: pulumi.Input<string>;
    /**
     * The id of the Ms SQL Server on which to create the database. Changing this forces a new resource to be created.
     */
    readonly serverId?: pulumi.Input<string>;
    /**
     * Specifies the name of the sku used by the database. Changing this forces a new resource to be created. For example, `GP_S_Gen5_2`,`HS_Gen4_1`,`BC_Gen5_2`, `ElasticPool`, `Basic`,`S0`, `P2` ,`DW100c`, `DS100`.
     */
    readonly skuName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Threat detection policy configuration. The `threatDetectionPolicy` block supports fields documented below.
     */
    readonly threatDetectionPolicy?: pulumi.Input<inputs.mssql.DatabaseThreatDetectionPolicy>;
    /**
     * Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. This property is only settable for Premium and Business Critical databases.
     */
    readonly zoneRedundant?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a Database resource.
 */
export interface DatabaseArgs {
    /**
     * Time in minutes after which database is automatically paused. A value of `-1` means that automatic pause is disabled. This property is only settable for General Purpose Serverless databases.
     */
    readonly autoPauseDelayInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the collation of the database. Changing this forces a new resource to be created.
     */
    readonly collation?: pulumi.Input<string>;
    /**
     * The create mode of the database. Possible values are `Copy`, `Default`, `OnlineSecondary`, `PointInTimeRestore`, `Restore`, `RestoreExternalBackup`, `RestoreExternalBackupSecondary`, `RestoreLongTermRetentionBackup` and `Secondary`. 
     */
    readonly createMode?: pulumi.Input<string>;
    /**
     * The id of the source database to be referred to create the new database. This should only be used for databases with `createMode` values that use another database as reference. Changing this forces a new resource to be created.
     */
    readonly creationSourceDatabaseId?: pulumi.Input<string>;
    /**
     * Specifies the ID of the elastic pool containing this database. Changing this forces a new resource to be created.
     */
    readonly elasticPoolId?: pulumi.Input<string>;
    /**
     * A `extendedAuditingPolicy` block as defined below.
     */
    readonly extendedAuditingPolicy?: pulumi.Input<inputs.mssql.DatabaseExtendedAuditingPolicy>;
    /**
     * Specifies the license type applied to this database. Possible values are `LicenseIncluded` and `BasePrice`.
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * The max size of the database in gigabytes. 
     */
    readonly maxSizeGb?: pulumi.Input<number>;
    /**
     * Minimal capacity that database will always have allocated, if not paused. This property is only settable for General Purpose Serverless databases.
     */
    readonly minCapacity?: pulumi.Input<number>;
    /**
     * The name of the Ms SQL Database. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The number of readonly secondary replicas associated with the database to which readonly application intent connections may be routed. This property is only settable for Hyperscale edition databases.
     */
    readonly readReplicaCount?: pulumi.Input<number>;
    /**
     * If enabled, connections that have application intent set to readonly in their connection string may be routed to a readonly secondary replica. This property is only settable for Premium and Business Critical databases.
     */
    readonly readScale?: pulumi.Input<boolean>;
    /**
     * Specifies the point in time (ISO8601 format) of the source database that will be restored to create the new database. This property is only settable for `createMode`= `PointInTimeRestore`  databases.
     */
    readonly restorePointInTime?: pulumi.Input<string>;
    /**
     * Specifies the name of the sample schema to apply when creating this database. Possible value is `AdventureWorksLT`.
     */
    readonly sampleName?: pulumi.Input<string>;
    /**
     * The id of the Ms SQL Server on which to create the database. Changing this forces a new resource to be created.
     */
    readonly serverId: pulumi.Input<string>;
    /**
     * Specifies the name of the sku used by the database. Changing this forces a new resource to be created. For example, `GP_S_Gen5_2`,`HS_Gen4_1`,`BC_Gen5_2`, `ElasticPool`, `Basic`,`S0`, `P2` ,`DW100c`, `DS100`.
     */
    readonly skuName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Threat detection policy configuration. The `threatDetectionPolicy` block supports fields documented below.
     */
    readonly threatDetectionPolicy?: pulumi.Input<inputs.mssql.DatabaseThreatDetectionPolicy>;
    /**
     * Whether or not this database is zone redundant, which means the replicas of this database will be spread across multiple availability zones. This property is only settable for Premium and Business Critical databases.
     */
    readonly zoneRedundant?: pulumi.Input<boolean>;
}