# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class CacheBlobTarget(pulumi.CustomResource):
    cache_name: pulumi.Output[str]
    """
    The name HPC Cache, which the HPC Cache Blob Target will be added to. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    The name of the HPC Cache Blob Target. Changing this forces a new resource to be created.
    """
    namespace_path: pulumi.Output[str]
    """
    The client-facing file path of the HPC Cache Blob Target.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the Resource Group in which to create the HPC Cache Blob Target. Changing this forces a new resource to be created.
    """
    storage_container_id: pulumi.Output[str]
    """
    The Resource Manager ID of the Storage Container used as the HPC Cache Blob Target. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, cache_name=None, name=None, namespace_path=None, resource_group_name=None, storage_container_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Blob Target within a HPC Cache.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure
        import pulumi_azuread as azuread

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_virtual_network = azure.network.VirtualNetwork("exampleVirtualNetwork",
            address_spaces=["10.0.0.0/16"],
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name)
        example_subnet = azure.network.Subnet("exampleSubnet",
            resource_group_name=example_resource_group.name,
            virtual_network_name=example_virtual_network.name,
            address_prefix="10.0.1.0/24")
        example_cache = azure.hpc.Cache("exampleCache",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            cache_size_in_gb=3072,
            subnet_id=example_subnet.id,
            sku_name="Standard_2G")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS")
        example_container = azure.storage.Container("exampleContainer", storage_account_name=example_account.name)
        example_service_principal = azuread.get_service_principal(display_name="HPC Cache Resource Provider")
        example_storage_account_contrib = azure.authorization.Assignment("exampleStorageAccountContrib",
            scope=example_account.id,
            role_definition_name="Storage Account Contributor",
            principal_id=example_service_principal.object_id)
        example_storage_blob_data_contrib = azure.authorization.Assignment("exampleStorageBlobDataContrib",
            scope=example_account.id,
            role_definition_name="Storage Blob Data Contributor",
            principal_id=example_service_principal.object_id)
        example_cache_blob_target = azure.hpc.CacheBlobTarget("exampleCacheBlobTarget",
            resource_group_name=example_resource_group.name,
            cache_name=example_cache.name,
            storage_container_id=example_container.resource_manager_id,
            namespace_path="/blob_storage")
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cache_name: The name HPC Cache, which the HPC Cache Blob Target will be added to. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the HPC Cache Blob Target. Changing this forces a new resource to be created.
        :param pulumi.Input[str] namespace_path: The client-facing file path of the HPC Cache Blob Target.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which to create the HPC Cache Blob Target. Changing this forces a new resource to be created.
        :param pulumi.Input[str] storage_container_id: The Resource Manager ID of the Storage Container used as the HPC Cache Blob Target. Changing this forces a new resource to be created.
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

            if cache_name is None:
                raise TypeError("Missing required property 'cache_name'")
            __props__['cache_name'] = cache_name
            __props__['name'] = name
            if namespace_path is None:
                raise TypeError("Missing required property 'namespace_path'")
            __props__['namespace_path'] = namespace_path
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if storage_container_id is None:
                raise TypeError("Missing required property 'storage_container_id'")
            __props__['storage_container_id'] = storage_container_id
        super(CacheBlobTarget, __self__).__init__(
            'azure:hpc/cacheBlobTarget:CacheBlobTarget',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, cache_name=None, name=None, namespace_path=None, resource_group_name=None, storage_container_id=None):
        """
        Get an existing CacheBlobTarget resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cache_name: The name HPC Cache, which the HPC Cache Blob Target will be added to. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the HPC Cache Blob Target. Changing this forces a new resource to be created.
        :param pulumi.Input[str] namespace_path: The client-facing file path of the HPC Cache Blob Target.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which to create the HPC Cache Blob Target. Changing this forces a new resource to be created.
        :param pulumi.Input[str] storage_container_id: The Resource Manager ID of the Storage Container used as the HPC Cache Blob Target. Changing this forces a new resource to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["cache_name"] = cache_name
        __props__["name"] = name
        __props__["namespace_path"] = namespace_path
        __props__["resource_group_name"] = resource_group_name
        __props__["storage_container_id"] = storage_container_id
        return CacheBlobTarget(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

