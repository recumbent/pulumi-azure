// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Storage
{
    /// <summary>
    /// Manages an Azure Storage Account.
    /// 
    /// ## Example Usage
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West Europe",
    ///         });
    ///         var exampleAccount = new Azure.Storage.Account("exampleAccount", new Azure.Storage.AccountArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Location = exampleResourceGroup.Location,
    ///             AccountTier = "Standard",
    ///             AccountReplicationType = "GRS",
    ///             Tags = 
    ///             {
    ///                 { "environment", "staging" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// ### With Network Rules
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West Europe",
    ///         });
    ///         var exampleVirtualNetwork = new Azure.Network.VirtualNetwork("exampleVirtualNetwork", new Azure.Network.VirtualNetworkArgs
    ///         {
    ///             AddressSpaces = 
    ///             {
    ///                 "10.0.0.0/16",
    ///             },
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///         });
    ///         var exampleSubnet = new Azure.Network.Subnet("exampleSubnet", new Azure.Network.SubnetArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             VirtualNetworkName = exampleVirtualNetwork.Name,
    ///             AddressPrefix = "10.0.2.0/24",
    ///             ServiceEndpoints = 
    ///             {
    ///                 "Microsoft.Sql",
    ///                 "Microsoft.Storage",
    ///             },
    ///         });
    ///         var exampleAccount = new Azure.Storage.Account("exampleAccount", new Azure.Storage.AccountArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             Location = exampleResourceGroup.Location,
    ///             AccountTier = "Standard",
    ///             AccountReplicationType = "LRS",
    ///             NetworkRules = new Azure.Storage.Inputs.AccountNetworkRulesArgs
    ///             {
    ///                 DefaultAction = "Deny",
    ///                 IpRules = 
    ///                 {
    ///                     "100.0.0.1",
    ///                 },
    ///                 VirtualNetworkSubnetIds = 
    ///                 {
    ///                     exampleSubnet.Id,
    ///                 },
    ///             },
    ///             Tags = 
    ///             {
    ///                 { "environment", "staging" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class Account : Pulumi.CustomResource
    {
        /// <summary>
        /// Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts. Valid options are `Hot` and `Cool`, defaults to `Hot`.
        /// </summary>
        [Output("accessTier")]
        public Output<string> AccessTier { get; private set; } = null!;

        /// <summary>
        /// Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`. Changing this forces a new resource to be created. Defaults to `StorageV2`.
        /// </summary>
        [Output("accountKind")]
        public Output<string?> AccountKind { get; private set; } = null!;

        /// <summary>
        /// Defines the type of replication to use for this storage account. Valid options are `LRS`, `GRS`, `RAGRS`, `ZRS`, `GZRS` and `RAGZRS`.
        /// </summary>
        [Output("accountReplicationType")]
        public Output<string> AccountReplicationType { get; private set; } = null!;

        /// <summary>
        /// Defines the Tier to use for this storage account. Valid options are `Standard` and `Premium`. For `BlockBlobStorage` and `FileStorage` accounts only `Premium` is valid. Changing this forces a new resource to be created.
        /// </summary>
        [Output("accountTier")]
        public Output<string> AccountTier { get; private set; } = null!;

        /// <summary>
        /// Allow or disallow public access to all blobs or containers in the storage account. Defaults to `false`.
        /// </summary>
        [Output("allowBlobPublicAccess")]
        public Output<bool?> AllowBlobPublicAccess { get; private set; } = null!;

        /// <summary>
        /// A `blob_properties` block as defined below.
        /// </summary>
        [Output("blobProperties")]
        public Output<Outputs.AccountBlobProperties> BlobProperties { get; private set; } = null!;

        /// <summary>
        /// A `custom_domain` block as documented below.
        /// </summary>
        [Output("customDomain")]
        public Output<Outputs.AccountCustomDomain?> CustomDomain { get; private set; } = null!;

        /// <summary>
        /// Boolean flag which forces HTTPS if enabled, see [here](https://docs.microsoft.com/en-us/azure/storage/storage-require-secure-transfer/)
        /// for more information. Defaults to `true`.
        /// </summary>
        [Output("enableHttpsTrafficOnly")]
        public Output<bool?> EnableHttpsTrafficOnly { get; private set; } = null!;

        /// <summary>
        /// A `identity` block as defined below.
        /// </summary>
        [Output("identity")]
        public Output<Outputs.AccountIdentity> Identity { get; private set; } = null!;

        /// <summary>
        /// Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 ([see here for more information](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-quickstart-create-account/)). Changing this forces a new resource to be created.
        /// </summary>
        [Output("isHnsEnabled")]
        public Output<bool?> IsHnsEnabled { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the storage account. Changing this forces a new resource to be created. This must be unique across the entire Azure service, not just within the resource group.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// A `network_rules` block as documented below.
        /// </summary>
        [Output("networkRules")]
        public Output<Outputs.AccountNetworkRules> NetworkRules { get; private set; } = null!;

        /// <summary>
        /// The primary access key for the storage account.
        /// </summary>
        [Output("primaryAccessKey")]
        public Output<string> PrimaryAccessKey { get; private set; } = null!;

        /// <summary>
        /// The connection string associated with the primary blob location.
        /// </summary>
        [Output("primaryBlobConnectionString")]
        public Output<string> PrimaryBlobConnectionString { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for blob storage in the primary location.
        /// </summary>
        [Output("primaryBlobEndpoint")]
        public Output<string> PrimaryBlobEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for blob storage in the primary location.
        /// </summary>
        [Output("primaryBlobHost")]
        public Output<string> PrimaryBlobHost { get; private set; } = null!;

        /// <summary>
        /// The connection string associated with the primary location.
        /// </summary>
        [Output("primaryConnectionString")]
        public Output<string> PrimaryConnectionString { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for DFS storage in the primary location.
        /// </summary>
        [Output("primaryDfsEndpoint")]
        public Output<string> PrimaryDfsEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for DFS storage in the primary location.
        /// </summary>
        [Output("primaryDfsHost")]
        public Output<string> PrimaryDfsHost { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for file storage in the primary location.
        /// </summary>
        [Output("primaryFileEndpoint")]
        public Output<string> PrimaryFileEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for file storage in the primary location.
        /// </summary>
        [Output("primaryFileHost")]
        public Output<string> PrimaryFileHost { get; private set; } = null!;

        /// <summary>
        /// The primary location of the storage account.
        /// </summary>
        [Output("primaryLocation")]
        public Output<string> PrimaryLocation { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for queue storage in the primary location.
        /// </summary>
        [Output("primaryQueueEndpoint")]
        public Output<string> PrimaryQueueEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for queue storage in the primary location.
        /// </summary>
        [Output("primaryQueueHost")]
        public Output<string> PrimaryQueueHost { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for table storage in the primary location.
        /// </summary>
        [Output("primaryTableEndpoint")]
        public Output<string> PrimaryTableEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for table storage in the primary location.
        /// </summary>
        [Output("primaryTableHost")]
        public Output<string> PrimaryTableHost { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for web storage in the primary location.
        /// </summary>
        [Output("primaryWebEndpoint")]
        public Output<string> PrimaryWebEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for web storage in the primary location.
        /// </summary>
        [Output("primaryWebHost")]
        public Output<string> PrimaryWebHost { get; private set; } = null!;

        /// <summary>
        /// A `queue_properties` block as defined below.
        /// </summary>
        [Output("queueProperties")]
        public Output<Outputs.AccountQueueProperties> QueueProperties { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The secondary access key for the storage account.
        /// </summary>
        [Output("secondaryAccessKey")]
        public Output<string> SecondaryAccessKey { get; private set; } = null!;

        /// <summary>
        /// The connection string associated with the secondary blob location.
        /// </summary>
        [Output("secondaryBlobConnectionString")]
        public Output<string> SecondaryBlobConnectionString { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for blob storage in the secondary location.
        /// </summary>
        [Output("secondaryBlobEndpoint")]
        public Output<string> SecondaryBlobEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for blob storage in the secondary location.
        /// </summary>
        [Output("secondaryBlobHost")]
        public Output<string> SecondaryBlobHost { get; private set; } = null!;

        /// <summary>
        /// The connection string associated with the secondary location.
        /// </summary>
        [Output("secondaryConnectionString")]
        public Output<string> SecondaryConnectionString { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for DFS storage in the secondary location.
        /// </summary>
        [Output("secondaryDfsEndpoint")]
        public Output<string> SecondaryDfsEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for DFS storage in the secondary location.
        /// </summary>
        [Output("secondaryDfsHost")]
        public Output<string> SecondaryDfsHost { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for file storage in the secondary location.
        /// </summary>
        [Output("secondaryFileEndpoint")]
        public Output<string> SecondaryFileEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for file storage in the secondary location.
        /// </summary>
        [Output("secondaryFileHost")]
        public Output<string> SecondaryFileHost { get; private set; } = null!;

        /// <summary>
        /// The secondary location of the storage account.
        /// </summary>
        [Output("secondaryLocation")]
        public Output<string> SecondaryLocation { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for queue storage in the secondary location.
        /// </summary>
        [Output("secondaryQueueEndpoint")]
        public Output<string> SecondaryQueueEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for queue storage in the secondary location.
        /// </summary>
        [Output("secondaryQueueHost")]
        public Output<string> SecondaryQueueHost { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for table storage in the secondary location.
        /// </summary>
        [Output("secondaryTableEndpoint")]
        public Output<string> SecondaryTableEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for table storage in the secondary location.
        /// </summary>
        [Output("secondaryTableHost")]
        public Output<string> SecondaryTableHost { get; private set; } = null!;

        /// <summary>
        /// The endpoint URL for web storage in the secondary location.
        /// </summary>
        [Output("secondaryWebEndpoint")]
        public Output<string> SecondaryWebEndpoint { get; private set; } = null!;

        /// <summary>
        /// The hostname with port if applicable for web storage in the secondary location.
        /// </summary>
        [Output("secondaryWebHost")]
        public Output<string> SecondaryWebHost { get; private set; } = null!;

        /// <summary>
        /// A `static_website` block as defined below.
        /// </summary>
        [Output("staticWebsite")]
        public Output<Outputs.AccountStaticWebsite?> StaticWebsite { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a Account resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Account(string name, AccountArgs args, CustomResourceOptions? options = null)
            : base("azure:storage/account:Account", name, args ?? new AccountArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Account(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
            : base("azure:storage/account:Account", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Account resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Account Get(string name, Input<string> id, AccountState? state = null, CustomResourceOptions? options = null)
        {
            return new Account(name, id, state, options);
        }
    }

    public sealed class AccountArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts. Valid options are `Hot` and `Cool`, defaults to `Hot`.
        /// </summary>
        [Input("accessTier")]
        public Input<string>? AccessTier { get; set; }

        /// <summary>
        /// Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`. Changing this forces a new resource to be created. Defaults to `StorageV2`.
        /// </summary>
        [Input("accountKind")]
        public Input<string>? AccountKind { get; set; }

        /// <summary>
        /// Defines the type of replication to use for this storage account. Valid options are `LRS`, `GRS`, `RAGRS`, `ZRS`, `GZRS` and `RAGZRS`.
        /// </summary>
        [Input("accountReplicationType", required: true)]
        public Input<string> AccountReplicationType { get; set; } = null!;

        /// <summary>
        /// Defines the Tier to use for this storage account. Valid options are `Standard` and `Premium`. For `BlockBlobStorage` and `FileStorage` accounts only `Premium` is valid. Changing this forces a new resource to be created.
        /// </summary>
        [Input("accountTier", required: true)]
        public Input<string> AccountTier { get; set; } = null!;

        /// <summary>
        /// Allow or disallow public access to all blobs or containers in the storage account. Defaults to `false`.
        /// </summary>
        [Input("allowBlobPublicAccess")]
        public Input<bool>? AllowBlobPublicAccess { get; set; }

        /// <summary>
        /// A `blob_properties` block as defined below.
        /// </summary>
        [Input("blobProperties")]
        public Input<Inputs.AccountBlobPropertiesArgs>? BlobProperties { get; set; }

        /// <summary>
        /// A `custom_domain` block as documented below.
        /// </summary>
        [Input("customDomain")]
        public Input<Inputs.AccountCustomDomainArgs>? CustomDomain { get; set; }

        /// <summary>
        /// Boolean flag which forces HTTPS if enabled, see [here](https://docs.microsoft.com/en-us/azure/storage/storage-require-secure-transfer/)
        /// for more information. Defaults to `true`.
        /// </summary>
        [Input("enableHttpsTrafficOnly")]
        public Input<bool>? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// A `identity` block as defined below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.AccountIdentityArgs>? Identity { get; set; }

        /// <summary>
        /// Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 ([see here for more information](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-quickstart-create-account/)). Changing this forces a new resource to be created.
        /// </summary>
        [Input("isHnsEnabled")]
        public Input<bool>? IsHnsEnabled { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the storage account. Changing this forces a new resource to be created. This must be unique across the entire Azure service, not just within the resource group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `network_rules` block as documented below.
        /// </summary>
        [Input("networkRules")]
        public Input<Inputs.AccountNetworkRulesArgs>? NetworkRules { get; set; }

        /// <summary>
        /// A `queue_properties` block as defined below.
        /// </summary>
        [Input("queueProperties")]
        public Input<Inputs.AccountQueuePropertiesArgs>? QueueProperties { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// A `static_website` block as defined below.
        /// </summary>
        [Input("staticWebsite")]
        public Input<Inputs.AccountStaticWebsiteArgs>? StaticWebsite { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public AccountArgs()
        {
        }
    }

    public sealed class AccountState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Defines the access tier for `BlobStorage`, `FileStorage` and `StorageV2` accounts. Valid options are `Hot` and `Cool`, defaults to `Hot`.
        /// </summary>
        [Input("accessTier")]
        public Input<string>? AccessTier { get; set; }

        /// <summary>
        /// Defines the Kind of account. Valid options are `BlobStorage`, `BlockBlobStorage`, `FileStorage`, `Storage` and `StorageV2`. Changing this forces a new resource to be created. Defaults to `StorageV2`.
        /// </summary>
        [Input("accountKind")]
        public Input<string>? AccountKind { get; set; }

        /// <summary>
        /// Defines the type of replication to use for this storage account. Valid options are `LRS`, `GRS`, `RAGRS`, `ZRS`, `GZRS` and `RAGZRS`.
        /// </summary>
        [Input("accountReplicationType")]
        public Input<string>? AccountReplicationType { get; set; }

        /// <summary>
        /// Defines the Tier to use for this storage account. Valid options are `Standard` and `Premium`. For `BlockBlobStorage` and `FileStorage` accounts only `Premium` is valid. Changing this forces a new resource to be created.
        /// </summary>
        [Input("accountTier")]
        public Input<string>? AccountTier { get; set; }

        /// <summary>
        /// Allow or disallow public access to all blobs or containers in the storage account. Defaults to `false`.
        /// </summary>
        [Input("allowBlobPublicAccess")]
        public Input<bool>? AllowBlobPublicAccess { get; set; }

        /// <summary>
        /// A `blob_properties` block as defined below.
        /// </summary>
        [Input("blobProperties")]
        public Input<Inputs.AccountBlobPropertiesGetArgs>? BlobProperties { get; set; }

        /// <summary>
        /// A `custom_domain` block as documented below.
        /// </summary>
        [Input("customDomain")]
        public Input<Inputs.AccountCustomDomainGetArgs>? CustomDomain { get; set; }

        /// <summary>
        /// Boolean flag which forces HTTPS if enabled, see [here](https://docs.microsoft.com/en-us/azure/storage/storage-require-secure-transfer/)
        /// for more information. Defaults to `true`.
        /// </summary>
        [Input("enableHttpsTrafficOnly")]
        public Input<bool>? EnableHttpsTrafficOnly { get; set; }

        /// <summary>
        /// A `identity` block as defined below.
        /// </summary>
        [Input("identity")]
        public Input<Inputs.AccountIdentityGetArgs>? Identity { get; set; }

        /// <summary>
        /// Is Hierarchical Namespace enabled? This can be used with Azure Data Lake Storage Gen 2 ([see here for more information](https://docs.microsoft.com/en-us/azure/storage/blobs/data-lake-storage-quickstart-create-account/)). Changing this forces a new resource to be created.
        /// </summary>
        [Input("isHnsEnabled")]
        public Input<bool>? IsHnsEnabled { get; set; }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the storage account. Changing this forces a new resource to be created. This must be unique across the entire Azure service, not just within the resource group.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// A `network_rules` block as documented below.
        /// </summary>
        [Input("networkRules")]
        public Input<Inputs.AccountNetworkRulesGetArgs>? NetworkRules { get; set; }

        /// <summary>
        /// The primary access key for the storage account.
        /// </summary>
        [Input("primaryAccessKey")]
        public Input<string>? PrimaryAccessKey { get; set; }

        /// <summary>
        /// The connection string associated with the primary blob location.
        /// </summary>
        [Input("primaryBlobConnectionString")]
        public Input<string>? PrimaryBlobConnectionString { get; set; }

        /// <summary>
        /// The endpoint URL for blob storage in the primary location.
        /// </summary>
        [Input("primaryBlobEndpoint")]
        public Input<string>? PrimaryBlobEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for blob storage in the primary location.
        /// </summary>
        [Input("primaryBlobHost")]
        public Input<string>? PrimaryBlobHost { get; set; }

        /// <summary>
        /// The connection string associated with the primary location.
        /// </summary>
        [Input("primaryConnectionString")]
        public Input<string>? PrimaryConnectionString { get; set; }

        /// <summary>
        /// The endpoint URL for DFS storage in the primary location.
        /// </summary>
        [Input("primaryDfsEndpoint")]
        public Input<string>? PrimaryDfsEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for DFS storage in the primary location.
        /// </summary>
        [Input("primaryDfsHost")]
        public Input<string>? PrimaryDfsHost { get; set; }

        /// <summary>
        /// The endpoint URL for file storage in the primary location.
        /// </summary>
        [Input("primaryFileEndpoint")]
        public Input<string>? PrimaryFileEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for file storage in the primary location.
        /// </summary>
        [Input("primaryFileHost")]
        public Input<string>? PrimaryFileHost { get; set; }

        /// <summary>
        /// The primary location of the storage account.
        /// </summary>
        [Input("primaryLocation")]
        public Input<string>? PrimaryLocation { get; set; }

        /// <summary>
        /// The endpoint URL for queue storage in the primary location.
        /// </summary>
        [Input("primaryQueueEndpoint")]
        public Input<string>? PrimaryQueueEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for queue storage in the primary location.
        /// </summary>
        [Input("primaryQueueHost")]
        public Input<string>? PrimaryQueueHost { get; set; }

        /// <summary>
        /// The endpoint URL for table storage in the primary location.
        /// </summary>
        [Input("primaryTableEndpoint")]
        public Input<string>? PrimaryTableEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for table storage in the primary location.
        /// </summary>
        [Input("primaryTableHost")]
        public Input<string>? PrimaryTableHost { get; set; }

        /// <summary>
        /// The endpoint URL for web storage in the primary location.
        /// </summary>
        [Input("primaryWebEndpoint")]
        public Input<string>? PrimaryWebEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for web storage in the primary location.
        /// </summary>
        [Input("primaryWebHost")]
        public Input<string>? PrimaryWebHost { get; set; }

        /// <summary>
        /// A `queue_properties` block as defined below.
        /// </summary>
        [Input("queueProperties")]
        public Input<Inputs.AccountQueuePropertiesGetArgs>? QueueProperties { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the storage account. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The secondary access key for the storage account.
        /// </summary>
        [Input("secondaryAccessKey")]
        public Input<string>? SecondaryAccessKey { get; set; }

        /// <summary>
        /// The connection string associated with the secondary blob location.
        /// </summary>
        [Input("secondaryBlobConnectionString")]
        public Input<string>? SecondaryBlobConnectionString { get; set; }

        /// <summary>
        /// The endpoint URL for blob storage in the secondary location.
        /// </summary>
        [Input("secondaryBlobEndpoint")]
        public Input<string>? SecondaryBlobEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for blob storage in the secondary location.
        /// </summary>
        [Input("secondaryBlobHost")]
        public Input<string>? SecondaryBlobHost { get; set; }

        /// <summary>
        /// The connection string associated with the secondary location.
        /// </summary>
        [Input("secondaryConnectionString")]
        public Input<string>? SecondaryConnectionString { get; set; }

        /// <summary>
        /// The endpoint URL for DFS storage in the secondary location.
        /// </summary>
        [Input("secondaryDfsEndpoint")]
        public Input<string>? SecondaryDfsEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for DFS storage in the secondary location.
        /// </summary>
        [Input("secondaryDfsHost")]
        public Input<string>? SecondaryDfsHost { get; set; }

        /// <summary>
        /// The endpoint URL for file storage in the secondary location.
        /// </summary>
        [Input("secondaryFileEndpoint")]
        public Input<string>? SecondaryFileEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for file storage in the secondary location.
        /// </summary>
        [Input("secondaryFileHost")]
        public Input<string>? SecondaryFileHost { get; set; }

        /// <summary>
        /// The secondary location of the storage account.
        /// </summary>
        [Input("secondaryLocation")]
        public Input<string>? SecondaryLocation { get; set; }

        /// <summary>
        /// The endpoint URL for queue storage in the secondary location.
        /// </summary>
        [Input("secondaryQueueEndpoint")]
        public Input<string>? SecondaryQueueEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for queue storage in the secondary location.
        /// </summary>
        [Input("secondaryQueueHost")]
        public Input<string>? SecondaryQueueHost { get; set; }

        /// <summary>
        /// The endpoint URL for table storage in the secondary location.
        /// </summary>
        [Input("secondaryTableEndpoint")]
        public Input<string>? SecondaryTableEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for table storage in the secondary location.
        /// </summary>
        [Input("secondaryTableHost")]
        public Input<string>? SecondaryTableHost { get; set; }

        /// <summary>
        /// The endpoint URL for web storage in the secondary location.
        /// </summary>
        [Input("secondaryWebEndpoint")]
        public Input<string>? SecondaryWebEndpoint { get; set; }

        /// <summary>
        /// The hostname with port if applicable for web storage in the secondary location.
        /// </summary>
        [Input("secondaryWebHost")]
        public Input<string>? SecondaryWebHost { get; set; }

        /// <summary>
        /// A `static_website` block as defined below.
        /// </summary>
        [Input("staticWebsite")]
        public Input<Inputs.AccountStaticWebsiteGetArgs>? StaticWebsite { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;

        /// <summary>
        /// A mapping of tags to assign to the resource.
        /// </summary>
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public AccountState()
        {
        }
    }
}
