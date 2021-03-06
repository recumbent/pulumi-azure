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

__all__ = ['Cluster']


class Cluster(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 add_on_features: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
                 azure_active_directory: Optional[pulumi.Input[pulumi.InputType['ClusterAzureActiveDirectoryArgs']]] = None,
                 certificate: Optional[pulumi.Input[pulumi.InputType['ClusterCertificateArgs']]] = None,
                 certificate_common_names: Optional[pulumi.Input[pulumi.InputType['ClusterCertificateCommonNamesArgs']]] = None,
                 client_certificate_common_names: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateCommonNameArgs']]]]] = None,
                 client_certificate_thumbprints: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateThumbprintArgs']]]]] = None,
                 cluster_code_version: Optional[pulumi.Input[str]] = None,
                 diagnostics_config: Optional[pulumi.Input[pulumi.InputType['ClusterDiagnosticsConfigArgs']]] = None,
                 fabric_settings: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterFabricSettingArgs']]]]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 management_endpoint: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 node_types: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterNodeTypeArgs']]]]] = None,
                 reliability_level: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 reverse_proxy_certificate: Optional[pulumi.Input[pulumi.InputType['ClusterReverseProxyCertificateArgs']]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 upgrade_mode: Optional[pulumi.Input[str]] = None,
                 vm_image: Optional[pulumi.Input[str]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Service Fabric Cluster.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_cluster = azure.servicefabric.Cluster("exampleCluster",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            reliability_level="Bronze",
            upgrade_mode="Manual",
            cluster_code_version="7.1.456.959",
            vm_image="Windows",
            management_endpoint="https://example:80",
            node_types=[azure.servicefabric.ClusterNodeTypeArgs(
                name="first",
                instance_count=3,
                is_primary=True,
                client_endpoint_port=2020,
                http_endpoint_port=80,
            )])
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[List[pulumi.Input[str]]] add_on_features: A List of one or more features which should be enabled, such as `DnsService`.
        :param pulumi.Input[pulumi.InputType['ClusterAzureActiveDirectoryArgs']] azure_active_directory: An `azure_active_directory` block as defined below.
        :param pulumi.Input[pulumi.InputType['ClusterCertificateArgs']] certificate: A `certificate` block as defined below. Conflicts with `certificate_common_names`.
        :param pulumi.Input[pulumi.InputType['ClusterCertificateCommonNamesArgs']] certificate_common_names: A `certificate_common_names` block as defined below. Conflicts with `certificate`.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateCommonNameArgs']]]] client_certificate_common_names: A `client_certificate_common_name` block as defined below.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateThumbprintArgs']]]] client_certificate_thumbprints: One or two `client_certificate_thumbprint` blocks as defined below.
        :param pulumi.Input[str] cluster_code_version: Required if Upgrade Mode set to `Manual`, Specifies the Version of the Cluster Code of the cluster.
        :param pulumi.Input[pulumi.InputType['ClusterDiagnosticsConfigArgs']] diagnostics_config: A `diagnostics_config` block as defined below. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterFabricSettingArgs']]]] fabric_settings: One or more `fabric_settings` blocks as defined below.
        :param pulumi.Input[str] location: Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] management_endpoint: Specifies the Management Endpoint of the cluster such as `http://example.com`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the Service Fabric Cluster. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterNodeTypeArgs']]]] node_types: One or more `node_type` blocks as defined below.
        :param pulumi.Input[str] reliability_level: Specifies the Reliability Level of the Cluster. Possible values include `None`, `Bronze`, `Silver`, `Gold` and `Platinum`.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.
        :param pulumi.Input[pulumi.InputType['ClusterReverseProxyCertificateArgs']] reverse_proxy_certificate: A `reverse_proxy_certificate` block as defined below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] upgrade_mode: Specifies the Upgrade Mode of the cluster. Possible values are `Automatic` or `Manual`.
        :param pulumi.Input[str] vm_image: Specifies the Image expected for the Service Fabric Cluster, such as `Windows`. Changing this forces a new resource to be created.
        """
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

            __props__['add_on_features'] = add_on_features
            __props__['azure_active_directory'] = azure_active_directory
            __props__['certificate'] = certificate
            __props__['certificate_common_names'] = certificate_common_names
            __props__['client_certificate_common_names'] = client_certificate_common_names
            __props__['client_certificate_thumbprints'] = client_certificate_thumbprints
            __props__['cluster_code_version'] = cluster_code_version
            __props__['diagnostics_config'] = diagnostics_config
            __props__['fabric_settings'] = fabric_settings
            __props__['location'] = location
            if management_endpoint is None:
                raise TypeError("Missing required property 'management_endpoint'")
            __props__['management_endpoint'] = management_endpoint
            __props__['name'] = name
            if node_types is None:
                raise TypeError("Missing required property 'node_types'")
            __props__['node_types'] = node_types
            if reliability_level is None:
                raise TypeError("Missing required property 'reliability_level'")
            __props__['reliability_level'] = reliability_level
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['reverse_proxy_certificate'] = reverse_proxy_certificate
            __props__['tags'] = tags
            if upgrade_mode is None:
                raise TypeError("Missing required property 'upgrade_mode'")
            __props__['upgrade_mode'] = upgrade_mode
            if vm_image is None:
                raise TypeError("Missing required property 'vm_image'")
            __props__['vm_image'] = vm_image
            __props__['cluster_endpoint'] = None
        super(Cluster, __self__).__init__(
            'azure:servicefabric/cluster:Cluster',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            add_on_features: Optional[pulumi.Input[List[pulumi.Input[str]]]] = None,
            azure_active_directory: Optional[pulumi.Input[pulumi.InputType['ClusterAzureActiveDirectoryArgs']]] = None,
            certificate: Optional[pulumi.Input[pulumi.InputType['ClusterCertificateArgs']]] = None,
            certificate_common_names: Optional[pulumi.Input[pulumi.InputType['ClusterCertificateCommonNamesArgs']]] = None,
            client_certificate_common_names: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateCommonNameArgs']]]]] = None,
            client_certificate_thumbprints: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateThumbprintArgs']]]]] = None,
            cluster_code_version: Optional[pulumi.Input[str]] = None,
            cluster_endpoint: Optional[pulumi.Input[str]] = None,
            diagnostics_config: Optional[pulumi.Input[pulumi.InputType['ClusterDiagnosticsConfigArgs']]] = None,
            fabric_settings: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterFabricSettingArgs']]]]] = None,
            location: Optional[pulumi.Input[str]] = None,
            management_endpoint: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None,
            node_types: Optional[pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterNodeTypeArgs']]]]] = None,
            reliability_level: Optional[pulumi.Input[str]] = None,
            resource_group_name: Optional[pulumi.Input[str]] = None,
            reverse_proxy_certificate: Optional[pulumi.Input[pulumi.InputType['ClusterReverseProxyCertificateArgs']]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
            upgrade_mode: Optional[pulumi.Input[str]] = None,
            vm_image: Optional[pulumi.Input[str]] = None) -> 'Cluster':
        """
        Get an existing Cluster resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[List[pulumi.Input[str]]] add_on_features: A List of one or more features which should be enabled, such as `DnsService`.
        :param pulumi.Input[pulumi.InputType['ClusterAzureActiveDirectoryArgs']] azure_active_directory: An `azure_active_directory` block as defined below.
        :param pulumi.Input[pulumi.InputType['ClusterCertificateArgs']] certificate: A `certificate` block as defined below. Conflicts with `certificate_common_names`.
        :param pulumi.Input[pulumi.InputType['ClusterCertificateCommonNamesArgs']] certificate_common_names: A `certificate_common_names` block as defined below. Conflicts with `certificate`.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateCommonNameArgs']]]] client_certificate_common_names: A `client_certificate_common_name` block as defined below.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterClientCertificateThumbprintArgs']]]] client_certificate_thumbprints: One or two `client_certificate_thumbprint` blocks as defined below.
        :param pulumi.Input[str] cluster_code_version: Required if Upgrade Mode set to `Manual`, Specifies the Version of the Cluster Code of the cluster.
        :param pulumi.Input[str] cluster_endpoint: The Cluster Endpoint for this Service Fabric Cluster.
        :param pulumi.Input[pulumi.InputType['ClusterDiagnosticsConfigArgs']] diagnostics_config: A `diagnostics_config` block as defined below. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterFabricSettingArgs']]]] fabric_settings: One or more `fabric_settings` blocks as defined below.
        :param pulumi.Input[str] location: Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] management_endpoint: Specifies the Management Endpoint of the cluster such as `http://example.com`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: The name of the Service Fabric Cluster. Changing this forces a new resource to be created.
        :param pulumi.Input[List[pulumi.Input[pulumi.InputType['ClusterNodeTypeArgs']]]] node_types: One or more `node_type` blocks as defined below.
        :param pulumi.Input[str] reliability_level: Specifies the Reliability Level of the Cluster. Possible values include `None`, `Bronze`, `Silver`, `Gold` and `Platinum`.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.
        :param pulumi.Input[pulumi.InputType['ClusterReverseProxyCertificateArgs']] reverse_proxy_certificate: A `reverse_proxy_certificate` block as defined below.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] upgrade_mode: Specifies the Upgrade Mode of the cluster. Possible values are `Automatic` or `Manual`.
        :param pulumi.Input[str] vm_image: Specifies the Image expected for the Service Fabric Cluster, such as `Windows`. Changing this forces a new resource to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["add_on_features"] = add_on_features
        __props__["azure_active_directory"] = azure_active_directory
        __props__["certificate"] = certificate
        __props__["certificate_common_names"] = certificate_common_names
        __props__["client_certificate_common_names"] = client_certificate_common_names
        __props__["client_certificate_thumbprints"] = client_certificate_thumbprints
        __props__["cluster_code_version"] = cluster_code_version
        __props__["cluster_endpoint"] = cluster_endpoint
        __props__["diagnostics_config"] = diagnostics_config
        __props__["fabric_settings"] = fabric_settings
        __props__["location"] = location
        __props__["management_endpoint"] = management_endpoint
        __props__["name"] = name
        __props__["node_types"] = node_types
        __props__["reliability_level"] = reliability_level
        __props__["resource_group_name"] = resource_group_name
        __props__["reverse_proxy_certificate"] = reverse_proxy_certificate
        __props__["tags"] = tags
        __props__["upgrade_mode"] = upgrade_mode
        __props__["vm_image"] = vm_image
        return Cluster(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="addOnFeatures")
    def add_on_features(self) -> pulumi.Output[Optional[List[str]]]:
        """
        A List of one or more features which should be enabled, such as `DnsService`.
        """
        return pulumi.get(self, "add_on_features")

    @property
    @pulumi.getter(name="azureActiveDirectory")
    def azure_active_directory(self) -> pulumi.Output[Optional['outputs.ClusterAzureActiveDirectory']]:
        """
        An `azure_active_directory` block as defined below.
        """
        return pulumi.get(self, "azure_active_directory")

    @property
    @pulumi.getter
    def certificate(self) -> pulumi.Output[Optional['outputs.ClusterCertificate']]:
        """
        A `certificate` block as defined below. Conflicts with `certificate_common_names`.
        """
        return pulumi.get(self, "certificate")

    @property
    @pulumi.getter(name="certificateCommonNames")
    def certificate_common_names(self) -> pulumi.Output[Optional['outputs.ClusterCertificateCommonNames']]:
        """
        A `certificate_common_names` block as defined below. Conflicts with `certificate`.
        """
        return pulumi.get(self, "certificate_common_names")

    @property
    @pulumi.getter(name="clientCertificateCommonNames")
    def client_certificate_common_names(self) -> pulumi.Output[Optional[List['outputs.ClusterClientCertificateCommonName']]]:
        """
        A `client_certificate_common_name` block as defined below.
        """
        return pulumi.get(self, "client_certificate_common_names")

    @property
    @pulumi.getter(name="clientCertificateThumbprints")
    def client_certificate_thumbprints(self) -> pulumi.Output[Optional[List['outputs.ClusterClientCertificateThumbprint']]]:
        """
        One or two `client_certificate_thumbprint` blocks as defined below.
        """
        return pulumi.get(self, "client_certificate_thumbprints")

    @property
    @pulumi.getter(name="clusterCodeVersion")
    def cluster_code_version(self) -> pulumi.Output[str]:
        """
        Required if Upgrade Mode set to `Manual`, Specifies the Version of the Cluster Code of the cluster.
        """
        return pulumi.get(self, "cluster_code_version")

    @property
    @pulumi.getter(name="clusterEndpoint")
    def cluster_endpoint(self) -> pulumi.Output[str]:
        """
        The Cluster Endpoint for this Service Fabric Cluster.
        """
        return pulumi.get(self, "cluster_endpoint")

    @property
    @pulumi.getter(name="diagnosticsConfig")
    def diagnostics_config(self) -> pulumi.Output[Optional['outputs.ClusterDiagnosticsConfig']]:
        """
        A `diagnostics_config` block as defined below. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "diagnostics_config")

    @property
    @pulumi.getter(name="fabricSettings")
    def fabric_settings(self) -> pulumi.Output[Optional[List['outputs.ClusterFabricSetting']]]:
        """
        One or more `fabric_settings` blocks as defined below.
        """
        return pulumi.get(self, "fabric_settings")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Specifies the Azure Region where the Service Fabric Cluster should exist. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="managementEndpoint")
    def management_endpoint(self) -> pulumi.Output[str]:
        """
        Specifies the Management Endpoint of the cluster such as `http://example.com`. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "management_endpoint")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the Service Fabric Cluster. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="nodeTypes")
    def node_types(self) -> pulumi.Output[List['outputs.ClusterNodeType']]:
        """
        One or more `node_type` blocks as defined below.
        """
        return pulumi.get(self, "node_types")

    @property
    @pulumi.getter(name="reliabilityLevel")
    def reliability_level(self) -> pulumi.Output[str]:
        """
        Specifies the Reliability Level of the Cluster. Possible values include `None`, `Bronze`, `Silver`, `Gold` and `Platinum`.
        """
        return pulumi.get(self, "reliability_level")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Output[str]:
        """
        The name of the Resource Group in which the Service Fabric Cluster exists. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter(name="reverseProxyCertificate")
    def reverse_proxy_certificate(self) -> pulumi.Output[Optional['outputs.ClusterReverseProxyCertificate']]:
        """
        A `reverse_proxy_certificate` block as defined below.
        """
        return pulumi.get(self, "reverse_proxy_certificate")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags to assign to the resource.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="upgradeMode")
    def upgrade_mode(self) -> pulumi.Output[str]:
        """
        Specifies the Upgrade Mode of the cluster. Possible values are `Automatic` or `Manual`.
        """
        return pulumi.get(self, "upgrade_mode")

    @property
    @pulumi.getter(name="vmImage")
    def vm_image(self) -> pulumi.Output[str]:
        """
        Specifies the Image expected for the Service Fabric Cluster, such as `Windows`. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "vm_image")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

