# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetExpressRouteCircuitResult:
    """
    A collection of values returned by getExpressRouteCircuit.
    """
    def __init__(__self__, id=None, location=None, name=None, peerings=None, resource_group_name=None, service_key=None, service_provider_properties=None, service_provider_provisioning_state=None, sku=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        __self__.location = location
        """
        The Azure location where the ExpressRoute circuit exists
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if peerings and not isinstance(peerings, list):
            raise TypeError("Expected argument 'peerings' to be a list")
        __self__.peerings = peerings
        """
        A `peerings` block for the ExpressRoute circuit as documented below
        """
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if service_key and not isinstance(service_key, str):
            raise TypeError("Expected argument 'service_key' to be a str")
        __self__.service_key = service_key
        """
        The string needed by the service provider to provision the ExpressRoute circuit.
        """
        if service_provider_properties and not isinstance(service_provider_properties, list):
            raise TypeError("Expected argument 'service_provider_properties' to be a list")
        __self__.service_provider_properties = service_provider_properties
        """
        A `service_provider_properties` block for the ExpressRoute circuit as documented below
        """
        if service_provider_provisioning_state and not isinstance(service_provider_provisioning_state, str):
            raise TypeError("Expected argument 'service_provider_provisioning_state' to be a str")
        __self__.service_provider_provisioning_state = service_provider_provisioning_state
        """
        The ExpressRoute circuit provisioning state from your chosen service provider. Possible values are "NotProvisioned", "Provisioning", "Provisioned", and "Deprovisioning".
        """
        if sku and not isinstance(sku, dict):
            raise TypeError("Expected argument 'sku' to be a dict")
        __self__.sku = sku
        """
        A `sku` block for the ExpressRoute circuit as documented below.
        """
class AwaitableGetExpressRouteCircuitResult(GetExpressRouteCircuitResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetExpressRouteCircuitResult(
            id=self.id,
            location=self.location,
            name=self.name,
            peerings=self.peerings,
            resource_group_name=self.resource_group_name,
            service_key=self.service_key,
            service_provider_properties=self.service_provider_properties,
            service_provider_provisioning_state=self.service_provider_provisioning_state,
            sku=self.sku)

def get_express_route_circuit(name=None,resource_group_name=None,opts=None):
    """
    Use this data source to access information about an existing ExpressRoute circuit.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.network.get_express_route_circuit(resource_group_name=azurerm_resource_group["example"]["name"],
        name=azurerm_express_route_circuit["example"]["name"])
    pulumi.export("expressRouteCircuitId", example.id)
    pulumi.export("serviceKey", example.service_key)
    ```



    :param str name: The name of the ExpressRoute circuit.
    :param str resource_group_name: The Name of the Resource Group where the ExpressRoute circuit exists.
    """
    __args__ = dict()


    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:network/getExpressRouteCircuit:getExpressRouteCircuit', __args__, opts=opts).value

    return AwaitableGetExpressRouteCircuitResult(
        id=__ret__.get('id'),
        location=__ret__.get('location'),
        name=__ret__.get('name'),
        peerings=__ret__.get('peerings'),
        resource_group_name=__ret__.get('resourceGroupName'),
        service_key=__ret__.get('serviceKey'),
        service_provider_properties=__ret__.get('serviceProviderProperties'),
        service_provider_provisioning_state=__ret__.get('serviceProviderProvisioningState'),
        sku=__ret__.get('sku'))
