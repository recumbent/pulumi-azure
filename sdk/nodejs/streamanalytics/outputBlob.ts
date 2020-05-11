// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Stream Analytics Output to Blob Storage.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = azure.core.getResourceGroup({
 *     name: "example-resources",
 * });
 * const exampleJob = azure.streamanalytics.getJob({
 *     name: "example-job",
 *     resourceGroupName: azurerm_resource_group.example.name,
 * });
 * const exampleAccount = new azure.storage.Account("exampleAccount", {
 *     resourceGroupName: exampleResourceGroup.then(exampleResourceGroup => exampleResourceGroup.name),
 *     location: exampleResourceGroup.then(exampleResourceGroup => exampleResourceGroup.location),
 *     accountTier: "Standard",
 *     accountReplicationType: "LRS",
 * });
 * const exampleContainer = new azure.storage.Container("exampleContainer", {
 *     resourceGroupName: exampleResourceGroup.then(exampleResourceGroup => exampleResourceGroup.name),
 *     storageAccountName: exampleAccount.name,
 *     containerAccessType: "private",
 * });
 * const exampleOutputBlob = new azure.streamanalytics.OutputBlob("exampleOutputBlob", {
 *     streamAnalyticsJobName: exampleJob.then(exampleJob => exampleJob.name),
 *     resourceGroupName: exampleJob.then(exampleJob => exampleJob.resourceGroupName),
 *     storageAccountName: exampleAccount.name,
 *     storageAccountKey: exampleAccount.primaryAccessKey,
 *     storageContainerName: exampleContainer.name,
 *     pathPattern: "some-pattern",
 *     dateFormat: "yyyy-MM-dd",
 *     timeFormat: "HH",
 *     serialization: {
 *         type: "Csv",
 *         encoding: "UTF8",
 *         fieldDelimiter: ",",
 *     },
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/stream_analytics_output_blob.html.markdown.
 */
export class OutputBlob extends pulumi.CustomResource {
    /**
     * Get an existing OutputBlob resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: OutputBlobState, opts?: pulumi.CustomResourceOptions): OutputBlob {
        return new OutputBlob(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:streamanalytics/outputBlob:OutputBlob';

    /**
     * Returns true if the given object is an instance of OutputBlob.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is OutputBlob {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === OutputBlob.__pulumiType;
    }

    /**
     * The date format. Wherever `{date}` appears in `pathPattern`, the value of this property is used as the date format instead.
     */
    public readonly dateFormat!: pulumi.Output<string>;
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job.
     */
    public readonly pathPattern!: pulumi.Output<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `serialization` block as defined below.
     */
    public readonly serialization!: pulumi.Output<outputs.streamanalytics.OutputBlobSerialization>;
    /**
     * The Access Key which should be used to connect to this Storage Account.
     */
    public readonly storageAccountKey!: pulumi.Output<string>;
    /**
     * The name of the Storage Account.
     */
    public readonly storageAccountName!: pulumi.Output<string>;
    /**
     * The name of the Container within the Storage Account.
     */
    public readonly storageContainerName!: pulumi.Output<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    public readonly streamAnalyticsJobName!: pulumi.Output<string>;
    /**
     * The time format. Wherever `{time}` appears in `pathPattern`, the value of this property is used as the time format instead.
     */
    public readonly timeFormat!: pulumi.Output<string>;

    /**
     * Create a OutputBlob resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: OutputBlobArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: OutputBlobArgs | OutputBlobState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as OutputBlobState | undefined;
            inputs["dateFormat"] = state ? state.dateFormat : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["pathPattern"] = state ? state.pathPattern : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["serialization"] = state ? state.serialization : undefined;
            inputs["storageAccountKey"] = state ? state.storageAccountKey : undefined;
            inputs["storageAccountName"] = state ? state.storageAccountName : undefined;
            inputs["storageContainerName"] = state ? state.storageContainerName : undefined;
            inputs["streamAnalyticsJobName"] = state ? state.streamAnalyticsJobName : undefined;
            inputs["timeFormat"] = state ? state.timeFormat : undefined;
        } else {
            const args = argsOrState as OutputBlobArgs | undefined;
            if (!args || args.dateFormat === undefined) {
                throw new Error("Missing required property 'dateFormat'");
            }
            if (!args || args.pathPattern === undefined) {
                throw new Error("Missing required property 'pathPattern'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.serialization === undefined) {
                throw new Error("Missing required property 'serialization'");
            }
            if (!args || args.storageAccountKey === undefined) {
                throw new Error("Missing required property 'storageAccountKey'");
            }
            if (!args || args.storageAccountName === undefined) {
                throw new Error("Missing required property 'storageAccountName'");
            }
            if (!args || args.storageContainerName === undefined) {
                throw new Error("Missing required property 'storageContainerName'");
            }
            if (!args || args.streamAnalyticsJobName === undefined) {
                throw new Error("Missing required property 'streamAnalyticsJobName'");
            }
            if (!args || args.timeFormat === undefined) {
                throw new Error("Missing required property 'timeFormat'");
            }
            inputs["dateFormat"] = args ? args.dateFormat : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["pathPattern"] = args ? args.pathPattern : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["serialization"] = args ? args.serialization : undefined;
            inputs["storageAccountKey"] = args ? args.storageAccountKey : undefined;
            inputs["storageAccountName"] = args ? args.storageAccountName : undefined;
            inputs["storageContainerName"] = args ? args.storageContainerName : undefined;
            inputs["streamAnalyticsJobName"] = args ? args.streamAnalyticsJobName : undefined;
            inputs["timeFormat"] = args ? args.timeFormat : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(OutputBlob.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering OutputBlob resources.
 */
export interface OutputBlobState {
    /**
     * The date format. Wherever `{date}` appears in `pathPattern`, the value of this property is used as the date format instead.
     */
    readonly dateFormat?: pulumi.Input<string>;
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job.
     */
    readonly pathPattern?: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `serialization` block as defined below.
     */
    readonly serialization?: pulumi.Input<inputs.streamanalytics.OutputBlobSerialization>;
    /**
     * The Access Key which should be used to connect to this Storage Account.
     */
    readonly storageAccountKey?: pulumi.Input<string>;
    /**
     * The name of the Storage Account.
     */
    readonly storageAccountName?: pulumi.Input<string>;
    /**
     * The name of the Container within the Storage Account.
     */
    readonly storageContainerName?: pulumi.Input<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    readonly streamAnalyticsJobName?: pulumi.Input<string>;
    /**
     * The time format. Wherever `{time}` appears in `pathPattern`, the value of this property is used as the time format instead.
     */
    readonly timeFormat?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a OutputBlob resource.
 */
export interface OutputBlobArgs {
    /**
     * The date format. Wherever `{date}` appears in `pathPattern`, the value of this property is used as the date format instead.
     */
    readonly dateFormat: pulumi.Input<string>;
    /**
     * The name of the Stream Output. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The blob path pattern. Not a regular expression. It represents a pattern against which blob names will be matched to determine whether or not they should be included as input or output to the job.
     */
    readonly pathPattern: pulumi.Input<string>;
    /**
     * The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `serialization` block as defined below.
     */
    readonly serialization: pulumi.Input<inputs.streamanalytics.OutputBlobSerialization>;
    /**
     * The Access Key which should be used to connect to this Storage Account.
     */
    readonly storageAccountKey: pulumi.Input<string>;
    /**
     * The name of the Storage Account.
     */
    readonly storageAccountName: pulumi.Input<string>;
    /**
     * The name of the Container within the Storage Account.
     */
    readonly storageContainerName: pulumi.Input<string>;
    /**
     * The name of the Stream Analytics Job. Changing this forces a new resource to be created.
     */
    readonly streamAnalyticsJobName: pulumi.Input<string>;
    /**
     * The time format. Wherever `{time}` appears in `pathPattern`, the value of this property is used as the time format instead.
     */
    readonly timeFormat: pulumi.Input<string>;
}
