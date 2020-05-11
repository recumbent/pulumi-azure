// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Azure Data Lake Analytics Firewall Rule.
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const exampleResourceGroup = new azure.core.ResourceGroup("exampleResourceGroup", {location: "northeurope"});
 * const exampleStore = new azure.datalake.Store("exampleStore", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 * });
 * const exampleAnalyticsAccount = new azure.datalake.AnalyticsAccount("exampleAnalyticsAccount", {
 *     resourceGroupName: exampleResourceGroup.name,
 *     location: exampleResourceGroup.location,
 *     defaultStoreAccountName: exampleStore.name,
 * });
 * const exampleAnalyticsFirewallRule = new azure.datalake.AnalyticsFirewallRule("exampleAnalyticsFirewallRule", {
 *     accountName: azurerm_data_lake_analytics.example.name,
 *     resourceGroupName: exampleResourceGroup.name,
 *     startIpAddress: "1.2.3.4",
 *     endIpAddress: "2.3.4.5",
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/data_lake_analytics_firewall_rule.html.markdown.
 */
export class AnalyticsFirewallRule extends pulumi.CustomResource {
    /**
     * Get an existing AnalyticsFirewallRule resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AnalyticsFirewallRuleState, opts?: pulumi.CustomResourceOptions): AnalyticsFirewallRule {
        return new AnalyticsFirewallRule(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:datalake/analyticsFirewallRule:AnalyticsFirewallRule';

    /**
     * Returns true if the given object is an instance of AnalyticsFirewallRule.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is AnalyticsFirewallRule {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === AnalyticsFirewallRule.__pulumiType;
    }

    /**
     * Specifies the name of the Data Lake Analytics for which the Firewall Rule should take effect.
     */
    public readonly accountName!: pulumi.Output<string>;
    /**
     * The End IP Address for the firewall rule.
     */
    public readonly endIpAddress!: pulumi.Output<string>;
    /**
     * Specifies the name of the Data Lake Analytics. Changing this forces a new resource to be created. Has to be between 3 to 24 characters.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the Data Lake Analytics.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * The Start IP address for the firewall rule.
     */
    public readonly startIpAddress!: pulumi.Output<string>;

    /**
     * Create a AnalyticsFirewallRule resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: AnalyticsFirewallRuleArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: AnalyticsFirewallRuleArgs | AnalyticsFirewallRuleState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AnalyticsFirewallRuleState | undefined;
            inputs["accountName"] = state ? state.accountName : undefined;
            inputs["endIpAddress"] = state ? state.endIpAddress : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["startIpAddress"] = state ? state.startIpAddress : undefined;
        } else {
            const args = argsOrState as AnalyticsFirewallRuleArgs | undefined;
            if (!args || args.accountName === undefined) {
                throw new Error("Missing required property 'accountName'");
            }
            if (!args || args.endIpAddress === undefined) {
                throw new Error("Missing required property 'endIpAddress'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.startIpAddress === undefined) {
                throw new Error("Missing required property 'startIpAddress'");
            }
            inputs["accountName"] = args ? args.accountName : undefined;
            inputs["endIpAddress"] = args ? args.endIpAddress : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["startIpAddress"] = args ? args.startIpAddress : undefined;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(AnalyticsFirewallRule.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering AnalyticsFirewallRule resources.
 */
export interface AnalyticsFirewallRuleState {
    /**
     * Specifies the name of the Data Lake Analytics for which the Firewall Rule should take effect.
     */
    readonly accountName?: pulumi.Input<string>;
    /**
     * The End IP Address for the firewall rule.
     */
    readonly endIpAddress?: pulumi.Input<string>;
    /**
     * Specifies the name of the Data Lake Analytics. Changing this forces a new resource to be created. Has to be between 3 to 24 characters.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Data Lake Analytics.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * The Start IP address for the firewall rule.
     */
    readonly startIpAddress?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a AnalyticsFirewallRule resource.
 */
export interface AnalyticsFirewallRuleArgs {
    /**
     * Specifies the name of the Data Lake Analytics for which the Firewall Rule should take effect.
     */
    readonly accountName: pulumi.Input<string>;
    /**
     * The End IP Address for the firewall rule.
     */
    readonly endIpAddress: pulumi.Input<string>;
    /**
     * Specifies the name of the Data Lake Analytics. Changing this forces a new resource to be created. Has to be between 3 to 24 characters.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Data Lake Analytics.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * The Start IP address for the firewall rule.
     */
    readonly startIpAddress: pulumi.Input<string>;
}
