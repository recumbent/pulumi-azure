# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class Route(pulumi.CustomResource):
    """
    Manages a Route within a Route Table.
    """
    def __init__(__self__, __name__, __opts__=None, address_prefix=None, name=None, next_hop_in_ip_address=None, next_hop_type=None, resource_group_name=None, route_table_name=None):
        """Create a Route resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not address_prefix:
            raise TypeError('Missing required property address_prefix')
        __props__['address_prefix'] = address_prefix

        __props__['name'] = name

        __props__['next_hop_in_ip_address'] = next_hop_in_ip_address

        if not next_hop_type:
            raise TypeError('Missing required property next_hop_type')
        __props__['next_hop_type'] = next_hop_type

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        __props__['resource_group_name'] = resource_group_name

        if not route_table_name:
            raise TypeError('Missing required property route_table_name')
        __props__['route_table_name'] = route_table_name

        super(Route, __self__).__init__(
            'azure:network/route:Route',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

