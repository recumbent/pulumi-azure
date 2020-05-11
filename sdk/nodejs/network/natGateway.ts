// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Azure NAT Gateway.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "eastus2"});
 * const examplePublicIp = new azure.network.PublicIp("examplePublicIp", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     allocationMethod: "Static",
 *     sku: "Standard",
 *     zones: ["1"],
 * });
 * const examplePublicIpPrefix = new azure.network.PublicIpPrefix("examplePublicIpPrefix", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     prefixLength: 30,
 *     zones: ["1"],
 * });
 * const exampleNatGateway = new azure.network.NatGateway("exampleNatGateway", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     publicIpAddressIds: [examplePublicIp.id],
 *     publicIpPrefixIds: [examplePublicIpPrefix.id],
 *     skuName: "Standard",
 *     idleTimeoutInMinutes: 10,
 *     zones: ["1"],
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/nat_gateway.html.markdown.
 */
export class NatGateway extends pulumi.CustomResource {
    /**
     * Get an existing NatGateway resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: NatGatewayState, opts?: pulumi.CustomResourceOptions): NatGateway {
        return new NatGateway(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:network/natGateway:NatGateway';

    /**
     * Returns true if the given object is an instance of NatGateway.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is NatGateway {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === NatGateway.__pulumiType;
    }

    /**
     * The idle timeout which should be used in minutes. Defaults to `4`.
     */
    public readonly idleTimeoutInMinutes!: pulumi.Output<number | undefined>;
    /**
     * Specifies the supported Azure location where the NAT Gateway should exist. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the NAT Gateway. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A list of Public IP Address ID's which should be associated with the NAT Gateway resource.
     */
    public readonly publicIpAddressIds!: pulumi.Output<string[] | undefined>;
    /**
     * A list of Public IP Prefix ID's which should be associated with the NAT Gateway resource.
     */
    public readonly publicIpPrefixIds!: pulumi.Output<string[] | undefined>;
    /**
     * Specifies the name of the Resource Group in which the NAT Gateway should exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The resource GUID property of the NAT Gateway.
     */
    public /*out*/ readonly resourceGuid!: pulumi.Output<string>;
    /**
     * The SKU which should be used. At this time the only supported value is `Standard`. Defaults to `Standard`.
     */
    public readonly skuName!: pulumi.Output<string | undefined>;
    /**
     * A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A list of availability zones where the NAT Gateway should be provisioned. Changing this forces a new resource to be created.
     */
    public readonly zones!: pulumi.Output<string[] | undefined>;

    /**
     * Create a NatGateway resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: NatGatewayArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: NatGatewayArgs | NatGatewayState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as NatGatewayState | undefined;
            inputs["idleTimeoutInMinutes"] = state ? state.idleTimeoutInMinutes : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["publicIpAddressIds"] = state ? state.publicIpAddressIds : undefined;
            inputs["publicIpPrefixIds"] = state ? state.publicIpPrefixIds : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["resourceGuid"] = state ? state.resourceGuid : undefined;
            inputs["skuName"] = state ? state.skuName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["zones"] = state ? state.zones : undefined;
        } else {
            const args = argsOrState as NatGatewayArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["idleTimeoutInMinutes"] = args ? args.idleTimeoutInMinutes : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["publicIpAddressIds"] = args ? args.publicIpAddressIds : undefined;
            inputs["publicIpPrefixIds"] = args ? args.publicIpPrefixIds : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["skuName"] = args ? args.skuName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["zones"] = args ? args.zones : undefined;
            inputs["resourceGuid"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(NatGateway.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering NatGateway resources.
 */
export interface NatGatewayState {
    /**
     * The idle timeout which should be used in minutes. Defaults to `4`.
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the supported Azure location where the NAT Gateway should exist. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the NAT Gateway. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of Public IP Address ID's which should be associated with the NAT Gateway resource.
     */
    readonly publicIpAddressIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of Public IP Prefix ID's which should be associated with the NAT Gateway resource.
     */
    readonly publicIpPrefixIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies the name of the Resource Group in which the NAT Gateway should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The resource GUID property of the NAT Gateway.
     */
    readonly resourceGuid?: pulumi.Input<string>;
    /**
     * The SKU which should be used. At this time the only supported value is `Standard`. Defaults to `Standard`.
     */
    readonly skuName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of availability zones where the NAT Gateway should be provisioned. Changing this forces a new resource to be created.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a NatGateway resource.
 */
export interface NatGatewayArgs {
    /**
     * The idle timeout which should be used in minutes. Defaults to `4`.
     */
    readonly idleTimeoutInMinutes?: pulumi.Input<number>;
    /**
     * Specifies the supported Azure location where the NAT Gateway should exist. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the NAT Gateway. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A list of Public IP Address ID's which should be associated with the NAT Gateway resource.
     */
    readonly publicIpAddressIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A list of Public IP Prefix ID's which should be associated with the NAT Gateway resource.
     */
    readonly publicIpPrefixIds?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies the name of the Resource Group in which the NAT Gateway should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The SKU which should be used. At this time the only supported value is `Standard`. Defaults to `Standard`.
     */
    readonly skuName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource. Changing this forces a new resource to be created.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A list of availability zones where the NAT Gateway should be provisioned. Changing this forces a new resource to be created.
     */
    readonly zones?: pulumi.Input<pulumi.Input<string>[]>;
}
