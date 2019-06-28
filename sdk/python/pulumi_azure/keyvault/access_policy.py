# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from .. import utilities, tables

class AccessPolicy(pulumi.CustomResource):
    application_id: pulumi.Output[str]
    """
    The object ID of an Application in Azure Active Directory.
    """
    certificate_permissions: pulumi.Output[list]
    """
    List of certificate permissions, must be one or more from
    the following: `backup`, `create`, `delete`, `deleteissuers`, `get`, `getissuers`, `import`, `list`, `listissuers`,
    `managecontacts`, `manageissuers`, `purge`, `recover`, `restore`, `setissuers` and `update`.
    """
    key_permissions: pulumi.Output[list]
    """
    List of key permissions, must be one or more from
    the following: `backup`, `create`, `decrypt`, `delete`, `encrypt`, `get`, `import`, `list`, `purge`,
    `recover`, `restore`, `sign`, `unwrapKey`, `update`, `verify` and `wrapKey`.
    """
    key_vault_id: pulumi.Output[str]
    """
    Specifies the id of the Key Vault resource. Changing this
    forces a new resource to be created.
    """
    object_id: pulumi.Output[str]
    """
    The object ID of a user, service principal or security
    group in the Azure Active Directory tenant for the vault. The object ID must
    be unique for the list of access policies. Changing this forces a new resource
    to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to
    create the namespace. Changing this forces a new resource to be created.
    """
    secret_permissions: pulumi.Output[list]
    """
    List of secret permissions, must be one or more
    from the following: `backup`, `delete`, `get`, `list`, `purge`, `recover`, `restore` and `set`.
    """
    storage_permissions: pulumi.Output[list]
    """
    List of storage permissions, must be one or more from the following: `backup`, `delete`, `deletesas`, `get`, `getsas`, `list`, `listsas`, `purge`, `recover`, `regeneratekey`, `restore`, `set`, `setsas` and `update`.
    """
    tenant_id: pulumi.Output[str]
    """
    The Azure Active Directory tenant ID that should be used
    for authenticating requests to the key vault. Changing this forces a new resource
    to be created.
    """
    vault_name: pulumi.Output[str]
    """
    Specifies the name of the Key Vault resource. Changing this
    forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, application_id=None, certificate_permissions=None, key_permissions=None, key_vault_id=None, object_id=None, resource_group_name=None, secret_permissions=None, storage_permissions=None, tenant_id=None, vault_name=None, __name__=None, __opts__=None):
        """
        Manages a Key Vault Access Policy.
        
        > **NOTE:** It's possible to define Key Vault Access Policies both within the `azurerm_key_vault` resource via the `access_policy` block and by using the `azurerm_key_vault_access_policy` resource. However it's not possible to use both methods to manage Access Policies within a KeyVault, since there'll be conflicts.
        
        > **NOTE:** Azure permits a maximum of 1024 Access Policies per Key Vault - [more information can be found in this document](https://docs.microsoft.com/en-us/azure/key-vault/key-vault-secure-your-key-vault#data-plane-access-control).
        
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] application_id: The object ID of an Application in Azure Active Directory.
        :param pulumi.Input[list] certificate_permissions: List of certificate permissions, must be one or more from
               the following: `backup`, `create`, `delete`, `deleteissuers`, `get`, `getissuers`, `import`, `list`, `listissuers`,
               `managecontacts`, `manageissuers`, `purge`, `recover`, `restore`, `setissuers` and `update`.
        :param pulumi.Input[list] key_permissions: List of key permissions, must be one or more from
               the following: `backup`, `create`, `decrypt`, `delete`, `encrypt`, `get`, `import`, `list`, `purge`,
               `recover`, `restore`, `sign`, `unwrapKey`, `update`, `verify` and `wrapKey`.
        :param pulumi.Input[str] key_vault_id: Specifies the id of the Key Vault resource. Changing this
               forces a new resource to be created.
        :param pulumi.Input[str] object_id: The object ID of a user, service principal or security
               group in the Azure Active Directory tenant for the vault. The object ID must
               be unique for the list of access policies. Changing this forces a new resource
               to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the namespace. Changing this forces a new resource to be created.
        :param pulumi.Input[list] secret_permissions: List of secret permissions, must be one or more
               from the following: `backup`, `delete`, `get`, `list`, `purge`, `recover`, `restore` and `set`.
        :param pulumi.Input[list] storage_permissions: List of storage permissions, must be one or more from the following: `backup`, `delete`, `deletesas`, `get`, `getsas`, `list`, `listsas`, `purge`, `recover`, `regeneratekey`, `restore`, `set`, `setsas` and `update`.
        :param pulumi.Input[str] tenant_id: The Azure Active Directory tenant ID that should be used
               for authenticating requests to the key vault. Changing this forces a new resource
               to be created.
        :param pulumi.Input[str] vault_name: Specifies the name of the Key Vault resource. Changing this
               forces a new resource to be created.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if not resource_name:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(resource_name, str):
            raise TypeError('Expected resource name to be a string')
        if opts and not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['application_id'] = application_id

        __props__['certificate_permissions'] = certificate_permissions

        __props__['key_permissions'] = key_permissions

        __props__['key_vault_id'] = key_vault_id

        if object_id is None:
            raise TypeError("Missing required property 'object_id'")
        __props__['object_id'] = object_id

        __props__['resource_group_name'] = resource_group_name

        __props__['secret_permissions'] = secret_permissions

        __props__['storage_permissions'] = storage_permissions

        if tenant_id is None:
            raise TypeError("Missing required property 'tenant_id'")
        __props__['tenant_id'] = tenant_id

        __props__['vault_name'] = vault_name

        super(AccessPolicy, __self__).__init__(
            'azure:keyvault/accessPolicy:AccessPolicy',
            resource_name,
            __props__,
            opts)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

