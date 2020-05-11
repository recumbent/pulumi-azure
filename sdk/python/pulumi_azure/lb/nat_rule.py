# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class NatRule(pulumi.CustomResource):
    backend_ip_configuration_id: pulumi.Output[str]
    backend_port: pulumi.Output[float]
    """
    The port used for internal connections on the endpoint. Possible values range between 1 and 65535, inclusive.
    """
    enable_floating_ip: pulumi.Output[bool]
    """
    Are the Floating IPs enabled for this Load Balncer Rule? A "floating” IP is reassigned to a secondary server in case the primary server fails. Required to configure a SQL AlwaysOn Availability Group. Defaults to `false`.
    """
    enable_tcp_reset: pulumi.Output[bool]
    """
    Is TCP Reset enabled for this Load Balancer Rule? Defaults to `false`.
    """
    frontend_ip_configuration_id: pulumi.Output[str]
    frontend_ip_configuration_name: pulumi.Output[str]
    """
    The name of the frontend IP configuration exposing this rule.
    """
    frontend_port: pulumi.Output[float]
    """
    The port for the external endpoint. Port numbers for each Rule must be unique within the Load Balancer. Possible values range between 1 and 65534, inclusive.
    """
    idle_timeout_in_minutes: pulumi.Output[float]
    """
    Specifies the idle timeout in minutes for TCP connections. Valid values are between `4` and `30` minutes. Defaults to `4` minutes.
    """
    loadbalancer_id: pulumi.Output[str]
    """
    The ID of the Load Balancer in which to create the NAT Rule.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the NAT Rule.
    """
    protocol: pulumi.Output[str]
    """
    The transport protocol for the external endpoint. Possible values are `Udp`, `Tcp` or `All`.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the resource.
    """
    def __init__(__self__, resource_name, opts=None, backend_port=None, enable_floating_ip=None, enable_tcp_reset=None, frontend_ip_configuration_name=None, frontend_port=None, idle_timeout_in_minutes=None, loadbalancer_id=None, name=None, protocol=None, resource_group_name=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Load Balancer NAT Rule.

        > **NOTE:** This resource cannot be used with with virtual machine scale sets, instead use the `lb.NatPool` resource.

        > **NOTE** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration Attached

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West US")
        example_public_ip = azure.network.PublicIp("examplePublicIp",
            location="West US",
            resource_group_name=example_resource_group.name,
            allocation_method="Static")
        example_load_balancer = azure.lb.LoadBalancer("exampleLoadBalancer",
            location="West US",
            resource_group_name=example_resource_group.name,
            frontend_ip_configuration=[{
                "name": "PublicIPAddress",
                "publicIpAddressId": example_public_ip.id,
            }])
        example_nat_rule = azure.lb.NatRule("exampleNatRule",
            resource_group_name=example_resource_group.name,
            loadbalancer_id=example_load_balancer.id,
            protocol="Tcp",
            frontend_port=3389,
            backend_port=3389,
            frontend_ip_configuration_name="PublicIPAddress")
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] backend_port: The port used for internal connections on the endpoint. Possible values range between 1 and 65535, inclusive.
        :param pulumi.Input[bool] enable_floating_ip: Are the Floating IPs enabled for this Load Balncer Rule? A "floating” IP is reassigned to a secondary server in case the primary server fails. Required to configure a SQL AlwaysOn Availability Group. Defaults to `false`.
        :param pulumi.Input[bool] enable_tcp_reset: Is TCP Reset enabled for this Load Balancer Rule? Defaults to `false`.
        :param pulumi.Input[str] frontend_ip_configuration_name: The name of the frontend IP configuration exposing this rule.
        :param pulumi.Input[float] frontend_port: The port for the external endpoint. Port numbers for each Rule must be unique within the Load Balancer. Possible values range between 1 and 65534, inclusive.
        :param pulumi.Input[float] idle_timeout_in_minutes: Specifies the idle timeout in minutes for TCP connections. Valid values are between `4` and `30` minutes. Defaults to `4` minutes.
        :param pulumi.Input[str] loadbalancer_id: The ID of the Load Balancer in which to create the NAT Rule.
        :param pulumi.Input[str] name: Specifies the name of the NAT Rule.
        :param pulumi.Input[str] protocol: The transport protocol for the external endpoint. Possible values are `Udp`, `Tcp` or `All`.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the resource.
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

            if backend_port is None:
                raise TypeError("Missing required property 'backend_port'")
            __props__['backend_port'] = backend_port
            __props__['enable_floating_ip'] = enable_floating_ip
            __props__['enable_tcp_reset'] = enable_tcp_reset
            if frontend_ip_configuration_name is None:
                raise TypeError("Missing required property 'frontend_ip_configuration_name'")
            __props__['frontend_ip_configuration_name'] = frontend_ip_configuration_name
            if frontend_port is None:
                raise TypeError("Missing required property 'frontend_port'")
            __props__['frontend_port'] = frontend_port
            __props__['idle_timeout_in_minutes'] = idle_timeout_in_minutes
            if loadbalancer_id is None:
                raise TypeError("Missing required property 'loadbalancer_id'")
            __props__['loadbalancer_id'] = loadbalancer_id
            __props__['name'] = name
            if protocol is None:
                raise TypeError("Missing required property 'protocol'")
            __props__['protocol'] = protocol
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['backend_ip_configuration_id'] = None
            __props__['frontend_ip_configuration_id'] = None
        super(NatRule, __self__).__init__(
            'azure:lb/natRule:NatRule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, backend_ip_configuration_id=None, backend_port=None, enable_floating_ip=None, enable_tcp_reset=None, frontend_ip_configuration_id=None, frontend_ip_configuration_name=None, frontend_port=None, idle_timeout_in_minutes=None, loadbalancer_id=None, name=None, protocol=None, resource_group_name=None):
        """
        Get an existing NatRule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] backend_port: The port used for internal connections on the endpoint. Possible values range between 1 and 65535, inclusive.
        :param pulumi.Input[bool] enable_floating_ip: Are the Floating IPs enabled for this Load Balncer Rule? A "floating” IP is reassigned to a secondary server in case the primary server fails. Required to configure a SQL AlwaysOn Availability Group. Defaults to `false`.
        :param pulumi.Input[bool] enable_tcp_reset: Is TCP Reset enabled for this Load Balancer Rule? Defaults to `false`.
        :param pulumi.Input[str] frontend_ip_configuration_name: The name of the frontend IP configuration exposing this rule.
        :param pulumi.Input[float] frontend_port: The port for the external endpoint. Port numbers for each Rule must be unique within the Load Balancer. Possible values range between 1 and 65534, inclusive.
        :param pulumi.Input[float] idle_timeout_in_minutes: Specifies the idle timeout in minutes for TCP connections. Valid values are between `4` and `30` minutes. Defaults to `4` minutes.
        :param pulumi.Input[str] loadbalancer_id: The ID of the Load Balancer in which to create the NAT Rule.
        :param pulumi.Input[str] name: Specifies the name of the NAT Rule.
        :param pulumi.Input[str] protocol: The transport protocol for the external endpoint. Possible values are `Udp`, `Tcp` or `All`.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["backend_ip_configuration_id"] = backend_ip_configuration_id
        __props__["backend_port"] = backend_port
        __props__["enable_floating_ip"] = enable_floating_ip
        __props__["enable_tcp_reset"] = enable_tcp_reset
        __props__["frontend_ip_configuration_id"] = frontend_ip_configuration_id
        __props__["frontend_ip_configuration_name"] = frontend_ip_configuration_name
        __props__["frontend_port"] = frontend_port
        __props__["idle_timeout_in_minutes"] = idle_timeout_in_minutes
        __props__["loadbalancer_id"] = loadbalancer_id
        __props__["name"] = name
        __props__["protocol"] = protocol
        __props__["resource_group_name"] = resource_group_name
        return NatRule(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

