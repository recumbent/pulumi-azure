// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing ExpressRoute circuit.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/express_route_circuit.html.markdown.
 */
export function getExpressRouteCircuit(args: GetExpressRouteCircuitArgs, opts?: pulumi.InvokeOptions): Promise<GetExpressRouteCircuitResult> & GetExpressRouteCircuitResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetExpressRouteCircuitResult> = pulumi.runtime.invoke("azure:network/getExpressRouteCircuit:getExpressRouteCircuit", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getExpressRouteCircuit.
 */
export interface GetExpressRouteCircuitArgs {
    /**
     * The name of the ExpressRoute circuit.
     */
    readonly name: string;
    /**
     * The Name of the Resource Group where the ExpressRoute circuit exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getExpressRouteCircuit.
 */
export interface GetExpressRouteCircuitResult {
    /**
     * The Azure location where the ExpressRoute circuit exists
     */
    readonly location: string;
    readonly name: string;
    /**
     * A `peerings` block for the ExpressRoute circuit as documented below
     */
    readonly peerings: outputs.network.GetExpressRouteCircuitPeering[];
    readonly resourceGroupName: string;
    /**
     * The string needed by the service provider to provision the ExpressRoute circuit.
     */
    readonly serviceKey: string;
    /**
     * A `serviceProviderProperties` block for the ExpressRoute circuit as documented below
     */
    readonly serviceProviderProperties: outputs.network.GetExpressRouteCircuitServiceProviderProperty[];
    /**
     * The ExpressRoute circuit provisioning state from your chosen service provider. Possible values are "NotProvisioned", "Provisioning", "Provisioned", and "Deprovisioning".
     */
    readonly serviceProviderProvisioningState: string;
    /**
     * A `sku` block for the ExpressRoute circuit as documented below.
     */
    readonly sku: outputs.network.GetExpressRouteCircuitSku;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
