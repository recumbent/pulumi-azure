# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import json
import warnings
import pulumi
import pulumi.runtime
from typing import Union
from .. import utilities, tables

class LinuxVirtualMachine(pulumi.CustomResource):
    additional_capabilities: pulumi.Output[dict]
    """
    A `additional_capabilities` block as defined below.

      * `ultraSsdEnabled` (`bool`) - Should the capacity to enable Data Disks of the `UltraSSD_LRS` storage account type be supported on this Virtual Machine? Defaults to `false`. Changing this forces a new resource to be created.
    """
    admin_password: pulumi.Output[str]
    """
    The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.
    """
    admin_ssh_keys: pulumi.Output[list]
    """
    One or more `admin_ssh_key` blocks as defined below.

      * `publicKey` (`str`) - The Public Key which should be used for authentication, which needs to be at least 2048-bit and in `ssh-rsa` format. Changing this forces a new resource to be created.
      * `username` (`str`) - The Username for which this Public SSH Key should be configured. Changing this forces a new resource to be created.
    """
    admin_username: pulumi.Output[str]
    """
    The username of the local administrator used for the Virtual Machine. Changing this forces a new resource to be created.
    """
    allow_extension_operations: pulumi.Output[bool]
    """
    Should Extension Operations be allowed on this Virtual Machine? Changing this forces a new resource to be created.
    """
    availability_set_id: pulumi.Output[str]
    """
    Specifies the ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
    """
    boot_diagnostics: pulumi.Output[dict]
    """
    A `boot_diagnostics` block as defined below.

      * `storageAccountUri` (`str`) - The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.
    """
    computer_name: pulumi.Output[str]
    """
    Specifies the Hostname which should be used for this Virtual Machine. If unspecified this defaults to the value for the `name` field. Changing this forces a new resource to be created.
    """
    custom_data: pulumi.Output[str]
    """
    The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.
    """
    dedicated_host_id: pulumi.Output[str]
    """
    The ID of a Dedicated Host where this machine should be run on. Changing this forces a new resource to be created.
    """
    disable_password_authentication: pulumi.Output[bool]
    """
    Should Password Authentication be disabled on this Virtual Machine? Defaults to `true`. Changing this forces a new resource to be created.
    """
    eviction_policy: pulumi.Output[str]
    """
    Specifies what should happen when the Virtual Machine is evicted for price reasons when using a Spot instance. At this time the only supported value is `Deallocate`. Changing this forces a new resource to be created.
    """
    identity: pulumi.Output[dict]
    """
    An `identity` block as defined below.

      * `identityIds` (`list`) - A list of User Managed Identity ID's which should be assigned to the Linux Virtual Machine.
      * `principal_id` (`str`) - The ID of the System Managed Service Principal.
      * `type` (`str`) - The type of Managed Identity which should be assigned to the Linux Virtual Machine. Possible values are `SystemAssigned`, `UserAssigned` and `SystemAssigned, UserAssigned`.
    """
    location: pulumi.Output[str]
    """
    The Azure location where the Linux Virtual Machine should exist. Changing this forces a new resource to be created.
    """
    max_bid_price: pulumi.Output[float]
    """
    The maximum price you're willing to pay for this Virtual Machine, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machine will be evicted using the `eviction_policy`. Defaults to `-1`, which means that the Virtual Machine should not be evicted for price reasons.
    """
    name: pulumi.Output[str]
    """
    The name of the Linux Virtual Machine. Changing this forces a new resource to be created.
    """
    network_interface_ids: pulumi.Output[list]
    """
    . A list of Network Interface ID's which should be attached to this Virtual Machine. The first Network Interface ID in this list will be the Primary Network Interface on the Virtual Machine.
    """
    os_disk: pulumi.Output[dict]
    """
    A `os_disk` block as defined below.

      * `caching` (`str`) - The Type of Caching which should be used for the Internal OS Disk. Possible values are `None`, `ReadOnly` and `ReadWrite`.
      * `diffDiskSettings` (`dict`) - A `diff_disk_settings` block as defined above.
        * `option` (`str`) - Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is `Local`. Changing this forces a new resource to be created.

      * `disk_encryption_set_id` (`str`) - The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk.
      * `disk_size_gb` (`float`) - The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine is sourced from.
      * `name` (`str`) - The name which should be used for the Internal OS Disk. Changing this forces a new resource to be created.
      * `storage_account_type` (`str`) - The Type of Storage Account which should back this the Internal OS Disk. Possible values are `Standard_LRS`, `StandardSSD_LRS` and `Premium_LRS`. Changing this forces a new resource to be created.
      * `write_accelerator_enabled` (`bool`) - Should Write Accelerator be Enabled for this OS Disk? Defaults to `false`.
    """
    plan: pulumi.Output[dict]
    """
    A `plan` block as defined below. Changing this forces a new resource to be created.

      * `name` (`str`) - Specifies the Name of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
      * `product` (`str`) - Specifies the Product of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
      * `publisher` (`str`) - Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
    """
    priority: pulumi.Output[str]
    """
    Specifies the priority of this Virtual Machine. Possible values are `Regular` and `Spot`. Defaults to `Regular`. Changing this forces a new resource to be created.
    """
    private_ip_address: pulumi.Output[str]
    """
    The Primary Private IP Address assigned to this Virtual Machine.
    """
    private_ip_addresses: pulumi.Output[list]
    """
    A list of Private IP Addresses assigned to this Virtual Machine.
    """
    provision_vm_agent: pulumi.Output[bool]
    """
    Should the Azure VM Agent be provisioned on this Virtual Machine? Defaults to `true`. Changing this forces a new resource to be created.
    """
    proximity_placement_group_id: pulumi.Output[str]
    """
    The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.
    """
    public_ip_address: pulumi.Output[str]
    """
    The Primary Public IP Address assigned to this Virtual Machine.
    """
    public_ip_addresses: pulumi.Output[list]
    """
    A list of the Public IP Addresses assigned to this Virtual Machine.
    """
    resource_group_name: pulumi.Output[str]
    """
    The name of the Resource Group in which the Linux Virtual Machine should be exist. Changing this forces a new resource to be created.
    """
    secrets: pulumi.Output[list]
    """
    One or more `secret` blocks as defined below.

      * `certificates` (`list`) - One or more `certificate` blocks as defined above.
        * `url` (`str`) - The Secret URL of a Key Vault Certificate.

      * `key_vault_id` (`str`) - The ID of the Key Vault from which all Secrets should be sourced.
    """
    size: pulumi.Output[str]
    """
    The SKU which should be used for this Virtual Machine, such as `Standard_F2`.
    """
    source_image_id: pulumi.Output[str]
    """
    The ID of the Image which this Virtual Machine should be created from. Changing this forces a new resource to be created.
    """
    source_image_reference: pulumi.Output[dict]
    """
    A `source_image_reference` block as defined below. Changing this forces a new resource to be created.

      * `offer` (`str`)
      * `publisher` (`str`) - Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
      * `sku` (`str`)
      * `version` (`str`)
    """
    tags: pulumi.Output[dict]
    """
    A mapping of tags which should be assigned to this Virtual Machine.
    """
    virtual_machine_id: pulumi.Output[str]
    """
    A 128-bit identifier which uniquely identifies this Virtual Machine.
    """
    zone: pulumi.Output[str]
    """
    The Zone in which this Virtual Machine should be created. Changing this forces a new resource to be created.
    """
    def __init__(__self__, resource_name, opts=None, additional_capabilities=None, admin_password=None, admin_ssh_keys=None, admin_username=None, allow_extension_operations=None, availability_set_id=None, boot_diagnostics=None, computer_name=None, custom_data=None, dedicated_host_id=None, disable_password_authentication=None, eviction_policy=None, identity=None, location=None, max_bid_price=None, name=None, network_interface_ids=None, os_disk=None, plan=None, priority=None, provision_vm_agent=None, proximity_placement_group_id=None, resource_group_name=None, secrets=None, size=None, source_image_id=None, source_image_reference=None, tags=None, zone=None, __props__=None, __name__=None, __opts__=None):
        """
        Manages a Linux Virtual Machine.

        ## Disclaimers

        > **Note** This provider will automatically remove the OS Disk by default - this behaviour can be configured using the `features` configuration within the Provider configuration block.

        > **Note** This resource does not support Unmanaged Disks. If you need to use Unmanaged Disks you can continue to use the `compute.VirtualMachine` resource instead.

        > **Note** This resource does not support attaching existing OS Disks. You can instead capture an image of the OS Disk or continue to use the `compute.VirtualMachine` resource instead.

        > In this release there's a known issue where the `public_ip_address` and `public_ip_addresses` fields may not be fully populated for Dynamic Public IP's.



        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] additional_capabilities: A `additional_capabilities` block as defined below.
        :param pulumi.Input[str] admin_password: The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[list] admin_ssh_keys: One or more `admin_ssh_key` blocks as defined below.
        :param pulumi.Input[str] admin_username: The username of the local administrator used for the Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] allow_extension_operations: Should Extension Operations be allowed on this Virtual Machine? Changing this forces a new resource to be created.
        :param pulumi.Input[str] availability_set_id: Specifies the ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] boot_diagnostics: A `boot_diagnostics` block as defined below.
        :param pulumi.Input[str] computer_name: Specifies the Hostname which should be used for this Virtual Machine. If unspecified this defaults to the value for the `name` field. Changing this forces a new resource to be created.
        :param pulumi.Input[str] custom_data: The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[str] dedicated_host_id: The ID of a Dedicated Host where this machine should be run on. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] disable_password_authentication: Should Password Authentication be disabled on this Virtual Machine? Defaults to `true`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] eviction_policy: Specifies what should happen when the Virtual Machine is evicted for price reasons when using a Spot instance. At this time the only supported value is `Deallocate`. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] identity: An `identity` block as defined below.
        :param pulumi.Input[str] location: The Azure location where the Linux Virtual Machine should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[float] max_bid_price: The maximum price you're willing to pay for this Virtual Machine, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machine will be evicted using the `eviction_policy`. Defaults to `-1`, which means that the Virtual Machine should not be evicted for price reasons.
        :param pulumi.Input[str] name: The name of the Linux Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[list] network_interface_ids: . A list of Network Interface ID's which should be attached to this Virtual Machine. The first Network Interface ID in this list will be the Primary Network Interface on the Virtual Machine.
        :param pulumi.Input[dict] os_disk: A `os_disk` block as defined below.
        :param pulumi.Input[dict] plan: A `plan` block as defined below. Changing this forces a new resource to be created.
        :param pulumi.Input[str] priority: Specifies the priority of this Virtual Machine. Possible values are `Regular` and `Spot`. Defaults to `Regular`. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] provision_vm_agent: Should the Azure VM Agent be provisioned on this Virtual Machine? Defaults to `true`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] proximity_placement_group_id: The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Linux Virtual Machine should be exist. Changing this forces a new resource to be created.
        :param pulumi.Input[list] secrets: One or more `secret` blocks as defined below.
        :param pulumi.Input[str] size: The SKU which should be used for this Virtual Machine, such as `Standard_F2`.
        :param pulumi.Input[str] source_image_id: The ID of the Image which this Virtual Machine should be created from. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] source_image_reference: A `source_image_reference` block as defined below. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags which should be assigned to this Virtual Machine.
        :param pulumi.Input[str] zone: The Zone in which this Virtual Machine should be created. Changing this forces a new resource to be created.

        The **additional_capabilities** object supports the following:

          * `ultraSsdEnabled` (`pulumi.Input[bool]`) - Should the capacity to enable Data Disks of the `UltraSSD_LRS` storage account type be supported on this Virtual Machine? Defaults to `false`. Changing this forces a new resource to be created.

        The **admin_ssh_keys** object supports the following:

          * `publicKey` (`pulumi.Input[str]`) - The Public Key which should be used for authentication, which needs to be at least 2048-bit and in `ssh-rsa` format. Changing this forces a new resource to be created.
          * `username` (`pulumi.Input[str]`) - The Username for which this Public SSH Key should be configured. Changing this forces a new resource to be created.

        The **boot_diagnostics** object supports the following:

          * `storageAccountUri` (`pulumi.Input[str]`) - The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.

        The **identity** object supports the following:

          * `identityIds` (`pulumi.Input[list]`) - A list of User Managed Identity ID's which should be assigned to the Linux Virtual Machine.
          * `principal_id` (`pulumi.Input[str]`) - The ID of the System Managed Service Principal.
          * `type` (`pulumi.Input[str]`) - The type of Managed Identity which should be assigned to the Linux Virtual Machine. Possible values are `SystemAssigned`, `UserAssigned` and `SystemAssigned, UserAssigned`.

        The **os_disk** object supports the following:

          * `caching` (`pulumi.Input[str]`) - The Type of Caching which should be used for the Internal OS Disk. Possible values are `None`, `ReadOnly` and `ReadWrite`.
          * `diffDiskSettings` (`pulumi.Input[dict]`) - A `diff_disk_settings` block as defined above.
            * `option` (`pulumi.Input[str]`) - Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is `Local`. Changing this forces a new resource to be created.

          * `disk_encryption_set_id` (`pulumi.Input[str]`) - The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk.
          * `disk_size_gb` (`pulumi.Input[float]`) - The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine is sourced from.
          * `name` (`pulumi.Input[str]`) - The name which should be used for the Internal OS Disk. Changing this forces a new resource to be created.
          * `storage_account_type` (`pulumi.Input[str]`) - The Type of Storage Account which should back this the Internal OS Disk. Possible values are `Standard_LRS`, `StandardSSD_LRS` and `Premium_LRS`. Changing this forces a new resource to be created.
          * `write_accelerator_enabled` (`pulumi.Input[bool]`) - Should Write Accelerator be Enabled for this OS Disk? Defaults to `false`.

        The **plan** object supports the following:

          * `name` (`pulumi.Input[str]`) - Specifies the Name of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
          * `product` (`pulumi.Input[str]`) - Specifies the Product of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
          * `publisher` (`pulumi.Input[str]`) - Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.

        The **secrets** object supports the following:

          * `certificates` (`pulumi.Input[list]`) - One or more `certificate` blocks as defined above.
            * `url` (`pulumi.Input[str]`) - The Secret URL of a Key Vault Certificate.

          * `key_vault_id` (`pulumi.Input[str]`) - The ID of the Key Vault from which all Secrets should be sourced.

        The **source_image_reference** object supports the following:

          * `offer` (`pulumi.Input[str]`)
          * `publisher` (`pulumi.Input[str]`) - Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
          * `sku` (`pulumi.Input[str]`)
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

            __props__['additional_capabilities'] = additional_capabilities
            __props__['admin_password'] = admin_password
            __props__['admin_ssh_keys'] = admin_ssh_keys
            if admin_username is None:
                raise TypeError("Missing required property 'admin_username'")
            __props__['admin_username'] = admin_username
            __props__['allow_extension_operations'] = allow_extension_operations
            __props__['availability_set_id'] = availability_set_id
            __props__['boot_diagnostics'] = boot_diagnostics
            __props__['computer_name'] = computer_name
            __props__['custom_data'] = custom_data
            __props__['dedicated_host_id'] = dedicated_host_id
            __props__['disable_password_authentication'] = disable_password_authentication
            __props__['eviction_policy'] = eviction_policy
            __props__['identity'] = identity
            __props__['location'] = location
            __props__['max_bid_price'] = max_bid_price
            __props__['name'] = name
            if network_interface_ids is None:
                raise TypeError("Missing required property 'network_interface_ids'")
            __props__['network_interface_ids'] = network_interface_ids
            if os_disk is None:
                raise TypeError("Missing required property 'os_disk'")
            __props__['os_disk'] = os_disk
            __props__['plan'] = plan
            __props__['priority'] = priority
            __props__['provision_vm_agent'] = provision_vm_agent
            __props__['proximity_placement_group_id'] = proximity_placement_group_id
            if resource_group_name is None:
                raise TypeError("Missing required property 'resource_group_name'")
            __props__['resource_group_name'] = resource_group_name
            __props__['secrets'] = secrets
            if size is None:
                raise TypeError("Missing required property 'size'")
            __props__['size'] = size
            __props__['source_image_id'] = source_image_id
            __props__['source_image_reference'] = source_image_reference
            __props__['tags'] = tags
            __props__['zone'] = zone
            __props__['private_ip_address'] = None
            __props__['private_ip_addresses'] = None
            __props__['public_ip_address'] = None
            __props__['public_ip_addresses'] = None
            __props__['virtual_machine_id'] = None
        super(LinuxVirtualMachine, __self__).__init__(
            'azure:compute/linuxVirtualMachine:LinuxVirtualMachine',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name, id, opts=None, additional_capabilities=None, admin_password=None, admin_ssh_keys=None, admin_username=None, allow_extension_operations=None, availability_set_id=None, boot_diagnostics=None, computer_name=None, custom_data=None, dedicated_host_id=None, disable_password_authentication=None, eviction_policy=None, identity=None, location=None, max_bid_price=None, name=None, network_interface_ids=None, os_disk=None, plan=None, priority=None, private_ip_address=None, private_ip_addresses=None, provision_vm_agent=None, proximity_placement_group_id=None, public_ip_address=None, public_ip_addresses=None, resource_group_name=None, secrets=None, size=None, source_image_id=None, source_image_reference=None, tags=None, virtual_machine_id=None, zone=None):
        """
        Get an existing LinuxVirtualMachine resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param str id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[dict] additional_capabilities: A `additional_capabilities` block as defined below.
        :param pulumi.Input[str] admin_password: The Password which should be used for the local-administrator on this Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[list] admin_ssh_keys: One or more `admin_ssh_key` blocks as defined below.
        :param pulumi.Input[str] admin_username: The username of the local administrator used for the Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] allow_extension_operations: Should Extension Operations be allowed on this Virtual Machine? Changing this forces a new resource to be created.
        :param pulumi.Input[str] availability_set_id: Specifies the ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] boot_diagnostics: A `boot_diagnostics` block as defined below.
        :param pulumi.Input[str] computer_name: Specifies the Hostname which should be used for this Virtual Machine. If unspecified this defaults to the value for the `name` field. Changing this forces a new resource to be created.
        :param pulumi.Input[str] custom_data: The Base64-Encoded Custom Data which should be used for this Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[str] dedicated_host_id: The ID of a Dedicated Host where this machine should be run on. Changing this forces a new resource to be created.
        :param pulumi.Input[bool] disable_password_authentication: Should Password Authentication be disabled on this Virtual Machine? Defaults to `true`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] eviction_policy: Specifies what should happen when the Virtual Machine is evicted for price reasons when using a Spot instance. At this time the only supported value is `Deallocate`. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] identity: An `identity` block as defined below.
        :param pulumi.Input[str] location: The Azure location where the Linux Virtual Machine should exist. Changing this forces a new resource to be created.
        :param pulumi.Input[float] max_bid_price: The maximum price you're willing to pay for this Virtual Machine, in US Dollars; which must be greater than the current spot price. If this bid price falls below the current spot price the Virtual Machine will be evicted using the `eviction_policy`. Defaults to `-1`, which means that the Virtual Machine should not be evicted for price reasons.
        :param pulumi.Input[str] name: The name of the Linux Virtual Machine. Changing this forces a new resource to be created.
        :param pulumi.Input[list] network_interface_ids: . A list of Network Interface ID's which should be attached to this Virtual Machine. The first Network Interface ID in this list will be the Primary Network Interface on the Virtual Machine.
        :param pulumi.Input[dict] os_disk: A `os_disk` block as defined below.
        :param pulumi.Input[dict] plan: A `plan` block as defined below. Changing this forces a new resource to be created.
        :param pulumi.Input[str] priority: Specifies the priority of this Virtual Machine. Possible values are `Regular` and `Spot`. Defaults to `Regular`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] private_ip_address: The Primary Private IP Address assigned to this Virtual Machine.
        :param pulumi.Input[list] private_ip_addresses: A list of Private IP Addresses assigned to this Virtual Machine.
        :param pulumi.Input[bool] provision_vm_agent: Should the Azure VM Agent be provisioned on this Virtual Machine? Defaults to `true`. Changing this forces a new resource to be created.
        :param pulumi.Input[str] proximity_placement_group_id: The ID of the Proximity Placement Group which the Virtual Machine should be assigned to. Changing this forces a new resource to be created.
        :param pulumi.Input[str] public_ip_address: The Primary Public IP Address assigned to this Virtual Machine.
        :param pulumi.Input[list] public_ip_addresses: A list of the Public IP Addresses assigned to this Virtual Machine.
        :param pulumi.Input[str] resource_group_name: The name of the Resource Group in which the Linux Virtual Machine should be exist. Changing this forces a new resource to be created.
        :param pulumi.Input[list] secrets: One or more `secret` blocks as defined below.
        :param pulumi.Input[str] size: The SKU which should be used for this Virtual Machine, such as `Standard_F2`.
        :param pulumi.Input[str] source_image_id: The ID of the Image which this Virtual Machine should be created from. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] source_image_reference: A `source_image_reference` block as defined below. Changing this forces a new resource to be created.
        :param pulumi.Input[dict] tags: A mapping of tags which should be assigned to this Virtual Machine.
        :param pulumi.Input[str] virtual_machine_id: A 128-bit identifier which uniquely identifies this Virtual Machine.
        :param pulumi.Input[str] zone: The Zone in which this Virtual Machine should be created. Changing this forces a new resource to be created.

        The **additional_capabilities** object supports the following:

          * `ultraSsdEnabled` (`pulumi.Input[bool]`) - Should the capacity to enable Data Disks of the `UltraSSD_LRS` storage account type be supported on this Virtual Machine? Defaults to `false`. Changing this forces a new resource to be created.

        The **admin_ssh_keys** object supports the following:

          * `publicKey` (`pulumi.Input[str]`) - The Public Key which should be used for authentication, which needs to be at least 2048-bit and in `ssh-rsa` format. Changing this forces a new resource to be created.
          * `username` (`pulumi.Input[str]`) - The Username for which this Public SSH Key should be configured. Changing this forces a new resource to be created.

        The **boot_diagnostics** object supports the following:

          * `storageAccountUri` (`pulumi.Input[str]`) - The Primary/Secondary Endpoint for the Azure Storage Account which should be used to store Boot Diagnostics, including Console Output and Screenshots from the Hypervisor.

        The **identity** object supports the following:

          * `identityIds` (`pulumi.Input[list]`) - A list of User Managed Identity ID's which should be assigned to the Linux Virtual Machine.
          * `principal_id` (`pulumi.Input[str]`) - The ID of the System Managed Service Principal.
          * `type` (`pulumi.Input[str]`) - The type of Managed Identity which should be assigned to the Linux Virtual Machine. Possible values are `SystemAssigned`, `UserAssigned` and `SystemAssigned, UserAssigned`.

        The **os_disk** object supports the following:

          * `caching` (`pulumi.Input[str]`) - The Type of Caching which should be used for the Internal OS Disk. Possible values are `None`, `ReadOnly` and `ReadWrite`.
          * `diffDiskSettings` (`pulumi.Input[dict]`) - A `diff_disk_settings` block as defined above.
            * `option` (`pulumi.Input[str]`) - Specifies the Ephemeral Disk Settings for the OS Disk. At this time the only possible value is `Local`. Changing this forces a new resource to be created.

          * `disk_encryption_set_id` (`pulumi.Input[str]`) - The ID of the Disk Encryption Set which should be used to Encrypt this OS Disk.
          * `disk_size_gb` (`pulumi.Input[float]`) - The Size of the Internal OS Disk in GB, if you wish to vary from the size used in the image this Virtual Machine is sourced from.
          * `name` (`pulumi.Input[str]`) - The name which should be used for the Internal OS Disk. Changing this forces a new resource to be created.
          * `storage_account_type` (`pulumi.Input[str]`) - The Type of Storage Account which should back this the Internal OS Disk. Possible values are `Standard_LRS`, `StandardSSD_LRS` and `Premium_LRS`. Changing this forces a new resource to be created.
          * `write_accelerator_enabled` (`pulumi.Input[bool]`) - Should Write Accelerator be Enabled for this OS Disk? Defaults to `false`.

        The **plan** object supports the following:

          * `name` (`pulumi.Input[str]`) - Specifies the Name of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
          * `product` (`pulumi.Input[str]`) - Specifies the Product of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
          * `publisher` (`pulumi.Input[str]`) - Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.

        The **secrets** object supports the following:

          * `certificates` (`pulumi.Input[list]`) - One or more `certificate` blocks as defined above.
            * `url` (`pulumi.Input[str]`) - The Secret URL of a Key Vault Certificate.

          * `key_vault_id` (`pulumi.Input[str]`) - The ID of the Key Vault from which all Secrets should be sourced.

        The **source_image_reference** object supports the following:

          * `offer` (`pulumi.Input[str]`)
          * `publisher` (`pulumi.Input[str]`) - Specifies the Publisher of the Marketplace Image this Virtual Machine should be created from. Changing this forces a new resource to be created.
          * `sku` (`pulumi.Input[str]`)
          * `version` (`pulumi.Input[str]`)
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = dict()

        __props__["additional_capabilities"] = additional_capabilities
        __props__["admin_password"] = admin_password
        __props__["admin_ssh_keys"] = admin_ssh_keys
        __props__["admin_username"] = admin_username
        __props__["allow_extension_operations"] = allow_extension_operations
        __props__["availability_set_id"] = availability_set_id
        __props__["boot_diagnostics"] = boot_diagnostics
        __props__["computer_name"] = computer_name
        __props__["custom_data"] = custom_data
        __props__["dedicated_host_id"] = dedicated_host_id
        __props__["disable_password_authentication"] = disable_password_authentication
        __props__["eviction_policy"] = eviction_policy
        __props__["identity"] = identity
        __props__["location"] = location
        __props__["max_bid_price"] = max_bid_price
        __props__["name"] = name
        __props__["network_interface_ids"] = network_interface_ids
        __props__["os_disk"] = os_disk
        __props__["plan"] = plan
        __props__["priority"] = priority
        __props__["private_ip_address"] = private_ip_address
        __props__["private_ip_addresses"] = private_ip_addresses
        __props__["provision_vm_agent"] = provision_vm_agent
        __props__["proximity_placement_group_id"] = proximity_placement_group_id
        __props__["public_ip_address"] = public_ip_address
        __props__["public_ip_addresses"] = public_ip_addresses
        __props__["resource_group_name"] = resource_group_name
        __props__["secrets"] = secrets
        __props__["size"] = size
        __props__["source_image_id"] = source_image_id
        __props__["source_image_reference"] = source_image_reference
        __props__["tags"] = tags
        __props__["virtual_machine_id"] = virtual_machine_id
        __props__["zone"] = zone
        return LinuxVirtualMachine(resource_name, opts=opts, __props__=__props__)
    def translate_output_property(self, prop):
        return tables._CAMEL_TO_SNAKE_CASE_TABLE.get(prop) or prop

    def translate_input_property(self, prop):
        return tables._SNAKE_TO_CAMEL_CASE_TABLE.get(prop) or prop

