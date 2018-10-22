# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import pulumi
import pulumi.runtime
from .. import utilities

class LinuxVirtualMachine(pulumi.CustomResource):
    """
    Manages a Linux Virtual Machine within a Dev Test Lab.
    """
    def __init__(__self__, __name__, __opts__=None, allow_claim=None, disallow_public_ip_address=None, gallery_image_reference=None, inbound_nat_rules=None, lab_name=None, lab_subnet_name=None, lab_virtual_network_id=None, location=None, name=None, notes=None, password=None, resource_group_name=None, size=None, ssh_key=None, storage_type=None, tags=None, username=None):
        """Create a LinuxVirtualMachine resource with the given unique name, props, and options."""
        if not __name__:
            raise TypeError('Missing resource name argument (for URN creation)')
        if not isinstance(__name__, basestring):
            raise TypeError('Expected resource name to be a string')
        if __opts__ and not isinstance(__opts__, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')

        __props__ = dict()

        if allow_claim and not isinstance(allow_claim, bool):
            raise TypeError('Expected property allow_claim to be a bool')
        __self__.allow_claim = allow_claim
        """
        Can this Virtual Machine be claimed by users? Defaults to `true`.
        """
        __props__['allowClaim'] = allow_claim

        if disallow_public_ip_address and not isinstance(disallow_public_ip_address, bool):
            raise TypeError('Expected property disallow_public_ip_address to be a bool')
        __self__.disallow_public_ip_address = disallow_public_ip_address
        """
        Should the Virtual Machine be created without a Public IP Address? Changing this forces a new resource to be created.
        """
        __props__['disallowPublicIpAddress'] = disallow_public_ip_address

        if not gallery_image_reference:
            raise TypeError('Missing required property gallery_image_reference')
        elif not isinstance(gallery_image_reference, dict):
            raise TypeError('Expected property gallery_image_reference to be a dict')
        __self__.gallery_image_reference = gallery_image_reference
        """
        A `gallery_image_reference` block as defined below.
        """
        __props__['galleryImageReference'] = gallery_image_reference

        if inbound_nat_rules and not isinstance(inbound_nat_rules, list):
            raise TypeError('Expected property inbound_nat_rules to be a list')
        __self__.inbound_nat_rules = inbound_nat_rules
        """
        One or more `inbound_nat_rule` blocks as defined below. Changing this forces a new resource to be created.
        """
        __props__['inboundNatRules'] = inbound_nat_rules

        if not lab_name:
            raise TypeError('Missing required property lab_name')
        elif not isinstance(lab_name, basestring):
            raise TypeError('Expected property lab_name to be a basestring')
        __self__.lab_name = lab_name
        """
        Specifies the name of the Dev Test Lab in which the Virtual Machine should be created. Changing this forces a new resource to be created.
        """
        __props__['labName'] = lab_name

        if not lab_subnet_name:
            raise TypeError('Missing required property lab_subnet_name')
        elif not isinstance(lab_subnet_name, basestring):
            raise TypeError('Expected property lab_subnet_name to be a basestring')
        __self__.lab_subnet_name = lab_subnet_name
        """
        The name of a Subnet within the Dev Test Virtual Network where this machine should exist. Changing this forces a new resource to be created.
        """
        __props__['labSubnetName'] = lab_subnet_name

        if not lab_virtual_network_id:
            raise TypeError('Missing required property lab_virtual_network_id')
        elif not isinstance(lab_virtual_network_id, basestring):
            raise TypeError('Expected property lab_virtual_network_id to be a basestring')
        __self__.lab_virtual_network_id = lab_virtual_network_id
        """
        The ID of the Dev Test Virtual Network where this Virtual Machine should be created. Changing this forces a new resource to be created.
        """
        __props__['labVirtualNetworkId'] = lab_virtual_network_id

        if not location:
            raise TypeError('Missing required property location')
        elif not isinstance(location, basestring):
            raise TypeError('Expected property location to be a basestring')
        __self__.location = location
        """
        Specifies the supported Azure location where the Dev Test Lab exists. Changing this forces a new resource to be created.
        """
        __props__['location'] = location

        if name and not isinstance(name, basestring):
            raise TypeError('Expected property name to be a basestring')
        __self__.name = name
        """
        Specifies the name of the Dev Test Machine. Changing this forces a new resource to be created.
        """
        __props__['name'] = name

        if notes and not isinstance(notes, basestring):
            raise TypeError('Expected property notes to be a basestring')
        __self__.notes = notes
        """
        Any notes about the Virtual Machine.
        """
        __props__['notes'] = notes

        if password and not isinstance(password, basestring):
            raise TypeError('Expected property password to be a basestring')
        __self__.password = password
        """
        The Password associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        """
        __props__['password'] = password

        if not resource_group_name:
            raise TypeError('Missing required property resource_group_name')
        elif not isinstance(resource_group_name, basestring):
            raise TypeError('Expected property resource_group_name to be a basestring')
        __self__.resource_group_name = resource_group_name
        """
        The name of the resource group in which the Dev Test Lab resource exists. Changing this forces a new resource to be created.
        """
        __props__['resourceGroupName'] = resource_group_name

        if not size:
            raise TypeError('Missing required property size')
        elif not isinstance(size, basestring):
            raise TypeError('Expected property size to be a basestring')
        __self__.size = size
        """
        The Machine Size to use for this Virtual Machine, such as `Standard_F2`. Changing this forces a new resource to be created.
        """
        __props__['size'] = size

        if ssh_key and not isinstance(ssh_key, basestring):
            raise TypeError('Expected property ssh_key to be a basestring')
        __self__.ssh_key = ssh_key
        """
        The SSH Key associated with the `username` used to login to this Virtual Machine. Changing this forces a new resource to be created.
        """
        __props__['sshKey'] = ssh_key

        if not storage_type:
            raise TypeError('Missing required property storage_type')
        elif not isinstance(storage_type, basestring):
            raise TypeError('Expected property storage_type to be a basestring')
        __self__.storage_type = storage_type
        """
        The type of Storage to use on this Virtual Machine. Possible values are `Standard` and `Premium`.
        """
        __props__['storageType'] = storage_type

        if tags and not isinstance(tags, dict):
            raise TypeError('Expected property tags to be a dict')
        __self__.tags = tags
        """
        A mapping of tags to assign to the resource.
        """
        __props__['tags'] = tags

        if not username:
            raise TypeError('Missing required property username')
        elif not isinstance(username, basestring):
            raise TypeError('Expected property username to be a basestring')
        __self__.username = username
        """
        The Username associated with the local administrator on this Virtual Machine. Changing this forces a new resource to be created.
        """
        __props__['username'] = username

        __self__.fqdn = pulumi.runtime.UNKNOWN
        """
        The FQDN of the Virtual Machine.
        """
        __self__.unique_identifier = pulumi.runtime.UNKNOWN
        """
        The unique immutable identifier of the Virtual Machine.
        """

        super(LinuxVirtualMachine, __self__).__init__(
            'azure:devtest/linuxVirtualMachine:LinuxVirtualMachine',
            __name__,
            __props__,
            __opts__)

    def set_outputs(self, outs):
        if 'allowClaim' in outs:
            self.allow_claim = outs['allowClaim']
        if 'disallowPublicIpAddress' in outs:
            self.disallow_public_ip_address = outs['disallowPublicIpAddress']
        if 'fqdn' in outs:
            self.fqdn = outs['fqdn']
        if 'galleryImageReference' in outs:
            self.gallery_image_reference = outs['galleryImageReference']
        if 'inboundNatRules' in outs:
            self.inbound_nat_rules = outs['inboundNatRules']
        if 'labName' in outs:
            self.lab_name = outs['labName']
        if 'labSubnetName' in outs:
            self.lab_subnet_name = outs['labSubnetName']
        if 'labVirtualNetworkId' in outs:
            self.lab_virtual_network_id = outs['labVirtualNetworkId']
        if 'location' in outs:
            self.location = outs['location']
        if 'name' in outs:
            self.name = outs['name']
        if 'notes' in outs:
            self.notes = outs['notes']
        if 'password' in outs:
            self.password = outs['password']
        if 'resourceGroupName' in outs:
            self.resource_group_name = outs['resourceGroupName']
        if 'size' in outs:
            self.size = outs['size']
        if 'sshKey' in outs:
            self.ssh_key = outs['sshKey']
        if 'storageType' in outs:
            self.storage_type = outs['storageType']
        if 'tags' in outs:
            self.tags = outs['tags']
        if 'uniqueIdentifier' in outs:
            self.unique_identifier = outs['uniqueIdentifier']
        if 'username' in outs:
            self.username = outs['username']
