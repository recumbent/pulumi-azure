# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetKeyResult:
    """
    A collection of values returned by getKey.
    """
    def __init__(__self__, e=None, id=None, key_opts=None, key_size=None, key_type=None, key_vault_id=None, n=None, name=None, tags=None, version=None):
        if e and not isinstance(e, str):
            raise TypeError("Expected argument 'e' to be a str")
        __self__.e = e
        """
        The RSA public exponent of this Key Vault Key.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if key_opts and not isinstance(key_opts, list):
            raise TypeError("Expected argument 'key_opts' to be a list")
        __self__.key_opts = key_opts
        """
        A list of JSON web key operations assigned to this Key Vault Key
        """
        if key_size and not isinstance(key_size, float):
            raise TypeError("Expected argument 'key_size' to be a float")
        __self__.key_size = key_size
        """
        Specifies the Size of this Key Vault Key.
        """
        if key_type and not isinstance(key_type, str):
            raise TypeError("Expected argument 'key_type' to be a str")
        __self__.key_type = key_type
        """
        Specifies the Key Type of this Key Vault Key
        """
        if key_vault_id and not isinstance(key_vault_id, str):
            raise TypeError("Expected argument 'key_vault_id' to be a str")
        __self__.key_vault_id = key_vault_id
        if n and not isinstance(n, str):
            raise TypeError("Expected argument 'n' to be a str")
        __self__.n = n
        """
        The RSA modulus of this Key Vault Key.
        """
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if tags and not isinstance(tags, dict):
            raise TypeError("Expected argument 'tags' to be a dict")
        __self__.tags = tags
        """
        A mapping of tags assigned to this Key Vault Key.
        """
        if version and not isinstance(version, str):
            raise TypeError("Expected argument 'version' to be a str")
        __self__.version = version
        """
        The current version of the Key Vault Key.
        """
class AwaitableGetKeyResult(GetKeyResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetKeyResult(
            e=self.e,
            id=self.id,
            key_opts=self.key_opts,
            key_size=self.key_size,
            key_type=self.key_type,
            key_vault_id=self.key_vault_id,
            n=self.n,
            name=self.name,
            tags=self.tags,
            version=self.version)

def get_key(key_vault_id=None,name=None,opts=None):
    """
    Use this data source to access information about an existing Key Vault Key.




    :param str key_vault_id: Specifies the ID of the Key Vault instance where the Secret resides, available on the `keyvault.KeyVault` Data Source / Resource. 
    :param str name: Specifies the name of the Key Vault Key.
    """
    __args__ = dict()


    __args__['keyVaultId'] = key_vault_id
    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:keyvault/getKey:getKey', __args__, opts=opts).value

    return AwaitableGetKeyResult(
        e=__ret__.get('e'),
        id=__ret__.get('id'),
        key_opts=__ret__.get('keyOpts'),
        key_size=__ret__.get('keySize'),
        key_type=__ret__.get('keyType'),
        key_vault_id=__ret__.get('keyVaultId'),
        n=__ret__.get('n'),
        name=__ret__.get('name'),
        tags=__ret__.get('tags'),
        version=__ret__.get('version'))
