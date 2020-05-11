// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Recurrence Trigger within a Logic App Workflow
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
 * const exampleWorkflow = new azure.logicapps.Workflow("exampleWorkflow", {
 *     location: exampleResourceGroup.location,
 *     resourceGroupName: exampleResourceGroup.name,
 * });
 * const exampleTriggerRecurrence = new azure.logicapps.TriggerRecurrence("exampleTriggerRecurrence", {
 *     logicAppId: exampleWorkflow.id,
 *     frequency: "Day",
 *     interval: 1,
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/logic_app_trigger_recurrence.html.markdown.
 */
export class TriggerRecurrence extends pulumi.CustomResource {
    /**
     * Get an existing TriggerRecurrence resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TriggerRecurrenceState, opts?: pulumi.CustomResourceOptions): TriggerRecurrence {
        return new TriggerRecurrence(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:logicapps/triggerRecurrence:TriggerRecurrence';

    /**
     * Returns true if the given object is an instance of TriggerRecurrence.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TriggerRecurrence {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TriggerRecurrence.__pulumiType;
    }

    /**
     * Specifies the Frequency at which this Trigger should be run. Possible values include `Month`, `Week`, `Day`, `Hour`, `Minute` and `Second`.
     */
    public readonly frequency!: pulumi.Output<string>;
    /**
     * Specifies interval used for the Frequency, for example a value of `4` for `interval` and `hour` for `frequency` would run the Trigger every 4 hours.
     */
    public readonly interval!: pulumi.Output<number>;
    /**
     * Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    public readonly logicAppId!: pulumi.Output<string>;
    /**
     * Specifies the name of the Recurrence Triggers to be created within the Logic App Workflow. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specifies the start date and time for this trigger in RFC3339 format: `2000-01-02T03:04:05Z`.
     */
    public readonly startTime!: pulumi.Output<string | undefined>;

    /**
     * Create a TriggerRecurrence resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TriggerRecurrenceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TriggerRecurrenceArgs | TriggerRecurrenceState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as TriggerRecurrenceState | undefined;
            inputs["frequency"] = state ? state.frequency : undefined;
            inputs["interval"] = state ? state.interval : undefined;
            inputs["logicAppId"] = state ? state.logicAppId : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["startTime"] = state ? state.startTime : undefined;
        } else {
            const args = argsOrState as TriggerRecurrenceArgs | undefined;
            if (!args || args.frequency === undefined) {
                throw new Error("Missing required property 'frequency'");
            }
            if (!args || args.interval === undefined) {
                throw new Error("Missing required property 'interval'");
            }
            if (!args || args.logicAppId === undefined) {
                throw new Error("Missing required property 'logicAppId'");
            }
            inputs["frequency"] = args ? args.frequency : undefined;
            inputs["interval"] = args ? args.interval : undefined;
            inputs["logicAppId"] = args ? args.logicAppId : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["startTime"] = args ? args.startTime : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(TriggerRecurrence.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TriggerRecurrence resources.
 */
export interface TriggerRecurrenceState {
    /**
     * Specifies the Frequency at which this Trigger should be run. Possible values include `Month`, `Week`, `Day`, `Hour`, `Minute` and `Second`.
     */
    readonly frequency?: pulumi.Input<string>;
    /**
     * Specifies interval used for the Frequency, for example a value of `4` for `interval` and `hour` for `frequency` would run the Trigger every 4 hours.
     */
    readonly interval?: pulumi.Input<number>;
    /**
     * Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    readonly logicAppId?: pulumi.Input<string>;
    /**
     * Specifies the name of the Recurrence Triggers to be created within the Logic App Workflow. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the start date and time for this trigger in RFC3339 format: `2000-01-02T03:04:05Z`.
     */
    readonly startTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a TriggerRecurrence resource.
 */
export interface TriggerRecurrenceArgs {
    /**
     * Specifies the Frequency at which this Trigger should be run. Possible values include `Month`, `Week`, `Day`, `Hour`, `Minute` and `Second`.
     */
    readonly frequency: pulumi.Input<string>;
    /**
     * Specifies interval used for the Frequency, for example a value of `4` for `interval` and `hour` for `frequency` would run the Trigger every 4 hours.
     */
    readonly interval: pulumi.Input<number>;
    /**
     * Specifies the ID of the Logic App Workflow. Changing this forces a new resource to be created.
     */
    readonly logicAppId: pulumi.Input<string>;
    /**
     * Specifies the name of the Recurrence Triggers to be created within the Logic App Workflow. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the start date and time for this trigger in RFC3339 format: `2000-01-02T03:04:05Z`.
     */
    readonly startTime?: pulumi.Input<string>;
}
