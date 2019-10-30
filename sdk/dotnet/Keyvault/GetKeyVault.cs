// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Keyvault
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Key Vault.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/key_vault.html.markdown.
        /// </summary>
        public static Task<GetKeyVaultResult> GetKeyVault(GetKeyVaultArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetKeyVaultResult>("azure:keyvault/getKeyVault:getKeyVault", args, options.WithVersion());
    }

    public sealed class GetKeyVaultArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Key Vault.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the Key Vault exists.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetKeyVaultArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetKeyVaultResult
    {
        /// <summary>
        /// One or more `access_policy` blocks as defined below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetKeyVaultAccessPoliciesResult> AccessPolicies;
        /// <summary>
        /// Can Azure Virtual Machines retrieve certificates stored as secrets from the Key Vault?
        /// </summary>
        public readonly bool EnabledForDeployment;
        /// <summary>
        /// Can Azure Disk Encryption retrieve secrets from the Key Vault?
        /// </summary>
        public readonly bool EnabledForDiskEncryption;
        /// <summary>
        /// Can Azure Resource Manager retrieve secrets from the Key Vault?
        /// </summary>
        public readonly bool EnabledForTemplateDeployment;
        /// <summary>
        /// The Azure Region in which the Key Vault exists.
        /// </summary>
        public readonly string Location;
        /// <summary>
        /// The name of the SKU used for this Key Vault.
        /// </summary>
        public readonly string Name;
        public readonly ImmutableArray<Outputs.GetKeyVaultNetworkAclsResult> NetworkAcls;
        public readonly string ResourceGroupName;
        /// <summary>
        /// A `sku` block as described below.
        /// </summary>
        public readonly Outputs.GetKeyVaultSkuResult Sku;
        public readonly string SkuName;
        /// <summary>
        /// A mapping of tags assigned to the Key Vault.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// The Azure Active Directory Tenant ID used to authenticate requests for this Key Vault.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The URI of the vault for performing operations on keys and secrets.
        /// </summary>
        public readonly string VaultUri;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetKeyVaultResult(
            ImmutableArray<Outputs.GetKeyVaultAccessPoliciesResult> accessPolicies,
            bool enabledForDeployment,
            bool enabledForDiskEncryption,
            bool enabledForTemplateDeployment,
            string location,
            string name,
            ImmutableArray<Outputs.GetKeyVaultNetworkAclsResult> networkAcls,
            string resourceGroupName,
            Outputs.GetKeyVaultSkuResult sku,
            string skuName,
            ImmutableDictionary<string, string> tags,
            string tenantId,
            string vaultUri,
            string id)
        {
            AccessPolicies = accessPolicies;
            EnabledForDeployment = enabledForDeployment;
            EnabledForDiskEncryption = enabledForDiskEncryption;
            EnabledForTemplateDeployment = enabledForTemplateDeployment;
            Location = location;
            Name = name;
            NetworkAcls = networkAcls;
            ResourceGroupName = resourceGroupName;
            Sku = sku;
            SkuName = skuName;
            Tags = tags;
            TenantId = tenantId;
            VaultUri = vaultUri;
            Id = id;
        }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class GetKeyVaultAccessPoliciesResult
    {
        /// <summary>
        /// The Object ID of a Azure Active Directory Application.
        /// </summary>
        public readonly string ApplicationId;
        /// <summary>
        /// A list of certificate permissions applicable to this Access Policy.
        /// </summary>
        public readonly ImmutableArray<string> CertificatePermissions;
        /// <summary>
        /// A list of key permissions applicable to this Access Policy.
        /// </summary>
        public readonly ImmutableArray<string> KeyPermissions;
        /// <summary>
        /// An Object ID of a User, Service Principal or Security Group.
        /// </summary>
        public readonly string ObjectId;
        /// <summary>
        /// A list of secret permissions applicable to this Access Policy.
        /// </summary>
        public readonly ImmutableArray<string> SecretPermissions;
        /// <summary>
        /// A list of storage permissions applicable to this Access Policy.
        /// </summary>
        public readonly ImmutableArray<string> StoragePermissions;
        /// <summary>
        /// The Azure Active Directory Tenant ID used to authenticate requests for this Key Vault.
        /// </summary>
        public readonly string TenantId;

        [OutputConstructor]
        private GetKeyVaultAccessPoliciesResult(
            string applicationId,
            ImmutableArray<string> certificatePermissions,
            ImmutableArray<string> keyPermissions,
            string objectId,
            ImmutableArray<string> secretPermissions,
            ImmutableArray<string> storagePermissions,
            string tenantId)
        {
            ApplicationId = applicationId;
            CertificatePermissions = certificatePermissions;
            KeyPermissions = keyPermissions;
            ObjectId = objectId;
            SecretPermissions = secretPermissions;
            StoragePermissions = storagePermissions;
            TenantId = tenantId;
        }
    }

    [OutputType]
    public sealed class GetKeyVaultNetworkAclsResult
    {
        public readonly string Bypass;
        public readonly string DefaultAction;
        public readonly ImmutableArray<string> IpRules;
        public readonly ImmutableArray<string> VirtualNetworkSubnetIds;

        [OutputConstructor]
        private GetKeyVaultNetworkAclsResult(
            string bypass,
            string defaultAction,
            ImmutableArray<string> ipRules,
            ImmutableArray<string> virtualNetworkSubnetIds)
        {
            Bypass = bypass;
            DefaultAction = defaultAction;
            IpRules = ipRules;
            VirtualNetworkSubnetIds = virtualNetworkSubnetIds;
        }
    }

    [OutputType]
    public sealed class GetKeyVaultSkuResult
    {
        /// <summary>
        /// Specifies the name of the Key Vault.
        /// </summary>
        public readonly string Name;

        [OutputConstructor]
        private GetKeyVaultSkuResult(string name)
        {
            Name = name;
        }
    }
    }
}
