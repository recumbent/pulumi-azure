# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['VirtualWan']


class VirtualWan(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 allow_branch_to_branch_traffic: Optional[pulumi.Input[bool]] = None,
                 allow_vnet_to_vnet_traffic: Optional[pulumi.Input[bool]] = None,
                 disable_vpn_encryption: Optional[pulumi.Input[bool]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 office365_local_breakout_category: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Virtual WAN.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_virtual_wan = azure.network.VirtualWan("exampleVirtualWan",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] allow_branch_to_branch_traffic: Boolean flag to specify whether branch to branch traffic is allowed. Defaults to `true`.
        :param pulumi.Input[bool] allow_vnet_to_vnet_traffic: Boolean flag to specify whether VNet to VNet traffic is allowed. Defaults to `false`.
        :param pulumi.Input[bool] disable_vpn_encryption: Boolean flag to specify whether VPN encryption is disabled. Defaults to `false`.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Virtual WAN. Changing this forces a new resource to be created.
        :param pulumi.Input[str] office365_local_breakout_category: Specifies the Office365 local breakout category. Possible values include: `Optimize`, `OptimizeAndAllow`, `All`, `None`. Defaults to `None`.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Virtual WAN. Changing this forces a new resource to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the Virtual WAN.
        :param pulumi.Input[str] type: Specifies the Virtual WAN type. Possible Values include: `Basic` and `Standard`. Defaults to `Standard`.
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

            __props__['allow_branch_to_branch_traffic'] = allow_branch_to_branch_traffic
            __props__['allow_vnet_to_vnet_traffic'] = allow_vnet_to_vnet_traffic
            __props__['disable_vpn_encryption'] = disable_vpn_encryption
            __props__['location'] = location
            __props__['name'] = name
            __props__['office365_local_breakout_category'] = office365_local_breakout_category
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['type'] = type
        super(VirtualWan, __self__).__init__(
            'azure:network/virtualWan:VirtualWan',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            allow_branch_to_branch_traffic: Optional[pulumi.Input[bool]] = None,
            allow_vnet_to_vnet_traffic: Optional[pulumi.Input[bool]] = None,
            disable_vpn_encryption: Optional[pulumi.Input[bool]] = None,
            location: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            office365_local_breakout_category: Optional[pulumi.Input[str]] = None,
            resource_group_name: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            type: Optional[pulumi.Input[str]] = None) -> 'VirtualWan':
        """
        Get an existing VirtualWan resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[bool] allow_branch_to_branch_traffic: Boolean flag to specify whether branch to branch traffic is allowed. Defaults to `true`.
        :param pulumi.Input[bool] allow_vnet_to_vnet_traffic: Boolean flag to specify whether VNet to VNet traffic is allowed. Defaults to `false`.
        :param pulumi.Input[bool] disable_vpn_encryption: Boolean flag to specify whether VPN encryption is disabled. Defaults to `false`.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Virtual WAN. Changing this forces a new resource to be created.
        :param pulumi.Input[str] office365_local_breakout_category: Specifies the Office365 local breakout category. Possible values include: `Optimize`, `OptimizeAndAllow`, `All`, `None`. Defaults to `None`.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Virtual WAN. Changing this forces a new resource to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the Virtual WAN.
        :param pulumi.Input[str] type: Specifies the Virtual WAN type. Possible Values include: `Basic` and `Standard`. Defaults to `Standard`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["allow_branch_to_branch_traffic"] = allow_branch_to_branch_traffic
        __props__["allow_vnet_to_vnet_traffic"] = allow_vnet_to_vnet_traffic
        __props__["disable_vpn_encryption"] = disable_vpn_encryption
        __props__["location"] = location
        __props__["name"] = name
        __props__["office365_local_breakout_category"] = office365_local_breakout_category
        __props__["resource_group_name"] = resource_group_name
        __props__["tags"] = tags
        __props__["type"] = type
        return VirtualWan(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="allowBranchToBranchTraffic")
    def allow_branch_to_branch_traffic(self) -> pulumi.Output[Optional[bool]]:
        """
        Boolean flag to specify whether branch to branch traffic is allowed. Defaults to `true`.
        """
        return pulumi.get(self, "allow_branch_to_branch_traffic")

    @property
    @pulumi.getter(name="allowVnetToVnetTraffic")
    def allow_vnet_to_vnet_traffic(self) -> pulumi.Output[Optional[bool]]:
        """
        Boolean flag to specify whether VNet to VNet traffic is allowed. Defaults to `false`.
        """
        return pulumi.get(self, "allow_vnet_to_vnet_traffic")

    @property
    @pulumi.getter(name="disableVpnEncryption")
    def disable_vpn_encryption(self) -> pulumi.Output[Optional[bool]]:
        """
        Boolean flag to specify whether VPN encryption is disabled. Defaults to `false`.
        """
        return pulumi.get(self, "disable_vpn_encryption")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the Virtual WAN. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="office365LocalBreakoutCategory")
    def office365_local_breakout_category(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the Office365 local breakout category. Possible values include: `Optimize`, `OptimizeAndAllow`, `All`, `None`. Defaults to `None`.
        """
        return pulumi.get(self, "office365_local_breakout_category")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Output[str]:
        """
        The name of the resource group in which to create the Virtual WAN. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags to assign to the Virtual WAN.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        Specifies the Virtual WAN type. Possible Values include: `Basic` and `Standard`. Defaults to `Standard`.
        """
        return pulumi.get(self, "type")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

