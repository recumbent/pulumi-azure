# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class PointToPointVpnGateway(pulumi.CustomResource):
    connection_configuration: pulumi.Output[dict]
    """
    A `connection_configuration` block as defined below.

      * `name` (`str`) - The Name which should be used for this Connection Configuration.
      * `vpnClientAddressPool` (`dict`) - A `vpn_client_address_pool` block as defined below.
        * `address_prefixes` (`list`) - A list of CIDR Ranges which should be used as Address Prefixes.
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.
    """
    scale_unit: pulumi.Output[float]
    """
    The Scale Unit for this Point-to-Site VPN Gateway.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the Point-to-Site VPN Gateway.
    """
    virtual_hub_id: pulumi.Output[str]
    """
    The ID of the Virtual Hub where this Point-to-Site VPN Gateway should exist. Changing this forces a new resource to be created.
    """
    vpn_server_configuration_id: pulumi.Output[str]
    """
    The ID of the VPN Server Configuration which this Point-to-Site VPN Gateway should use. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, connection_configuration=None, location=None, name=None, resource_group_name=None, scale_unit=None, tags=None, virtual_hub_id=None, vpn_server_configuration_id=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Point-to-Site VPN Gateway.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example = azure.network.PointToPointVpnGateway("example",
            location=azurerm_resource_group["example"]["location"],
            resource_group_name=azurerm_resource_group["example"]["resource_group_name"],
            virtual_hub_id=azurerm_virtual_hub["example"]["id"],
            vpn_server_configuration_id=azurerm_vpn_server_configuration["example"]["id"],
            scale_unit=1)
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] connection_configuration: A `connection_configuration` block as defined below.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.
        :param pulumi.Input[float] scale_unit: The Scale Unit for this Point-to-Site VPN Gateway.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the Point-to-Site VPN Gateway.
        :param pulumi.Input[str] virtual_hub_id: The ID of the Virtual Hub where this Point-to-Site VPN Gateway should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] vpn_server_configuration_id: The ID of the VPN Server Configuration which this Point-to-Site VPN Gateway should use. Changing this forces a new resource to be created.

        The **connection_configuration** object supports the following:

          * `name` (`pulumi.Input[str]`) - The Name which should be used for this Connection Configuration.
          * `vpnClientAddressPool` (`pulumi.Input[dict]`) - A `vpn_client_address_pool` block as defined below.
            * `address_prefixes` (`pulumi.Input[list]`) - A list of CIDR Ranges which should be used as Address Prefixes.
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

            if connection_configuration is None:
                raise TypeError("Missing required property 'connection_configuration'")
            __props__['connection_configuration'] = connection_configuration
            __props__['location'] = location
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if scale_unit is None:
                raise TypeError("Missing required property 'scale_unit'")
            __props__['scale_unit'] = scale_unit
            __props__['tags'] = tags
            if virtual_hub_id is None:
                raise TypeError("Missing required property 'virtual_hub_id'")
            __props__['virtual_hub_id'] = virtual_hub_id
            if vpn_server_configuration_id is None:
                raise TypeError("Missing required property 'vpn_server_configuration_id'")
            __props__['vpn_server_configuration_id'] = vpn_server_configuration_id
        super(PointToPointVpnGateway, __self__).__init__(
            'azure:network/pointToPointVpnGateway:PointToPointVpnGateway',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, connection_configuration=None, location=None, name=None, resource_group_name=None, scale_unit=None, tags=None, virtual_hub_id=None, vpn_server_configuration_id=None):
        """
        Get an existing PointToPointVpnGateway resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] connection_configuration: A `connection_configuration` block as defined below.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Point-to-Site VPN Gateway. Changing this forces a new resource to be created.
        :param pulumi.Input[float] scale_unit: The Scale Unit for this Point-to-Site VPN Gateway.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the Point-to-Site VPN Gateway.
        :param pulumi.Input[str] virtual_hub_id: The ID of the Virtual Hub where this Point-to-Site VPN Gateway should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] vpn_server_configuration_id: The ID of the VPN Server Configuration which this Point-to-Site VPN Gateway should use. Changing this forces a new resource to be created.

        The **connection_configuration** object supports the following:

          * `name` (`pulumi.Input[str]`) - The Name which should be used for this Connection Configuration.
          * `vpnClientAddressPool` (`pulumi.Input[dict]`) - A `vpn_client_address_pool` block as defined below.
            * `address_prefixes` (`pulumi.Input[list]`) - A list of CIDR Ranges which should be used as Address Prefixes.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["connection_configuration"] = connection_configuration
        __props__["location"] = location
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["scale_unit"] = scale_unit
        __props__["tags"] = tags
        __props__["virtual_hub_id"] = virtual_hub_id
        __props__["vpn_server_configuration_id"] = vpn_server_configuration_id
        return PointToPointVpnGateway(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

