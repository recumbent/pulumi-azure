# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class DscConfiguration(pulumi.CustomResource):
    """
    Manages a Automation DSC Configuration.
    """
    def __init__(__self__, __name__, __opts__=None, automation_account_name=None, content_embedded=None, description=None, location=None, log_verbose=None, name=None, resource_group_name=None):
        """Create a DscConfiguration resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if not automation_account_name:
            raise TypeError('Missing required property automation_account_name')
        elif not isinstance(automation_account_name, basestring):
            raise TypeError('Expected property automation_account_name to be a basestring')
        __self__.automation_account_name = automation_account_name
        """
        The name of the automation account in which the DSC Configuration is created. Changing this forces a new resource to be created.
        """
        __props__['automationAccountName'] = automation_account_name

        if not content_embedded:
            raise TypeError('Missing required property content_embedded')
        elif not isinstance(content_embedded, basestring):
            raise TypeError('Expected property content_embedded to be a basestring')
        __self__.content_embedded = content_embedded
        """
        The PowerShell DSC Configuration script.
        """
        __props__['contentEmbedded'] = content_embedded

        if description and not isinstance(description, basestring):
            raise TypeError('Expected property description to be a basestring')
        __self__.description = description
        """
        Description to go with DSC Configuration.
        """
        __props__['description'] = description

        if not location:
            raise TypeError('Missing required property location')
        elif not isinstance(location, basestring):
            raise TypeError('Expected property location to be a basestring')
        __self__.location = location
        """
        Must be the same location as the Automation Account.
        """
        __props__['location'] = location

        if log_verbose and not isinstance(log_verbose, bool):
            raise TypeError('Expected property log_verbose to be a bool')
        __self__.log_verbose = log_verbose
        """
        Verbose log option.
        """
        __props__['logVerbose'] = log_verbose

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        Specifies the name of the DSC Configuration. Changing this forces a new resource to be created.
        """
        __props__['name'] = name

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        elif not isinstance(resource_group_name, basestring):
            raise TypeError('Expected property resource_group_name to be a basestring')
        __self__.resource_group_name = resource_group_name
        """
        The name of the resource group in which the DSC Configuration is created. Changing this forces a new resource to be created.
        """
        __props__['resourceGroupName'] = resource_group_name

        __self__.state = pulumi.runtime.UNKNOWN

        super(DscConfiguration, __self__).__init__(
            'azure:automation/dscConfiguration:DscConfiguration',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'automationAccountName' in outs:
            self.automation_account_name = outs['automationAccountName']
        if 'contentEmbedded' in outs:
            self.content_embedded = outs['contentEmbedded']
        if 'description' in outs:
            self.description = outs['description']
        if 'location' in outs:
            self.location = outs['location']
        if 'logVerbose' in outs:
            self.log_verbose = outs['logVerbose']
        if 'name' in outs:
            self.name = outs['name']
        if 'resourceGroupName' in outs:
            self.resource_group_name = outs['resourceGroupName']
        if 'state' in outs:
            self.state = outs['state']
