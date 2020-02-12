// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an ExpressRoute circuit.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/express_route_circuit.html.markdown.
 */
export class ExpressRouteCircuit extends pulumi.CustomResource {
    /**
     * Get an existing ExpressRouteCircuit resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ExpressRouteCircuitState, opts?: pulumi.CustomResourceOptions): ExpressRouteCircuit {
        return new ExpressRouteCircuit(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:network/expressRouteCircuit:ExpressRouteCircuit';

    /**
     * Returns true if the given object is an instance of ExpressRouteCircuit.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ExpressRouteCircuit {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ExpressRouteCircuit.__pulumiType;
    }

    /**
     * Allow the circuit to interact with classic (RDFE) resources. The default value is `false`.
     */
    public readonly allowClassicOperations!: pulumi.Output<boolean | undefined>;
    /**
     * The bandwidth in Mbps of the circuit being created.
     */
    public readonly bandwidthInMbps!: pulumi.Output<number>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the ExpressRoute circuit. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the peering location and **not** the Azure resource location.
     */
    public readonly peeringLocation!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the ExpressRoute circuit. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The string needed by the service provider to provision the ExpressRoute circuit.
     */
    public /*out*/ readonly serviceKey!: pulumi.Output<string>;
    /**
     * The name of the ExpressRoute Service Provider.
     */
    public readonly serviceProviderName!: pulumi.Output<string>;
    /**
     * The ExpressRoute circuit provisioning state from your chosen service provider. Possible values are "NotProvisioned", "Provisioning", "Provisioned", and "Deprovisioning".
     */
    public /*out*/ readonly serviceProviderProvisioningState!: pulumi.Output<string>;
    /**
     * A `sku` block for the ExpressRoute circuit as documented below.
     */
    public readonly sku!: pulumi.Output<outputs.network.ExpressRouteCircuitSku>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string}>;

    /**
     * Create a ExpressRouteCircuit resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ExpressRouteCircuitArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ExpressRouteCircuitArgs | ExpressRouteCircuitState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as ExpressRouteCircuitState | undefined;
            inputs["allowClassicOperations"] = state ? state.allowClassicOperations : undefined;
            inputs["bandwidthInMbps"] = state ? state.bandwidthInMbps : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["peeringLocation"] = state ? state.peeringLocation : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["serviceKey"] = state ? state.serviceKey : undefined;
            inputs["serviceProviderName"] = state ? state.serviceProviderName : undefined;
            inputs["serviceProviderProvisioningState"] = state ? state.serviceProviderProvisioningState : undefined;
            inputs["sku"] = state ? state.sku : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as ExpressRouteCircuitArgs | undefined;
            if (!args || args.bandwidthInMbps === undefined) {
                throw new Error("Missing required property 'bandwidthInMbps'");
            }
            if (!args || args.peeringLocation === undefined) {
                throw new Error("Missing required property 'peeringLocation'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serviceProviderName === undefined) {
                throw new Error("Missing required property 'serviceProviderName'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["allowClassicOperations"] = args ? args.allowClassicOperations : undefined;
            inputs["bandwidthInMbps"] = args ? args.bandwidthInMbps : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["peeringLocation"] = args ? args.peeringLocation : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serviceProviderName"] = args ? args.serviceProviderName : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["serviceKey"] = undefined /*out*/;
            inputs["serviceProviderProvisioningState"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(ExpressRouteCircuit.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ExpressRouteCircuit resources.
 */
export interface ExpressRouteCircuitState {
    /**
     * Allow the circuit to interact with classic (RDFE) resources. The default value is `false`.
     */
    readonly allowClassicOperations?: pulumi.Input<boolean>;
    /**
     * The bandwidth in Mbps of the circuit being created.
     */
    readonly bandwidthInMbps?: pulumi.Input<number>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the ExpressRoute circuit. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the peering location and **not** the Azure resource location.
     */
    readonly peeringLocation?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the ExpressRoute circuit. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The string needed by the service provider to provision the ExpressRoute circuit.
     */
    readonly serviceKey?: pulumi.Input<string>;
    /**
     * The name of the ExpressRoute Service Provider.
     */
    readonly serviceProviderName?: pulumi.Input<string>;
    /**
     * The ExpressRoute circuit provisioning state from your chosen service provider. Possible values are "NotProvisioned", "Provisioning", "Provisioned", and "Deprovisioning".
     */
    readonly serviceProviderProvisioningState?: pulumi.Input<string>;
    /**
     * A `sku` block for the ExpressRoute circuit as documented below.
     */
    readonly sku?: pulumi.Input<inputs.network.ExpressRouteCircuitSku>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}

/**
 * The set of arguments for constructing a ExpressRouteCircuit resource.
 */
export interface ExpressRouteCircuitArgs {
    /**
     * Allow the circuit to interact with classic (RDFE) resources. The default value is `false`.
     */
    readonly allowClassicOperations?: pulumi.Input<boolean>;
    /**
     * The bandwidth in Mbps of the circuit being created.
     */
    readonly bandwidthInMbps: pulumi.Input<number>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the ExpressRoute circuit. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the peering location and **not** the Azure resource location.
     */
    readonly peeringLocation: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the ExpressRoute circuit. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The name of the ExpressRoute Service Provider.
     */
    readonly serviceProviderName: pulumi.Input<string>;
    /**
     * A `sku` block for the ExpressRoute circuit as documented below.
     */
    readonly sku: pulumi.Input<inputs.network.ExpressRouteCircuitSku>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
