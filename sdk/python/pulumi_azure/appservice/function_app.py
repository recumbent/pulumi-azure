# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class FunctionApp(pulumi.CustomResource):
    app_service_plan_id: pulumi.Output[str]
    """
    The ID of the App Service Plan within which to create this Function App.
    """
    app_settings: pulumi.Output[dict]
    """
    A key-value pair of App Settings.
    """
    auth_settings: pulumi.Output[dict]
    """
    A `auth_settings` block as defined below.

      * `active_directory` (`dict`) - A `active_directory` block as defined below.
        * `allowedAudiences` (`list`) - Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
        * `client_id` (`str`) - The Client ID of this relying party application. Enables OpenIDConnection authentication with Azure Active Directory.
        * `client_secret` (`str`) - The Client Secret of this relying party application. If no secret is provided, implicit flow will be used.

      * `additionalLoginParams` (`dict`) - Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".
      * `allowedExternalRedirectUrls` (`list`) - External URLs that can be redirected to as part of logging in or logging out of the app.
      * `defaultProvider` (`str`) - The default provider to use when multiple providers have been set up. Possible values are `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount` and `Twitter`.
      * `enabled` (`bool`) - Is Authentication enabled?
      * `facebook` (`dict`) - A `facebook` block as defined below.
        * `app_id` (`str`) - The App ID of the Facebook app used for login
        * `app_secret` (`str`) - The App Secret of the Facebook app used for Facebook Login.
        * `oauthScopes` (`list`) - The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication. https://developers.facebook.com/docs/facebook-login

      * `google` (`dict`) - A `google` block as defined below.
        * `client_id` (`str`) - The OpenID Connect Client ID for the Google web application.
        * `client_secret` (`str`) - The client secret associated with the Google web application.
        * `oauthScopes` (`list`) - The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. https://developers.google.com/identity/sign-in/web/

      * `issuer` (`str`) - Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
      * `microsoft` (`dict`) - A `microsoft` block as defined below.
        * `client_id` (`str`) - The OAuth 2.0 client ID that was created for the app used for authentication.
        * `client_secret` (`str`) - The OAuth 2.0 client secret that was created for the app used for authentication.
        * `oauthScopes` (`list`) - The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx

      * `runtimeVersion` (`str`) - The runtime version of the Authentication/Authorization module.
      * `tokenRefreshExtensionHours` (`float`) - The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.
      * `tokenStoreEnabled` (`bool`) - If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.
      * `twitter` (`dict`) - A `twitter` block as defined below.
        * `consumerKey` (`str`)
        * `consumerSecret` (`str`)

      * `unauthenticatedClientAction` (`str`) - The action to take when an unauthenticated client attempts to access the app. Possible values are `AllowAnonymous` and `RedirectToLoginPage`.
    """
    client_affinity_enabled: pulumi.Output[bool]
    """
    Should the Function App send session affinity cookies, which route client requests in the same session to the same instance?
    """
    connection_strings: pulumi.Output[list]
    """
    An `connection_string` block as defined below.

      * `name` (`str`) - The name of the Connection String.
      * `type` (`str`) - The type of the Connection String. Possible values are `APIHub`, `Custom`, `DocDb`, `EventHub`, `MySQL`, `NotificationHub`, `PostgreSQL`, `RedisCache`, `ServiceBus`, `SQLAzure` and  `SQLServer`.
      * `value` (`str`) - The value for the Connection String.
    """
    daily_memory_time_quota: pulumi.Output[float]
    """
    The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to `0`.
    """
    default_hostname: pulumi.Output[str]
    """
    The default hostname associated with the Function App - such as `mysite.azurewebsites.net`
    """
    enable_builtin_logging: pulumi.Output[bool]
    """
    Should the built-in logging of this Function App be enabled? Defaults to `true`.
    """
    enabled: pulumi.Output[bool]
    """
    Is the Function App enabled?
    """
    https_only: pulumi.Output[bool]
    """
    Can the Function App only be accessed via HTTPS? Defaults to `false`.
    """
    identity: pulumi.Output[dict]
    """
    An `identity` block as defined below.

      * `identityIds` (`list`) - Specifies a list of user managed identity ids to be assigned. Required if `type` is `UserAssigned`.
      * `principal_id` (`str`) - The Principal ID for the Service Principal associated with the Managed Service Identity of this App Service.
      * `tenant_id` (`str`) - The Tenant ID for the Service Principal associated with the Managed Service Identity of this App Service.
      * `type` (`str`) - Specifies the identity type of the Function App. Possible values are `SystemAssigned` (where Azure will generate a Service Principal for you), `UserAssigned` where you can specify the Service Principal IDs in the `identity_ids` field, and `SystemAssigned, UserAssigned` which assigns both a system managed identity as well as the specified user assigned identities.
    """
    kind: pulumi.Output[str]
    """
    The Function App kind - such as `functionapp,linux,container`
    """
    location: pulumi.Output[str]
    """
    Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
    """
    name: pulumi.Output[str]
    """
    Specifies the name of the Function App. Changing this forces a new resource to be created.
    """
    os_type: pulumi.Output[str]
    """
    A string indicating the Operating System type for this function app. 
    """
    outbound_ip_addresses: pulumi.Output[str]
    """
    A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`
    """
    possible_outbound_ip_addresses: pulumi.Output[str]
    """
    A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outbound_ip_addresses`.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to create the Function App.
    """
    site_config: pulumi.Output[dict]
    """
    A `site_config` object as defined below.

      * `alwaysOn` (`bool`) - Should the Function App be loaded at all times? Defaults to `false`.
      * `cors` (`dict`) - A `cors` block as defined below.
        * `allowedOrigins` (`list`) - A list of origins which should be able to make cross-origin calls. `*` can be used to allow all calls.
        * `supportCredentials` (`bool`) - Are credentials supported?

      * `ftpsState` (`str`) - State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`.
      * `http2Enabled` (`bool`) - Specifies whether or not the http2 protocol should be enabled. Defaults to `false`.
      * `ipRestrictions` (`list`) - A list of objects representing ip restrictions as defined below.
        * `ip_address` (`str`) - The IP Address CIDR notation used for this IP Restriction.
        * `subnet_id` (`str`) - The Subnet ID used for this IP Restriction.

      * `linuxFxVersion` (`str`) - Linux App Framework and version for the AppService, e.g. `DOCKER|(golang:latest)`.
      * `minTlsVersion` (`str`) - The minimum supported TLS version for the function app. Possible values are `1.0`, `1.1`, and `1.2`. Defaults to `1.2` for new function apps.
      * `preWarmedInstanceCount` (`float`) - The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.
      * `use32BitWorkerProcess` (`bool`) - Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to `true`.
      * `websocketsEnabled` (`bool`) - Should WebSockets be enabled?
    """
    site_credentials: pulumi.Output[list]
    """
    A `site_credential` block as defined below, which contains the site-level credentials used to publish to this App Service.

      * `password` (`str`) - The password associated with the username, which can be used to publish to this App Service.
      * `username` (`str`) - The username which can be used to publish to this App Service
    """
    storage_account_access_key: pulumi.Output[str]
    """
    The access key which will be used to access the backend storage account for the Function App.
    """
    storage_account_name: pulumi.Output[str]
    """
    The backend storage account name which will be used by this Function App (such as the dashboard, logs).
    """
    storage_connection_string: pulumi.Output[str]
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    version: pulumi.Output[str]
    """
    The runtime version associated with the Function App. Defaults to `~1`.
    """
    def __init__(__self__, resource_name, opts=None, app_service_plan_id=None, app_settings=None, auth_settings=None, client_affinity_enabled=None, connection_strings=None, daily_memory_time_quota=None, enable_builtin_logging=None, enabled=None, https_only=None, identity=None, location=None, name=None, os_type=None, resource_group_name=None, site_config=None, storage_account_access_key=None, storage_account_name=None, storage_connection_string=None, tags=None, version=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Function App.

        ## Example Usage (with App Service Plan)

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="westus2")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS")
        example_plan = azure.appservice.Plan("examplePlan",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            sku={
                "tier": "Standard",
                "size": "S1",
            })
        example_function_app = azure.appservice.FunctionApp("exampleFunctionApp",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            app_service_plan_id=example_plan.id,
            storage_account_name=example_account.name,
            storage_account_access_key=example_account.primary_access_key)
        ```
        ## Example Usage (in a Consumption Plan)

        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="westus2")
        example_account = azure.storage.Account("exampleAccount",
            resource_group_name=example_resource_group.name,
            location=example_resource_group.location,
            account_tier="Standard",
            account_replication_type="LRS")
        example_plan = azure.appservice.Plan("examplePlan",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            kind="FunctionApp",
            sku={
                "tier": "Dynamic",
                "size": "Y1",
            })
        example_function_app = azure.appservice.FunctionApp("exampleFunctionApp",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            app_service_plan_id=example_plan.id,
            storage_account_name=example_account.name,
            storage_account_access_key=example_account.primary_access_key)
        ```

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] app_service_plan_id: The ID of the App Service Plan within which to create this Function App.
        :param pulumi.Input[dict] app_settings: A key-value pair of App Settings.
        :param pulumi.Input[dict] auth_settings: A `auth_settings` block as defined below.
        :param pulumi.Input[bool] client_affinity_enabled: Should the Function App send session affinity cookies, which route client requests in the same session to the same instance?
        :param pulumi.Input[list] connection_strings: An `connection_string` block as defined below.
        :param pulumi.Input[float] daily_memory_time_quota: The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to `0`.
        :param pulumi.Input[bool] enable_builtin_logging: Should the built-in logging of this Function App be enabled? Defaults to `true`.
        :param pulumi.Input[bool] enabled: Is the Function App enabled?
        :param pulumi.Input[bool] https_only: Can the Function App only be accessed via HTTPS? Defaults to `false`.
        :param pulumi.Input[dict] identity: An `identity` block as defined below.
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Function App. Changing this forces a new resource to be created.
        :param pulumi.Input[str] os_type: A string indicating the Operating System type for this function app. 
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Function App.
        :param pulumi.Input[dict] site_config: A `site_config` object as defined below.
        :param pulumi.Input[str] storage_account_access_key: The access key which will be used to access the backend storage account for the Function App.
        :param pulumi.Input[str] storage_account_name: The backend storage account name which will be used by this Function App (such as the dashboard, logs).
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] version: The runtime version associated with the Function App. Defaults to `~1`.

        The **auth_settings** object supports the following:

          * `active_directory` (`pulumi.Input[dict]`) - A `active_directory` block as defined below.
            * `allowedAudiences` (`pulumi.Input[list]`) - Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
            * `client_id` (`pulumi.Input[str]`) - The Client ID of this relying party application. Enables OpenIDConnection authentication with Azure Active Directory.
            * `client_secret` (`pulumi.Input[str]`) - The Client Secret of this relying party application. If no secret is provided, implicit flow will be used.

          * `additionalLoginParams` (`pulumi.Input[dict]`) - Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".
          * `allowedExternalRedirectUrls` (`pulumi.Input[list]`) - External URLs that can be redirected to as part of logging in or logging out of the app.
          * `defaultProvider` (`pulumi.Input[str]`) - The default provider to use when multiple providers have been set up. Possible values are `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount` and `Twitter`.
          * `enabled` (`pulumi.Input[bool]`) - Is Authentication enabled?
          * `facebook` (`pulumi.Input[dict]`) - A `facebook` block as defined below.
            * `app_id` (`pulumi.Input[str]`) - The App ID of the Facebook app used for login
            * `app_secret` (`pulumi.Input[str]`) - The App Secret of the Facebook app used for Facebook Login.
            * `oauthScopes` (`pulumi.Input[list]`) - The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication. https://developers.facebook.com/docs/facebook-login

          * `google` (`pulumi.Input[dict]`) - A `google` block as defined below.
            * `client_id` (`pulumi.Input[str]`) - The OpenID Connect Client ID for the Google web application.
            * `client_secret` (`pulumi.Input[str]`) - The client secret associated with the Google web application.
            * `oauthScopes` (`pulumi.Input[list]`) - The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. https://developers.google.com/identity/sign-in/web/

          * `issuer` (`pulumi.Input[str]`) - Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
          * `microsoft` (`pulumi.Input[dict]`) - A `microsoft` block as defined below.
            * `client_id` (`pulumi.Input[str]`) - The OAuth 2.0 client ID that was created for the app used for authentication.
            * `client_secret` (`pulumi.Input[str]`) - The OAuth 2.0 client secret that was created for the app used for authentication.
            * `oauthScopes` (`pulumi.Input[list]`) - The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx

          * `runtimeVersion` (`pulumi.Input[str]`) - The runtime version of the Authentication/Authorization module.
          * `tokenRefreshExtensionHours` (`pulumi.Input[float]`) - The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.
          * `tokenStoreEnabled` (`pulumi.Input[bool]`) - If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.
          * `twitter` (`pulumi.Input[dict]`) - A `twitter` block as defined below.
            * `consumerKey` (`pulumi.Input[str]`)
            * `consumerSecret` (`pulumi.Input[str]`)

          * `unauthenticatedClientAction` (`pulumi.Input[str]`) - The action to take when an unauthenticated client attempts to access the app. Possible values are `AllowAnonymous` and `RedirectToLoginPage`.

        The **connection_strings** object supports the following:

          * `name` (`pulumi.Input[str]`) - The name of the Connection String.
          * `type` (`pulumi.Input[str]`) - The type of the Connection String. Possible values are `APIHub`, `Custom`, `DocDb`, `EventHub`, `MySQL`, `NotificationHub`, `PostgreSQL`, `RedisCache`, `ServiceBus`, `SQLAzure` and  `SQLServer`.
          * `value` (`pulumi.Input[str]`) - The value for the Connection String.

        The **identity** object supports the following:

          * `identityIds` (`pulumi.Input[list]`) - Specifies a list of user managed identity ids to be assigned. Required if `type` is `UserAssigned`.
          * `principal_id` (`pulumi.Input[str]`) - The Principal ID for the Service Principal associated with the Managed Service Identity of this App Service.
          * `tenant_id` (`pulumi.Input[str]`) - The Tenant ID for the Service Principal associated with the Managed Service Identity of this App Service.
          * `type` (`pulumi.Input[str]`) - Specifies the identity type of the Function App. Possible values are `SystemAssigned` (where Azure will generate a Service Principal for you), `UserAssigned` where you can specify the Service Principal IDs in the `identity_ids` field, and `SystemAssigned, UserAssigned` which assigns both a system managed identity as well as the specified user assigned identities.

        The **site_config** object supports the following:

          * `alwaysOn` (`pulumi.Input[bool]`) - Should the Function App be loaded at all times? Defaults to `false`.
          * `cors` (`pulumi.Input[dict]`) - A `cors` block as defined below.
            * `allowedOrigins` (`pulumi.Input[list]`) - A list of origins which should be able to make cross-origin calls. `*` can be used to allow all calls.
            * `supportCredentials` (`pulumi.Input[bool]`) - Are credentials supported?

          * `ftpsState` (`pulumi.Input[str]`) - State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`.
          * `http2Enabled` (`pulumi.Input[bool]`) - Specifies whether or not the http2 protocol should be enabled. Defaults to `false`.
          * `ipRestrictions` (`pulumi.Input[list]`) - A list of objects representing ip restrictions as defined below.
            * `ip_address` (`pulumi.Input[str]`) - The IP Address CIDR notation used for this IP Restriction.
            * `subnet_id` (`pulumi.Input[str]`) - The Subnet ID used for this IP Restriction.

          * `linuxFxVersion` (`pulumi.Input[str]`) - Linux App Framework and version for the AppService, e.g. `DOCKER|(golang:latest)`.
          * `minTlsVersion` (`pulumi.Input[str]`) - The minimum supported TLS version for the function app. Possible values are `1.0`, `1.1`, and `1.2`. Defaults to `1.2` for new function apps.
          * `preWarmedInstanceCount` (`pulumi.Input[float]`) - The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.
          * `use32BitWorkerProcess` (`pulumi.Input[bool]`) - Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to `true`.
          * `websocketsEnabled` (`pulumi.Input[bool]`) - Should WebSockets be enabled?
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

            if app_service_plan_id is None:
                raise TypeError("Missing required property 'app_service_plan_id'")
            __props__['app_service_plan_id'] = app_service_plan_id
            __props__['app_settings'] = app_settings
            __props__['auth_settings'] = auth_settings
            __props__['client_affinity_enabled'] = client_affinity_enabled
            __props__['connection_strings'] = connection_strings
            __props__['daily_memory_time_quota'] = daily_memory_time_quota
            __props__['enable_builtin_logging'] = enable_builtin_logging
            __props__['enabled'] = enabled
            __props__['https_only'] = https_only
            __props__['identity'] = identity
            __props__['location'] = location
            __props__['name'] = name
            __props__['os_type'] = os_type
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['site_config'] = site_config
            __props__['storage_account_access_key'] = storage_account_access_key
            __props__['storage_account_name'] = storage_account_name
            __props__['storage_connection_string'] = storage_connection_string
            __props__['tags'] = tags
            __props__['version'] = version
            __props__['default_hostname'] = None
            __props__['kind'] = None
            __props__['outbound_ip_addresses'] = None
            __props__['possible_outbound_ip_addresses'] = None
            __props__['site_credentials'] = None
        super(FunctionApp, __self__).__init__(
            'azure:appservice/functionApp:FunctionApp',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, app_service_plan_id=None, app_settings=None, auth_settings=None, client_affinity_enabled=None, connection_strings=None, daily_memory_time_quota=None, default_hostname=None, enable_builtin_logging=None, enabled=None, https_only=None, identity=None, kind=None, location=None, name=None, os_type=None, outbound_ip_addresses=None, possible_outbound_ip_addresses=None, resource_group_name=None, site_config=None, site_credentials=None, storage_account_access_key=None, storage_account_name=None, storage_connection_string=None, tags=None, version=None):
        """
        Get an existing FunctionApp resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] app_service_plan_id: The ID of the App Service Plan within which to create this Function App.
        :param pulumi.Input[dict] app_settings: A key-value pair of App Settings.
        :param pulumi.Input[dict] auth_settings: A `auth_settings` block as defined below.
        :param pulumi.Input[bool] client_affinity_enabled: Should the Function App send session affinity cookies, which route client requests in the same session to the same instance?
        :param pulumi.Input[list] connection_strings: An `connection_string` block as defined below.
        :param pulumi.Input[float] daily_memory_time_quota: The amount of memory in gigabyte-seconds that your application is allowed to consume per day. Setting this value only affects function apps under the consumption plan. Defaults to `0`.
        :param pulumi.Input[str] default_hostname: The default hostname associated with the Function App - such as `mysite.azurewebsites.net`
        :param pulumi.Input[bool] enable_builtin_logging: Should the built-in logging of this Function App be enabled? Defaults to `true`.
        :param pulumi.Input[bool] enabled: Is the Function App enabled?
        :param pulumi.Input[bool] https_only: Can the Function App only be accessed via HTTPS? Defaults to `false`.
        :param pulumi.Input[dict] identity: An `identity` block as defined below.
        :param pulumi.Input[str] kind: The Function App kind - such as `functionapp,linux,container`
        :param pulumi.Input[str] location: Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        :param pulumi.Input[str] name: Specifies the name of the Function App. Changing this forces a new resource to be created.
        :param pulumi.Input[str] os_type: A string indicating the Operating System type for this function app. 
        :param pulumi.Input[str] outbound_ip_addresses: A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12`
        :param pulumi.Input[str] possible_outbound_ip_addresses: A comma separated list of outbound IP addresses - such as `52.23.25.3,52.143.43.12,52.143.43.17` - not all of which are necessarily in use. Superset of `outbound_ip_addresses`.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to create the Function App.
        :param pulumi.Input[dict] site_config: A `site_config` object as defined below.
        :param pulumi.Input[list] site_credentials: A `site_credential` block as defined below, which contains the site-level credentials used to publish to this App Service.
        :param pulumi.Input[str] storage_account_access_key: The access key which will be used to access the backend storage account for the Function App.
        :param pulumi.Input[str] storage_account_name: The backend storage account name which will be used by this Function App (such as the dashboard, logs).
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] version: The runtime version associated with the Function App. Defaults to `~1`.

        The **auth_settings** object supports the following:

          * `active_directory` (`pulumi.Input[dict]`) - A `active_directory` block as defined below.
            * `allowedAudiences` (`pulumi.Input[list]`) - Allowed audience values to consider when validating JWTs issued by Azure Active Directory.
            * `client_id` (`pulumi.Input[str]`) - The Client ID of this relying party application. Enables OpenIDConnection authentication with Azure Active Directory.
            * `client_secret` (`pulumi.Input[str]`) - The Client Secret of this relying party application. If no secret is provided, implicit flow will be used.

          * `additionalLoginParams` (`pulumi.Input[dict]`) - Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".
          * `allowedExternalRedirectUrls` (`pulumi.Input[list]`) - External URLs that can be redirected to as part of logging in or logging out of the app.
          * `defaultProvider` (`pulumi.Input[str]`) - The default provider to use when multiple providers have been set up. Possible values are `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount` and `Twitter`.
          * `enabled` (`pulumi.Input[bool]`) - Is Authentication enabled?
          * `facebook` (`pulumi.Input[dict]`) - A `facebook` block as defined below.
            * `app_id` (`pulumi.Input[str]`) - The App ID of the Facebook app used for login
            * `app_secret` (`pulumi.Input[str]`) - The App Secret of the Facebook app used for Facebook Login.
            * `oauthScopes` (`pulumi.Input[list]`) - The OAuth 2.0 scopes that will be requested as part of Facebook Login authentication. https://developers.facebook.com/docs/facebook-login

          * `google` (`pulumi.Input[dict]`) - A `google` block as defined below.
            * `client_id` (`pulumi.Input[str]`) - The OpenID Connect Client ID for the Google web application.
            * `client_secret` (`pulumi.Input[str]`) - The client secret associated with the Google web application.
            * `oauthScopes` (`pulumi.Input[list]`) - The OAuth 2.0 scopes that will be requested as part of Google Sign-In authentication. https://developers.google.com/identity/sign-in/web/

          * `issuer` (`pulumi.Input[str]`) - Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
          * `microsoft` (`pulumi.Input[dict]`) - A `microsoft` block as defined below.
            * `client_id` (`pulumi.Input[str]`) - The OAuth 2.0 client ID that was created for the app used for authentication.
            * `client_secret` (`pulumi.Input[str]`) - The OAuth 2.0 client secret that was created for the app used for authentication.
            * `oauthScopes` (`pulumi.Input[list]`) - The OAuth 2.0 scopes that will be requested as part of Microsoft Account authentication. https://msdn.microsoft.com/en-us/library/dn631845.aspx

          * `runtimeVersion` (`pulumi.Input[str]`) - The runtime version of the Authentication/Authorization module.
          * `tokenRefreshExtensionHours` (`pulumi.Input[float]`) - The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.
          * `tokenStoreEnabled` (`pulumi.Input[bool]`) - If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.
          * `twitter` (`pulumi.Input[dict]`) - A `twitter` block as defined below.
            * `consumerKey` (`pulumi.Input[str]`)
            * `consumerSecret` (`pulumi.Input[str]`)

          * `unauthenticatedClientAction` (`pulumi.Input[str]`) - The action to take when an unauthenticated client attempts to access the app. Possible values are `AllowAnonymous` and `RedirectToLoginPage`.

        The **connection_strings** object supports the following:

          * `name` (`pulumi.Input[str]`) - The name of the Connection String.
          * `type` (`pulumi.Input[str]`) - The type of the Connection String. Possible values are `APIHub`, `Custom`, `DocDb`, `EventHub`, `MySQL`, `NotificationHub`, `PostgreSQL`, `RedisCache`, `ServiceBus`, `SQLAzure` and  `SQLServer`.
          * `value` (`pulumi.Input[str]`) - The value for the Connection String.

        The **identity** object supports the following:

          * `identityIds` (`pulumi.Input[list]`) - Specifies a list of user managed identity ids to be assigned. Required if `type` is `UserAssigned`.
          * `principal_id` (`pulumi.Input[str]`) - The Principal ID for the Service Principal associated with the Managed Service Identity of this App Service.
          * `tenant_id` (`pulumi.Input[str]`) - The Tenant ID for the Service Principal associated with the Managed Service Identity of this App Service.
          * `type` (`pulumi.Input[str]`) - Specifies the identity type of the Function App. Possible values are `SystemAssigned` (where Azure will generate a Service Principal for you), `UserAssigned` where you can specify the Service Principal IDs in the `identity_ids` field, and `SystemAssigned, UserAssigned` which assigns both a system managed identity as well as the specified user assigned identities.

        The **site_config** object supports the following:

          * `alwaysOn` (`pulumi.Input[bool]`) - Should the Function App be loaded at all times? Defaults to `false`.
          * `cors` (`pulumi.Input[dict]`) - A `cors` block as defined below.
            * `allowedOrigins` (`pulumi.Input[list]`) - A list of origins which should be able to make cross-origin calls. `*` can be used to allow all calls.
            * `supportCredentials` (`pulumi.Input[bool]`) - Are credentials supported?

          * `ftpsState` (`pulumi.Input[str]`) - State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`.
          * `http2Enabled` (`pulumi.Input[bool]`) - Specifies whether or not the http2 protocol should be enabled. Defaults to `false`.
          * `ipRestrictions` (`pulumi.Input[list]`) - A list of objects representing ip restrictions as defined below.
            * `ip_address` (`pulumi.Input[str]`) - The IP Address CIDR notation used for this IP Restriction.
            * `subnet_id` (`pulumi.Input[str]`) - The Subnet ID used for this IP Restriction.

          * `linuxFxVersion` (`pulumi.Input[str]`) - Linux App Framework and version for the AppService, e.g. `DOCKER|(golang:latest)`.
          * `minTlsVersion` (`pulumi.Input[str]`) - The minimum supported TLS version for the function app. Possible values are `1.0`, `1.1`, and `1.2`. Defaults to `1.2` for new function apps.
          * `preWarmedInstanceCount` (`pulumi.Input[float]`) - The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.
          * `use32BitWorkerProcess` (`pulumi.Input[bool]`) - Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to `true`.
          * `websocketsEnabled` (`pulumi.Input[bool]`) - Should WebSockets be enabled?

        The **site_credentials** object supports the following:

          * `password` (`pulumi.Input[str]`) - The password associated with the username, which can be used to publish to this App Service.
          * `username` (`pulumi.Input[str]`) - The username which can be used to publish to this App Service
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["app_service_plan_id"] = app_service_plan_id
        __props__["app_settings"] = app_settings
        __props__["auth_settings"] = auth_settings
        __props__["client_affinity_enabled"] = client_affinity_enabled
        __props__["connection_strings"] = connection_strings
        __props__["daily_memory_time_quota"] = daily_memory_time_quota
        __props__["default_hostname"] = default_hostname
        __props__["enable_builtin_logging"] = enable_builtin_logging
        __props__["enabled"] = enabled
        __props__["https_only"] = https_only
        __props__["identity"] = identity
        __props__["kind"] = kind
        __props__["location"] = location
        __props__["name"] = name
        __props__["os_type"] = os_type
        __props__["outbound_ip_addresses"] = outbound_ip_addresses
        __props__["possible_outbound_ip_addresses"] = possible_outbound_ip_addresses
        __props__["resource_group_name"] = resource_group_name
        __props__["site_config"] = site_config
        __props__["site_credentials"] = site_credentials
        __props__["storage_account_access_key"] = storage_account_access_key
        __props__["storage_account_name"] = storage_account_name
        __props__["storage_connection_string"] = storage_connection_string
        __props__["tags"] = tags
        __props__["version"] = version
        return FunctionApp(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

