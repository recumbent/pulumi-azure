// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Load Balancer Backend Address Pool.
 * 
 * > **NOTE:** When using this resource, the Load Balancer needs to have a FrontEnd IP Configuration Attached
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/lb_backend_address_pool.html.markdown.
 */
export class BackendAddressPool extends pulumi.CustomResource {
    /**
     * Get an existing BackendAddressPool resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BackendAddressPoolState, opts?: pulumi.CustomResourceOptions): BackendAddressPool {
        return new BackendAddressPool(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:lb/backendAddressPool:BackendAddressPool';

    /**
     * Returns true if the given object is an instance of BackendAddressPool.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BackendAddressPool {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BackendAddressPool.__pulumiType;
    }

    /**
     * The Backend IP Configurations associated with this Backend Address Pool.
     */
    public /*out*/ readonly backendIpConfigurations!: pulumi.Output<string[]>;
    /**
     * The Load Balancing Rules associated with this Backend Address Pool.
     */
    public /*out*/ readonly loadBalancingRules!: pulumi.Output<string[]>;
    /**
     * The ID of the Load Balancer in which to create the Backend Address Pool.
     */
    public readonly loadbalancerId!: pulumi.Output<string>;
    public readonly location!: pulumi.Output<string>;
    /**
     * Specifies the name of the Backend Address Pool.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the resource.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;

    /**
     * Create a BackendAddressPool resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BackendAddressPoolArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BackendAddressPoolArgs | BackendAddressPoolState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as BackendAddressPoolState | undefined;
            inputs["backendIpConfigurations"] = state ? state.backendIpConfigurations : undefined;
            inputs["loadBalancingRules"] = state ? state.loadBalancingRules : undefined;
            inputs["loadbalancerId"] = state ? state.loadbalancerId : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
        } else {
            const args = argsOrState as BackendAddressPoolArgs | undefined;
            if (!args || args.loadbalancerId === undefined) {
                throw new Error("Missing required property 'loadbalancerId'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["loadbalancerId"] = args ? args.loadbalancerId : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["backendIpConfigurations"] = undefined /*out*/;
            inputs["loadBalancingRules"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(BackendAddressPool.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BackendAddressPool resources.
 */
export interface BackendAddressPoolState {
    /**
     * The Backend IP Configurations associated with this Backend Address Pool.
     */
    readonly backendIpConfigurations?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The Load Balancing Rules associated with this Backend Address Pool.
     */
    readonly loadBalancingRules?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * The ID of the Load Balancer in which to create the Backend Address Pool.
     */
    readonly loadbalancerId?: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Backend Address Pool.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the resource.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a BackendAddressPool resource.
 */
export interface BackendAddressPoolArgs {
    /**
     * The ID of the Load Balancer in which to create the Backend Address Pool.
     */
    readonly loadbalancerId: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Backend Address Pool.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the resource.
     */
    readonly resourceGroupName: pulumi.Input<string>;
}
