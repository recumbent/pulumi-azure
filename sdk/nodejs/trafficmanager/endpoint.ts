// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Traffic Manager Endpoint.
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/traffic_manager_endpoint.html.markdown.
 */
/** @deprecated azure.Endpoint has been deprecated in favour of azure.TrafficManagerEndpoint */
export class Endpoint extends pulumi.CustomResource {
    /**
     * Get an existing Endpoint resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: EndpointState, opts?: pulumi.CustomResourceOptions): Endpoint {
        pulumi.log.warn("Endpoint is deprecated: azure.Endpoint has been deprecated in favour of azure.TrafficManagerEndpoint")
        return new Endpoint(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:trafficmanager/endpoint:Endpoint';

    /**
     * Returns true if the given object is an instance of Endpoint.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Endpoint {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Endpoint.__pulumiType;
    }

    /**
     * One or more `customHeader` blocks as defined below
     */
    public readonly customHeaders!: pulumi.Output<outputs.trafficmanager.EndpointCustomHeader[] | undefined>;
    /**
     * Specifies the Azure location of the Endpoint,
     * this must be specified for Profiles using the `Performance` routing method
     * if the Endpoint is of either type `nestedEndpoints` or `externalEndpoints`.
     * For Endpoints of type `azureEndpoints` the value will be taken from the
     * location of the Azure target resource.
     */
    public readonly endpointLocation!: pulumi.Output<string>;
    public /*out*/ readonly endpointMonitorStatus!: pulumi.Output<string>;
    /**
     * The status of the Endpoint, can be set to
     * either `Enabled` or `Disabled`. Defaults to `Enabled`.
     */
    public readonly endpointStatus!: pulumi.Output<string>;
    /**
     * A list of Geographic Regions used to distribute traffic, such as `WORLD`, `UK` or `DE`. The same location can't be specified in two endpoints. [See the Geographic Hierarchies documentation for more information](https://docs.microsoft.com/en-us/rest/api/trafficmanager/geographichierarchies/getdefault).
     */
    public readonly geoMappings!: pulumi.Output<string[] | undefined>;
    /**
     * This argument specifies the minimum number
     * of endpoints that must be ‘online’ in the child profile in order for the
     * parent profile to direct traffic to any of the endpoints in that child
     * profile. This argument only applies to Endpoints of type `nestedEndpoints`
     * and defaults to `1`.
     */
    public readonly minChildEndpoints!: pulumi.Output<number | undefined>;
    /**
     * The name of the Traffic Manager endpoint. Changing this forces a
     * new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Specifies the priority of this Endpoint, this must be
     * specified for Profiles using the `Priority` traffic routing method. Supports
     * values between 1 and 1000, with no Endpoints sharing the same value. If
     * omitted the value will be computed in order of creation.
     */
    public readonly priority!: pulumi.Output<number>;
    /**
     * The name of the Traffic Manager Profile to attach
     * create the Traffic Manager endpoint.
     */
    public readonly profileName!: pulumi.Output<string>;
    /**
     * The name of the resource group in which to
     * create the Traffic Manager endpoint.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * One or more `subnet` blocks as defined below
     */
    public readonly subnets!: pulumi.Output<outputs.trafficmanager.EndpointSubnet[] | undefined>;
    /**
     * The FQDN DNS name of the target. This argument must be
     * provided for an endpoint of type `externalEndpoints`, for other types it
     * will be computed.
     */
    public readonly target!: pulumi.Output<string>;
    /**
     * The resource id of an Azure resource to
     * target. This argument must be provided for an endpoint of type
     * `azureEndpoints` or `nestedEndpoints`.
     */
    public readonly targetResourceId!: pulumi.Output<string | undefined>;
    /**
     * The Endpoint type, must be one of:
     * - `azureEndpoints`
     * - `externalEndpoints`
     * - `nestedEndpoints`
     */
    public readonly type!: pulumi.Output<string>;
    /**
     * Specifies how much traffic should be distributed to this
     * endpoint, this must be specified for Profiles using the  `Weighted` traffic
     * routing method. Supports values between 1 and 1000.
     */
    public readonly weight!: pulumi.Output<number>;

