# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class DiskEncryptionSet(pulumi.CustomResource):
    identity: pulumi.Output[dict]
    """
    A `identity` block defined below.

      * `principal_id` (`str`) - The (Client) ID of the Service Principal.
      * `tenant_id` (`str`) - The ID of the Tenant the Service Principal is assigned in.
      * `type` (`str`) - The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
    """
    key_vault_key_id: pulumi.Output[str]
    """
    Specifies the URL to a Key Vault Key (either from a Key Vault Key, or the Key URL for the Key Vault Secret).
    """
    location: pulumi.Output[str]
    """
    Specifies the Azure Region where the Disk Encryption Set exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    The name of the Disk Encryption Set. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    Specifies the name of the Resource Group where the Disk Encryption Set should exist. Changing this forces a new resource to be created.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the Disk Encryption Set.
    """
    def __init__(__self__, resource_name, opts=None, identity=None, key_vault_key_id=None, location=None, name=None, resource_group_name=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Disk Encryption Set.

        > **NOTE:** At this time the Key Vault used to store the Active Key for this Disk Encryption Set must have both Soft Delete & Purge Protection enabled - which are not yet supported by this provider.



        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] identity: A `identity` block defined below.
        :param pulumi.Input[str] key_vault_key_id: Specifies the URL to a Key Vault Key (either from a Key Vault Key, or the Key URL for the Key Vault Secret).
        :param pulumi.Input[str] location: Specifies the Azure Region where the Disk Encryption Set exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the Disk Encryption Set. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group where the Disk Encryption Set should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the Disk Encryption Set.

        The **identity** object supports the following:

          * `principal_id` (`pulumi.Input[str]`) - The (Client) ID of the Service Principal.
          * `tenant_id` (`pulumi.Input[str]`) - The ID of the Tenant the Service Principal is assigned in.
          * `type` (`pulumi.Input[str]`) - The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
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

            if identity is None:
                raise TypeError("Missing required property 'identity'")
            __props__['identity'] = identity
            if key_vault_key_id is None:
                raise TypeError("Missing required property 'key_vault_key_id'")
            __props__['key_vault_key_id'] = key_vault_key_id
            __props__['location'] = location
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
        super(DiskEncryptionSet, __self__).__init__(
            'azure:compute/diskEncryptionSet:DiskEncryptionSet',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, identity=None, key_vault_key_id=None, location=None, name=None, resource_group_name=None, tags=None):
        """
        Get an existing DiskEncryptionSet resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] identity: A `identity` block defined below.
        :param pulumi.Input[str] key_vault_key_id: Specifies the URL to a Key Vault Key (either from a Key Vault Key, or the Key URL for the Key Vault Secret).
        :param pulumi.Input[str] location: Specifies the Azure Region where the Disk Encryption Set exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the Disk Encryption Set. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group where the Disk Encryption Set should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the Disk Encryption Set.

        The **identity** object supports the following:

          * `principal_id` (`pulumi.Input[str]`) - The (Client) ID of the Service Principal.
          * `tenant_id` (`pulumi.Input[str]`) - The ID of the Tenant the Service Principal is assigned in.
          * `type` (`pulumi.Input[str]`) - The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["identity"] = identity
        __props__["key_vault_key_id"] = key_vault_key_id
        __props__["location"] = location
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["tags"] = tags
        return DiskEncryptionSet(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

