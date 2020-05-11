# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetVolumeResult:
    """
    A collection of values returned by getVolume.
    """
    def __init__(__self__, account_name=None, id=None, location=None, name=None, pool_name=None, protocols=None, resource_group_name=None, service_level=None, storage_quota_in_gb=None, subnet_id=None, volume_path=None):
        if account_name and not isinstance(account_name, str):
            raise TypeError("Expected argument 'account_name' to be a str")
        __self__.account_name = account_name
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
        The Azure Region where the NetApp Volume exists.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if pool_name and not isinstance(pool_name, str):
            raise TypeError("Expected argument 'pool_name' to be a str")
        __self__.pool_name = pool_name
        if protocols and not isinstance(protocols, list):
            raise TypeError("Expected argument 'protocols' to be a list")
        __self__.protocols = protocols
        if resource_group_name and not isinstance(resource_group_name, str):
            raise TypeError("Expected argument 'resource_group_name' to be a str")
        __self__.resource_group_name = resource_group_name
        if service_level and not isinstance(service_level, str):
            raise TypeError("Expected argument 'service_level' to be a str")
        __self__.service_level = service_level
        """
        The service level of the file system.
        """
        if storage_quota_in_gb and not isinstance(storage_quota_in_gb, float):
            raise TypeError("Expected argument 'storage_quota_in_gb' to be a float")
        __self__.storage_quota_in_gb = storage_quota_in_gb
        """
        The maximum Storage Quota in Gigabytes allowed for a file system.
        """
        if subnet_id and not isinstance(subnet_id, str):
            raise TypeError("Expected argument 'subnet_id' to be a str")
        __self__.subnet_id = subnet_id
        """
        The ID of a Subnet in which the NetApp Volume resides.
        """
        if volume_path and not isinstance(volume_path, str):
            raise TypeError("Expected argument 'volume_path' to be a str")
        __self__.volume_path = volume_path
        """
        The unique file path of the volume.
        """
class AwaitableGetVolumeResult(GetVolumeResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetVolumeResult(
            account_name=self.account_name,
            id=self.id,
            location=self.location,
            name=self.name,
            pool_name=self.pool_name,
            protocols=self.protocols,
            resource_group_name=self.resource_group_name,
            service_level=self.service_level,
            storage_quota_in_gb=self.storage_quota_in_gb,
            subnet_id=self.subnet_id,
            volume_path=self.volume_path)

def get_volume(account_name=None,name=None,pool_name=None,resource_group_name=None,opts=None):
    """
    Uses this data source to access information about an existing NetApp Volume.

    ## NetApp Volume Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    example = azure.netapp.get_volume(resource_group_name="acctestRG",
        account_name="acctestnetappaccount",
        pool_name="acctestnetapppool",
        name="example-volume")
    pulumi.export("netappVolumeId", example.id)
    ```


    :param str account_name: The name of the NetApp account where the NetApp pool exists.
    :param str name: The name of the NetApp Volume.
    :param str pool_name: The name of the NetApp pool where the NetApp volume exists.
    :param str resource_group_name: The Name of the Resource Group where the NetApp Volume exists.
    """
    __args__ = dict()


    __args__['accountName'] = account_name
    __args__['name'] = name
    __args__['poolName'] = pool_name
    __args__['resourceGroupName'] = resource_group_name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:netapp/getVolume:getVolume', __args__, opts=opts).value

    return AwaitableGetVolumeResult(
        account_name=__ret__.get('accountName'),
        id=__ret__.get('id'),
        location=__ret__.get('location'),
        name=__ret__.get('name'),
        pool_name=__ret__.get('poolName'),
        protocols=__ret__.get('protocols'),
        resource_group_name=__ret__.get('resourceGroupName'),
        service_level=__ret__.get('serviceLevel'),
        storage_quota_in_gb=__ret__.get('storageQuotaInGb'),
        subnet_id=__ret__.get('subnetId'),
        volume_path=__ret__.get('volumePath'))
