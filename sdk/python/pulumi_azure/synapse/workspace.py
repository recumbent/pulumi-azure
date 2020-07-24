# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class Workspace(pulumi.CustomResource):
    aad_admin: pulumi.Output[dict]
    """
    An `aad_admin` block as defined below.

      * `login` (`str`) - The login name of the Azure AD Administrator of this Synapse Workspace.
      * `object_id` (`str`) - The object id of the Azure AD Administrator of this Synapse Workspace.
      * `tenant_id` (`str`) - The tenant id of the Azure AD Administrator of this Synapse Workspace.
    """
    connectivity_endpoints: pulumi.Output[dict]
    """
    A list of Connectivity endpoints for this Synapse Workspace.
    """
    identities: pulumi.Output[list]
    """
    An `identity` block as defined below, which contains the Managed Service Identity information for this Synapse Workspace.

      * `principal_id` (`str`) - The Principal ID for the Service Principal associated with the Managed Service Identity of this Synapse Workspace.
      * `tenant_id` (`str`) - The tenant id of the Azure AD Administrator of this Synapse Workspace.
      * `type` (`str`) - The Identity Type for the Service Principal associated with the Managed Service Identity of this Synapse Workspace.
    """
    location: pulumi.Output[str]
    """
    Specifies the Azure Region where the synapse Workspace should exist. Changing this forces a new resource to be created.
    """
    managed_resource_group_name: pulumi.Output[str]
    """
    Workspace managed resource group.
    """
    managed_virtual_network_enabled: pulumi.Output[bool]
    """
    Is Virtual Network enabled for all computes in this workspace. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name which should be used for this synapse Workspace. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    Specifies the name of the Resource Group where the synapse Workspace should exist. Changing this forces a new resource to be created.
    """
    sql_administrator_login: pulumi.Output[str]
    """
    Specifies The Login Name of the SQL administrator. Changing this forces a new resource to be created.
    """
    sql_administrator_login_password: pulumi.Output[str]
    """
    The Password associated with the `sql_administrator_login` for the SQL administrator.
    """
    storage_data_lake_gen2_filesystem_id: pulumi.Output[str]
    """
    Specifies the ID of storage data lake gen2 filesystem resource. Changing this forces a new resource to be created.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags which should be assigned to the Synapse Workspace.
    """
    def __init__(__self__, resource_name, opts=None, aad_admin=None, location=None, managed_virtual_network_enabled=None, name=None, resource_group_name=None, sql_administrator_login=None, sql_administrator_login_password=None, storage_data_lake_gen2_filesystem_id=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Synapse Workspace.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS",
            account_kind="StorageV2",
            is_hns_enabled="true")
        example_data_lake_gen2_filesystem = azure.storage.DataLakeGen2Filesystem("exampleDataLakeGen2Filesystem", storage_account_id=example_account.id)
        example_workspace = azure.synapse.Workspace("exampleWorkspace",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            storage_data_lake_gen2_filesystem_id=example_data_lake_gen2_filesystem.id,
            sql_administrator_login="sqladminuser",
            sql_administrator_login_password="H@Sh1CoR3!",
            aad_admin={
                "login": "AzureAD Admin",
                "object_id": "00000000-0000-0000-0000-000000000000",
                "tenant_id": "00000000-0000-0000-0000-000000000000",
            },
            tags={
                "Env": "production",
            })
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] aad_admin: An `aad_admin` block as defined below.
        :param pulumi.Input[str] location: Specifies the Azure Region where the synapse Workspace should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] managed_virtual_network_enabled: Is Virtual Network enabled for all computes in this workspace. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name which should be used for this synapse Workspace. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group where the synapse Workspace should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sql_administrator_login: Specifies The Login Name of the SQL administrator. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sql_administrator_login_password: The Password associated with the `sql_administrator_login` for the SQL administrator.
        :param pulumi.Input[str] storage_data_lake_gen2_filesystem_id: Specifies the ID of storage data lake gen2 filesystem resource. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags which should be assigned to the Synapse Workspace.

        The **aad_admin** object supports the following:

          * `login` (`pulumi.Input[str]`) - The login name of the Azure AD Administrator of this Synapse Workspace.
          * `object_id` (`pulumi.Input[str]`) - The object id of the Azure AD Administrator of this Synapse Workspace.
          * `tenant_id` (`pulumi.Input[str]`) - The tenant id of the Azure AD Administrator of this Synapse Workspace.
        """
        if __name__ is not None:
            warnings.warn("explicit use of __name__ is deprecated", DeprecationWarning)
            resource_name = __name__
        if __opts__ is not None:
            warnings.warn("explicit use of __opts__ is deprecated, use 'opts' instead", DeprecationWarning)
            opts = __opts__
        if opts is None:
            opts = pulumi.ResourceOptions()
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.version is None:
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['aad_admin'] = aad_admin
            __props__['location'] = location
            __props__['managed_virtual_network_enabled'] = managed_virtual_network_enabled
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sql_administrator_login is None:
                raise TypeError("Missing required property 'sql_administrator_login'")
            __props__['sql_administrator_login'] = sql_administrator_login
            if sql_administrator_login_password is None:
                raise TypeError("Missing required property 'sql_administrator_login_password'")
            __props__['sql_administrator_login_password'] = sql_administrator_login_password
            if storage_data_lake_gen2_filesystem_id is None:
                raise TypeError("Missing required property 'storage_data_lake_gen2_filesystem_id'")
            __props__['storage_data_lake_gen2_filesystem_id'] = storage_data_lake_gen2_filesystem_id
            __props__['tags'] = tags
            __props__['connectivity_endpoints'] = None
            __props__['identities'] = None
            __props__['managed_resource_group_name'] = None
        super(Workspace, __self__).__init__(
            'azure:synapse/workspace:Workspace',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, aad_admin=None, connectivity_endpoints=None, identities=None, location=None, managed_resource_group_name=None, managed_virtual_network_enabled=None, name=None, resource_group_name=None, sql_administrator_login=None, sql_administrator_login_password=None, storage_data_lake_gen2_filesystem_id=None, tags=None):
        """
        Get an existing Workspace resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] aad_admin: An `aad_admin` block as defined below.
        :param pulumi.Input[dict] connectivity_endpoints: A list of Connectivity endpoints for this Synapse Workspace.
        :param pulumi.Input[list] identities: An `identity` block as defined below, which contains the Managed Service Identity information for this Synapse Workspace.
        :param pulumi.Input[str] location: Specifies the Azure Region where the synapse Workspace should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] managed_resource_group_name: Workspace managed resource group.
        :param pulumi.Input[bool] managed_virtual_network_enabled: Is Virtual Network enabled for all computes in this workspace. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name which should be used for this synapse Workspace. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group where the synapse Workspace should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sql_administrator_login: Specifies The Login Name of the SQL administrator. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sql_administrator_login_password: The Password associated with the `sql_administrator_login` for the SQL administrator.
        :param pulumi.Input[str] storage_data_lake_gen2_filesystem_id: Specifies the ID of storage data lake gen2 filesystem resource. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags which should be assigned to the Synapse Workspace.

        The **aad_admin** object supports the following:

          * `login` (`pulumi.Input[str]`) - The login name of the Azure AD Administrator of this Synapse Workspace.
          * `object_id` (`pulumi.Input[str]`) - The object id of the Azure AD Administrator of this Synapse Workspace.
          * `tenant_id` (`pulumi.Input[str]`) - The tenant id of the Azure AD Administrator of this Synapse Workspace.

        The **identities** object supports the following:

          * `principal_id` (`pulumi.Input[str]`) - The Principal ID for the Service Principal associated with the Managed Service Identity of this Synapse Workspace.
          * `tenant_id` (`pulumi.Input[str]`) - The tenant id of the Azure AD Administrator of this Synapse Workspace.
          * `type` (`pulumi.Input[str]`) - The Identity Type for the Service Principal associated with the Managed Service Identity of this Synapse Workspace.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["aad_admin"] = aad_admin
        __props__["connectivity_endpoints"] = connectivity_endpoints
        __props__["identities"] = identities
        __props__["location"] = location
        __props__["managed_resource_group_name"] = managed_resource_group_name
        __props__["managed_virtual_network_enabled"] = managed_virtual_network_enabled
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["sql_administrator_login"] = sql_administrator_login
        __props__["sql_administrator_login_password"] = sql_administrator_login_password
        __props__["storage_data_lake_gen2_filesystem_id"] = storage_data_lake_gen2_filesystem_id
        __props__["tags"] = tags
        return Workspace(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop
