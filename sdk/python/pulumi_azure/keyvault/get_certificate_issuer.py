# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class GetCertificateIssuerResult:
    """
    A collection of values returned by getCertificateIssuer.
    """
    def __init__(__self__, account_id=None, admins=None, id=None, key_vault_id=None, name=None, org_id=None, provider_name=None):
        if account_id and not isinstance(account_id, str):
            raise TypeError("Expected argument 'account_id' to be a str")
        __self__.account_id = account_id
        """
        The account number with the third-party Certificate Issuer.
        """
        if admins and not isinstance(admins, list):
            raise TypeError("Expected argument 'admins' to be a list")
        __self__.admins = admins
        """
        A list of `admin` blocks as defined below.
        """
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        __self__.id = id
        """
        The provider-assigned unique ID for this managed resource.
        """
        if key_vault_id and not isinstance(key_vault_id, str):
            raise TypeError("Expected argument 'key_vault_id' to be a str")
        __self__.key_vault_id = key_vault_id
        if name and not isinstance(name, str):
            raise TypeError("Expected argument 'name' to be a str")
        __self__.name = name
        if org_id and not isinstance(org_id, str):
            raise TypeError("Expected argument 'org_id' to be a str")
        __self__.org_id = org_id
        """
        The organization ID with the third-party Certificate Issuer.
        """
        if provider_name and not isinstance(provider_name, str):
            raise TypeError("Expected argument 'provider_name' to be a str")
        __self__.provider_name = provider_name
        """
        The name of the third-party Certificate Issuer.
        """
class AwaitableGetCertificateIssuerResult(GetCertificateIssuerResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetCertificateIssuerResult(
            account_id=self.account_id,
            admins=self.admins,
            id=self.id,
            key_vault_id=self.key_vault_id,
            name=self.name,
            org_id=self.org_id,
            provider_name=self.provider_name)

def get_certificate_issuer(key_vault_id=None,name=None,opts=None):
    """
    Use this data source to access information about an existing Key Vault Certificate Issuer.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_azure as azure

    example_key_vault = azure.keyvault.get_key_vault(name="mykeyvault",
        resource_group_name="some-resource-group")
    example_certificate_issuer = azure.keyvault.get_certificate_issuer(name="existing",
        key_vault_id=example_key_vault.id)
    pulumi.export("id", example_certificate_issuer.id)
    ```


    :param str key_vault_id: The ID of the Key Vault in which to locate the Certificate Issuer.
    :param str name: The name of the Key Vault Certificate Issuer.
    """
    __args__ = dict()


    __args__['keyVaultId'] = key_vault_id
    __args__['name'] = name
    if opts is None:
        opts = pulumi.InvokeOptions()
    if opts.version is None:
        opts.version = utilities.get_version()
    __ret__ = pulumi.runtime.invoke('azure:keyvault/getCertificateIssuer:getCertificateIssuer', __args__, opts=opts).value

    return AwaitableGetCertificateIssuerResult(
        account_id=__ret__.get('accountId'),
        admins=__ret__.get('admins'),
        id=__ret__.get('id'),
        key_vault_id=__ret__.get('keyVaultId'),
        name=__ret__.get('name'),
        org_id=__ret__.get('orgId'),
        provider_name=__ret__.get('providerName'))