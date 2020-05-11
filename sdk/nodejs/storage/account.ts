// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an Azure Storage Account.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West Europe"});
 * const exampleAccount = new azure.storage.Account("exampleAccount", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     accountTier: "Standard",
 *     accountReplicationType: "GRS",
 *     tags: {
 *         environment: "staging",
 *     },
 * });
 * ```
 * 
 * ## Example Usage with Network Rules
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West Europe"});
 * const exampleVirtualNetwork = new azure.network.VirtualNetwork("exampleVirtualNetwork", {
 *     addressSpaces: ["10.0.0.0/16"],
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 * });
 * const exampleSubnet = new azure.network.Subnet("exampleSubnet", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     virtualNetworkName: exampleVirtualNetwork.name,
 *     addressPrefix: "10.0.2.0/24",
 *     serviceEndpoints: [
 *         "Microsoft.Sql",
 *         "Microsoft.Storage",
 *     ],
 * });
 * const exampleAccount = new azure.storage.Account("exampleAccount", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     accountTier: "Standard",
 *     accountReplicationType: "LRS",
 *     network_rules: {
 *         defaultAction: "Deny",
 *         ipRules: ["100.0.0.1"],
 *         virtualNetworkSubnetIds: [exampleSubnet.id],
 *     },
 *     tags: {
 *         environment: "staging",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/storage_account.html.markdown.
 */
export class Account extends pulumi.CustomResource {
    /**
     * Get an existing Account resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AccountState, opts?: pulumi.CustomResourceOptions): Account {
        return new Account(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:storage/account:Account';

    /**
     * Returns true if the given object is an instance of Account.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Account {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Account.__pulumiType;
    }

    /**
     * Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts. Valid options are `Hot` and `Cool`, defaults to `Hot`.
     */
    public readonly accessTier!: pulumi.Output<string>;
    /**
     * Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`. Changing this forces a new resource to be created. Defaults to `StorageV2`.
     */
    public readonly accountKind!: pulumi.Output<string | undefined>;
    /**
     * Defines the type of replication to use for this storage account. Valid options are `LRS`, `GRS`, `RAGRS` and `ZRS`.
     */
    public readonly accountReplicationType!: pulumi.Output<string>;
    /**
     * Defines the Tier to use for this storage account. Valid options are `Standard` and `Premium`. For `FileStorage` accounts only `Premium` is valid. Changing this forces a new resource to be created.
     */
    public readonly accountTier!: pulumi.Output<string>;
    /**
     * A `blobProperties` block as defined below.
     */
    public readonly blobProperties!: pulumi.Output<outputs.storage.AccountBlobProperties>;
    /**
     * A `customDomain` block as documented below.
     */
    public readonly customDomain!: pulumi.Output<outputs.storage.AccountCustomDomain | undefined>;
    /**
     * Boolean flag which forces HTTPS if enabled, see [here](https://docs.microsoft.com/en-us/azure/storage/storage-require-secure-transfer/)
     * for more information. Defaults to `true`.
     */
    public readonly enableHttpsTrafficOnly!: pulumi.Output<boolean | undefined>;
    /**
     * A `identity` block as defined below.
     */
    public readonly identity!: pulumi.Output<outputs.storage.AccountIdentity>;
    /**
     * Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 ([see here for more information](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-quickstart-create-account/)). Changing this forces a new resource to be created.
     */
    public readonly isHnsEnabled!: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the storage account. Changing this forces a new resource to be created. This must be unique across the entire Azure service, not just within the resource group.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A `networkRules` block as documented below.
     */
    public readonly networkRules!: pulumi.Output<outputs.storage.AccountNetworkRules>;
    /**
     * The primary access key for the storage account.
     */
    public /*out*/ readonly primaryAccessKey!: pulumi.Output<string>;
    /**
     * The connection string associated with the primary blob location.
     */
    public /*out*/ readonly primaryBlobConnectionString!: pulumi.Output<string>;
    /**
     * The endpoint URL for blob storage in the primary location.
     */
    public /*out*/ readonly primaryBlobEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for blob storage in the primary location.
     */
    public /*out*/ readonly primaryBlobHost!: pulumi.Output<string>;
    /**
     * The connection string associated with the primary location.
     */
    public /*out*/ readonly primaryConnectionString!: pulumi.Output<string>;
    /**
     * The endpoint URL for DFS storage in the primary location.
     */
    public /*out*/ readonly primaryDfsEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for DFS storage in the primary location.
     */
    public /*out*/ readonly primaryDfsHost!: pulumi.Output<string>;
    /**
     * The endpoint URL for file storage in the primary location.
     */
    public /*out*/ readonly primaryFileEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for file storage in the primary location.
     */
    public /*out*/ readonly primaryFileHost!: pulumi.Output<string>;
    /**
     * The primary location of the storage account.
     */
    public /*out*/ readonly primaryLocation!: pulumi.Output<string>;
    /**
     * The endpoint URL for queue storage in the primary location.
     */
    public /*out*/ readonly primaryQueueEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for queue storage in the primary location.
     */
    public /*out*/ readonly primaryQueueHost!: pulumi.Output<string>;
    /**
     * The endpoint URL for table storage in the primary location.
     */
    public /*out*/ readonly primaryTableEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for table storage in the primary location.
     */
    public /*out*/ readonly primaryTableHost!: pulumi.Output<string>;
    /**
     * The endpoint URL for web storage in the primary location.
     */
    public /*out*/ readonly primaryWebEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for web storage in the primary location.
     */
    public /*out*/ readonly primaryWebHost!: pulumi.Output<string>;
    /**
     * A `queueProperties` block as defined below.
     */
    public readonly queueProperties!: pulumi.Output<outputs.storage.AccountQueueProperties>;
    /**
     * The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The secondary access key for the storage account.
     */
    public /*out*/ readonly secondaryAccessKey!: pulumi.Output<string>;
    /**
     * The connection string associated with the secondary blob location.
     */
    public /*out*/ readonly secondaryBlobConnectionString!: pulumi.Output<string>;
    /**
     * The endpoint URL for blob storage in the secondary location.
     */
    public /*out*/ readonly secondaryBlobEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for blob storage in the secondary location.
     */
    public /*out*/ readonly secondaryBlobHost!: pulumi.Output<string>;
    /**
     * The connection string associated with the secondary location.
     */
    public /*out*/ readonly secondaryConnectionString!: pulumi.Output<string>;
    /**
     * The endpoint URL for DFS storage in the secondary location.
     */
    public /*out*/ readonly secondaryDfsEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for DFS storage in the secondary location.
     */
    public /*out*/ readonly secondaryDfsHost!: pulumi.Output<string>;
    /**
     * The endpoint URL for file storage in the secondary location.
     */
    public /*out*/ readonly secondaryFileEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for file storage in the secondary location.
     */
    public /*out*/ readonly secondaryFileHost!: pulumi.Output<string>;
    /**
     * The secondary location of the storage account.
     */
    public /*out*/ readonly secondaryLocation!: pulumi.Output<string>;
    /**
     * The endpoint URL for queue storage in the secondary location.
     */
    public /*out*/ readonly secondaryQueueEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for queue storage in the secondary location.
     */
    public /*out*/ readonly secondaryQueueHost!: pulumi.Output<string>;
    /**
     * The endpoint URL for table storage in the secondary location.
     */
    public /*out*/ readonly secondaryTableEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for table storage in the secondary location.
     */
    public /*out*/ readonly secondaryTableHost!: pulumi.Output<string>;
    /**
     * The endpoint URL for web storage in the secondary location.
     */
    public /*out*/ readonly secondaryWebEndpoint!: pulumi.Output<string>;
    /**
     * The hostname with port if applicable for web storage in the secondary location.
     */
    public /*out*/ readonly secondaryWebHost!: pulumi.Output<string>;
    /**
     * A `staticWebsite` block as defined below.
     */
    public readonly staticWebsite!: pulumi.Output<outputs.storage.AccountStaticWebsite | undefined>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;

    /**
     * Create a Account resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AccountArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AccountArgs | AccountState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AccountState | undefined;
            inputs["accessTier"] = state ? state.accessTier : undefined;
            inputs["accountKind"] = state ? state.accountKind : undefined;
            inputs["accountReplicationType"] = state ? state.accountReplicationType : undefined;
            inputs["accountTier"] = state ? state.accountTier : undefined;
            inputs["blobProperties"] = state ? state.blobProperties : undefined;
            inputs["customDomain"] = state ? state.customDomain : undefined;
            inputs["enableHttpsTrafficOnly"] = state ? state.enableHttpsTrafficOnly : undefined;
            inputs["identity"] = state ? state.identity : undefined;
            inputs["isHnsEnabled"] = state ? state.isHnsEnabled : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkRules"] = state ? state.networkRules : undefined;
            inputs["primaryAccessKey"] = state ? state.primaryAccessKey : undefined;
            inputs["primaryBlobConnectionString"] = state ? state.primaryBlobConnectionString : undefined;
            inputs["primaryBlobEndpoint"] = state ? state.primaryBlobEndpoint : undefined;
            inputs["primaryBlobHost"] = state ? state.primaryBlobHost : undefined;
            inputs["primaryConnectionString"] = state ? state.primaryConnectionString : undefined;
            inputs["primaryDfsEndpoint"] = state ? state.primaryDfsEndpoint : undefined;
            inputs["primaryDfsHost"] = state ? state.primaryDfsHost : undefined;
            inputs["primaryFileEndpoint"] = state ? state.primaryFileEndpoint : undefined;
            inputs["primaryFileHost"] = state ? state.primaryFileHost : undefined;
            inputs["primaryLocation"] = state ? state.primaryLocation : undefined;
            inputs["primaryQueueEndpoint"] = state ? state.primaryQueueEndpoint : undefined;
            inputs["primaryQueueHost"] = state ? state.primaryQueueHost : undefined;
            inputs["primaryTableEndpoint"] = state ? state.primaryTableEndpoint : undefined;
            inputs["primaryTableHost"] = state ? state.primaryTableHost : undefined;
            inputs["primaryWebEndpoint"] = state ? state.primaryWebEndpoint : undefined;
            inputs["primaryWebHost"] = state ? state.primaryWebHost : undefined;
            inputs["queueProperties"] = state ? state.queueProperties : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["secondaryAccessKey"] = state ? state.secondaryAccessKey : undefined;
            inputs["secondaryBlobConnectionString"] = state ? state.secondaryBlobConnectionString : undefined;
            inputs["secondaryBlobEndpoint"] = state ? state.secondaryBlobEndpoint : undefined;
            inputs["secondaryBlobHost"] = state ? state.secondaryBlobHost : undefined;
            inputs["secondaryConnectionString"] = state ? state.secondaryConnectionString : undefined;
            inputs["secondaryDfsEndpoint"] = state ? state.secondaryDfsEndpoint : undefined;
            inputs["secondaryDfsHost"] = state ? state.secondaryDfsHost : undefined;
            inputs["secondaryFileEndpoint"] = state ? state.secondaryFileEndpoint : undefined;
            inputs["secondaryFileHost"] = state ? state.secondaryFileHost : undefined;
            inputs["secondaryLocation"] = state ? state.secondaryLocation : undefined;
            inputs["secondaryQueueEndpoint"] = state ? state.secondaryQueueEndpoint : undefined;
            inputs["secondaryQueueHost"] = state ? state.secondaryQueueHost : undefined;
            inputs["secondaryTableEndpoint"] = state ? state.secondaryTableEndpoint : undefined;
            inputs["secondaryTableHost"] = state ? state.secondaryTableHost : undefined;
            inputs["secondaryWebEndpoint"] = state ? state.secondaryWebEndpoint : undefined;
            inputs["secondaryWebHost"] = state ? state.secondaryWebHost : undefined;
            inputs["staticWebsite"] = state ? state.staticWebsite : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as AccountArgs | undefined;
            if (!args || args.accountReplicationType === undefined) {
                throw new Error("Missing required property 'accountReplicationType'");
            }
            if (!args || args.accountTier === undefined) {
                throw new Error("Missing required property 'accountTier'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["accessTier"] = args ? args.accessTier : undefined;
            inputs["accountKind"] = args ? args.accountKind : undefined;
            inputs["accountReplicationType"] = args ? args.accountReplicationType : undefined;
            inputs["accountTier"] = args ? args.accountTier : undefined;
            inputs["blobProperties"] = args ? args.blobProperties : undefined;
            inputs["customDomain"] = args ? args.customDomain : undefined;
            inputs["enableHttpsTrafficOnly"] = args ? args.enableHttpsTrafficOnly : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["isHnsEnabled"] = args ? args.isHnsEnabled : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkRules"] = args ? args.networkRules : undefined;
            inputs["queueProperties"] = args ? args.queueProperties : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["staticWebsite"] = args ? args.staticWebsite : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["primaryAccessKey"] = undefined /*out*/;
            inputs["primaryBlobConnectionString"] = undefined /*out*/;
            inputs["primaryBlobEndpoint"] = undefined /*out*/;
            inputs["primaryBlobHost"] = undefined /*out*/;
            inputs["primaryConnectionString"] = undefined /*out*/;
            inputs["primaryDfsEndpoint"] = undefined /*out*/;
            inputs["primaryDfsHost"] = undefined /*out*/;
            inputs["primaryFileEndpoint"] = undefined /*out*/;
            inputs["primaryFileHost"] = undefined /*out*/;
            inputs["primaryLocation"] = undefined /*out*/;
            inputs["primaryQueueEndpoint"] = undefined /*out*/;
            inputs["primaryQueueHost"] = undefined /*out*/;
            inputs["primaryTableEndpoint"] = undefined /*out*/;
            inputs["primaryTableHost"] = undefined /*out*/;
            inputs["primaryWebEndpoint"] = undefined /*out*/;
            inputs["primaryWebHost"] = undefined /*out*/;
            inputs["secondaryAccessKey"] = undefined /*out*/;
            inputs["secondaryBlobConnectionString"] = undefined /*out*/;
            inputs["secondaryBlobEndpoint"] = undefined /*out*/;
            inputs["secondaryBlobHost"] = undefined /*out*/;
            inputs["secondaryConnectionString"] = undefined /*out*/;
            inputs["secondaryDfsEndpoint"] = undefined /*out*/;
            inputs["secondaryDfsHost"] = undefined /*out*/;
            inputs["secondaryFileEndpoint"] = undefined /*out*/;
            inputs["secondaryFileHost"] = undefined /*out*/;
            inputs["secondaryLocation"] = undefined /*out*/;
            inputs["secondaryQueueEndpoint"] = undefined /*out*/;
            inputs["secondaryQueueHost"] = undefined /*out*/;
            inputs["secondaryTableEndpoint"] = undefined /*out*/;
            inputs["secondaryTableHost"] = undefined /*out*/;
            inputs["secondaryWebEndpoint"] = undefined /*out*/;
            inputs["secondaryWebHost"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Account.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Account resources.
 */
export interface AccountState {
    /**
     * Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts. Valid options are `Hot` and `Cool`, defaults to `Hot`.
     */
    readonly accessTier?: pulumi.Input<string>;
    /**
     * Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`. Changing this forces a new resource to be created. Defaults to `StorageV2`.
     */
    readonly accountKind?: pulumi.Input<string>;
    /**
     * Defines the type of replication to use for this storage account. Valid options are `LRS`, `GRS`, `RAGRS` and `ZRS`.
     */
    readonly accountReplicationType?: pulumi.Input<string>;
    /**
     * Defines the Tier to use for this storage account. Valid options are `Standard` and `Premium`. For `FileStorage` accounts only `Premium` is valid. Changing this forces a new resource to be created.
     */
    readonly accountTier?: pulumi.Input<string>;
    /**
     * A `blobProperties` block as defined below.
     */
    readonly blobProperties?: pulumi.Input<inputs.storage.AccountBlobProperties>;
    /**
     * A `customDomain` block as documented below.
     */
    readonly customDomain?: pulumi.Input<inputs.storage.AccountCustomDomain>;
    /**
     * Boolean flag which forces HTTPS if enabled, see [here](https://docs.microsoft.com/en-us/azure/storage/storage-require-secure-transfer/)
     * for more information. Defaults to `true`.
     */
    readonly enableHttpsTrafficOnly?: pulumi.Input<boolean>;
    /**
     * A `identity` block as defined below.
     */
    readonly identity?: pulumi.Input<inputs.storage.AccountIdentity>;
    /**
     * Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 ([see here for more information](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-quickstart-create-account/)). Changing this forces a new resource to be created.
     */
    readonly isHnsEnabled?: pulumi.Input<boolean>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the storage account. Changing this forces a new resource to be created. This must be unique across the entire Azure service, not just within the resource group.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `networkRules` block as documented below.
     */
    readonly networkRules?: pulumi.Input<inputs.storage.AccountNetworkRules>;
    /**
     * The primary access key for the storage account.
     */
    readonly primaryAccessKey?: pulumi.Input<string>;
    /**
     * The connection string associated with the primary blob location.
     */
    readonly primaryBlobConnectionString?: pulumi.Input<string>;
    /**
     * The endpoint URL for blob storage in the primary location.
     */
    readonly primaryBlobEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for blob storage in the primary location.
     */
    readonly primaryBlobHost?: pulumi.Input<string>;
    /**
     * The connection string associated with the primary location.
     */
    readonly primaryConnectionString?: pulumi.Input<string>;
    /**
     * The endpoint URL for DFS storage in the primary location.
     */
    readonly primaryDfsEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for DFS storage in the primary location.
     */
    readonly primaryDfsHost?: pulumi.Input<string>;
    /**
     * The endpoint URL for file storage in the primary location.
     */
    readonly primaryFileEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for file storage in the primary location.
     */
    readonly primaryFileHost?: pulumi.Input<string>;
    /**
     * The primary location of the storage account.
     */
    readonly primaryLocation?: pulumi.Input<string>;
    /**
     * The endpoint URL for queue storage in the primary location.
     */
    readonly primaryQueueEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for queue storage in the primary location.
     */
    readonly primaryQueueHost?: pulumi.Input<string>;
    /**
     * The endpoint URL for table storage in the primary location.
     */
    readonly primaryTableEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for table storage in the primary location.
     */
    readonly primaryTableHost?: pulumi.Input<string>;
    /**
     * The endpoint URL for web storage in the primary location.
     */
    readonly primaryWebEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for web storage in the primary location.
     */
    readonly primaryWebHost?: pulumi.Input<string>;
    /**
     * A `queueProperties` block as defined below.
     */
    readonly queueProperties?: pulumi.Input<inputs.storage.AccountQueueProperties>;
    /**
     * The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The secondary access key for the storage account.
     */
    readonly secondaryAccessKey?: pulumi.Input<string>;
    /**
     * The connection string associated with the secondary blob location.
     */
    readonly secondaryBlobConnectionString?: pulumi.Input<string>;
    /**
     * The endpoint URL for blob storage in the secondary location.
     */
    readonly secondaryBlobEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for blob storage in the secondary location.
     */
    readonly secondaryBlobHost?: pulumi.Input<string>;
    /**
     * The connection string associated with the secondary location.
     */
    readonly secondaryConnectionString?: pulumi.Input<string>;
    /**
     * The endpoint URL for DFS storage in the secondary location.
     */
    readonly secondaryDfsEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for DFS storage in the secondary location.
     */
    readonly secondaryDfsHost?: pulumi.Input<string>;
    /**
     * The endpoint URL for file storage in the secondary location.
     */
    readonly secondaryFileEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for file storage in the secondary location.
     */
    readonly secondaryFileHost?: pulumi.Input<string>;
    /**
     * The secondary location of the storage account.
     */
    readonly secondaryLocation?: pulumi.Input<string>;
    /**
     * The endpoint URL for queue storage in the secondary location.
     */
    readonly secondaryQueueEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for queue storage in the secondary location.
     */
    readonly secondaryQueueHost?: pulumi.Input<string>;
    /**
     * The endpoint URL for table storage in the secondary location.
     */
    readonly secondaryTableEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for table storage in the secondary location.
     */
    readonly secondaryTableHost?: pulumi.Input<string>;
    /**
     * The endpoint URL for web storage in the secondary location.
     */
    readonly secondaryWebEndpoint?: pulumi.Input<string>;
    /**
     * The hostname with port if applicable for web storage in the secondary location.
     */
    readonly secondaryWebHost?: pulumi.Input<string>;
    /**
     * A `staticWebsite` block as defined below.
     */
    readonly staticWebsite?: pulumi.Input<inputs.storage.AccountStaticWebsite>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a Account resource.
 */
export interface AccountArgs {
    /**
     * Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts. Valid options are `Hot` and `Cool`, defaults to `Hot`.
     */
    readonly accessTier?: pulumi.Input<string>;
    /**
     * Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`. Changing this forces a new resource to be created. Defaults to `StorageV2`.
     */
    readonly accountKind?: pulumi.Input<string>;
    /**
     * Defines the type of replication to use for this storage account. Valid options are `LRS`, `GRS`, `RAGRS` and `ZRS`.
     */
    readonly accountReplicationType: pulumi.Input<string>;
    /**
     * Defines the Tier to use for this storage account. Valid options are `Standard` and `Premium`. For `FileStorage` accounts only `Premium` is valid. Changing this forces a new resource to be created.
     */
    readonly accountTier: pulumi.Input<string>;
    /**
     * A `blobProperties` block as defined below.
     */
    readonly blobProperties?: pulumi.Input<inputs.storage.AccountBlobProperties>;
    /**
     * A `customDomain` block as documented below.
     */
    readonly customDomain?: pulumi.Input<inputs.storage.AccountCustomDomain>;
    /**
     * Boolean flag which forces HTTPS if enabled, see [here](https://docs.microsoft.com/en-us/azure/storage/storage-require-secure-transfer/)
     * for more information. Defaults to `true`.
     */
    readonly enableHttpsTrafficOnly?: pulumi.Input<boolean>;
    /**
     * A `identity` block as defined below.
     */
    readonly identity?: pulumi.Input<inputs.storage.AccountIdentity>;
    /**
     * Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 ([see here for more information](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-quickstart-create-account/)). Changing this forces a new resource to be created.
     */
    readonly isHnsEnabled?: pulumi.Input<boolean>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the storage account. Changing this forces a new resource to be created. This must be unique across the entire Azure service, not just within the resource group.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `networkRules` block as documented below.
     */
    readonly networkRules?: pulumi.Input<inputs.storage.AccountNetworkRules>;
    /**
     * A `queueProperties` block as defined below.
     */
    readonly queueProperties?: pulumi.Input<inputs.storage.AccountQueueProperties>;
    /**
     * The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `staticWebsite` block as defined below.
     */
    readonly staticWebsite?: pulumi.Input<inputs.storage.AccountStaticWebsite>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
