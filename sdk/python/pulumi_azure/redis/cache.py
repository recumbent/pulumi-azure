# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class Cache(pulumi.CustomResource):
    capacity: pulumi.Output[float]
    """
    The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
    """
    enable_non_ssl_port: pulumi.Output[bool]
    """
    Enable the non-SSL port (6379) - disabled by default.
    """
    family: pulumi.Output[str]
    """
    The SKU family/pricing group to use. Valid values are `C` (for Basic/Standard SKU family) and `P` (for `Premium`)
    """
    hostname: pulumi.Output[str]
    """
    The Hostname of the Redis Instance
    """
    location: pulumi.Output[str]
    """
    The location of the resource group.
    """
    minimum_tls_version: pulumi.Output[str]
    """
    The minimum TLS version.  Defaults to `1.0`.
    """
    name: pulumi.Output[str]
    """
    The name of the Redis instance. Changing this forces a
    new resource to be created.
    """
    patch_schedules: pulumi.Output[list]
    """
    A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.

      * `dayOfWeek` (`str`)
      * `startHourUtc` (`float`)
    """
    port: pulumi.Output[float]
    """
    The non-SSL Port of the Redis Instance
    """
    primary_access_key: pulumi.Output[str]
    """
    The Primary Access Key for the Redis Instance
    """
    primary_connection_string: pulumi.Output[str]
    """
    The primary connection string of the Redis Instance.
    """
    private_static_ip_address: pulumi.Output[str]
    """
    The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
    """
    redis_configuration: pulumi.Output[dict]
    """
    A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.

      * `aofBackupEnabled` (`bool`)
      * `aofStorageConnectionString0` (`str`)
      * `aofStorageConnectionString1` (`str`)
      * `enableAuthentication` (`bool`) - If set to `false`, the Redis instance will be accessible without authentication. Defaults to `true`.
      * `maxclients` (`float`) - Returns the max number of connected clients at the same time.
      * `maxfragmentationmemoryReserved` (`float`) - Value in megabytes reserved to accommodate for memory fragmentation. Defaults are shown below.
      * `maxmemoryDelta` (`float`) - The max-memory delta for this Redis instance. Defaults are shown below.
      * `maxmemoryPolicy` (`str`) - How Redis will select what to remove when `maxmemory` is reached. Defaults are shown below.
      * `maxmemoryReserved` (`float`) - Value in megabytes reserved for non-cache usage e.g. failover. Defaults are shown below.
      * `notifyKeyspaceEvents` (`str`) - Keyspace notifications allows clients to subscribe to Pub/Sub channels in order to receive events affecting the Redis data set in some way. [Reference](https://redis.io/topics/notifications#configuration)
      * `rdbBackupEnabled` (`bool`) - Is Backup Enabled? Only supported on Premium SKU's.
      * `rdbBackupFrequency` (`float`) - The Backup Frequency in Minutes. Only supported on Premium SKU's. Possible values are: `15`, `30`, `60`, `360`, `720` and `1440`.
      * `rdbBackupMaxSnapshotCount` (`float`) - The maximum number of snapshots to create as a backup. Only supported for Premium SKU's.
      * `rdbStorageConnectionString` (`str`) - The Connection String to the Storage Account. Only supported for Premium SKU's. In the format: `DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}`.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the resource group in which to
    create the Redis instance.
    """
    secondary_access_key: pulumi.Output[str]
    """
    The Secondary Access Key for the Redis Instance
    """
    secondary_connection_string: pulumi.Output[str]
    """
    The secondary connection string of the Redis Instance.
    """
    shard_count: pulumi.Output[float]
    """
    *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
    """
    sku_name: pulumi.Output[str]
    """
    The SKU of Redis to use. Possible values are `Basic`, `Standard` and `Premium`.
    """
    ssl_port: pulumi.Output[float]
    """
    The SSL Port of the Redis Instance
    """
    subnet_id: pulumi.Output[str]
    """
    *Only available when using the Premium SKU* The ID of the Subnet within which the Redis Cache should be deployed. This Subnet must only contain Azure Cache for Redis instances without any other type of resources. Changing this forces a new resource to be created.
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags to assign to the resource.
    """
    zones: pulumi.Output[str]
    """
    A list of a single item of the Availability Zone which the Redis Cache should be allocated in.
    """
    def __init__(__self__, resource_name, opts=None, capacity=None, enable_non_ssl_port=None, family=None, location=None, minimum_tls_version=None, name=None, patch_schedules=None, private_static_ip_address=None, redis_configuration=None, resource_group_name=None, shard_count=None, sku_name=None, subnet_id=None, tags=None, zones=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Redis Cache.

        ## Example Usage



        ```python
        import pulumi
        import pulumi_azure as azure

        example_resource_group = azure.core.ResourceGroup("exampleResourceGroup", location="West Europe")
        # NOTE: the Name used for Redis needs to be globally unique
        example_cache = azure.redis.Cache("exampleCache",
            location=example_resource_group.location,
            resource_group_name=example_resource_group.name,
            capacity=2,
            family="C",
            sku_name="Standard",
            enable_non_ssl_port=False,
            minimum_tls_version="1.2",
            redis_configuration={})
        ```

        ## Default Redis Configuration Values

        | Redis Value                     | Basic        | Standard     | Premium      |
        | ------------------------------- | ------------ | ------------ | ------------ |
        | enable_authentication           | true         | true         | true         |
        | maxmemory_reserved              | 2            | 50           | 200          |
        | maxfragmentationmemory_reserved | 2            | 50           | 200          |
        | maxmemory_delta                 | 2            | 50           | 200          |
        | maxmemory_policy                | volatile-lru | volatile-lru | volatile-lru |

        > **NOTE:** The `maxmemory_reserved`, `maxmemory_delta` and `maxfragmentationmemory-reserved` settings are only available for Standard and Premium caches. More details are available in the Relevant Links section below._

        ---

        A `patch_schedule` block supports the following:

        * `day_of_week` (Required) the Weekday name - possible values include `Monday`, `Tuesday`, `Wednesday` etc.

        * `start_hour_utc` - (Optional) the Start Hour for maintenance in UTC - possible values range from `0 - 23`.

        > **Note:** The Patch Window lasts for `5` hours from the `start_hour_utc`.

        ## Relevant Links

         - [Azure Redis Cache: SKU specific configuration limitations](https://azure.microsoft.com/en-us/documentation/articles/cache-configure/#advanced-settings)
         - [Redis: Available Configuration Settings](http://redis.io/topics/config)

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] capacity: The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
        :param pulumi.Input[bool] enable_non_ssl_port: Enable the non-SSL port (6379) - disabled by default.
        :param pulumi.Input[str] family: The SKU family/pricing group to use. Valid values are `C` (for Basic/Standard SKU family) and `P` (for `Premium`)
        :param pulumi.Input[str] location: The location of the resource group.
        :param pulumi.Input[str] minimum_tls_version: The minimum TLS version.  Defaults to `1.0`.
        :param pulumi.Input[str] name: The name of the Redis instance. Changing this forces a
               new resource to be created.
        :param pulumi.Input[list] patch_schedules: A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
        :param pulumi.Input[str] private_static_ip_address: The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] redis_configuration: A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the Redis instance.
        :param pulumi.Input[float] shard_count: *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
        :param pulumi.Input[str] sku_name: The SKU of Redis to use. Possible values are `Basic`, `Standard` and `Premium`.
        :param pulumi.Input[str] subnet_id: *Only available when using the Premium SKU* The ID of the Subnet within which the Redis Cache should be deployed. This Subnet must only contain Azure Cache for Redis instances without any other type of resources. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] zones: A list of a single item of the Availability Zone which the Redis Cache should be allocated in.

        The **patch_schedules** object supports the following:

          * `dayOfWeek` (`pulumi.Input[str]`)
          * `startHourUtc` (`pulumi.Input[float]`)

        The **redis_configuration** object supports the following:

          * `aofBackupEnabled` (`pulumi.Input[bool]`)
          * `aofStorageConnectionString0` (`pulumi.Input[str]`)
          * `aofStorageConnectionString1` (`pulumi.Input[str]`)
          * `enableAuthentication` (`pulumi.Input[bool]`) - If set to `false`, the Redis instance will be accessible without authentication. Defaults to `true`.
          * `maxclients` (`pulumi.Input[float]`) - Returns the max number of connected clients at the same time.
          * `maxfragmentationmemoryReserved` (`pulumi.Input[float]`) - Value in megabytes reserved to accommodate for memory fragmentation. Defaults are shown below.
          * `maxmemoryDelta` (`pulumi.Input[float]`) - The max-memory delta for this Redis instance. Defaults are shown below.
          * `maxmemoryPolicy` (`pulumi.Input[str]`) - How Redis will select what to remove when `maxmemory` is reached. Defaults are shown below.
          * `maxmemoryReserved` (`pulumi.Input[float]`) - Value in megabytes reserved for non-cache usage e.g. failover. Defaults are shown below.
          * `notifyKeyspaceEvents` (`pulumi.Input[str]`) - Keyspace notifications allows clients to subscribe to Pub/Sub channels in order to receive events affecting the Redis data set in some way. [Reference](https://redis.io/topics/notifications#configuration)
          * `rdbBackupEnabled` (`pulumi.Input[bool]`) - Is Backup Enabled? Only supported on Premium SKU's.
          * `rdbBackupFrequency` (`pulumi.Input[float]`) - The Backup Frequency in Minutes. Only supported on Premium SKU's. Possible values are: `15`, `30`, `60`, `360`, `720` and `1440`.
          * `rdbBackupMaxSnapshotCount` (`pulumi.Input[float]`) - The maximum number of snapshots to create as a backup. Only supported for Premium SKU's.
          * `rdbStorageConnectionString` (`pulumi.Input[str]`) - The Connection String to the Storage Account. Only supported for Premium SKU's. In the format: `DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}`.
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

            if capacity is None:
                raise TypeError("Missing required property 'capacity'")
            __props__['capacity'] = capacity
            __props__['enable_non_ssl_port'] = enable_non_ssl_port
            if family is None:
                raise TypeError("Missing required property 'family'")
            __props__['family'] = family
            __props__['location'] = location
            __props__['minimum_tls_version'] = minimum_tls_version
            __props__['name'] = name
            __props__['patch_schedules'] = patch_schedules
            __props__['private_static_ip_address'] = private_static_ip_address
            __props__['redis_configuration'] = redis_configuration
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['shard_count'] = shard_count
            if sku_name is None:
                raise TypeError("Missing required property 'sku_name'")
            __props__['sku_name'] = sku_name
            __props__['subnet_id'] = subnet_id
            __props__['tags'] = tags
            __props__['zones'] = zones
            __props__['hostname'] = None
            __props__['port'] = None
            __props__['primary_access_key'] = None
            __props__['primary_connection_string'] = None
            __props__['secondary_access_key'] = None
            __props__['secondary_connection_string'] = None
            __props__['ssl_port'] = None
        super(Cache, __self__).__init__(
            'azure:redis/cache:Cache',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, capacity=None, enable_non_ssl_port=None, family=None, hostname=None, location=None, minimum_tls_version=None, name=None, patch_schedules=None, port=None, primary_access_key=None, primary_connection_string=None, private_static_ip_address=None, redis_configuration=None, resource_group_name=None, secondary_access_key=None, secondary_connection_string=None, shard_count=None, sku_name=None, ssl_port=None, subnet_id=None, tags=None, zones=None):
        """
        Get an existing Cache resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[float] capacity: The size of the Redis cache to deploy. Valid values for a SKU `family` of C (Basic/Standard) are `0, 1, 2, 3, 4, 5, 6`, and for P (Premium) `family` are `1, 2, 3, 4`.
        :param pulumi.Input[bool] enable_non_ssl_port: Enable the non-SSL port (6379) - disabled by default.
        :param pulumi.Input[str] family: The SKU family/pricing group to use. Valid values are `C` (for Basic/Standard SKU family) and `P` (for `Premium`)
        :param pulumi.Input[str] hostname: The Hostname of the Redis Instance
        :param pulumi.Input[str] location: The location of the resource group.
        :param pulumi.Input[str] minimum_tls_version: The minimum TLS version.  Defaults to `1.0`.
        :param pulumi.Input[str] name: The name of the Redis instance. Changing this forces a
               new resource to be created.
        :param pulumi.Input[list] patch_schedules: A list of `patch_schedule` blocks as defined below - only available for Premium SKU's.
        :param pulumi.Input[float] port: The non-SSL Port of the Redis Instance
        :param pulumi.Input[str] primary_access_key: The Primary Access Key for the Redis Instance
        :param pulumi.Input[str] primary_connection_string: The primary connection string of the Redis Instance.
        :param pulumi.Input[str] private_static_ip_address: The Static IP Address to assign to the Redis Cache when hosted inside the Virtual Network. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] redis_configuration: A `redis_configuration` as defined below - with some limitations by SKU - defaults/details are shown below.
        :param pulumi.Input[str] resource_group_name: The name of the resource group in which to
               create the Redis instance.
        :param pulumi.Input[str] secondary_access_key: The Secondary Access Key for the Redis Instance
        :param pulumi.Input[str] secondary_connection_string: The secondary connection string of the Redis Instance.
        :param pulumi.Input[float] shard_count: *Only available when using the Premium SKU* The number of Shards to create on the Redis Cluster.
        :param pulumi.Input[str] sku_name: The SKU of Redis to use. Possible values are `Basic`, `Standard` and `Premium`.
        :param pulumi.Input[float] ssl_port: The SSL Port of the Redis Instance
        :param pulumi.Input[str] subnet_id: *Only available when using the Premium SKU* The ID of the Subnet within which the Redis Cache should be deployed. This Subnet must only contain Azure Cache for Redis instances without any other type of resources. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags to assign to the resource.
        :param pulumi.Input[str] zones: A list of a single item of the Availability Zone which the Redis Cache should be allocated in.

        The **patch_schedules** object supports the following:

          * `dayOfWeek` (`pulumi.Input[str]`)
          * `startHourUtc` (`pulumi.Input[float]`)

        The **redis_configuration** object supports the following:

          * `aofBackupEnabled` (`pulumi.Input[bool]`)
          * `aofStorageConnectionString0` (`pulumi.Input[str]`)
          * `aofStorageConnectionString1` (`pulumi.Input[str]`)
          * `enableAuthentication` (`pulumi.Input[bool]`) - If set to `false`, the Redis instance will be accessible without authentication. Defaults to `true`.
          * `maxclients` (`pulumi.Input[float]`) - Returns the max number of connected clients at the same time.
          * `maxfragmentationmemoryReserved` (`pulumi.Input[float]`) - Value in megabytes reserved to accommodate for memory fragmentation. Defaults are shown below.
          * `maxmemoryDelta` (`pulumi.Input[float]`) - The max-memory delta for this Redis instance. Defaults are shown below.
          * `maxmemoryPolicy` (`pulumi.Input[str]`) - How Redis will select what to remove when `maxmemory` is reached. Defaults are shown below.
          * `maxmemoryReserved` (`pulumi.Input[float]`) - Value in megabytes reserved for non-cache usage e.g. failover. Defaults are shown below.
          * `notifyKeyspaceEvents` (`pulumi.Input[str]`) - Keyspace notifications allows clients to subscribe to Pub/Sub channels in order to receive events affecting the Redis data set in some way. [Reference](https://redis.io/topics/notifications#configuration)
          * `rdbBackupEnabled` (`pulumi.Input[bool]`) - Is Backup Enabled? Only supported on Premium SKU's.
          * `rdbBackupFrequency` (`pulumi.Input[float]`) - The Backup Frequency in Minutes. Only supported on Premium SKU's. Possible values are: `15`, `30`, `60`, `360`, `720` and `1440`.
          * `rdbBackupMaxSnapshotCount` (`pulumi.Input[float]`) - The maximum number of snapshots to create as a backup. Only supported for Premium SKU's.
          * `rdbStorageConnectionString` (`pulumi.Input[str]`) - The Connection String to the Storage Account. Only supported for Premium SKU's. In the format: `DefaultEndpointsProtocol=https;BlobEndpoint=${azurerm_storage_account.example.primary_blob_endpoint};AccountName=${azurerm_storage_account.example.name};AccountKey=${azurerm_storage_account.example.primary_access_key}`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["capacity"] = capacity
        __props__["enable_non_ssl_port"] = enable_non_ssl_port
        __props__["family"] = family
        __props__["hostname"] = hostname
        __props__["location"] = location
        __props__["minimum_tls_version"] = minimum_tls_version
        __props__["name"] = name
        __props__["patch_schedules"] = patch_schedules
        __props__["port"] = port
        __props__["primary_access_key"] = primary_access_key
        __props__["primary_connection_string"] = primary_connection_string
        __props__["private_static_ip_address"] = private_static_ip_address
        __props__["redis_configuration"] = redis_configuration
        __props__["resource_group_name"] = resource_group_name
        __props__["secondary_access_key"] = secondary_access_key
        __props__["secondary_connection_string"] = secondary_connection_string
        __props__["shard_count"] = shard_count
        __props__["sku_name"] = sku_name
        __props__["ssl_port"] = ssl_port
        __props__["subnet_id"] = subnet_id
        __props__["tags"] = tags
        __props__["zones"] = zones
        return Cache(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

