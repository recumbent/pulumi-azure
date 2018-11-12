# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class VirtualNetworkGateway(pulumi.CustomResource):
    """
    Manages a Virtual Network Gateway to establish secure, cross-premises connectivity.
    
    -> **Note:** Please be aware that provisioning a Virtual Network Gateway takes a long time (between 30 minutes and 1 hour)
    """
    def __init__(__self__, __name__, __opts__=None, active_active=None, bgp_settings=None, default_local_network_gateway_id=None, enable_bgp=None, ip_configurations=None, location=None, name=None, resource_group_name=None, sku=None, tags=None, type=None, vpn_client_configuration=None, vpn_type=None):
        """Create a VirtualNetworkGateway resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['active_active'] = active_active

        __props__['bgp_settings'] = bgp_settings

        __props__['default_local_network_gateway_id'] = default_local_network_gateway_id

        __props__['enable_bgp'] = enable_bgp

        if not ip_configurations:
            raise TypeError('Missing required property ip_configurations')
        __props__['ip_configurations'] = ip_configurations

        if not location:
            raise TypeError('Missing required property location')
        __props__['location'] = location

        __props__['name'] = name

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        __props__['resource_group_name'] = resource_group_name

        if not sku:
            raise TypeError('Missing required property sku')
        __props__['sku'] = sku

        __props__['tags'] = tags

        if not type:
            raise TypeError('Missing required property type')
        __props__['type'] = type

        __props__['vpn_client_configuration'] = vpn_client_configuration

        __props__['vpn_type'] = vpn_type

        super(VirtualNetworkGateway, __self__).__init__(
            'azure:network/virtualNetworkGateway:VirtualNetworkGateway',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

