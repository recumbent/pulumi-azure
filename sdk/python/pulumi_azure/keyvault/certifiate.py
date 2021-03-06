# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables
from . import outputs
from ._inputs import *

__all__ = ['Certifiate']

warnings.warn("azure.keyvault.Certifiate has been deprecated in favor of azure.keyvault.Certificate", DeprecationWarning)


class Certifiate(pulumi.CustomResource):
    warnings.warn("azure.keyvault.Certifiate has been deprecated in favor of azure.keyvault.Certificate", DeprecationWarning)

    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificate: Optional[pulumi.Input[pulumi.InputType['CertifiateCertificateArgs']]] = None,
                 certificate_policy: Optional[pulumi.Input[pulumi.InputType['CertifiateCertificatePolicyArgs']]] = None,
                 key_vault_id: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Key Vault Certificate.

        ## Example Usage
        ### Generating A New Certificate)

        ```python
        import pulumi
        import pulumi_azure as azure

        current = azure.core.get_client_config()
        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_key_vault = azure.keyvault.KeyVault("exampleKeyVault",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            tenant_id=current.tenant_id,
            sku_name="standard",
            access_policies=[azure.keyvault.KeyVaultAccessPolicyArgs(
                tenant_id=current.tenant_id,
                object_id=current.object_id,
                certificate_permissions=[
                    "create",
                    "delete",
                    "deleteissuers",
                    "get",
                    "getissuers",
                    "import",
                    "list",
                    "listissuers",
                    "managecontacts",
                    "manageissuers",
                    "setissuers",
                    "update",
                ],
                key_permissions=[
                    "backup",
                    "create",
                    "decrypt",
                    "delete",
                    "encrypt",
                    "get",
                    "import",
                    "list",
                    "purge",
                    "recover",
                    "restore",
                    "sign",
                    "unwrapKey",
                    "update",
                    "verify",
                    "wrapKey",
                ],
                secret_permissions=[
                    "backup",
                    "delete",
                    "get",
                    "list",
                    "purge",
                    "recover",
                    "restore",
                    "set",
                ],
            )],
            tags={
                "environment": "Production",
            })
        example_certificate = azure.keyvault.Certificate("exampleCertificate",
            key_vault_id=example_key_vault.id,
            certificate_policy=azure.keyvault.CertificateCertificatePolicyArgs(
                issuer_parameters=azure.keyvault.CertificateCertificatePolicyIssuerParametersArgs(
                    name="Self",
                ),
                key_properties={
                    "exportable": True,
                    "key_size": 2048,
                    "key_type": "RSA",
                    "reuseKey": True,
                },
                lifetime_actions=[azure.keyvault.CertificateCertificatePolicyLifetimeActionArgs(
                    action=azure.keyvault.CertificateCertificatePolicyLifetimeActionActionArgs(
                        action_type="AutoRenew",
                    ),
                    trigger=azure.keyvault.CertificateCertificatePolicyLifetimeActionTriggerArgs(
                        days_before_expiry=30,
                    ),
                )],
                secret_properties=azure.keyvault.CertificateCertificatePolicySecretPropertiesArgs(
                    content_type="application/x-pkcs12",
                ),
                x509_certificate_properties=azure.keyvault.CertificateCertificatePolicyX509CertificatePropertiesArgs(
                    extended_key_usages=["1.3.6.1.5.5.7.3.1"],
                    key_usages=[
                        "cRLSign",
                        "dataEncipherment",
                        "digitalSignature",
                        "keyAgreement",
                        "keyCertSign",
                        "keyEncipherment",
                    ],
                    subject_alternative_names=azure.keyvault.CertificateCertificatePolicyX509CertificatePropertiesSubjectAlternativeNamesArgs(
                        dns_names=[
                            "internal.contoso.com",
                            "domain.hello.world",
                        ],
                    ),
                    subject="CN=hello-world",
                    validity_in_months=12,
                ),
            ))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['CertifiateCertificateArgs']] certificate: A `certificate` block as defined below, used to Import an existing certificate.
        :param pulumi.Input[pulumi.InputType['CertifiateCertificatePolicyArgs']] certificate_policy: A `certificate_policy` block as defined below.
        :param pulumi.Input[str] key_vault_id: The ID of the Key Vault where the Certificate should be created.
        :param pulumi.Input[str] name: Specifies the name of the Key Vault Certificate. Changing this forces a new resource to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource.
        """
        pulumi.log.warn("Certifiate is deprecated: azure.keyvault.Certifiate has been deprecated in favor of azure.keyvault.Certificate")
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
            opts.version = _utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['certificate'] = certificate
            if certificate_policy is None:
                raise TypeError("Missing required property 'certificate_policy'")
            __props__['certificate_policy'] = certificate_policy
            if key_vault_id is None:
                raise TypeError("Missing required property 'key_vault_id'")
            __props__['key_vault_id'] = key_vault_id
            __props__['name'] = name
            __props__['tags'] = tags
            __props__['certificate_attributes'] = None
            __props__['certificate_data'] = None
            __props__['secret_id'] = None
            __props__['thumbprint'] = None
            __props__['version'] = None
        super(Certifiate, __self__).__init__(
            'azure:keyvault/certifiate:Certifiate',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            certificate: Optional[pulumi.Input[pulumi.InputType['CertifiateCertificateArgs']]] = None,
            certificate_attributes: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['CertifiateCertificateAttributeArgs']]]]] = None,
            certificate_data: Optional[pulumi.Input[str]] = None,
            certificate_policy: Optional[pulumi.Input[pulumi.InputType['CertifiateCertificatePolicyArgs']]] = None,
            key_vault_id: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            secret_id: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            thumbprint: Optional[pulumi.Input[str]] = None,
            version: Optional[pulumi.Input[str]] = None) -> 'Certifiate':
        """
        Get an existing Certifiate resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['CertifiateCertificateArgs']] certificate: A `certificate` block as defined below, used to Import an existing certificate.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['CertifiateCertificateAttributeArgs']]]] certificate_attributes: A `certificate_attribute` block as defined below.
        :param pulumi.Input[str] certificate_data: The raw Key Vault Certificate data represented as a hexadecimal string.
        :param pulumi.Input[pulumi.InputType['CertifiateCertificatePolicyArgs']] certificate_policy: A `certificate_policy` block as defined below.
        :param pulumi.Input[str] key_vault_id: The ID of the Key Vault where the Certificate should be created.
        :param pulumi.Input[str] name: Specifies the name of the Key Vault Certificate. Changing this forces a new resource to be created.
        :param pulumi.Input[str] secret_id: The ID of the associated Key Vault Secret.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] thumbprint: The X509 Thumbprint of the Key Vault Certificate represented as a hexadecimal string.
        :param pulumi.Input[str] version: The current version of the Key Vault Certificate.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["certificate"] = certificate
        __props__["certificate_attributes"] = certificate_attributes
        __props__["certificate_data"] = certificate_data
        __props__["certificate_policy"] = certificate_policy
        __props__["key_vault_id"] = key_vault_id
        __props__["name"] = name
        __props__["secret_id"] = secret_id
        __props__["tags"] = tags
        __props__["thumbprint"] = thumbprint
        __props__["version"] = version
        return Certifiate(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def certificate(self) -> pulumi.Output[Optional['outputs.CertifiateCertificate']]:
        """
        A `certificate` block as defined below, used to Import an existing certificate.
        """
        return pulumi.get(self, "certificate")

    @property
    @pulumi.getter(name="certificateAttributes")
    def certificate_attributes(self) -> pulumi.Output[List['outputs.CertifiateCertificateAttribute']]:
        """
        A `certificate_attribute` block as defined below.
        """
        return pulumi.get(self, "certificate_attributes")

    @property
    @pulumi.getter(name="certificateData")
    def certificate_data(self) -> pulumi.Output[str]:
        """
        The raw Key Vault Certificate data represented as a hexadecimal string.
        """
        return pulumi.get(self, "certificate_data")

    @property
    @pulumi.getter(name="certificatePolicy")
    def certificate_policy(self) -> pulumi.Output['outputs.CertifiateCertificatePolicy']:
        """
        A `certificate_policy` block as defined below.
        """
        return pulumi.get(self, "certificate_policy")

    @property
    @pulumi.getter(name="keyVaultId")
    def key_vault_id(self) -> pulumi.Output[str]:
        """
        The ID of the Key Vault where the Certificate should be created.
        """
        return pulumi.get(self, "key_vault_id")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the Key Vault Certificate. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="secretId")
    def secret_id(self) -> pulumi.Output[str]:
        """
        The ID of the associated Key Vault Secret.
        """
        return pulumi.get(self, "secret_id")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags to assign to the resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter
    def thumbprint(self) -> pulumi.Output[str]:
        """
        The X509 Thumbprint of the Key Vault Certificate represented as a hexadecimal string.
        """
        return pulumi.get(self, "thumbprint")

    @property
    @pulumi.getter
    def version(self) -> pulumi.Output[str]:
        """
        The current version of the Key Vault Certificate.
        """
        return pulumi.get(self, "version")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