    /**
     * Create a Endpoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    /** @deprecated azure.Endpoint has been deprecated in favour of azure.TrafficManagerEndpoint */
    constructor(name: string, args: EndpointArgs, opts?: pulumi.CustomResourceOptions)
    /** @deprecated azure.Endpoint has been deprecated in favour of azure.TrafficManagerEndpoint */
    constructor(name: string, argsOrState?: EndpointArgs | EndpointState, opts?: pulumi.CustomResourceOptions) {
        pulumi.log.warn("Endpoint is deprecated: azure.Endpoint has been deprecated in favour of azure.TrafficManagerEndpoint")
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as EndpointState | undefined;
            inputs["customHeaders"] = state ? state.customHeaders : undefined;
            inputs["endpointLocation"] = state ? state.endpointLocation : undefined;
            inputs["endpointMonitorStatus"] = state ? state.endpointMonitorStatus : undefined;
            inputs["endpointStatus"] = state ? state.endpointStatus : undefined;
            inputs["geoMappings"] = state ? state.geoMappings : undefined;
            inputs["minChildEndpoints"] = state ? state.minChildEndpoints : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["priority"] = state ? state.priority : undefined;
            inputs["profileName"] = state ? state.profileName : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["subnets"] = state ? state.subnets : undefined;
            inputs["target"] = state ? state.target : undefined;
            inputs["targetResourceId"] = state ? state.targetResourceId : undefined;
            inputs["type"] = state ? state.type : undefined;
            inputs["weight"] = state ? state.weight : undefined;
        } else {
            const args = argsOrState as EndpointArgs | undefined;
            if (!args || args.profileName === undefined) {
                throw new Error("Missing required property 'profileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            if (!args || args.type === undefined) {
                throw new Error("Missing required property 'type'");
            }
            inputs["customHeaders"] = args ? args.customHeaders : undefined;
            inputs["endpointLocation"] = args ? args.endpointLocation : undefined;
            inputs["endpointStatus"] = args ? args.endpointStatus : undefined;
            inputs["geoMappings"] = args ? args.geoMappings : undefined;
            inputs["minChildEndpoints"] = args ? args.minChildEndpoints : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["priority"] = args ? args.priority : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["subnets"] = args ? args.subnets : undefined;
            inputs["target"] = args ? args.target : undefined;
            inputs["targetResourceId"] = args ? args.targetResourceId : undefined;
            inputs["type"] = args ? args.type : undefined;
            inputs["weight"] = args ? args.weight : undefined;
            inputs["endpointMonitorStatus"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(Endpoint.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Endpoint resources.
 */
export interface EndpointState {
    /**
     * One or more `customHeader` blocks as defined below
     */
    readonly customHeaders?: pulumi.Input<pulumi.Input<inputs.trafficmanager.EndpointCustomHeader>[]>;
    /**
     * Specifies the Azure location of the Endpoint,
     * this must be specified for Profiles using the `Performance` routing method
     * if the Endpoint is of either type `nestedEndpoints` or `externalEndpoints`.
     * For Endpoints of type `azureEndpoints` the value will be taken from the
     * location of the Azure target resource.
     */
    readonly endpointLocation?: pulumi.Input<string>;
    readonly endpointMonitorStatus?: pulumi.Input<string>;
    /**
     * The status of the Endpoint, can be set to
     * either `Enabled` or `Disabled`. Defaults to `Enabled`.
     */
    readonly endpointStatus?: pulumi.Input<string>;
    /**
     * A list of Geographic Regions used to distribute traffic, such as `WORLD`, `UK` or `DE`. The same location can't be specified in two endpoints. [See the Geographic Hierarchies documentation for more information](https://docs.microsoft.com/en-us/rest/api/trafficmanager/geographichierarchies/getdefault).
     */
    readonly geoMappings?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * This argument specifies the minimum number
     * of endpoints that must be ‘online’ in the child profile in order for the
     * parent profile to direct traffic to any of the endpoints in that child
     * profile. This argument only applies to Endpoints of type `nestedEndpoints`
     * and defaults to `1`.
     */
    readonly minChildEndpoints?: pulumi.Input<number>;
    /**
     * The name of the Traffic Manager endpoint. Changing this forces a
     * new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the priority of this Endpoint, this must be
     * specified for Profiles using the `Priority` traffic routing method. Supports
     * values between 1 and 1000, with no Endpoints sharing the same value. If
     * omitted the value will be computed in order of creation.
     */
    readonly priority?: pulumi.Input<number>;
    /**
     * The name of the Traffic Manager Profile to attach
     * create the Traffic Manager endpoint.
     */
    readonly profileName?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to
     * create the Traffic Manager endpoint.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * One or more `subnet` blocks as defined below
     */
    readonly subnets?: pulumi.Input<pulumi.Input<inputs.trafficmanager.EndpointSubnet>[]>;
    /**
     * The FQDN DNS name of the target. This argument must be
     * provided for an endpoint of type `externalEndpoints`, for other types it
     * will be computed.
     */
    readonly target?: pulumi.Input<string>;
    /**
     * The resource id of an Azure resource to
     * target. This argument must be provided for an endpoint of type
     * `azureEndpoints` or `nestedEndpoints`.
     */
    readonly targetResourceId?: pulumi.Input<string>;
    /**
     * The Endpoint type, must be one of:
     * - `azureEndpoints`
     * - `externalEndpoints`
     * - `nestedEndpoints`
     */
    readonly type?: pulumi.Input<string>;
    /**
     * Specifies how much traffic should be distributed to this
     * endpoint, this must be specified for Profiles using the  `Weighted` traffic
     * routing method. Supports values between 1 and 1000.
     */
    readonly weight?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Endpoint resource.
 */
export interface EndpointArgs {
    /**
     * One or more `customHeader` blocks as defined below
     */
    readonly customHeaders?: pulumi.Input<pulumi.Input<inputs.trafficmanager.EndpointCustomHeader>[]>;
    /**
     * Specifies the Azure location of the Endpoint,
     * this must be specified for Profiles using the `Performance` routing method
     * if the Endpoint is of either type `nestedEndpoints` or `externalEndpoints`.
     * For Endpoints of type `azureEndpoints` the value will be taken from the
     * location of the Azure target resource.
     */
    readonly endpointLocation?: pulumi.Input<string>;
    /**
     * The status of the Endpoint, can be set to
     * either `Enabled` or `Disabled`. Defaults to `Enabled`.
     */
    readonly endpointStatus?: pulumi.Input<string>;
    /**
     * A list of Geographic Regions used to distribute traffic, such as `WORLD`, `UK` or `DE`. The same location can't be specified in two endpoints. [See the Geographic Hierarchies documentation for more information](https://docs.microsoft.com/en-us/rest/api/trafficmanager/geographichierarchies/getdefault).
     */
    readonly geoMappings?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * This argument specifies the minimum number
     * of endpoints that must be ‘online’ in the child profile in order for the
     * parent profile to direct traffic to any of the endpoints in that child
     * profile. This argument only applies to Endpoints of type `nestedEndpoints`
     * and defaults to `1`.
     */
    readonly minChildEndpoints?: pulumi.Input<number>;
    /**
     * The name of the Traffic Manager endpoint. Changing this forces a
     * new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * Specifies the priority of this Endpoint, this must be
     * specified for Profiles using the `Priority` traffic routing method. Supports
     * values between 1 and 1000, with no Endpoints sharing the same value. If
     * omitted the value will be computed in order of creation.
     */
    readonly priority?: pulumi.Input<number>;
    /**
     * The name of the Traffic Manager Profile to attach
     * create the Traffic Manager endpoint.
     */
    readonly profileName: pulumi.Input<string>;
    /**
     * The name of the resource group in which to
     * create the Traffic Manager endpoint.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * One or more `subnet` blocks as defined below
     */
    readonly subnets?: pulumi.Input<pulumi.Input<inputs.trafficmanager.EndpointSubnet>[]>;
    /**
     * The FQDN DNS name of the target. This argument must be
     * provided for an endpoint of type `externalEndpoints`, for other types it
     * will be computed.
     */
    readonly target?: pulumi.Input<string>;
    /**
     * The resource id of an Azure resource to
     * target. This argument must be provided for an endpoint of type
     * `azureEndpoints` or `nestedEndpoints`.
     */
    readonly targetResourceId?: pulumi.Input<string>;
    /**
     * The Endpoint type, must be one of:
     * - `azureEndpoints`
     * - `externalEndpoints`
     * - `nestedEndpoints`
     */
    readonly type: pulumi.Input<string>;
    /**
     * Specifies how much traffic should be distributed to this
     * endpoint, this must be specified for Profiles using the  `Weighted` traffic
     * routing method. Supports values between 1 and 1000.
     */
    readonly weight?: pulumi.Input<number>;
}
