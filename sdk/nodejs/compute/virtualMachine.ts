// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Virtual Machine.
 *
 * ## Disclaimers
 *
 * > **Note:** The `azure.compute.VirtualMachine` resource has been superseded by the `azure.compute.LinuxVirtualMachine` and `azure.compute.WindowsVirtualMachine` resources. The existing `azure.compute.VirtualMachine` resource will continue to be available throughout the 2.x releases however is in a feature-frozen state to maintain compatibility - new functionality will instead be added to the `azure.compute.LinuxVirtualMachine` and `azure.compute.WindowsVirtualMachine` resources.
 *
 * > **Note:** Data Disks can be attached either directly on the `azure.compute.VirtualMachine` resource, or using the `azure.compute.DataDiskAttachment` resource - but the two cannot be used together. If both are used against the same Virtual Machine, spurious changes will occur.
 *
 * ## Example Usage
 * ### From An Azure Platform Image)
 *
 * This example provisions a Virtual Machine with Managed Disks.
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const config = new pulumi.Config();
 * const prefix = config.get("prefix") || "tfvmex";
 * const mainResourceGroup = new azure.core.ResourceGroup("mainResourceGroup", {location: "West US 2"});
 * const mainVirtualNetwork = new azure.network.VirtualNetwork("mainVirtualNetwork", {
 *     addressSpaces: ["10.0.0.0/16"],
 *     location: mainResourceGroup.location,
 *     resourceGroupName: mainResourceGroup.name,
 * });
 * const internal = new azure.network.Subnet("internal", {
 *     resourceGroupName: mainResourceGroup.name,
 *     virtualNetworkName: mainVirtualNetwork.name,
 *     addressPrefix: "10.0.2.0/24",
 * });
 * const mainNetworkInterface = new azure.network.NetworkInterface("mainNetworkInterface", {
 *     location: mainResourceGroup.location,
 *     resourceGroupName: mainResourceGroup.name,
 *     ipConfigurations: [{
 *         name: "testconfiguration1",
 *         subnetId: internal.id,
 *         privateIpAddressAllocation: "Dynamic",
 *     }],
 * });
 * const mainVirtualMachine = new azure.compute.VirtualMachine("mainVirtualMachine", {
 *     location: mainResourceGroup.location,
 *     resourceGroupName: mainResourceGroup.name,
 *     networkInterfaceIds: [mainNetworkInterface.id],
 *     vmSize: "Standard_DS1_v2",
 *     storageImageReference: {
 *         publisher: "Canonical",
 *         offer: "UbuntuServer",
 *         sku: "16.04-LTS",
 *         version: "latest",
 *     },
 *     storageOsDisk: {
 *         name: "myosdisk1",
 *         caching: "ReadWrite",
 *         createOption: "FromImage",
 *         managedDiskType: "Standard_LRS",
 *     },
 *     osProfile: {
 *         computerName: "hostname",
 *         adminUsername: "testadmin",
 *         adminPassword: "Password1234!",
 *     },
 *     osProfileLinuxConfig: {
 *         disablePasswordAuthentication: false,
 *     },
 *     tags: {
 *         environment: "staging",
 *     },
 * });
 * ```
 */
export class VirtualMachine extends pulumi.CustomResource {
    /**
     * Get an existing VirtualMachine resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VirtualMachineState, opts?: pulumi.CustomResourceOptions): VirtualMachine {
        return new VirtualMachine(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:compute/virtualMachine:VirtualMachine';

    /**
     * Returns true if the given object is an instance of VirtualMachine.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is VirtualMachine {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === VirtualMachine.__pulumiType;
    }

    /**
     * A `additionalCapabilities` block.
     */
    public readonly additionalCapabilities!: pulumi.Output<outputs.compute.VirtualMachineAdditionalCapabilities | undefined>;
    /**
     * The ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    public readonly availabilitySetId!: pulumi.Output<string>;
    /**
     * A `bootDiagnostics` block.
     */
    public readonly bootDiagnostics!: pulumi.Output<outputs.compute.VirtualMachineBootDiagnostics | undefined>;
    /**
     * Should the Data Disks (either the Managed Disks / VHD Blobs) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    public readonly deleteDataDisksOnTermination!: pulumi.Output<boolean | undefined>;
    /**
     * Should the OS Disk (either the Managed Disk / VHD Blob) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    public readonly deleteOsDiskOnTermination!: pulumi.Output<boolean | undefined>;
    /**
     * A `identity` block.
     */
    public readonly identity!: pulumi.Output<outputs.compute.VirtualMachineIdentity>;
    /**
     * Specifies the BYOL Type for this Virtual Machine. This is only applicable to Windows Virtual Machines. Possible values are `Windows_Client` and `Windows_Server`.
     */
    public readonly licenseType!: pulumi.Output<string>;
    /**
     * Specifies the Azure Region where the Virtual Machine exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the Virtual Machine. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A list of Network Interface ID's which should be associated with the Virtual Machine.
     */
    public readonly networkInterfaceIds!: pulumi.Output<string[]>;
    /**
     * An `osProfile` block. Required when `createOption` in the `storageOsDisk` block is set to `FromImage`.
     */
    public readonly osProfile!: pulumi.Output<outputs.compute.VirtualMachineOsProfile | undefined>;
    /**
     * A `osProfileLinuxConfig` block.
     */
    public readonly osProfileLinuxConfig!: pulumi.Output<outputs.compute.VirtualMachineOsProfileLinuxConfig | undefined>;
    /**
     * One or more `osProfileSecrets` blocks.
     */
    public readonly osProfileSecrets!: pulumi.Output<outputs.compute.VirtualMachineOsProfileSecret[] | undefined>;
    /**
     * A `osProfileWindowsConfig` block.
     */
    public readonly osProfileWindowsConfig!: pulumi.Output<outputs.compute.VirtualMachineOsProfileWindowsConfig | undefined>;
    /**
     * A `plan` block.
     */
    public readonly plan!: pulumi.Output<outputs.compute.VirtualMachinePlan | undefined>;
    /**
     * The ID of the Network Interface (which must be attached to the Virtual Machine) which should be the Primary Network Interface for this Virtual Machine.
     */
    public readonly primaryNetworkInterfaceId!: pulumi.Output<string | undefined>;
    /**
     * The ID of the Proximity Placement Group to which this Virtual Machine should be assigned. Changing this forces a new resource to be created
     */
    public readonly proximityPlacementGroupId!: pulumi.Output<string | undefined>;
    /**
     * Specifies the name of the Resource Group in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * One or more `storageDataDisk` blocks.
     */
    public readonly storageDataDisks!: pulumi.Output<outputs.compute.VirtualMachineStorageDataDisk[]>;
    /**
     * A `storageImageReference` block.
     */
    public readonly storageImageReference!: pulumi.Output<outputs.compute.VirtualMachineStorageImageReference>;
    /**
     * A `storageOsDisk` block.
     */
    public readonly storageOsDisk!: pulumi.Output<outputs.compute.VirtualMachineStorageOsDisk>;
    /**
     * A mapping of tags to assign to the Virtual Machine.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * Specifies the [size of the Virtual Machine](https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-size-specs/).
     */
    public readonly vmSize!: pulumi.Output<string>;
    /**
     * A list of a single item of the Availability Zone which the Virtual Machine should be allocated in.
     */
    public readonly zones!: pulumi.Output<string | undefined>;

    /**
     * Create a VirtualMachine resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VirtualMachineArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VirtualMachineArgs | VirtualMachineState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as VirtualMachineState | undefined;
            inputs["additionalCapabilities"] = state ? state.additionalCapabilities : undefined;
            inputs["availabilitySetId"] = state ? state.availabilitySetId : undefined;
            inputs["bootDiagnostics"] = state ? state.bootDiagnostics : undefined;
            inputs["deleteDataDisksOnTermination"] = state ? state.deleteDataDisksOnTermination : undefined;
            inputs["deleteOsDiskOnTermination"] = state ? state.deleteOsDiskOnTermination : undefined;
            inputs["identity"] = state ? state.identity : undefined;
            inputs["licenseType"] = state ? state.licenseType : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkInterfaceIds"] = state ? state.networkInterfaceIds : undefined;
            inputs["osProfile"] = state ? state.osProfile : undefined;
            inputs["osProfileLinuxConfig"] = state ? state.osProfileLinuxConfig : undefined;
            inputs["osProfileSecrets"] = state ? state.osProfileSecrets : undefined;
            inputs["osProfileWindowsConfig"] = state ? state.osProfileWindowsConfig : undefined;
            inputs["plan"] = state ? state.plan : undefined;
            inputs["primaryNetworkInterfaceId"] = state ? state.primaryNetworkInterfaceId : undefined;
            inputs["proximityPlacementGroupId"] = state ? state.proximityPlacementGroupId : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["storageDataDisks"] = state ? state.storageDataDisks : undefined;
            inputs["storageImageReference"] = state ? state.storageImageReference : undefined;
            inputs["storageOsDisk"] = state ? state.storageOsDisk : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["vmSize"] = state ? state.vmSize : undefined;
            inputs["zones"] = state ? state.zones : undefined;
        } else {
            const args = argsOrState as VirtualMachineArgs | undefined;
            if (!args || args.networkInterfaceIds === undefined) {
                throw new Error("Missing required property 'networkInterfaceIds'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.storageOsDisk === undefined) {
                throw new Error("Missing required property 'storageOsDisk'");
            }
            if (!args || args.vmSize === undefined) {
                throw new Error("Missing required property 'vmSize'");
            }
            inputs["additionalCapabilities"] = args ? args.additionalCapabilities : undefined;
            inputs["availabilitySetId"] = args ? args.availabilitySetId : undefined;
            inputs["bootDiagnostics"] = args ? args.bootDiagnostics : undefined;
            inputs["deleteDataDisksOnTermination"] = args ? args.deleteDataDisksOnTermination : undefined;
            inputs["deleteOsDiskOnTermination"] = args ? args.deleteOsDiskOnTermination : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["licenseType"] = args ? args.licenseType : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkInterfaceIds"] = args ? args.networkInterfaceIds : undefined;
            inputs["osProfile"] = args ? args.osProfile : undefined;
            inputs["osProfileLinuxConfig"] = args ? args.osProfileLinuxConfig : undefined;
            inputs["osProfileSecrets"] = args ? args.osProfileSecrets : undefined;
            inputs["osProfileWindowsConfig"] = args ? args.osProfileWindowsConfig : undefined;
            inputs["plan"] = args ? args.plan : undefined;
            inputs["primaryNetworkInterfaceId"] = args ? args.primaryNetworkInterfaceId : undefined;
            inputs["proximityPlacementGroupId"] = args ? args.proximityPlacementGroupId : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["storageDataDisks"] = args ? args.storageDataDisks : undefined;
            inputs["storageImageReference"] = args ? args.storageImageReference : undefined;
            inputs["storageOsDisk"] = args ? args.storageOsDisk : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["vmSize"] = args ? args.vmSize : undefined;
            inputs["zones"] = args ? args.zones : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(VirtualMachine.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering VirtualMachine resources.
 */
export interface VirtualMachineState {
    /**
     * A `additionalCapabilities` block.
     */
    readonly additionalCapabilities?: pulumi.Input<inputs.compute.VirtualMachineAdditionalCapabilities>;
    /**
     * The ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly availabilitySetId?: pulumi.Input<string>;
    /**
     * A `bootDiagnostics` block.
     */
    readonly bootDiagnostics?: pulumi.Input<inputs.compute.VirtualMachineBootDiagnostics>;
    /**
     * Should the Data Disks (either the Managed Disks / VHD Blobs) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteDataDisksOnTermination?: pulumi.Input<boolean>;
    /**
     * Should the OS Disk (either the Managed Disk / VHD Blob) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteOsDiskOnTermination?: pulumi.Input<boolean>;
    /**
     * A `identity` block.
     */
    readonly identity?: pulumi.Input<inputs.compute.VirtualMachineIdentity>;
    /**
     * Specifies the BYOL Type for this Virtual Machine. This is only applicable to Windows Virtual Machines. Possible values are `Windows_Client` and `Windows_Server`.
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * Specifies the Azure Region where the Virtual Machine exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Virtual Machine. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of Network Interface ID's which should be associated with the Virtual Machine.
     */
    readonly networkInterfaceIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An `osProfile` block. Required when `createOption` in the `storageOsDisk` block is set to `FromImage`.
     */
    readonly osProfile?: pulumi.Input<inputs.compute.VirtualMachineOsProfile>;
    /**
     * A `osProfileLinuxConfig` block.
     */
    readonly osProfileLinuxConfig?: pulumi.Input<inputs.compute.VirtualMachineOsProfileLinuxConfig>;
    /**
     * One or more `osProfileSecrets` blocks.
     */
    readonly osProfileSecrets?: pulumi.Input<pulumi.Input<inputs.compute.VirtualMachineOsProfileSecret>[]>;
    /**
     * A `osProfileWindowsConfig` block.
     */
    readonly osProfileWindowsConfig?: pulumi.Input<inputs.compute.VirtualMachineOsProfileWindowsConfig>;
    /**
     * A `plan` block.
     */
    readonly plan?: pulumi.Input<inputs.compute.VirtualMachinePlan>;
    /**
     * The ID of the Network Interface (which must be attached to the Virtual Machine) which should be the Primary Network Interface for this Virtual Machine.
     */
    readonly primaryNetworkInterfaceId?: pulumi.Input<string>;
    /**
     * The ID of the Proximity Placement Group to which this Virtual Machine should be assigned. Changing this forces a new resource to be created
     */
    readonly proximityPlacementGroupId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Resource Group in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * One or more `storageDataDisk` blocks.
     */
    readonly storageDataDisks?: pulumi.Input<pulumi.Input<inputs.compute.VirtualMachineStorageDataDisk>[]>;
    /**
     * A `storageImageReference` block.
     */
    readonly storageImageReference?: pulumi.Input<inputs.compute.VirtualMachineStorageImageReference>;
    /**
     * A `storageOsDisk` block.
     */
    readonly storageOsDisk?: pulumi.Input<inputs.compute.VirtualMachineStorageOsDisk>;
    /**
     * A mapping of tags to assign to the Virtual Machine.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the [size of the Virtual Machine](https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-size-specs/).
     */
    readonly vmSize?: pulumi.Input<string>;
    /**
     * A list of a single item of the Availability Zone which the Virtual Machine should be allocated in.
     */
    readonly zones?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a VirtualMachine resource.
 */
export interface VirtualMachineArgs {
    /**
     * A `additionalCapabilities` block.
     */
    readonly additionalCapabilities?: pulumi.Input<inputs.compute.VirtualMachineAdditionalCapabilities>;
    /**
     * The ID of the Availability Set in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly availabilitySetId?: pulumi.Input<string>;
    /**
     * A `bootDiagnostics` block.
     */
    readonly bootDiagnostics?: pulumi.Input<inputs.compute.VirtualMachineBootDiagnostics>;
    /**
     * Should the Data Disks (either the Managed Disks / VHD Blobs) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteDataDisksOnTermination?: pulumi.Input<boolean>;
    /**
     * Should the OS Disk (either the Managed Disk / VHD Blob) be deleted when the Virtual Machine is destroyed? Defaults to `false`.
     */
    readonly deleteOsDiskOnTermination?: pulumi.Input<boolean>;
    /**
     * A `identity` block.
     */
    readonly identity?: pulumi.Input<inputs.compute.VirtualMachineIdentity>;
    /**
     * Specifies the BYOL Type for this Virtual Machine. This is only applicable to Windows Virtual Machines. Possible values are `Windows_Client` and `Windows_Server`.
     */
    readonly licenseType?: pulumi.Input<string>;
    /**
     * Specifies the Azure Region where the Virtual Machine exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Virtual Machine. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of Network Interface ID's which should be associated with the Virtual Machine.
     */
    readonly networkInterfaceIds: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * An `osProfile` block. Required when `createOption` in the `storageOsDisk` block is set to `FromImage`.
     */
    readonly osProfile?: pulumi.Input<inputs.compute.VirtualMachineOsProfile>;
    /**
     * A `osProfileLinuxConfig` block.
     */
    readonly osProfileLinuxConfig?: pulumi.Input<inputs.compute.VirtualMachineOsProfileLinuxConfig>;
    /**
     * One or more `osProfileSecrets` blocks.
     */
    readonly osProfileSecrets?: pulumi.Input<pulumi.Input<inputs.compute.VirtualMachineOsProfileSecret>[]>;
    /**
     * A `osProfileWindowsConfig` block.
     */
    readonly osProfileWindowsConfig?: pulumi.Input<inputs.compute.VirtualMachineOsProfileWindowsConfig>;
    /**
     * A `plan` block.
     */
    readonly plan?: pulumi.Input<inputs.compute.VirtualMachinePlan>;
    /**
     * The ID of the Network Interface (which must be attached to the Virtual Machine) which should be the Primary Network Interface for this Virtual Machine.
     */
    readonly primaryNetworkInterfaceId?: pulumi.Input<string>;
    /**
     * The ID of the Proximity Placement Group to which this Virtual Machine should be assigned. Changing this forces a new resource to be created
     */
    readonly proximityPlacementGroupId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Resource Group in which the Virtual Machine should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * One or more `storageDataDisk` blocks.
     */
    readonly storageDataDisks?: pulumi.Input<pulumi.Input<inputs.compute.VirtualMachineStorageDataDisk>[]>;
    /**
     * A `storageImageReference` block.
     */
    readonly storageImageReference?: pulumi.Input<inputs.compute.VirtualMachineStorageImageReference>;
    /**
     * A `storageOsDisk` block.
     */
    readonly storageOsDisk: pulumi.Input<inputs.compute.VirtualMachineStorageOsDisk>;
    /**
     * A mapping of tags to assign to the Virtual Machine.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * Specifies the [size of the Virtual Machine](https://azure.microsoft.com/en-us/documentation/articles/virtual-machines-size-specs/).
     */
    readonly vmSize: pulumi.Input<string>;
    /**
     * A list of a single item of the Availability Zone which the Virtual Machine should be allocated in.
     */
    readonly zones?: pulumi.Input<string>;
}
