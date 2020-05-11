// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages an IotHub
 * 
 * > **NOTE:** Endpoints can be defined either directly on the `azure.iot.IoTHub` resource, or using the `azurerm_iothub_endpoint_*` resources - but the two ways of defining the endpoints cannot be used together. If both are used against the same IoTHub, spurious changes will occur. Also, defining a `azurerm_iothub_endpoint_*` resource and another endpoint of a different type directly on the `azure.iot.IoTHub` resource is not supported.
 * 
 * > **NOTE:** Routes can be defined either directly on the `azure.iot.IoTHub` resource, or using the `azure.iot.Route` resource - but the two cannot be used together. If both are used against the same IoTHub, spurious changes will occur.
 * 
 * > **NOTE:** Fallback route can be defined either directly on the `azure.iot.IoTHub` resource, or using the `azure.iot.FallbackRoute` resource - but the two cannot be used together. If both are used against the same IoTHub, spurious changes will occur.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "Canada Central"});
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
 * const exampleEventHubNamespace = new azure.eventhub.EventHubNamespace("exampleEventHubNamespace", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     sku: "Basic",
 * });
 * const exampleEventHub = new azure.eventhub.EventHub("exampleEventHub", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     namespaceName: exampleEventHubNamespace.name,
 *     partitionCount: 2,
 *     messageRetention: 1,
 * });
 * const exampleAuthorizationRule = new azure.eventhub.AuthorizationRule("exampleAuthorizationRule", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     namespaceName: exampleEventHubNamespace.name,
 *     eventhubName: exampleEventHub.name,
 *     send: true,
 * });
 * const exampleIoTHub = new azure.iot.IoTHub("exampleIoTHub", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     sku: {
 *         name: "S1",
 *         capacity: "1",
 *     },
 *     endpoint: [
 *         {
 *             type: "AzureIotHub.StorageContainer",
 *             connectionString: exampleAccount.primaryBlobConnectionString,
 *             name: "export",
 *             batchFrequencyInSeconds: 60,
 *             maxChunkSizeInBytes: 10485760,
 *             containerName: exampleContainer.name,
 *             encoding: "Avro",
 *             fileNameFormat: "{iothub}/{partition}_{YYYY}_{MM}_{DD}_{HH}_{mm}",
 *         },
 *         {
 *             type: "AzureIotHub.EventHub",
 *             connectionString: exampleAuthorizationRule.primaryConnectionString,
 *             name: "export2",
 *         },
 *     ],
 *     route: [
 *         {
 *             name: "export",
 *             source: "DeviceMessages",
 *             condition: "true",
 *             endpointNames: ["export"],
 *             enabled: true,
 *         },
 *         {
 *             name: "export2",
 *             source: "DeviceMessages",
 *             condition: "true",
 *             endpointNames: ["export2"],
 *             enabled: true,
 *         },
 *     ],
 *     tags: {
 *         purpose: "testing",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/iothub.html.markdown.
 */
export class IoTHub extends pulumi.CustomResource {
    /**
     * Get an existing IoTHub resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: IoTHubState, opts?: pulumi.CustomResourceOptions): IoTHub {
        return new IoTHub(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:iot/ioTHub:IoTHub';

    /**
     * Returns true if the given object is an instance of IoTHub.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is IoTHub {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === IoTHub.__pulumiType;
    }

    /**
     * An `endpoint` block as defined below.
     */
    public readonly endpoints!: pulumi.Output<outputs.iot.IoTHubEndpoint[]>;
    /**
     * The EventHub compatible endpoint for events data
     */
    public /*out*/ readonly eventHubEventsEndpoint!: pulumi.Output<string>;
    /**
     * The EventHub compatible path for events data
     */
    public /*out*/ readonly eventHubEventsPath!: pulumi.Output<string>;
    /**
     * The EventHub compatible endpoint for operational data
     */
    public /*out*/ readonly eventHubOperationsEndpoint!: pulumi.Output<string>;
    /**
     * The EventHub compatible path for operational data
     */
    public /*out*/ readonly eventHubOperationsPath!: pulumi.Output<string>;
    /**
     * The number of device-to-cloud partitions used by backing event hubs. Must be between `2` and `128`.
     */
    public readonly eventHubPartitionCount!: pulumi.Output<number>;
    /**
     * The event hub retention to use in days. Must be between `1` and `7`.
     */
    public readonly eventHubRetentionInDays!: pulumi.Output<number>;
    /**
     * A `fallbackRoute` block as defined below. If the fallback route is enabled, messages that don't match any of the supplied routes are automatically sent to this route. Defaults to messages/events.
     */
    public readonly fallbackRoute!: pulumi.Output<outputs.iot.IoTHubFallbackRoute>;
    /**
     * A `fileUpload` block as defined below.
     */
    public readonly fileUpload!: pulumi.Output<outputs.iot.IoTHubFileUpload | undefined>;
    /**
     * The hostname of the IotHub Resource.
     */
    public /*out*/ readonly hostname!: pulumi.Output<string>;
    /**
     * One or more `ipFilterRule` blocks as defined below.
     */
    public readonly ipFilterRules!: pulumi.Output<outputs.iot.IoTHubIpFilterRule[] | undefined>;
    /**
     * Specifies the supported Azure location where the resource has to be createc. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `route` block as defined below.
     */
    public readonly routes!: pulumi.Output<outputs.iot.IoTHubRoute[]>;
    /**
     * One or more `sharedAccessPolicy` blocks as defined below.
     */
    public /*out*/ readonly sharedAccessPolicies!: pulumi.Output<outputs.iot.IoTHubSharedAccessPolicy[]>;
    /**
     * A `sku` block as defined below.
     */
    public readonly sku!: pulumi.Output<outputs.iot.IoTHubSku>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * The type of the endpoint. Possible values are `AzureIotHub.StorageContainer`, `AzureIotHub.ServiceBusQueue`, `AzureIotHub.ServiceBusTopic` or `AzureIotHub.EventHub`.
     */
    public /*out*/ readonly type!: pulumi.Output<string>;

    /**
     * Create a IoTHub resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: IoTHubArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: IoTHubArgs | IoTHubState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as IoTHubState | undefined;
            inputs["endpoints"] = state ? state.endpoints : undefined;
            inputs["eventHubEventsEndpoint"] = state ? state.eventHubEventsEndpoint : undefined;
            inputs["eventHubEventsPath"] = state ? state.eventHubEventsPath : undefined;
            inputs["eventHubOperationsEndpoint"] = state ? state.eventHubOperationsEndpoint : undefined;
            inputs["eventHubOperationsPath"] = state ? state.eventHubOperationsPath : undefined;
            inputs["eventHubPartitionCount"] = state ? state.eventHubPartitionCount : undefined;
            inputs["eventHubRetentionInDays"] = state ? state.eventHubRetentionInDays : undefined;
            inputs["fallbackRoute"] = state ? state.fallbackRoute : undefined;
            inputs["fileUpload"] = state ? state.fileUpload : undefined;
            inputs["hostname"] = state ? state.hostname : undefined;
            inputs["ipFilterRules"] = state ? state.ipFilterRules : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["routes"] = state ? state.routes : undefined;
            inputs["sharedAccessPolicies"] = state ? state.sharedAccessPolicies : undefined;
            inputs["sku"] = state ? state.sku : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["type"] = state ? state.type : undefined;
        } else {
            const args = argsOrState as IoTHubArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.sku === undefined) {
                throw new Error("Missing required property 'sku'");
            }
            inputs["endpoints"] = args ? args.endpoints : undefined;
            inputs["eventHubPartitionCount"] = args ? args.eventHubPartitionCount : undefined;
            inputs["eventHubRetentionInDays"] = args ? args.eventHubRetentionInDays : undefined;
            inputs["fallbackRoute"] = args ? args.fallbackRoute : undefined;
            inputs["fileUpload"] = args ? args.fileUpload : undefined;
            inputs["ipFilterRules"] = args ? args.ipFilterRules : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["routes"] = args ? args.routes : undefined;
            inputs["sku"] = args ? args.sku : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["eventHubEventsEndpoint"] = undefined /*out*/;
            inputs["eventHubEventsPath"] = undefined /*out*/;
            inputs["eventHubOperationsEndpoint"] = undefined /*out*/;
            inputs["eventHubOperationsPath"] = undefined /*out*/;
            inputs["hostname"] = undefined /*out*/;
            inputs["sharedAccessPolicies"] = undefined /*out*/;
            inputs["type"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(IoTHub.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering IoTHub resources.
 */
export interface IoTHubState {
    /**
     * An `endpoint` block as defined below.
     */
    readonly endpoints?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubEndpoint>[]>;
    /**
     * The EventHub compatible endpoint for events data
     */
    readonly eventHubEventsEndpoint?: pulumi.Input<string>;
    /**
     * The EventHub compatible path for events data
     */
    readonly eventHubEventsPath?: pulumi.Input<string>;
    /**
     * The EventHub compatible endpoint for operational data
     */
    readonly eventHubOperationsEndpoint?: pulumi.Input<string>;
    /**
     * The EventHub compatible path for operational data
     */
    readonly eventHubOperationsPath?: pulumi.Input<string>;
    /**
     * The number of device-to-cloud partitions used by backing event hubs. Must be between `2` and `128`.
     */
    readonly eventHubPartitionCount?: pulumi.Input<number>;
    /**
     * The event hub retention to use in days. Must be between `1` and `7`.
     */
    readonly eventHubRetentionInDays?: pulumi.Input<number>;
    /**
     * A `fallbackRoute` block as defined below. If the fallback route is enabled, messages that don't match any of the supplied routes are automatically sent to this route. Defaults to messages/events.
     */
    readonly fallbackRoute?: pulumi.Input<inputs.iot.IoTHubFallbackRoute>;
    /**
     * A `fileUpload` block as defined below.
     */
    readonly fileUpload?: pulumi.Input<inputs.iot.IoTHubFileUpload>;
    /**
     * The hostname of the IotHub Resource.
     */
    readonly hostname?: pulumi.Input<string>;
    /**
     * One or more `ipFilterRule` blocks as defined below.
     */
    readonly ipFilterRules?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubIpFilterRule>[]>;
    /**
     * Specifies the supported Azure location where the resource has to be createc. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `route` block as defined below.
     */
    readonly routes?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubRoute>[]>;
    /**
     * One or more `sharedAccessPolicy` blocks as defined below.
     */
    readonly sharedAccessPolicies?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubSharedAccessPolicy>[]>;
    /**
     * A `sku` block as defined below.
     */
    readonly sku?: pulumi.Input<inputs.iot.IoTHubSku>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * The type of the endpoint. Possible values are `AzureIotHub.StorageContainer`, `AzureIotHub.ServiceBusQueue`, `AzureIotHub.ServiceBusTopic` or `AzureIotHub.EventHub`.
     */
    readonly type?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a IoTHub resource.
 */
export interface IoTHubArgs {
    /**
     * An `endpoint` block as defined below.
     */
    readonly endpoints?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubEndpoint>[]>;
    /**
     * The number of device-to-cloud partitions used by backing event hubs. Must be between `2` and `128`.
     */
    readonly eventHubPartitionCount?: pulumi.Input<number>;
    /**
     * The event hub retention to use in days. Must be between `1` and `7`.
     */
    readonly eventHubRetentionInDays?: pulumi.Input<number>;
    /**
     * A `fallbackRoute` block as defined below. If the fallback route is enabled, messages that don't match any of the supplied routes are automatically sent to this route. Defaults to messages/events.
     */
    readonly fallbackRoute?: pulumi.Input<inputs.iot.IoTHubFallbackRoute>;
    /**
     * A `fileUpload` block as defined below.
     */
    readonly fileUpload?: pulumi.Input<inputs.iot.IoTHubFileUpload>;
    /**
     * One or more `ipFilterRule` blocks as defined below.
     */
    readonly ipFilterRules?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubIpFilterRule>[]>;
    /**
     * Specifies the supported Azure location where the resource has to be createc. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the IotHub resource. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group under which the IotHub resource has to be created. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `route` block as defined below.
     */
    readonly routes?: pulumi.Input<pulumi.Input<inputs.iot.IoTHubRoute>[]>;
    /**
     * A `sku` block as defined below.
     */
    readonly sku: pulumi.Input<inputs.iot.IoTHubSku>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
}
