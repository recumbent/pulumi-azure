// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manages a Network Rule Collection within an Azure Firewall.
 * 
 * -> **NOTE** Azure Firewall is currently in Public Preview.
 */
export class FirewallNetworkRuleCollection extends pulumi.CustomResource {
    /**
     * Get an existing FirewallNetworkRuleCollection resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: FirewallNetworkRuleCollectionState, opts?: pulumi.CustomResourceOptions): FirewallNetworkRuleCollection {
        return new FirewallNetworkRuleCollection(name, <any>state, { ...opts, id: id });
    }

    /**
     * Specifies the action the rule will apply to matching traffic. Possible values are `Allow` and `Deny`.
     */
    public readonly action: pulumi.Output<string>;
    /**
     * Specifies the name of the Firewall in which to the Network Rule Collection should be created. Changing this forces a new resource to be created.
     */
    public readonly azureFirewallName: pulumi.Output<string>;
    /**
     * Specifies the name of the Network Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * Specifies the priority of the rule collection. Possible values are between `100` - `65000`.
     */
    public readonly priority: pulumi.Output<number>;
    /**
     * Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * One or more `rule` blocks as defined below.
     */
    public readonly rules: pulumi.Output<{ description?: string, destinationAddresses: string[], destinationPorts: string[], name: string, protocols: string[], sourceAddresses: string[] }[]>;

    /**
     * Create a FirewallNetworkRuleCollection resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: FirewallNetworkRuleCollectionArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: FirewallNetworkRuleCollectionArgs | FirewallNetworkRuleCollectionState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: FirewallNetworkRuleCollectionState = argsOrState as FirewallNetworkRuleCollectionState | undefined;
            inputs["action"] = state ? state.action : undefined;
            inputs["azureFirewallName"] = state ? state.azureFirewallName : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["priority"] = state ? state.priority : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["rules"] = state ? state.rules : undefined;
        } else {
            const args = argsOrState as FirewallNetworkRuleCollectionArgs | undefined;
            if (!args || args.action === undefined) {
                throw new Error("Missing required property 'action'");
            }
            if (!args || args.azureFirewallName === undefined) {
                throw new Error("Missing required property 'azureFirewallName'");
            }
            if (!args || args.priority === undefined) {
                throw new Error("Missing required property 'priority'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.rules === undefined) {
                throw new Error("Missing required property 'rules'");
            }
            inputs["action"] = args ? args.action : undefined;
            inputs["azureFirewallName"] = args ? args.azureFirewallName : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["priority"] = args ? args.priority : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["rules"] = args ? args.rules : undefined;
        }
        super("azure:network/firewallNetworkRuleCollection:FirewallNetworkRuleCollection", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering FirewallNetworkRuleCollection resources.
 */
export interface FirewallNetworkRuleCollectionState {
    /**
     * Specifies the action the rule will apply to matching traffic. Possible values are `Allow` and `Deny`.
     */
    readonly action?: pulumi.Input<string>;
    /**
     * Specifies the name of the Firewall in which to the Network Rule Collection should be created. Changing this forces a new resource to be created.
     */
    readonly azureFirewallName?: pulumi.Input<string>;
    /**
     * Specifies the name of the Network Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the priority of the rule collection. Possible values are between `100` - `65000`.
     */
    readonly priority?: pulumi.Input<number>;
    /**
     * Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * One or more `rule` blocks as defined below.
     */
    readonly rules?: pulumi.Input<pulumi.Input<{ description?: pulumi.Input<string>, destinationAddresses: pulumi.Input<pulumi.Input<string>[]>, destinationPorts: pulumi.Input<pulumi.Input<string>[]>, name: pulumi.Input<string>, protocols: pulumi.Input<pulumi.Input<string>[]>, sourceAddresses: pulumi.Input<pulumi.Input<string>[]> }>[]>;
}

/**
 * The set of arguments for constructing a FirewallNetworkRuleCollection resource.
 */
export interface FirewallNetworkRuleCollectionArgs {
    /**
     * Specifies the action the rule will apply to matching traffic. Possible values are `Allow` and `Deny`.
     */
    readonly action: pulumi.Input<string>;
    /**
     * Specifies the name of the Firewall in which to the Network Rule Collection should be created. Changing this forces a new resource to be created.
     */
    readonly azureFirewallName: pulumi.Input<string>;
    /**
     * Specifies the name of the Network Rule Collection which must be unique within the Firewall. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the priority of the rule collection. Possible values are between `100` - `65000`.
     */
    readonly priority: pulumi.Input<number>;
    /**
     * Specifies the name of the Resource Group in which the Firewall exists. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * One or more `rule` blocks as defined below.
     */
    readonly rules: pulumi.Input<pulumi.Input<{ description?: pulumi.Input<string>, destinationAddresses: pulumi.Input<pulumi.Input<string>[]>, destinationPorts: pulumi.Input<pulumi.Input<string>[]>, name: pulumi.Input<string>, protocols: pulumi.Input<pulumi.Input<string>[]>, sourceAddresses: pulumi.Input<pulumi.Input<string>[]> }>[]>;
}
