# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Account(pulumi.CustomResource):
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
    """
    storage_accounts: pulumi.Output[list]
    """
    One or more `storage_account` blocks as defined below.

      * `id` (`str`) - Specifies the ID of the Storage Account that will be associated with the Media Services instance.
      * `isPrimary` (`bool`) - Specifies whether the storage account should be the primary account or not. Defaults to `false`.
    """
    def __init__(__self__, resource_name, opts=None, location=None, name=None, resource_group_name=None, storage_accounts=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Media Services Account.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="GRS")
        example_mediaservices_account_account = azure.mediaservices.Account("exampleMediaservices/accountAccount",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            storage_account=[{
                "id": example_account.id,
                "isPrimary": True,
            }])
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
        :param pulumi.Input[list] storage_accounts: One or more `storage_account` blocks as defined below.

        The **storage_accounts** object supports the following:

          * `id` (`pulumi.Input[str]`) - Specifies the ID of the Storage Account that will be associated with the Media Services instance.
          * `isPrimary` (`pulumi.Input[bool]`) - Specifies whether the storage account should be the primary account or not. Defaults to `false`.
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

            __props__['location'] = location
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if storage_accounts is None:
                raise TypeError("Missing required property 'storage_accounts'")
            __props__['storage_accounts'] = storage_accounts
        super(Account, __self__).__init__(
            'azure:mediaservices/account:Account',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, location=None, name=None, resource_group_name=None, storage_accounts=None):
        """
        Get an existing Account resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Media Services Account. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Media Services Account. Changing this forces a new resource to be created.
        :param pulumi.Input[list] storage_accounts: One or more `storage_account` blocks as defined below.

        The **storage_accounts** object supports the following:

          * `id` (`pulumi.Input[str]`) - Specifies the ID of the Storage Account that will be associated with the Media Services instance.
          * `isPrimary` (`pulumi.Input[bool]`) - Specifies whether the storage account should be the primary account or not. Defaults to `false`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["location"] = location
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["storage_accounts"] = storage_accounts
        return Account(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

