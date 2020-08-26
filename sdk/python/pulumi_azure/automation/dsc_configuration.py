# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import warnings
import pulumi
import pulumi.runtime
from typing import Any, Dict, List, Mapping, Optional, Tuple, Union
from .. import _utilities, _tables

__all__ = ['DscConfiguration']


class DscConfiguration(pulumi.CustomResource):
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 automation_account_name: Optional[pulumi.Input[str]] = None,
                 content_embedded: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 location: Optional[pulumi.Input[str]] = None,
                 log_verbose: Optional[pulumi.Input[bool]] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 resource_group_name: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None,
                 __props__=None,
                 __name__=None,
                 __opts__=None):
        """
        Manages a Automation DSC Configuration.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] automation_account_name: The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] content_embedded: The PowerShell DSC Configuration script.
        :param pulumi.Input[str] description: Description to go with DSC Configuration.
        :param pulumi.Input[str] location: Must be the same location as the Automation Account.
        :param pulumi.Input[bool] log_verbose: Verbose log option.
        :param pulumi.Input[str] name: Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource.
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

            if automation_account_name is None:
                raise TypeError("Missing required property 'automation_account_name'")
            __props__['automation_account_name'] = automation_account_name
            if content_embedded is None:
                raise TypeError("Missing required property 'content_embedded'")
            __props__['content_embedded'] = content_embedded
            __props__['description'] = description
            __props__['location'] = location
            __props__['log_verbose'] = log_verbose
            __props__['name'] = name
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['tags'] = tags
            __props__['state'] = None
        super(DscConfiguration, __self__).__init__(
            'azure:automation/dscConfiguration:DscConfiguration',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            automation_account_name: Optional[pulumi.Input[str]] = None,
            content_embedded: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            location: Optional[pulumi.Input[str]] = None,
            log_verbose: Optional[pulumi.Input[bool]] = None,
            name: Optional[pulumi.Input[str]] = None,
            resource_group_name: Optional[pulumi.Input[str]] = None,
            state: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, pulumi.Input[str]]]] = None) -> 'DscConfiguration':
        """
        Get an existing DscConfiguration resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] automation_account_name: The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] content_embedded: The PowerShell DSC Configuration script.
        :param pulumi.Input[str] description: Description to go with DSC Configuration.
        :param pulumi.Input[str] location: Must be the same location as the Automation Account.
        :param pulumi.Input[bool] log_verbose: Verbose log option.
        :param pulumi.Input[str] name: Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        :param pulumi.Input[Mapping[str, pulumi.Input[str]]] tags: A mapping of tags to assign to the resource.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["automation_account_name"] = automation_account_name
        __props__["content_embedded"] = content_embedded
        __props__["description"] = description
        __props__["location"] = location
        __props__["log_verbose"] = log_verbose
        __props__["name"] = name
        __props__["resource_group_name"] = resource_group_name
        __props__["state"] = state
        __props__["tags"] = tags
        return DscConfiguration(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="automationAccountName")
    def automation_account_name(self) -> pulumi.Output[str]:
        """
        The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "automation_account_name")

    @property
    @pulumi.getter(name="contentEmbedded")
    def content_embedded(self) -> pulumi.Output[str]:
        """
        The PowerShell DSC Configuration script.
        """
        return pulumi.get(self, "content_embedded")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description to go with DSC Configuration.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def location(self) -> pulumi.Output[str]:
        """
        Must be the same location as the Automation Account.
        """
        return pulumi.get(self, "location")

    @property
    @pulumi.getter(name="logVerbose")
    def log_verbose(self) -> pulumi.Output[Optional[bool]]:
        """
        Verbose log option.
        """
        return pulumi.get(self, "log_verbose")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="resourceGroupName")
    def resource_group_name(self) -> pulumi.Output[str]:
        """
        The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        """
        return pulumi.get(self, "resource_group_name")

    @property
    @pulumi.getter
    def state(self) -> pulumi.Output[str]:
        return pulumi.get(self, "state")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, str]]]:
        """
        A mapping of tags to assign to the resource.
        """
        return pulumi.get(self, "tags")

    def translate_output_property(self, prop):
        return _tables.CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return _tables.SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

