# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class CustomHostnameBinding(pulumi.CustomResource):
    app_service_name: pulumi.Output[str]
    """
    The name of the App Service in which to add the Custom Hostname Binding. Changing this forces a new resource to be created.
    """
    hostname: pulumi.Output[str]
    """
    Specifies the Custom Hostname to use for the App Service, example `www.example.com`. Changing this forces a new resource to be created.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which the App Service exists. Changing this forces a new resource to be created.
    """
    ssl_state: pulumi.Output[str]
    """
    The SSL type. Possible values are `IpBasedEnabled` and `SniEnabled`. Changing this forces a new resource to be created.
    """
    thumbprint: pulumi.Output[str]
    """
    The SSL certificate thumbprint. Changing this forces a new resource to be created.
    """
    virtual_ip: pulumi.Output[str]
    """
    The virtual IP address assigned to the hostname if IP based SSL is enabled.
    """
    def __init__(__self__, resource_name, opts=None, app_service_name=None, hostname=None, resource_group_name=None, ssl_state=None, thumbprint=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Hostname Binding within an App Service.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure
        import pulumi_random as random

        server = random.RandomId("server",
            keepers={
                "azi_id": 1,
            },
            byte_length=8)
        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_plan = azure.appservice.Plan("examplePlan",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            sku={
                "tier": "Standard",
                "size": "S1",
            })
        example_app_service = azure.appservice.AppService("exampleAppService",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            app_service_plan_id=example_plan.id)
        example_custom_hostname_binding = azure.appservice.CustomHostnameBinding("exampleCustomHostnameBinding",
            hostname="www.mywebsite.com",
            app_service_name=example_app_service.name,
            resource_group_name=example_resource_group.name)
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] app_service_name: The name of the App Service in which to add the Custom Hostname Binding. Changing this forces a new resource to be created.
        :param pulumi.Input[str] hostname: Specifies the Custom Hostname to use for the App Service, example `www.example.com`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which the App Service exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] ssl_state: The SSL type. Possible values are `IpBasedEnabled` and `SniEnabled`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] thumbprint: The SSL certificate thumbprint. Changing this forces a new resource to be created.
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

            if app_service_name is None:
                raise TypeError("Missing required property 'app_service_name'")
            __props__['app_service_name'] = app_service_name
            if hostname is None:
                raise TypeError("Missing required property 'hostname'")
            __props__['hostname'] = hostname
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['ssl_state'] = ssl_state
            __props__['thumbprint'] = thumbprint
            __props__['virtual_ip'] = None
        super(CustomHostnameBinding, __self__).__init__(
            'azure:appservice/customHostnameBinding:CustomHostnameBinding',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, app_service_name=None, hostname=None, resource_group_name=None, ssl_state=None, thumbprint=None, virtual_ip=None):
        """
        Get an existing CustomHostnameBinding resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] app_service_name: The name of the App Service in which to add the Custom Hostname Binding. Changing this forces a new resource to be created.
        :param pulumi.Input[str] hostname: Specifies the Custom Hostname to use for the App Service, example `www.example.com`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which the App Service exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] ssl_state: The SSL type. Possible values are `IpBasedEnabled` and `SniEnabled`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] thumbprint: The SSL certificate thumbprint. Changing this forces a new resource to be created.
        :param pulumi.Input[str] virtual_ip: The virtual IP address assigned to the hostname if IP based SSL is enabled.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["app_service_name"] = app_service_name
        __props__["hostname"] = hostname
        __props__["resource_group_name"] = resource_group_name
        __props__["ssl_state"] = ssl_state
        __props__["thumbprint"] = thumbprint
        __props__["virtual_ip"] = virtual_ip
        return CustomHostnameBinding(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

