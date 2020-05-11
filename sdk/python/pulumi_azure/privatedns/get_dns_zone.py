# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetDnsZoneResult:
    """
    A collection of values returned by getDnsZone.
    """
    def __init__(__self__, id=None, max_number_of_record_sets=None, max_number_of_virtual_network_links=None, max_number_of_virtual_network_links_with_registration=None, name=None, number_of_record_sets=None, resource_group_name=None, tags=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if max_number_of_record_sets and not isinstance(max_number_of_record_sets, float):
            raise TypeError("Expected argument 'max_number_of_record_sets' to be a float")
        __self__.max_number_of_record_sets = max_number_of_record_sets
        """
        Maximum number of recordsets that can be created in this Private Zone.
        """
        if max_number_of_virtual_network_links and not isinstance(max_number_of_virtual_network_links, float):
            raise TypeError("Expected argument 'max_number_of_virtual_network_links' to be a float")
        __self__.max_number_of_virtual_network_links = max_number_of_virtual_network_links
        """
        Maximum number of Virtual Networks that can be linked to this Private Zone.
        """
        if max_number_of_virtual_network_links_with_registration and not isinstance(max_number_of_virtual_network_links_with_registration, float):
            raise TypeError("Expected argument 'max_number_of_virtual_network_links_with_registration' to be a float")
        __self__.max_number_of_virtual_network_links_with_registration = max_number_of_virtual_network_links_with_registration
        """
        Maximum number of Virtual Networks that can be linked to this Private Zone with registration enabled.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if number_of_record_sets and not isinstance(number_of_record_sets, float):
            raise TypeError("Expected argument 'number_of_record_sets' to be a float")
        __self__.number_of_record_sets = number_of_record_sets
        """
        The number of recordsets currently in the zone.
        """
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
        """
        A mapping of tags for the zone.
        """
class AwaitableGetDnsZoneResult(GetDnsZoneResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDnsZoneResult(
            id=self.id,
            max_number_of_record_sets=self.max_number_of_record_sets,
            max_number_of_virtual_network_links=self.max_number_of_virtual_network_links,
            max_number_of_virtual_network_links_with_registration=self.max_number_of_virtual_network_links_with_registration,
            name=self.name,
            number_of_record_sets=self.number_of_record_sets,
            resource_group_name=self.resource_group_name,
            tags=self.tags)

def get_dns_zone(name=None,resource_group_name=None,opts=None):
    """
    Use this data source to access information about an existing Private DNS Zone.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.privatedns.get_dns_zone(name="contoso.internal",
        resource_group_name="contoso-dns")
    pulumi.export("privateDnsZoneId", example.id)
    ```



    :param str name: The name of the Private DNS Zone.
    :param str resource_group_name: The Name of the Resource Group where the Private DNS Zone exists.
           If the Name of the Resource Group is not provided, the first Private DNS Zone from the list of Private
           DNS Zones in your subscription that matches `name` will be returned.
    """
    __args__ = dict()


    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:privatedns/getDnsZone:getDnsZone', __args__, opts=opts).value

    return AwaitableGetDnsZoneResult(
        id=__ret__.get('id'),
        max_number_of_record_sets=__ret__.get('maxNumberOfRecordSets'),
        max_number_of_virtual_network_links=__ret__.get('maxNumberOfVirtualNetworkLinks'),
        max_number_of_virtual_network_links_with_registration=__ret__.get('maxNumberOfVirtualNetworkLinksWithRegistration'),
        name=__ret__.get('name'),
        number_of_record_sets=__ret__.get('numberOfRecordSets'),
        resource_group_name=__ret__.get('resourceGroupName'),
        tags=__ret__.get('tags'))
