# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class ManagementGroup(pulumi.CustomResource):
    """
    Manages a Management Group.
    """
    def __init__(__self__, __name__, __opts__=None, display_name=None, group_id=None, parent_management_group_id=None, subscription_ids=None):
        """Create a ManagementGroup resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['display_name'] = display_name

        __props__['group_id'] = group_id

        __props__['parent_management_group_id'] = parent_management_group_id

        __props__['subscription_ids'] = subscription_ids

        super(ManagementGroup, __self__).__init__(
            'azure:managementgroups/managementGroup:ManagementGroup',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

