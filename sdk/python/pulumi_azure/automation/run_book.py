# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class RunBook(pulumi.CustomResource):
    automation_account_name: pulumi.Output[str]
    """
    The name of the automation account in which the Runbook is created. Changing this forces a new resource to be created.
    """
    content: pulumi.Output[str]
    """
    The desired content of the runbook.
    """
    description: pulumi.Output[str]
    """
    A description for this credential.
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    log_progress: pulumi.Output[bool]
    """
    Progress log option.
    """
    log_verbose: pulumi.Output[bool]
    """
    Verbose log option.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Runbook. Changing this forces a new resource to be created.
    """
    publish_content_link: pulumi.Output[dict]
    """
    The published runbook content link.

      * `hash` (`dict`)
        * `algorithm` (`str`)
        * `value` (`str`)

      * `uri` (`str`) - The uri of the runbook content.
      * `version` (`str`)
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which the Runbook is created. Changing this forces a new resource to be created.
    """
    runbook_type: pulumi.Output[str]
    """
    The type of the runbook - can be either `Graph`, `GraphPowerShell`, `GraphPowerShellWorkflow`, `PowerShellWorkflow`, `PowerShell` or `Script`.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    def __init__(__self__, resource_name, opts=None, automation_account_name=None, content=None, description=None, location=None, log_progress=None, log_verbose=None, name=None, publish_content_link=None, resource_group_name=None, runbook_type=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Automation Runbook.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        example_account = azure.automation.Account("exampleAccount",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            sku=[{
                "name": "Basic",
            }])
        example_run_book = azure.automation.RunBook("exampleRunBook",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            automation_account_name=example_account.name,
            log_verbose="true",
            log_progress="true",
            description="This is an example runbook",
            runbook_type="PowerShellWorkflow",
            publish_content_link={
                "uri": "https://raw.githubusercontent.com/Azure/azure-quickstart-templates/c4935ffb69246a6058eb24f54640f53f69d3ac9f/101-automation-runbook-getvms/Runbooks/Get-AzureVMTutorial.ps1",
            })
        ```


        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] automation_account_name: The name of the automation account in which the Runbook is created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] content: The desired content of the runbook.
        :param pulumi.Input[str] description: A description for this credential.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] log_progress: Progress log option.
        :param pulumi.Input[bool] log_verbose: Verbose log option.
        :param pulumi.Input[str] name: Specifies the name of the Runbook. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] publish_content_link: The published runbook content link.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which the Runbook is created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] runbook_type: The type of the runbook - can be either `Graph`, `GraphPowerShell`, `GraphPowerShellWorkflow`, `PowerShellWorkflow`, `PowerShell` or `Script`.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.

        The **publish_content_link** object supports the following:

          * `hash` (`pulumi.Input[dict]`)
            * `algorithm` (`pulumi.Input[str]`)
            * `value` (`pulumi.Input[str]`)

          * `uri` (`pulumi.Input[str]`) - The uri of the runbook content.
          * `version` (`pulumi.Input[str]`)
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

            if automation_account_name is None:
                raise TypeError("Missing required property 'automation_account_name'")
            __props__['automation_account_name'] = automation_account_name
            __props__['content'] = content
            __props__['description'] = description
            __props__['location'] = location
            if log_progress is None:
                raise TypeError("Missing required property 'log_progress'")
            __props__['log_progress'] = log_progress
            if log_verbose is None:
                raise TypeError("Missing required property 'log_verbose'")
            __props__['log_verbose'] = log_verbose
            __props__['name'] = name
            __props__['publish_content_link'] = publish_content_link
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if runbook_type is None:
                raise TypeError("Missing required property 'runbook_type'")
            __props__['runbook_type'] = runbook_type
            __props__['tags'] = tags
        super(RunBook, __self__).__init__(
            'azure:automation/runBook:RunBook',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, automation_account_name=None, content=None, description=None, location=None, log_progress=None, log_verbose=None, name=None, publish_content_link=None, resource_group_name=None, runbook_type=None, tags=None):
        """
        Get an existing RunBook resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] automation_account_name: The name of the automation account in which the Runbook is created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] content: The desired content of the runbook.
        :param pulumi.Input[str] description: A description for this credential.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] log_progress: Progress log option.
        :param pulumi.Input[bool] log_verbose: Verbose log option.
        :param pulumi.Input[str] name: Specifies the name of the Runbook. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] publish_content_link: The published runbook content link.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which the Runbook is created. Changing this forces a new resource to be created.
        :param pulumi.Input[str] runbook_type: The type of the runbook - can be either `Graph`, `GraphPowerShell`, `GraphPowerShellWorkflow`, `PowerShellWorkflow`, `PowerShell` or `Script`.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.

        The **publish_content_link** object supports the following:

          * `hash` (`pulumi.Input[dict]`)
            * `algorithm` (`pulumi.Input[str]`)
            * `value` (`pulumi.Input[str]`)

          * `uri` (`pulumi.Input[str]`) - The uri of the runbook content.
          * `version` (`pulumi.Input[str]`)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["automation_account_name"] = automation_account_name
        __props__["content"] = content
        __props__["description"] = description
        __props__["location"] = location
        __props__["log_progress"] = log_progress
        __props__["log_verbose"] = log_verbose
        __props__["name"] = name
        __props__["publish_content_link"] = publish_content_link
        __props__["resource_group_name"] = resource_group_name
        __props__["runbook_type"] = runbook_type
        __props__["tags"] = tags
        return RunBook(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

