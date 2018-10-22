# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class GetKubernetesClusterResult(object):
    """
    A collection of values returned by getKubernetesCluster.
    """
    def __init__(__self__, addon_profiles=None, agent_pool_profiles=None, dns_prefix=None, fqdn=None, kube_configs=None, kube_config_raw=None, kubernetes_version=None, linux_profiles=None, location=None, network_profiles=None, node_resource_group=None, service_principals=None, tags=None, id=None):
        if addon_profiles and not isinstance(addon_profiles, list):
            raise TypeError('Expected argument addon_profiles to be a list')
        __self__.addon_profiles = addon_profiles
        """
        A `addon_profile` block as documented below.
        """
        if agent_pool_profiles and not isinstance(agent_pool_profiles, list):
            raise TypeError('Expected argument agent_pool_profiles to be a list')
        __self__.agent_pool_profiles = agent_pool_profiles
        """
        One or more `agent_profile_pool` blocks as documented below.
        """
        if dns_prefix and not isinstance(dns_prefix, basestring):
            raise TypeError('Expected argument dns_prefix to be a basestring')
        __self__.dns_prefix = dns_prefix
        """
        The DNS Prefix of the managed Kubernetes cluster.
        """
        if fqdn and not isinstance(fqdn, basestring):
            raise TypeError('Expected argument fqdn to be a basestring')
        __self__.fqdn = fqdn
        """
        The FQDN of the Azure Kubernetes Managed Cluster.
        """
        if kube_configs and not isinstance(kube_configs, list):
            raise TypeError('Expected argument kube_configs to be a list')
        __self__.kube_configs = kube_configs
        """
        A `kube_config` block as defined below.
        """
        if kube_config_raw and not isinstance(kube_config_raw, basestring):
            raise TypeError('Expected argument kube_config_raw to be a basestring')
        __self__.kube_config_raw = kube_config_raw
        """
        Base64 encoded Kubernetes configuration.
        """
        if kubernetes_version and not isinstance(kubernetes_version, basestring):
            raise TypeError('Expected argument kubernetes_version to be a basestring')
        __self__.kubernetes_version = kubernetes_version
        """
        The version of Kubernetes used on the managed Kubernetes Cluster.
        """
        if linux_profiles and not isinstance(linux_profiles, list):
            raise TypeError('Expected argument linux_profiles to be a list')
        __self__.linux_profiles = linux_profiles
        """
        A `linux_profile` block as documented below.
        """
        if location and not isinstance(location, basestring):
            raise TypeError('Expected argument location to be a basestring')
        __self__.location = location
        """
        The Azure Region in which the managed Kubernetes Cluster exists.
        """
        if network_profiles and not isinstance(network_profiles, list):
            raise TypeError('Expected argument network_profiles to be a list')
        __self__.network_profiles = network_profiles
        """
        A `network_profile` block as documented below.
        """
        if node_resource_group and not isinstance(node_resource_group, basestring):
            raise TypeError('Expected argument node_resource_group to be a basestring')
        __self__.node_resource_group = node_resource_group
        """
        Auto-generated Resource Group containing AKS Cluster resources.
        """
        if service_principals and not isinstance(service_principals, list):
            raise TypeError('Expected argument service_principals to be a list')
        __self__.service_principals = service_principals
        """
        A `service_principal` block as documented below.
        """
        if tags and not isinstance(tags, dict):
            raise TypeError('Expected argument tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags assigned to this resource.
        """
        if id and not isinstance(id, basestring):
            raise TypeError('Expected argument id to be a basestring')
        __self__.id = id
        """
        id is the provider-assigned unique ID for this managed resource.
        """

def get_kubernetes_cluster(name=None, resource_group_name=None):
    """
    Use this data source to access information about an existing Managed Kubernetes Cluster (AKS).
    
    ~> **Note:** All arguments including the client secret will be stored in the raw state as plain-text.
    [Read more about sensitive data in state](https://www.terraform.io/docs/state/sensitive-data.html).
    """
    __args__ = dict()

    __args__['name'] = name
    __args__['resourceGroupName'] = resource_group_name
    __ret__ = pulumi.runtime.invoke('azure:containerservice/getKubernetesCluster:getKubernetesCluster', __args__)

    return GetKubernetesClusterResult(
        addon_profiles=__ret__.get('addonProfiles'),
        agent_pool_profiles=__ret__.get('agentPoolProfiles'),
        dns_prefix=__ret__.get('dnsPrefix'),
        fqdn=__ret__.get('fqdn'),
        kube_configs=__ret__.get('kubeConfigs'),
        kube_config_raw=__ret__.get('kubeConfigRaw'),
        kubernetes_version=__ret__.get('kubernetesVersion'),
        linux_profiles=__ret__.get('linuxProfiles'),
        location=__ret__.get('location'),
        network_profiles=__ret__.get('networkProfiles'),
        node_resource_group=__ret__.get('nodeResourceGroup'),
        service_principals=__ret__.get('servicePrincipals'),
        tags=__ret__.get('tags'),
        id=__ret__.get('id'))
