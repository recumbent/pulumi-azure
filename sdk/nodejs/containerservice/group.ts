// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * Manage as an Azure Container Group instance.
 */
export class Group extends pulumi.CustomResource {
    /**
     * Get an existing Group resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: GroupState): Group {
        return new Group(name, <any>state, { id });
    }

    /**
     * The definition of a container that is part of the group as documented in the `container` block below. Changing this forces a new resource to be created.
     */
    public readonly containers: pulumi.Output<{ command: string, commands: string[], cpu: number, environmentVariables?: {[key: string]: any}, image: string, memory: number, name: string, port?: number, protocol?: string, secureEnvironmentVariables?: {[key: string]: any}, volumes?: { mountPath: string, name: string, readOnly?: boolean, shareName: string, storageAccountKey: string, storageAccountName: string }[] }[]>;
    /**
     * The DNS label/name for the container groups IP.
     */
    public readonly dnsNameLabel: pulumi.Output<string | undefined>;
    /**
     * The FQDN of the container group derived from `dns_name_label`.
     */
    public /*out*/ readonly fqdn: pulumi.Output<string>;
    /**
     * Set image registry credentials for the group as documented in the `image_registry_credential` block below
     */
    public readonly imageRegistryCredentials: pulumi.Output<{ password: string, server: string, username: string }[] | undefined>;
    /**
     * The IP address allocated to the container group.
     */
    public /*out*/ readonly ipAddress: pulumi.Output<string>;
    /**
     * Specifies the ip address type of the container. `Public` is the only acceptable value at this time. Changing this forces a new resource to be created.
     */
    public readonly ipAddressType: pulumi.Output<string | undefined>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location: pulumi.Output<string>;
    /**
     * Specifies the name of the Container Group. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * The OS for the container group. Allowed values are `Linux` and `Windows`. Changing this forces a new resource to be created.
     */
    public readonly osType: pulumi.Output<string>;
    /**
     * The name of the resource group in which to create the Container Group. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * Restart policy for the container group. Allowed values are `Always`, `Never`, `OnFailure`. Defaults to `Always`.
     */
    public readonly restartPolicy: pulumi.Output<string | undefined>;
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a Group resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: GroupArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: GroupArgs | GroupState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: GroupState = argsOrState as GroupState | undefined;
            inputs["containers"] = state ? state.containers : undefined;
            inputs["dnsNameLabel"] = state ? state.dnsNameLabel : undefined;
            inputs["fqdn"] = state ? state.fqdn : undefined;
            inputs["imageRegistryCredentials"] = state ? state.imageRegistryCredentials : undefined;
            inputs["ipAddress"] = state ? state.ipAddress : undefined;
            inputs["ipAddressType"] = state ? state.ipAddressType : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["osType"] = state ? state.osType : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["restartPolicy"] = state ? state.restartPolicy : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as GroupArgs | undefined;
            if (!args || args.containers === undefined) {
                throw new Error("Missing required property 'containers'");
            }
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.osType === undefined) {
                throw new Error("Missing required property 'osType'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["containers"] = args ? args.containers : undefined;
            inputs["dnsNameLabel"] = args ? args.dnsNameLabel : undefined;
            inputs["imageRegistryCredentials"] = args ? args.imageRegistryCredentials : undefined;
            inputs["ipAddressType"] = args ? args.ipAddressType : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["osType"] = args ? args.osType : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["restartPolicy"] = args ? args.restartPolicy : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["fqdn"] = undefined /*out*/;
            inputs["ipAddress"] = undefined /*out*/;
        }
        super("azure:containerservice/group:Group", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Group resources.
 */
export interface GroupState {
    /**
     * The definition of a container that is part of the group as documented in the `container` block below. Changing this forces a new resource to be created.
     */
    readonly containers?: pulumi.Input<pulumi.Input<{ command?: pulumi.Input<string>, commands?: pulumi.Input<pulumi.Input<string>[]>, cpu: pulumi.Input<number>, environmentVariables?: pulumi.Input<{[key: string]: any}>, image: pulumi.Input<string>, memory: pulumi.Input<number>, name: pulumi.Input<string>, port?: pulumi.Input<number>, protocol?: pulumi.Input<string>, secureEnvironmentVariables?: pulumi.Input<{[key: string]: any}>, volumes?: pulumi.Input<pulumi.Input<{ mountPath: pulumi.Input<string>, name: pulumi.Input<string>, readOnly?: pulumi.Input<boolean>, shareName: pulumi.Input<string>, storageAccountKey: pulumi.Input<string>, storageAccountName: pulumi.Input<string> }>[]> }>[]>;
    /**
     * The DNS label/name for the container groups IP.
     */
    readonly dnsNameLabel?: pulumi.Input<string>;
    /**
     * The FQDN of the container group derived from `dns_name_label`.
     */
    readonly fqdn?: pulumi.Input<string>;
    /**
     * Set image registry credentials for the group as documented in the `image_registry_credential` block below
     */
    readonly imageRegistryCredentials?: pulumi.Input<pulumi.Input<{ password: pulumi.Input<string>, server: pulumi.Input<string>, username: pulumi.Input<string> }>[]>;
    /**
     * The IP address allocated to the container group.
     */
    readonly ipAddress?: pulumi.Input<string>;
    /**
     * Specifies the ip address type of the container. `Public` is the only acceptable value at this time. Changing this forces a new resource to be created.
     */
    readonly ipAddressType?: pulumi.Input<string>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the Container Group. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The OS for the container group. Allowed values are `Linux` and `Windows`. Changing this forces a new resource to be created.
     */
    readonly osType?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Container Group. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * Restart policy for the container group. Allowed values are `Always`, `Never`, `OnFailure`. Defaults to `Always`.
     */
    readonly restartPolicy?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Group resource.
 */
export interface GroupArgs {
    /**
     * The definition of a container that is part of the group as documented in the `container` block below. Changing this forces a new resource to be created.
     */
    readonly containers: pulumi.Input<pulumi.Input<{ command?: pulumi.Input<string>, commands?: pulumi.Input<pulumi.Input<string>[]>, cpu: pulumi.Input<number>, environmentVariables?: pulumi.Input<{[key: string]: any}>, image: pulumi.Input<string>, memory: pulumi.Input<number>, name: pulumi.Input<string>, port?: pulumi.Input<number>, protocol?: pulumi.Input<string>, secureEnvironmentVariables?: pulumi.Input<{[key: string]: any}>, volumes?: pulumi.Input<pulumi.Input<{ mountPath: pulumi.Input<string>, name: pulumi.Input<string>, readOnly?: pulumi.Input<boolean>, shareName: pulumi.Input<string>, storageAccountKey: pulumi.Input<string>, storageAccountName: pulumi.Input<string> }>[]> }>[]>;
    /**
     * The DNS label/name for the container groups IP.
     */
    readonly dnsNameLabel?: pulumi.Input<string>;
    /**
     * Set image registry credentials for the group as documented in the `image_registry_credential` block below
     */
    readonly imageRegistryCredentials?: pulumi.Input<pulumi.Input<{ password: pulumi.Input<string>, server: pulumi.Input<string>, username: pulumi.Input<string> }>[]>;
    /**
     * Specifies the ip address type of the container. `Public` is the only acceptable value at this time. Changing this forces a new resource to be created.
     */
    readonly ipAddressType?: pulumi.Input<string>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies the name of the Container Group. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * The OS for the container group. Allowed values are `Linux` and `Windows`. Changing this forces a new resource to be created.
     */
    readonly osType: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the Container Group. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * Restart policy for the container group. Allowed values are `Always`, `Never`, `OnFailure`. Defaults to `Always`.
     */
    readonly restartPolicy?: pulumi.Input<string>;
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
