# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['NatGateway']


class NatGateway(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 idle_timeout_in_minutes: Optional[pulumi.Input[float]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 public_ip_address_ids: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 public_ip_prefix_ids: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 sku_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 zones: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Azure NAT Gateway.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="eastus2")
        example_public_ip = azure.network.PublicIp("examplePublicIp",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            allocation_method="Static",
            sku="Standard",
            zones=["1"])
        example_public_ip_prefix = azure.network.PublicIpPrefix("examplePublicIpPrefix",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            prefix_length=30,
            zones=["1"])
        example_nat_gateway = azure.network.NatGateway("exampleNatGateway",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            public_ip_address_ids=[example_public_ip.id],
            public_ip_prefix_ids=[example_public_ip_prefix.id],
            sku_name="Standard",
            idle_timeout_in_minutes=10,
            zones=["1"])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] idle_timeout_in_minutes: The idle timeout which should be used in minutes. Defaults to `4`.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the NAT Gateway should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the NAT Gateway. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[str]]] public_ip_address_ids: A list of Public IP Address ID's which should be associated with the NAT Gateway resource.
        :param pulumi.Input[List[pulumi.Input[str]]] public_ip_prefix_ids: A list of Public IP Prefix ID's which should be associated with the NAT Gateway resource.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group in which the NAT Gateway should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sku_name: The SKU which should be used. At this time the only supported value is `Standard`. Defaults to `Standard`.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[str]]] zones: A list of availability zones where the NAT Gateway should be provisioned. Changing this forces a new resource to be created.
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
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['idle_timeout_in_minutes'] = idle_timeout_in_minutes
            __props__['location'] = location
            __props__['name'] = name
            if public_ip_address_ids is not None:
                warnings.warn("Inline Public IP Address ID Deprecations have been deprecated in favour of the `azurerm_nat_gateway_public_ip_association` resource. This field will be removed in the next major version of the Azure Provider.", DeprecationWarning)
                pulumi.log.warn("public_ip_address_ids is deprecated: Inline Public IP Address ID Deprecations have been deprecated in favour of the `azurerm_nat_gateway_public_ip_association` resource. This field will be removed in the next major version of the Azure Provider.")
            __props__['public_ip_address_ids'] = public_ip_address_ids
            __props__['public_ip_prefix_ids'] = public_ip_prefix_ids
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['sku_name'] = sku_name
            __props__['tags'] = tags
            __props__['zones'] = zones
            __props__['resource_guid'] = None
        super(NatGateway, __self__).__init__(
            'azure:network/natGateway:NatGateway',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            idle_timeout_in_minutes: Optional[pulumi.Input[float]] = None,
            location: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            public_ip_address_ids: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            public_ip_prefix_ids: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            resource_group_name: Optional[pulumi.Input[str]] = None,
            resource_guid: Optional[pulumi.Input[str]] = None,
            sku_name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            zones: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None) -> 'NatGateway':
        """
        Get an existing NatGateway resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] idle_timeout_in_minutes: The idle timeout which should be used in minutes. Defaults to `4`.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the NAT Gateway should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the NAT Gateway. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[str]]] public_ip_address_ids: A list of Public IP Address ID's which should be associated with the NAT Gateway resource.
        :param pulumi.Input[List[pulumi.Input[str]]] public_ip_prefix_ids: A list of Public IP Prefix ID's which should be associated with the NAT Gateway resource.
        :param pulumi.Input[str] resource_group_name: Specifies the name of the Resource Group in which the NAT Gateway should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_guid: The resource GUID property of the NAT Gateway.
        :param pulumi.Input[str] sku_name: The SKU which should be used. At this time the only supported value is `Standard`. Defaults to `Standard`.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[str]]] zones: A list of availability zones where the NAT Gateway should be provisioned. Changing this forces a new resource to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["idle_timeout_in_minutes"] = idle_timeout_in_minutes
        __props__["location"] = location
        __props__["name"] = name
        __props__["public_ip_address_ids"] = public_ip_address_ids
        __props__["public_ip_prefix_ids"] = public_ip_prefix_ids
        __props__["resource_group_name"] = resource_group_name
        __props__["resource_guid"] = resource_guid
        __props__["sku_name"] = sku_name
        __props__["tags"] = tags
        __props__["zones"] = zones
        return NatGateway(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="idleTimeoutInMinutes")
    def idle_timeout_in_minutes(self) -> pulumi.Output[Optional[float]]:
        """
        The idle timeout which should be used in minutes. Defaults to `4`.
        """
        return pulumi.get(self, "idle_timeout_in_minutes")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Specifies the supported Azure location where the NAT Gateway should exist. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the NAT Gateway. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="publicIpAddressIds")
    def public_ip_address_ids(self) -> pulumi.Output[List[str]]:
        """
        A list of Public IP Address ID's which should be associated with the NAT Gateway resource.
        """
        return pulumi.get(self, "public_ip_address_ids")

    @property
    @pulumi.getter(name="publicIpPrefixIds")
    def public_ip_prefix_ids(self) -> pulumi.Output[Optional[List[str]]]:
        """
        A list of Public IP Prefix ID's which should be associated with the NAT Gateway resource.
        """
        return pulumi.get(self, "public_ip_prefix_ids")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the Resource Group in which the NAT Gateway should exist. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter(name="resourceGuid")
    def resource_guid(self) -> pulumi.Output[str]:
        """
        The resource GUID property of the NAT Gateway.
        """
        return pulumi.get(self, "resource_guid")

    @property
    @pulumi.getter(name="skuName")
    def sku_name(self) -> pulumi.Output[Optional[str]]:
        """
        The SKU which should be used. At this time the only supported value is `Standard`. Defaults to `Standard`.
        """
        return pulumi.get(self, "sku_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def zones(self) -> pulumi.Output[Optional[List[str]]]:
        """
        A list of availability zones where the NAT Gateway should be provisioned. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "zones")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

