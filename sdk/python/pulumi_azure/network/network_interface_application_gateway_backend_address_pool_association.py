# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation(pulumi.CustomResource):
    """
    Manages the association between a Network Interface and a Application Gateway's Backend Address Pool.
    """
    def __init__(__self__, __name__, __opts__=None, backend_address_pool_id=None, ip_configuration_name=None, network_interface_id=None):
        """Create a NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not backend_address_pool_id:
            raise TypeError('Missing required property backend_address_pool_id')
        elif not isinstance(backend_address_pool_id, basestring):
            raise TypeError('Expected property backend_address_pool_id to be a basestring')
        __self__.backend_address_pool_id = backend_address_pool_id
        """
        The ID of the Application Gateway's Backend Address Pool which this Network Interface which should be connected to. Changing this forces a new resource to be created.
        """
        __props__['backendAddressPoolId'] = backend_address_pool_id

        if not ip_configuration_name:
            raise TypeError('Missing required property ip_configuration_name')
        elif not isinstance(ip_configuration_name, basestring):
            raise TypeError('Expected property ip_configuration_name to be a basestring')
        __self__.ip_configuration_name = ip_configuration_name
        """
        The Name of the IP Configuration within the Network Interface which should be connected to the Backend Address Pool. Changing this forces a new resource to be created.
        """
        __props__['ipConfigurationName'] = ip_configuration_name

        if not network_interface_id:
            raise TypeError('Missing required property network_interface_id')
        elif not isinstance(network_interface_id, basestring):
            raise TypeError('Expected property network_interface_id to be a basestring')
        __self__.network_interface_id = network_interface_id
        """
        The ID of the Network Interface. Changing this forces a new resource to be created.
        """
        __props__['networkInterfaceId'] = network_interface_id

        super(NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation, __self__).__init__(
            'azure:network/networkInterfaceApplicationGatewayBackendAddressPoolAssociation:NetworkInterfaceApplicationGatewayBackendAddressPoolAssociation',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'backendAddressPoolId' in outs:
            self.backend_address_pool_id = outs['backendAddressPoolId']
        if 'ipConfigurationName' in outs:
            self.ip_configuration_name = outs['ipConfigurationName']
        if 'networkInterfaceId' in outs:
            self.network_interface_id = outs['networkInterfaceId']
