# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Server(pulumi.CustomResource):
    admin_users: pulumi.Output[list]
    """
    List of email addresses of admin users.
    """
    backup_blob_container_uri: pulumi.Output[str]
    """
    URI and SAS token for a blob container to store backups.
    """
    enable_power_bi_service: pulumi.Output[bool]
    """
    Indicates if the Power BI service is allowed to access or not.
    """
    ipv4_firewall_rules: pulumi.Output[list]
    """
    One or more `ipv4_firewall_rule` block(s) as defined below.

      * `name` (`str`) - Specifies the name of the firewall rule.
      * `rangeEnd` (`str`) - End of the firewall rule range as IPv4 address.
      * `rangeStart` (`str`) - Start of the firewall rule range as IPv4 address.
    """
    location: pulumi.Output[str]
    """
    The Azure location where the Analysis Services Server exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the firewall rule.
    """
    querypool_connection_mode: pulumi.Output[str]
    """
    Controls how the read-write server is used in the query pool. If this value is set to `All` then read-write servers are also used for queries. Otherwise with `ReadOnly` these servers do not participate in query operations.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the Resource Group in which the Analysis Services Server should be exist. Changing this forces a new resource to be created.
    """
    server_full_name: pulumi.Output[str]
    """
    The full name of the Analysis Services Server.
    """
    sku: pulumi.Output[str]
    """
    SKU for the Analysis Services Server. Possible values are: `D1`, `B1`, `B2`, `S0`, `S1`, `S2`, `S4`, `S8` and `S9`
    """
    tags: pulumi.Output[dict]
    def __init__(__self__, resource_name, opts=None, admin_users=None, backup_blob_container_uri=None, enable_power_bi_service=None, ipv4_firewall_rules=None, location=None, name=None, querypool_connection_mode=None, resource_group_name=None, sku=None, tags=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages an Analysis Services Server.



        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] admin_users: List of email addresses of admin users.
        :param pulumi.Input[str] backup_blob_container_uri: URI and SAS token for a blob container to store backups.
        :param pulumi.Input[bool] enable_power_bi_service: Indicates if the Power BI service is allowed to access or not.
        :param pulumi.Input[list] ipv4_firewall_rules: One or more `ipv4_firewall_rule` block(s) as defined below.
        :param pulumi.Input[str] location: The Azure location where the Analysis Services Server exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the firewall rule.
        :param pulumi.Input[str] querypool_connection_mode: Controls how the read-write server is used in the query pool. If this value is set to `All` then read-write servers are also used for queries. Otherwise with `ReadOnly` these servers do not participate in query operations.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Analysis Services Server should be exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] sku: SKU for the Analysis Services Server. Possible values are: `D1`, `B1`, `B2`, `S0`, `S1`, `S2`, `S4`, `S8` and `S9`

        The **ipv4_firewall_rules** object supports the following:

          * `name` (`pulumi.Input[str]`) - Specifies the name of the firewall rule.
          * `rangeEnd` (`pulumi.Input[str]`) - End of the firewall rule range as IPv4 address.
          * `rangeStart` (`pulumi.Input[str]`) - Start of the firewall rule range as IPv4 address.
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

            __props__['admin_users'] = admin_users
            __props__['backup_blob_container_uri'] = backup_blob_container_uri
            __props__['enable_power_bi_service'] = enable_power_bi_service
            __props__['ipv4_firewall_rules'] = ipv4_firewall_rules
            __props__['location'] = location
            __props__['name'] = name
            __props__['querypool_connection_mode'] = querypool_connection_mode
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            if sku is None:
                raise TypeError("Missing required property 'sku'")
            __props__['sku'] = sku
            __props__['tags'] = tags
            __props__['server_full_name'] = None
        super(Server, __self__).__init__(
            'azure:analysisservices/server:Server',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, admin_users=None, backup_blob_container_uri=None, enable_power_bi_service=None, ipv4_firewall_rules=None, location=None, name=None, querypool_connection_mode=None, resource_group_name=None, server_full_name=None, sku=None, tags=None):
        """
        Get an existing Server resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[list] admin_users: List of email addresses of admin users.
        :param pulumi.Input[str] backup_blob_container_uri: URI and SAS token for a blob container to store backups.
        :param pulumi.Input[bool] enable_power_bi_service: Indicates if the Power BI service is allowed to access or not.
        :param pulumi.Input[list] ipv4_firewall_rules: One or more `ipv4_firewall_rule` block(s) as defined below.
        :param pulumi.Input[str] location: The Azure location where the Analysis Services Server exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the firewall rule.
        :param pulumi.Input[str] querypool_connection_mode: Controls how the read-write server is used in the query pool. If this value is set to `All` then read-write servers are also used for queries. Otherwise with `ReadOnly` these servers do not participate in query operations.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Analysis Services Server should be exist. Changing this forces a new resource to be created.
        :param pulumi.Input[str] server_full_name: The full name of the Analysis Services Server.
        :param pulumi.Input[str] sku: SKU for the Analysis Services Server. Possible values are: `D1`, `B1`, `B2`, `S0`, `S1`, `S2`, `S4`, `S8` and `S9`

        The **ipv4_firewall_rules** object supports the following:

          * `name` (`pulumi.Input[str]`) - Specifies the name of the firewall rule.
          * `rangeEnd` (`pulumi.Input[str]`) - End of the firewall rule range as IPv4 address.
          * `rangeStart` (`pulumi.Input[str]`) - Start of the firewall rule range as IPv4 address.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["admin_users"] = admin_users
        __props__["backup_blob_container_uri"] = backup_blob_container_uri
        __props__["enable_power_bi_service"] = enable_power_bi_service
        __props__["ipv4_firewall_rules"] = ipv4_firewall_rules
        __props__["location"] = location
        __props__["name"] = name
        __props__["querypool_connection_mode"] = querypool_connection_mode
        __props__["resource_group_name"] = resource_group_name
        __props__["server_full_name"] = server_full_name
        __props__["sku"] = sku
        __props__["tags"] = tags
        return Server(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

