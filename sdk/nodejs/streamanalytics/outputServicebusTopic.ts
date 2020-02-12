// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Stream Analytics Output to a ServiceBus Topic.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/stream_analytics_output_servicebus_topic.html.markdown.
 */
export class OutputServicebusTopic extends pulumi.CustomResource {
    /**
     * Get an existing OutputServicebusTopic resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OutputServicebusTopicState, opts?: pulumi.CustomResourceOptions): OutputServicebusTopic {
        return new OutputServicebusTopic(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:streamanalytics/outputServicebusTopic:OutputServicebusTopic';

    /**
     * Returns true if the given object is an instance of OutputServicebusTopic.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OutputServicebusTopic {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OutputServicebusTopic.__pulumiType;
    }

    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `serialization` block as defined below.
     */
    public readonly serialization!: pulumi.Output<outputs.streamanalytics.OutputServicebusTopicSerialization>;
    /**
     * The namespace that is associated with the desired Event Hub, Service Bus Topic, Service Bus Topic, etc.
     */
    public readonly servicebusNamespace!: pulumi.Output<string>;
    /**
     * The shared access policy key for the specified shared access policy.
     */
    public readonly sharedAccessPolicyKey!: pulumi.Output<string>;
    /**
     * The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
     */
    public readonly sharedAccessPolicyName!: pulumi.Output<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    public readonly streamAnalyticsJobName!: pulumi.Output<string>;
    /**
     * The name of the Service Bus Topic.
     */
    public readonly topicName!: pulumi.Output<string>;

    /**
     * Create a OutputServicebusTopic resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OutputServicebusTopicArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OutputServicebusTopicArgs | OutputServicebusTopicState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as OutputServicebusTopicState | undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["serialization"] = state ? state.serialization : undefined;
            inputs["servicebusNamespace"] = state ? state.servicebusNamespace : undefined;
            inputs["sharedAccessPolicyKey"] = state ? state.sharedAccessPolicyKey : undefined;
            inputs["sharedAccessPolicyName"] = state ? state.sharedAccessPolicyName : undefined;
            inputs["streamAnalyticsJobName"] = state ? state.streamAnalyticsJobName : undefined;
            inputs["topicName"] = state ? state.topicName : undefined;
        } else {
            const args = argsOrState as OutputServicebusTopicArgs | undefined;
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serialization === undefined) {
                throw new Error("Missing required property 'serialization'");
            }
            if (!args || args.servicebusNamespace === undefined) {
                throw new Error("Missing required property 'servicebusNamespace'");
            }
            if (!args || args.sharedAccessPolicyKey === undefined) {
                throw new Error("Missing required property 'sharedAccessPolicyKey'");
            }
            if (!args || args.sharedAccessPolicyName === undefined) {
                throw new Error("Missing required property 'sharedAccessPolicyName'");
            }
            if (!args || args.streamAnalyticsJobName === undefined) {
                throw new Error("Missing required property 'streamAnalyticsJobName'");
            }
            if (!args || args.topicName === undefined) {
                throw new Error("Missing required property 'topicName'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serialization"] = args ? args.serialization : undefined;
            inputs["servicebusNamespace"] = args ? args.servicebusNamespace : undefined;
            inputs["sharedAccessPolicyKey"] = args ? args.sharedAccessPolicyKey : undefined;
            inputs["sharedAccessPolicyName"] = args ? args.sharedAccessPolicyName : undefined;
            inputs["streamAnalyticsJobName"] = args ? args.streamAnalyticsJobName : undefined;
            inputs["topicName"] = args ? args.topicName : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(OutputServicebusTopic.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OutputServicebusTopic resources.
 */
export interface OutputServicebusTopicState {
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `serialization` block as defined below.
     */
    readonly serialization?: pulumi.Input<inputs.streamanalytics.OutputServicebusTopicSerialization>;
    /**
     * The namespace that is associated with the desired Event Hub, Service Bus Topic, Service Bus Topic, etc.
     */
    readonly servicebusNamespace?: pulumi.Input<string>;
    /**
     * The shared access policy key for the specified shared access policy.
     */
    readonly sharedAccessPolicyKey?: pulumi.Input<string>;
    /**
     * The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
     */
    readonly sharedAccessPolicyName?: pulumi.Input<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    readonly streamAnalyticsJobName?: pulumi.Input<string>;
    /**
     * The name of the Service Bus Topic.
     */
    readonly topicName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OutputServicebusTopic resource.
 */
export interface OutputServicebusTopicArgs {
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `serialization` block as defined below.
     */
    readonly serialization: pulumi.Input<inputs.streamanalytics.OutputServicebusTopicSerialization>;
    /**
     * The namespace that is associated with the desired Event Hub, Service Bus Topic, Service Bus Topic, etc.
     */
    readonly servicebusNamespace: pulumi.Input<string>;
    /**
     * The shared access policy key for the specified shared access policy.
     */
    readonly sharedAccessPolicyKey: pulumi.Input<string>;
    /**
     * The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
     */
    readonly sharedAccessPolicyName: pulumi.Input<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    readonly streamAnalyticsJobName: pulumi.Input<string>;
    /**
     * The name of the Service Bus Topic.
     */
    readonly topicName: pulumi.Input<string>;
}
