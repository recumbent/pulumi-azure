// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Assigns a given Principal (User or Application) to a given Role.
 * 
 * ## Example Usage (using a built-in Role)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const primary = azure.core.getSubscription({});
 * const exampleClientConfig = azure.core.getClientConfig({});
 * const exampleAssignment = new azure.authorization.Assignment("exampleAssignment", {
 *     scope: primary.then(primary => primary.id),
 *     roleDefinitionName: "Reader",
 *     principalId: exampleClientConfig.then(exampleClientConfig => exampleClientConfig.objectId),
 * });
 * ```
 * 
 * ## Example Usage (Custom Role & Service Principal)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const primary = azure.core.getSubscription({});
 * const exampleClientConfig = azure.core.getClientConfig({});
 * const exampleRoleDefinition = new azure.authorization.RoleDefinition("exampleRoleDefinition", {
 *     roleDefinitionId: "00000000-0000-0000-0000-000000000000",
 *     scope: primary.then(primary => primary.id),
 *     permissions: [{
 *         actions: ["Microsoft.Resources/subscriptions/resourceGroups/read"],
 *         notActions: [],
 *     }],
 *     assignableScopes: [primary.then(primary => primary.id)],
 * });
 * const exampleAssignment = new azure.authorization.Assignment("exampleAssignment", {
 *     name: "00000000-0000-0000-0000-000000000000",
 *     scope: primary.then(primary => primary.id),
 *     roleDefinitionId: exampleRoleDefinition.id,
 *     principalId: exampleClientConfig.then(exampleClientConfig => exampleClientConfig.objectId),
 * });
 * ```
 * 
 * ## Example Usage (Custom Role & User)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const primary = azure.core.getSubscription({});
 * const exampleClientConfig = azure.core.getClientConfig({});
 * const exampleRoleDefinition = new azure.authorization.RoleDefinition("exampleRoleDefinition", {
 *     roleDefinitionId: "00000000-0000-0000-0000-000000000000",
 *     scope: primary.then(primary => primary.id),
 *     permissions: [{
 *         actions: ["Microsoft.Resources/subscriptions/resourceGroups/read"],
 *         notActions: [],
 *     }],
 *     assignableScopes: [primary.then(primary => primary.id)],
 * });
 * const exampleAssignment = new azure.authorization.Assignment("exampleAssignment", {
 *     name: "00000000-0000-0000-0000-000000000000",
 *     scope: primary.then(primary => primary.id),
 *     roleDefinitionId: exampleRoleDefinition.id,
 *     principalId: exampleClientConfig.then(exampleClientConfig => exampleClientConfig.clientId),
 * });
 * ```
 * 
 * ## Example Usage (Custom Role & Management Group)
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const primary = azure.core.getSubscription({});
 * const exampleClientConfig = azure.core.getClientConfig({});
 * const exampleGroup = azure.management.getGroup({});
 * const exampleRoleDefinition = new azure.authorization.RoleDefinition("exampleRoleDefinition", {
 *     roleDefinitionId: "00000000-0000-0000-0000-000000000000",
 *     scope: primary.then(primary => primary.id),
 *     permissions: [{
 *         actions: ["Microsoft.Resources/subscriptions/resourceGroups/read"],
 *         notActions: [],
 *     }],
 *     assignableScopes: [primary.then(primary => primary.id)],
 * });
 * const exampleAssignment = new azure.authorization.Assignment("exampleAssignment", {
 *     name: "00000000-0000-0000-0000-000000000000",
 *     scope: data.azurerm_management_group.primary.id,
 *     roleDefinitionId: exampleRoleDefinition.id,
 *     principalId: exampleClientConfig.then(exampleClientConfig => exampleClientConfig.clientId),
 * });
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/role_assignment.html.markdown.
 */
/** @deprecated azure.role.Assignment has been deprecated in favour of azure.authorization.Assignment */
export class Assignment extends pulumi.CustomResource {
    /**
     * Get an existing Assignment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: AssignmentState, opts?: pulumi.CustomResourceOptions): Assignment {
        pulumi.log.warn("Assignment is deprecated: azure.role.Assignment has been deprecated in favour of azure.authorization.Assignment")
        return new Assignment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:role/assignment:Assignment';

    /**
     * Returns true if the given object is an instance of Assignment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Assignment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Assignment.__pulumiType;
    }

    /**
     * A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The ID of the Principal (User, Group, Service Principal, or Application) to assign the Role Definition to. Changing this forces a new resource to be created.
     */
    public readonly principalId!: pulumi.Output<string>;
    /**
     * The type of the `principalId`, e.g. User, Group, Service Principal, Application, etc.
     */
    public /*out*/ readonly principalType!: pulumi.Output<string>;
    /**
     * The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `roleDefinitionName`.
     */
    public readonly roleDefinitionId!: pulumi.Output<string>;
    /**
     * The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `roleDefinitionId`.
     */
    public readonly roleDefinitionName!: pulumi.Output<string>;
    /**
     * The scope at which the Role Assignment applies to, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`, or `/providers/Microsoft.Management/managementGroups/myMG`. Changing this forces a new resource to be created.
     */
    public readonly scope!: pulumi.Output<string>;
    /**
     * If the `principalId` is a newly provisioned `Service Principal` set this value to `true` to skip the `Azure Active Directory` check which may fail due to replication lag. This argument is only valid if the `principalId` is a `Service Principal` identity. If it is not a `Service Principal` identity it will cause the role assignment to fail. Defaults to `false`.
     */
    public readonly skipServicePrincipalAadCheck!: pulumi.Output<boolean>;

    /**
     * Create a Assignment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated azure.role.Assignment has been deprecated in favour of azure.authorization.Assignment */
    constructor(name: string, args: AssignmentArgs, opts?: pulumi.CustomResourceOptions)
    /** @deprecated azure.role.Assignment has been deprecated in favour of azure.authorization.Assignment */
    constructor(name: string, argsOrState?: AssignmentArgs | AssignmentState, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Assignment is deprecated: azure.role.Assignment has been deprecated in favour of azure.authorization.Assignment")
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as AssignmentState | undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["principalId"] = state ? state.principalId : undefined;
            inputs["principalType"] = state ? state.principalType : undefined;
            inputs["roleDefinitionId"] = state ? state.roleDefinitionId : undefined;
            inputs["roleDefinitionName"] = state ? state.roleDefinitionName : undefined;
            inputs["scope"] = state ? state.scope : undefined;
            inputs["skipServicePrincipalAadCheck"] = state ? state.skipServicePrincipalAadCheck : undefined;
        } else {
            const args = argsOrState as AssignmentArgs | undefined;
            if (!args || args.principalId === undefined) {
                throw new Error("Missing required property 'principalId'");
            }
            if (!args || args.scope === undefined) {
                throw new Error("Missing required property 'scope'");
            }
            inputs["name"] = args ? args.name : undefined;
            inputs["principalId"] = args ? args.principalId : undefined;
            inputs["roleDefinitionId"] = args ? args.roleDefinitionId : undefined;
            inputs["roleDefinitionName"] = args ? args.roleDefinitionName : undefined;
            inputs["scope"] = args ? args.scope : undefined;
            inputs["skipServicePrincipalAadCheck"] = args ? args.skipServicePrincipalAadCheck : undefined;
            inputs["principalType"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Assignment.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Assignment resources.
 */
export interface AssignmentState {
    /**
     * A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the Principal (User, Group, Service Principal, or Application) to assign the Role Definition to. Changing this forces a new resource to be created.
     */
    readonly principalId?: pulumi.Input<string>;
    /**
     * The type of the `principalId`, e.g. User, Group, Service Principal, Application, etc.
     */
    readonly principalType?: pulumi.Input<string>;
    /**
     * The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `roleDefinitionName`.
     */
    readonly roleDefinitionId?: pulumi.Input<string>;
    /**
     * The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `roleDefinitionId`.
     */
    readonly roleDefinitionName?: pulumi.Input<string>;
    /**
     * The scope at which the Role Assignment applies to, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`, or `/providers/Microsoft.Management/managementGroups/myMG`. Changing this forces a new resource to be created.
     */
    readonly scope?: pulumi.Input<string>;
    /**
     * If the `principalId` is a newly provisioned `Service Principal` set this value to `true` to skip the `Azure Active Directory` check which may fail due to replication lag. This argument is only valid if the `principalId` is a `Service Principal` identity. If it is not a `Service Principal` identity it will cause the role assignment to fail. Defaults to `false`.
     */
    readonly skipServicePrincipalAadCheck?: pulumi.Input<boolean>;
}

/**
 * The set of arguments for constructing a Assignment resource.
 */
export interface AssignmentArgs {
    /**
     * A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The ID of the Principal (User, Group, Service Principal, or Application) to assign the Role Definition to. Changing this forces a new resource to be created.
     */
    readonly principalId: pulumi.Input<string>;
    /**
     * The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `roleDefinitionName`.
     */
    readonly roleDefinitionId?: pulumi.Input<string>;
    /**
     * The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `roleDefinitionId`.
     */
    readonly roleDefinitionName?: pulumi.Input<string>;
    /**
     * The scope at which the Role Assignment applies to, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`, or `/providers/Microsoft.Management/managementGroups/myMG`. Changing this forces a new resource to be created.
     */
    readonly scope: pulumi.Input<string>;
    /**
     * If the `principalId` is a newly provisioned `Service Principal` set this value to `true` to skip the `Azure Active Directory` check which may fail due to replication lag. This argument is only valid if the `principalId` is a `Service Principal` identity. If it is not a `Service Principal` identity it will cause the role assignment to fail. Defaults to `false`.
     */
    readonly skipServicePrincipalAadCheck?: pulumi.Input<boolean>;
}
