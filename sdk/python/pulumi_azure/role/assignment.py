# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities, tables

class Assignment(pulumi.CustomResource):
    """
    Assigns a given Principal (User or Application) to a given Role.
    """
    def __init__(__self__, __name__, __opts__=None, name=None, principal_id=None, role_definition_id=None, role_definition_name=None, scope=None):
        """Create a Assignment resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, str):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        __props__['name'] = name

        if not principal_id:
            raise TypeError('Missing required property principal_id')
        __props__['principal_id'] = principal_id

        __props__['role_definition_id'] = role_definition_id

        __props__['role_definition_name'] = role_definition_name

        if not scope:
            raise TypeError('Missing required property scope')
        __props__['scope'] = scope

        super(Assignment, __self__).__init__(
            'azure:role/assignment:Assignment',
            __name__,
            __props__,
            __opts__)


    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

