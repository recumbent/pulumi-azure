// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an IotHub Fallback Route
 *
 * ## Disclaimers
 *
 * > **Note:** Fallback route can be defined either directly on the `azure.iot.IoTHub` resource, or using the `azure.iot.FallbackRoute` resource - but the two cannot be used together. If both are used against the same IoTHub, spurious changes will occur.
 *
 * > **Note:** Since this resource is provisioned by default, the Azure Provider will not check for the presence of an existing resource prior to attempting to create it.
 *
 * ## Example Usage
 *
 *
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 *
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "West US"});
 * const exampleAccount = new azure.storage.Account("exampleAccount", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     accountTier: "Standard",
 *     accountReplicationType: "LRS",
 * });
 * const exampleContainer = new azure.storage.Container("exampleContainer", {
 *     storageAccountName: exampleAccount.name,
 *     containerAccessType: "private",
 * });
 * const exampleIoTHub = new azure.iot.IoTHub("exampleIoTHub", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     sku: {
 *         name: "S1",
 *         capacity: "1",
 *     },
 *     tags: {
 *         purpose: "testing",
 *     },
 * });
 * const exampleEndpointStorageContainer = new azure.iot.EndpointStorageContainer("exampleEndpointStorageContainer", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     iothubName: exampleIoTHub.name,
 *     connectionString: exampleAccount.primaryBlobConnectionString,
 *     batchFrequencyInSeconds: 60,
 *     maxChunkSizeInBytes: 10485760,
 *     containerName: exampleContainer.name,
 *     encoding: "Avro",
 *     fileNameFormat: "{iothub}/{partition}_{YYYY}_{MM}_{DD}_{HH}_{mm}",
 * });
 * const exampleFallbackRoute = new azure.iot.FallbackRoute("exampleFallbackRoute", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     iothubName: exampleIoTHub.name,
 *     condition: "true",
 *     endpointNames: [exampleEndpointStorageContainer.name],
 *     enabled: true,
 * });
 * ```
 */
export class FallbackRoute extends pulumi.CustomResource {
    /**
     * Get an existing FallbackRoute resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FallbackRouteState, opts?: pulumi.CustomResourceOptions): FallbackRoute {
        return new FallbackRoute(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:iot/fallbackRoute:FallbackRoute';

    /**
     * Returns true if the given object is an instance of FallbackRoute.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is FallbackRoute {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === FallbackRoute.__pulumiType;
    }

    /**
     * The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to `true` by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language.
     */
    public readonly condition!: pulumi.Output<string | undefined>;
    /**
     * Used to specify whether the fallback route is enabled.
     */
    public readonly enabled!: pulumi.Output<boolean>;
    /**
     * The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.
     */
    public readonly endpointNames!: pulumi.Output<string>;
    /**
     * The name of the IoTHub to which this Fallback Route belongs. Changing this forces a new resource to be created.
     */
    public readonly iothubName!: pulumi.Output<string>;
    /**
     * The name of the resource group under which the IotHub Storage Container Endpoint resource has to be created. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a FallbackRoute resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FallbackRouteArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FallbackRouteArgs | FallbackRouteState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as FallbackRouteState | undefined;
            inputs["condition"] = state ? state.condition : undefined;
            inputs["enabled"] = state ? state.enabled : undefined;
            inputs["endpointNames"] = state ? state.endpointNames : undefined;
            inputs["iothubName"] = state ? state.iothubName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as FallbackRouteArgs | undefined;
            if (!args || args.enabled === undefined) {
                throw new Error("Missing required property 'enabled'");
            }
            if (!args || args.endpointNames === undefined) {
                throw new Error("Missing required property 'endpointNames'");
            }
            if (!args || args.iothubName === undefined) {
                throw new Error("Missing required property 'iothubName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["condition"] = args ? args.condition : undefined;
            inputs["enabled"] = args ? args.enabled : undefined;
            inputs["endpointNames"] = args ? args.endpointNames : undefined;
            inputs["iothubName"] = args ? args.iothubName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(FallbackRoute.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FallbackRoute resources.
 */
export interface FallbackRouteState {
    /**
     * The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to `true` by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language.
     */
    readonly condition?: pulumi.Input<string>;
    /**
     * Used to specify whether the fallback route is enabled.
     */
    readonly enabled?: pulumi.Input<boolean>;
    /**
     * The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.
     */
    readonly endpointNames?: pulumi.Input<string>;
    /**
     * The name of the IoTHub to which this Fallback Route belongs. Changing this forces a new resource to be created.
     */
    readonly iothubName?: pulumi.Input<string>;
    /**
     * The name of the resource group under which the IotHub Storage Container Endpoint resource has to be created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a FallbackRoute resource.
 */
export interface FallbackRouteArgs {
    /**
     * The condition that is evaluated to apply the routing rule. If no condition is provided, it evaluates to `true` by default. For grammar, see: https://docs.microsoft.com/azure/iot-hub/iot-hub-devguide-query-language.
     */
    readonly condition?: pulumi.Input<string>;
    /**
     * Used to specify whether the fallback route is enabled.
     */
    readonly enabled: pulumi.Input<boolean>;
    /**
     * The endpoints to which messages that satisfy the condition are routed. Currently only 1 endpoint is allowed.
     */
    readonly endpointNames: pulumi.Input<string>;
    /**
     * The name of the IoTHub to which this Fallback Route belongs. Changing this forces a new resource to be created.
     */
    readonly iothubName: pulumi.Input<string>;
    /**
     * The name of the resource group under which the IotHub Storage Container Endpoint resource has to be created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
