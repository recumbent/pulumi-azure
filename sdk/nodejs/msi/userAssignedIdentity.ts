// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class UserAssignedIdentity extends pulumi.CustomResource {
    /**
     * Get an existing UserAssignedIdentity resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: UserAssignedIdentityState): UserAssignedIdentity {
        return new UserAssignedIdentity(name, <any>state, { id });
    }

    public /*out*/ readonly clientId: pulumi.Output<string>;
    public readonly location: pulumi.Output<string>;
    public readonly name: pulumi.Output<string>;
    public /*out*/ readonly principalId: pulumi.Output<string>;
    public readonly resourceGroupName: pulumi.Output<string>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a UserAssignedIdentity resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: UserAssignedIdentityArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: UserAssignedIdentityArgs | UserAssignedIdentityState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: UserAssignedIdentityState = argsOrState as UserAssignedIdentityState | undefined;
            inputs["clientId"] = state ? state.clientId : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["principalId"] = state ? state.principalId : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as UserAssignedIdentityArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["clientId"] = undefined /*out*/;
            inputs["principalId"] = undefined /*out*/;
        }
        super("azure:msi/userAssignedIdentity:UserAssignedIdentity", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering UserAssignedIdentity resources.
 */
export interface UserAssignedIdentityState {
    readonly clientId?: pulumi.Input<string>;
    readonly location?: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly principalId?: pulumi.Input<string>;
    readonly resourceGroupName?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a UserAssignedIdentity resource.
 */
export interface UserAssignedIdentityArgs {
    readonly location: pulumi.Input<string>;
    readonly name?: pulumi.Input<string>;
    readonly resourceGroupName: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
