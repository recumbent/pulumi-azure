# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetKubernetesServiceVersionsResult:
    """
    A collection of values returned by getKubernetesServiceVersions.
    """
    def __init__(__self__, id=None, include_preview=None, latest_version=None, location=None, version_prefix=None, versions=None):
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if include_preview and not isinstance(include_preview, bool):
            raise TypeError("Expected argument 'include_preview' to be a bool")
        __self__.include_preview = include_preview
        if latest_version and not isinstance(latest_version, str):
            raise TypeError("Expected argument 'latest_version' to be a str")
        __self__.latest_version = latest_version
        """
        The most recent version available. If `include_preview == false`, this is the most recent non-preview version available.
        """
        if location and not isinstance(location, str):
            raise TypeError("Expected argument 'location' to be a str")
        __self__.location = location
        if version_prefix and not isinstance(version_prefix, str):
            raise TypeError("Expected argument 'version_prefix' to be a str")
        __self__.version_prefix = version_prefix
        if versions and not isinstance(versions, list):
            raise TypeError("Expected argument 'versions' to be a list")
        __self__.versions = versions
        """
        The list of all supported versions.
        """
class AwaitableGetKubernetesServiceVersionsResult(GetKubernetesServiceVersionsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetKubernetesServiceVersionsResult(
            id=self.id,
            include_preview=self.include_preview,
            latest_version=self.latest_version,
            location=self.location,
            version_prefix=self.version_prefix,
            versions=self.versions)

def get_kubernetes_service_versions(include_preview=None,location=None,version_prefix=None,opts=None):
    """
    Use this data source to retrieve the version of Kubernetes supported by Azure Kubernetes Service.

    ## Example Usage



    ```python
    import pulumi
    import pulumi_azure as azure

    current = azure.containerservice.get_kubernetes_service_versions(location="West Europe")
    pulumi.export("versions", current.versions)
    pulumi.export("latestVersion", current.latest_version)
    ```



    :param bool include_preview: Should Preview versions of Kubernetes in AKS be included? Defaults to `true`
    :param str location: Specifies the location in which to query for versions.
    :param str version_prefix: A prefix filter for the versions of Kubernetes which should be returned; for example `1.` will return `1.9` to `1.14`, whereas `1.12` will return `1.12.2`.
    """
    __args__ = dict()


    __args__['includePreview'] = include_preview
    __args__['location'] = location
    __args__['versionPrefix'] = version_prefix
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:containerservice/getKubernetesServiceVersions:getKubernetesServiceVersions', __args__, opts=opts).value

    return AwaitableGetKubernetesServiceVersionsResult(
        id=__ret__.get('id'),
        include_preview=__ret__.get('includePreview'),
        latest_version=__ret__.get('latestVersion'),
        location=__ret__.get('location'),
        version_prefix=__ret__.get('versionPrefix'),
        versions=__ret__.get('versions'))
