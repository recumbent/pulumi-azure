# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables


class Module(pulumi.CustomResource):
    location: pulumi.Output[str]
    """
    The Azure Region where the Dedicated Hardware Security Module should exist. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    name: pulumi.Output[str]
    """
    The name which should be used for this Dedicated Hardware Security Module. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    network_profile: pulumi.Output[dict]
    """
    A `network_profile` block as defined below.

      * `networkInterfacePrivateIpAddresses` (`list`) - The private IPv4 address of the network interface. Changing this forces a new Dedicated Hardware Security Module to be created.
      * `subnet_id` (`str`) - The ID of the subnet. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the Resource Group where the Dedicated Hardware Security Module should exist. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    sku_name: pulumi.Output[str]
    """
    The sku name of the dedicated hardware security module. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    stamp_id: pulumi.Output[str]
    """
    The ID of the stamp. Possible values are `stamp1` or `stamp2`. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags which should be assigned to the Dedicated Hardware Security Module.
    """
    zones: pulumi.Output[list]
    """
    The Dedicated Hardware Security Module zones. Changing this forces a new Dedicated Hardware Security Module to be created.
    """
    def __init__(__self__, resource_name, opts=None, location=None, name=None, network_profile=None, resource_group_name=None, sku_name=None, stamp_id=None, tags=None, zones=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Dedicated Hardware Security Module.

        > **Note**: Before using this resource, it's required to submit the request of registering the providers and features with Azure CLI `az provider register --namespace Microsoft.HardwareSecurityModules && az feature register --namespace Microsoft.HardwareSecurityModules --name AzureDedicatedHSM && az provider register --namespace Microsoft.Network && az feature register --namespace Microsoft.Network --name AllowBaremetalServers` and ask service team (hsmrequest@microsoft.com) to approve. See more details from https://docs.microsoft.com/en-us/azure/dedicated-hsm/tutorial-deploy-hsm-cli#prerequisites.

        > **Note**: If the quota is not enough in some region, please submit the quota request to service team.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_virtual_network = azure.network.VirtualNetwork("exampleVirtualNetwork",
            address_spaces=["10.2.0.0/16"],
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name)
        example_subnet = azure.network.Subnet("exampleSubnet",
            resource_group_name=example_resource_group.name,
            virtual_network_name=example_virtual_network.name,
            address_prefixes=["10.2.0.0/24"])
        example2 = azure.network.Subnet("example2",
            resource_group_name=example_resource_group.name,
            virtual_network_name=example_virtual_network.name,
            address_prefixes=["10.2.1.0/24"],
            delegations=[{
                "name": "first",
                "serviceDelegation": {
                    "name": "Microsoft.HardwareSecurityModules/dedicatedHSMs",
                    "actions": [
                        "Microsoft.Network/networkinterfaces/*",
                        "Microsoft.Network/virtualNetworks/subnets/join/action",
                    ],
                },
            }])
        example3 = azure.network.Subnet("example3",
            resource_group_name=example_resource_group.name,
            virtual_network_name=example_virtual_network.name,
            address_prefixes=["10.2.255.0/26"])
        example_public_ip = azure.network.PublicIp("examplePublicIp",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            allocation_method="Dynamic")
        example_virtual_network_gateway = azure.network.VirtualNetworkGateway("exampleVirtualNetworkGateway",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            type="ExpressRoute",
            vpn_type="PolicyBased",
            sku="Standard",
            ip_configurations=[{
                "public_ip_address_id": example_public_ip.id,
                "privateIpAddressAllocation": "Dynamic",
                "subnet_id": example3.id,
            }])
        example_module = azure.hsm.Module("exampleModule",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            sku_name="SafeNet Luna Network HSM A790",
            network_profile={
                "networkInterfacePrivateIpAddresses": ["10.2.1.8"],
                "subnet_id": example2.id,
            },
            stamp_id="stamp2",
            tags={
                "env": "Test",
            },
            opts=ResourceOptions(depends_on=[example_virtual_network_gateway]))
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: The Azure Region where the Dedicated Hardware Security Module should exist. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[str] name: The name which should be used for this Dedicated Hardware Security Module. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[dict] network_profile: A `network_profile` block as defined below.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group where the Dedicated Hardware Security Module should exist. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[str] sku_name: The sku name of the dedicated hardware security module. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[str] stamp_id: The ID of the stamp. Possible values are `stamp1` or `stamp2`. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[dict] tags: A mapping of tags which should be assigned to the Dedicated Hardware Security Module.
        :param pulumi.Input[list] zones: The Dedicated Hardware Security Module zones. Changing this forces a new Dedicated Hardware Security Module to be created.

        The **network_profile** object supports the following:

          * `networkInterfacePrivateIpAddresses` (`pulumi.Input[list]`) - The private IPv4 address of the network interface. Changing this forces a new Dedicated Hardware Security Module to be created.
          * `subnet_id` (`pulumi.Input[str]`) - The ID of the subnet. Changing this forces a new Dedicated Hardware Security Module to be created.
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
            opts.version = utilities.get_version()
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = dict()

            __props__['location'] = location
            __props__['name'] = name
            if network_profile is None:
                raise TypeError("Missing required property 'network_profile'")
            __props__['network_profile'] = network_profile
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku_name is None:
                raise TypeError("Missing required property 'sku_name'")
            __props__['sku_name'] = sku_name
            if stamp_id is None:
                raise TypeError("Missing required property 'stamp_id'")
            __props__['stamp_id'] = stamp_id
            __props__['tags'] = tags
            __props__['zones'] = zones
        super(Module, __self__).__init__(
            'azure:hsm/module:Module',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, location=None, name=None, network_profile=None, resource_group_name=None, sku_name=None, stamp_id=None, tags=None, zones=None):
        """
        Get an existing Module resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] location: The Azure Region where the Dedicated Hardware Security Module should exist. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[str] name: The name which should be used for this Dedicated Hardware Security Module. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[dict] network_profile: A `network_profile` block as defined below.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group where the Dedicated Hardware Security Module should exist. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[str] sku_name: The sku name of the dedicated hardware security module. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[str] stamp_id: The ID of the stamp. Possible values are `stamp1` or `stamp2`. Changing this forces a new Dedicated Hardware Security Module to be created.
        :param pulumi.Input[dict] tags: A mapping of tags which should be assigned to the Dedicated Hardware Security Module.
        :param pulumi.Input[list] zones: The Dedicated Hardware Security Module zones. Changing this forces a new Dedicated Hardware Security Module to be created.

        The **network_profile** object supports the following:

          * `networkInterfacePrivateIpAddresses` (`pulumi.Input[list]`) - The private IPv4 address of the network interface. Changing this forces a new Dedicated Hardware Security Module to be created.
          * `subnet_id` (`pulumi.Input[str]`) - The ID of the subnet. Changing this forces a new Dedicated Hardware Security Module to be created.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["location"] = location
        __props__["name"] = name
        __props__["network_profile"] = network_profile
        __props__["resource_group_name"] = resource_group_name
        __props__["sku_name"] = sku_name
        __props__["stamp_id"] = stamp_id
        __props__["tags"] = tags
        __props__["zones"] = zones
        return Module(resource_name, opts=opts, __props__=__props__)

    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop