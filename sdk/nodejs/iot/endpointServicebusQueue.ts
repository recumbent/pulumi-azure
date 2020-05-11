// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an IotHub ServiceBus Queue Endpoint
 * 
 * > **NOTE:** Endpoints can be defined either directly on the `azure.iot.IoTHub` resource, or using the `azurerm_iothub_endpoint_*` resources - but the two ways of defining the endpoints cannot be used together. If both are used against the same IoTHub, spurious changes will occur. Also, defining a `azurerm_iothub_endpoint_*` resource and another endpoint of a different type directly on the `azure.iot.IoTHub` resource is not supported.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "East US"});
 * const exampleNamespace = new azure.servicebus.Namespace("exampleNamespace", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 *     sku: "Standard",
 * });
 * const exampleQueue = new azure.servicebus.Queue("exampleQueue", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     namespaceName: exampleNamespace.name,
 *     enablePartitioning: true,
 * });
 * const exampleQueueAuthorizationRule = new azure.servicebus.QueueAuthorizationRule("exampleQueueAuthorizationRule", {
 *     namespaceName: exampleNamespace.name,
 *     queueName: exampleQueue.name,
 *     resourceGroupName: exampleResourceGroup.name,
 *     listen: false,
 *     send: true,
 *     manage: false,
 * });
 * const exampleIoTHub = new azure.iot.IoTHub("exampleIoTHub", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     sku: {
 *         name: "B1",
 *         tier: "Basic",
 *         capacity: "1",
 *     },
 *     tags: {
 *         purpose: "example",
 *     },
 * });
 * const exampleEndpointServicebusQueue = new azure.iot.EndpointServicebusQueue("exampleEndpointServicebusQueue", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     iothubName: exampleIoTHub.name,
 *     connectionString: exampleQueueAuthorizationRule.primaryConnectionString,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/iothub_endpoint_servicebus_queue.html.markdown.
 */
export class EndpointServicebusQueue extends pulumi.CustomResource {
    /**
     * Get an existing EndpointServicebusQueue resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EndpointServicebusQueueState, opts?: pulumi.CustomResourceOptions): EndpointServicebusQueue {
        return new EndpointServicebusQueue(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:iot/endpointServicebusQueue:EndpointServicebusQueue';

    /**
     * Returns true if the given object is an instance of EndpointServicebusQueue.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is EndpointServicebusQueue {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === EndpointServicebusQueue.__pulumiType;
    }

    /**
     * The connection string for the endpoint.
     */
    public readonly connectionString!: pulumi.Output<string>;
    public readonly iothubName!: pulumi.Output<string>;
    /**
     * The name of the endpoint. The name must be unique across endpoint types. The following names are reserved:  `events`, `operationsMonitoringEvents`, `fileNotifications` and `$default`.
     */
    public readonly name!: pulumi.Output<string>;
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a EndpointServicebusQueue resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EndpointServicebusQueueArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EndpointServicebusQueueArgs | EndpointServicebusQueueState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as EndpointServicebusQueueState | undefined;
            inputs["connectionString"] = state ? state.connectionString : undefined;
            inputs["iothubName"] = state ? state.iothubName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as EndpointServicebusQueueArgs | undefined;
            if (!args || args.connectionString === undefined) {
                throw new Error("Missing required property 'connectionString'");
            }
            if (!args || args.iothubName === undefined) {
                throw new Error("Missing required property 'iothubName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["connectionString"] = args ? args.connectionString : undefined;
            inputs["iothubName"] = args ? args.iothubName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(EndpointServicebusQueue.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering EndpointServicebusQueue resources.
 */
export interface EndpointServicebusQueueState {
    /**
     * The connection string for the endpoint.
     */
    readonly connectionString?: pulumi.Input<string>;
    readonly iothubName?: pulumi.Input<string>;
    /**
     * The name of the endpoint. The name must be unique across endpoint types. The following names are reserved:  `events`, `operationsMonitoringEvents`, `fileNotifications` and `$default`.
     */
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a EndpointServicebusQueue resource.
 */
export interface EndpointServicebusQueueArgs {
    /**
     * The connection string for the endpoint.
     */
    readonly connectionString: pulumi.Input<string>;
    readonly iothubName: pulumi.Input<string>;
    /**
     * The name of the endpoint. The name must be unique across endpoint types. The following names are reserved:  `events`, `operationsMonitoringEvents`, `fileNotifications` and `$default`.
     */
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
}
