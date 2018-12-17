// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

/**
 * A CDN Endpoint is the entity within a CDN Profile containing configuration information regarding caching behaviors and origins. The CDN Endpoint is exposed using the URL format <endpointname>.azureedge.net.
 */
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
        return new Endpoint(name, <any>state, { ...opts, id: id });
    }

    /**
     * An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.
     */
    public readonly contentTypesToCompresses: pulumi.Output<string[]>;
    /**
     * A set of Geo Filters for this CDN Endpoint. Each `geo_filter` block supports fields documented below.
     */
    public readonly geoFilters: pulumi.Output<{ action: string, countryCodes: string[], relativePath: string }[] | undefined>;
    public /*out*/ readonly hostName: pulumi.Output<string>;
    /**
     * Indicates whether compression is to be enabled. Defaults to false.
     */
    public readonly isCompressionEnabled: pulumi.Output<boolean | undefined>;
    /**
     * Defaults to `true`.
     */
    public readonly isHttpAllowed: pulumi.Output<boolean | undefined>;
    /**
     * Defaults to `true`.
     */
    public readonly isHttpsAllowed: pulumi.Output<boolean | undefined>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    public readonly location: pulumi.Output<string>;
    /**
     * Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
     */
    public readonly name: pulumi.Output<string>;
    /**
     * What types of optimization should this CDN Endpoint optimize for? Possible values include `DynamicSiteAcceleration`, `GeneralMediaStreaming`, `GeneralWebDelivery`, `LargeFileDownload` and `VideoOnDemandMediaStreaming`.
     */
    public readonly optimizationType: pulumi.Output<string | undefined>;
    /**
     * The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each `origin` block supports fields documented below.
     */
    public readonly origins: pulumi.Output<{ hostName: string, httpPort?: number, httpsPort?: number, name: string }[]>;
    /**
     * The host header CDN provider will send along with content requests to origins. Defaults to the host name of the origin.
     */
    public readonly originHostHeader: pulumi.Output<string>;
    /**
     * The path used at for origin requests.
     */
    public readonly originPath: pulumi.Output<string>;
    /**
     * the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the `origin_path`.
     */
    public readonly probePath: pulumi.Output<string>;
    /**
     * The CDN Profile to which to attach the CDN Endpoint.
     */
    public readonly profileName: pulumi.Output<string>;
    /**
     * Sets query string caching behavior. Allowed values are `IgnoreQueryString`, `BypassCaching` and `UseQueryString`. Defaults to `IgnoreQueryString`.
     */
    public readonly querystringCachingBehaviour: pulumi.Output<string | undefined>;
    /**
     * The name of the resource group in which to create the CDN Endpoint.
     */
    public readonly resourceGroupName: pulumi.Output<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags: pulumi.Output<{[key: string]: any}>;

    /**
     * Create a Endpoint resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: EndpointArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: EndpointArgs | EndpointState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state: EndpointState = argsOrState as EndpointState | undefined;
            inputs["contentTypesToCompresses"] = state ? state.contentTypesToCompresses : undefined;
            inputs["geoFilters"] = state ? state.geoFilters : undefined;
            inputs["hostName"] = state ? state.hostName : undefined;
            inputs["isCompressionEnabled"] = state ? state.isCompressionEnabled : undefined;
            inputs["isHttpAllowed"] = state ? state.isHttpAllowed : undefined;
            inputs["isHttpsAllowed"] = state ? state.isHttpsAllowed : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["optimizationType"] = state ? state.optimizationType : undefined;
            inputs["origins"] = state ? state.origins : undefined;
            inputs["originHostHeader"] = state ? state.originHostHeader : undefined;
            inputs["originPath"] = state ? state.originPath : undefined;
            inputs["probePath"] = state ? state.probePath : undefined;
            inputs["profileName"] = state ? state.profileName : undefined;
            inputs["querystringCachingBehaviour"] = state ? state.querystringCachingBehaviour : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as EndpointArgs | undefined;
            if (!args || args.location === undefined) {
                throw new Error("Missing required property 'location'");
            }
            if (!args || args.origins === undefined) {
                throw new Error("Missing required property 'origins'");
            }
            if (!args || args.profileName === undefined) {
                throw new Error("Missing required property 'profileName'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["contentTypesToCompresses"] = args ? args.contentTypesToCompresses : undefined;
            inputs["geoFilters"] = args ? args.geoFilters : undefined;
            inputs["isCompressionEnabled"] = args ? args.isCompressionEnabled : undefined;
            inputs["isHttpAllowed"] = args ? args.isHttpAllowed : undefined;
            inputs["isHttpsAllowed"] = args ? args.isHttpsAllowed : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["optimizationType"] = args ? args.optimizationType : undefined;
            inputs["origins"] = args ? args.origins : undefined;
            inputs["originHostHeader"] = args ? args.originHostHeader : undefined;
            inputs["originPath"] = args ? args.originPath : undefined;
            inputs["probePath"] = args ? args.probePath : undefined;
            inputs["profileName"] = args ? args.profileName : undefined;
            inputs["querystringCachingBehaviour"] = args ? args.querystringCachingBehaviour : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["hostName"] = undefined /*out*/;
        }
        super("azure:cdn/endpoint:Endpoint", name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Endpoint resources.
 */
export interface EndpointState {
    /**
     * An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.
     */
    readonly contentTypesToCompresses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A set of Geo Filters for this CDN Endpoint. Each `geo_filter` block supports fields documented below.
     */
    readonly geoFilters?: pulumi.Input<pulumi.Input<{ action: pulumi.Input<string>, countryCodes: pulumi.Input<pulumi.Input<string>[]>, relativePath: pulumi.Input<string> }>[]>;
    readonly hostName?: pulumi.Input<string>;
    /**
     * Indicates whether compression is to be enabled. Defaults to false.
     */
    readonly isCompressionEnabled?: pulumi.Input<boolean>;
    /**
     * Defaults to `true`.
     */
    readonly isHttpAllowed?: pulumi.Input<boolean>;
    /**
     * Defaults to `true`.
     */
    readonly isHttpsAllowed?: pulumi.Input<boolean>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * What types of optimization should this CDN Endpoint optimize for? Possible values include `DynamicSiteAcceleration`, `GeneralMediaStreaming`, `GeneralWebDelivery`, `LargeFileDownload` and `VideoOnDemandMediaStreaming`.
     */
    readonly optimizationType?: pulumi.Input<string>;
    /**
     * The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each `origin` block supports fields documented below.
     */
    readonly origins?: pulumi.Input<pulumi.Input<{ hostName: pulumi.Input<string>, httpPort?: pulumi.Input<number>, httpsPort?: pulumi.Input<number>, name: pulumi.Input<string> }>[]>;
    /**
     * The host header CDN provider will send along with content requests to origins. Defaults to the host name of the origin.
     */
    readonly originHostHeader?: pulumi.Input<string>;
    /**
     * The path used at for origin requests.
     */
    readonly originPath?: pulumi.Input<string>;
    /**
     * the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the `origin_path`.
     */
    readonly probePath?: pulumi.Input<string>;
    /**
     * The CDN Profile to which to attach the CDN Endpoint.
     */
    readonly profileName?: pulumi.Input<string>;
    /**
     * Sets query string caching behavior. Allowed values are `IgnoreQueryString`, `BypassCaching` and `UseQueryString`. Defaults to `IgnoreQueryString`.
     */
    readonly querystringCachingBehaviour?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the CDN Endpoint.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Endpoint resource.
 */
export interface EndpointArgs {
    /**
     * An array of strings that indicates a content types on which compression will be applied. The value for the elements should be MIME types.
     */
    readonly contentTypesToCompresses?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A set of Geo Filters for this CDN Endpoint. Each `geo_filter` block supports fields documented below.
     */
    readonly geoFilters?: pulumi.Input<pulumi.Input<{ action: pulumi.Input<string>, countryCodes: pulumi.Input<pulumi.Input<string>[]>, relativePath: pulumi.Input<string> }>[]>;
    /**
     * Indicates whether compression is to be enabled. Defaults to false.
     */
    readonly isCompressionEnabled?: pulumi.Input<boolean>;
    /**
     * Defaults to `true`.
     */
    readonly isHttpAllowed?: pulumi.Input<boolean>;
    /**
     * Defaults to `true`.
     */
    readonly isHttpsAllowed?: pulumi.Input<boolean>;
    /**
     * Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
     */
    readonly location: pulumi.Input<string>;
    /**
     * Specifies the name of the CDN Endpoint. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * What types of optimization should this CDN Endpoint optimize for? Possible values include `DynamicSiteAcceleration`, `GeneralMediaStreaming`, `GeneralWebDelivery`, `LargeFileDownload` and `VideoOnDemandMediaStreaming`.
     */
    readonly optimizationType?: pulumi.Input<string>;
    /**
     * The set of origins of the CDN endpoint. When multiple origins exist, the first origin will be used as primary and rest will be used as failover options. Each `origin` block supports fields documented below.
     */
    readonly origins: pulumi.Input<pulumi.Input<{ hostName: pulumi.Input<string>, httpPort?: pulumi.Input<number>, httpsPort?: pulumi.Input<number>, name: pulumi.Input<string> }>[]>;
    /**
     * The host header CDN provider will send along with content requests to origins. Defaults to the host name of the origin.
     */
    readonly originHostHeader?: pulumi.Input<string>;
    /**
     * The path used at for origin requests.
     */
    readonly originPath?: pulumi.Input<string>;
    /**
     * the path to a file hosted on the origin which helps accelerate delivery of the dynamic content and calculate the most optimal routes for the CDN. This is relative to the `origin_path`.
     */
    readonly probePath?: pulumi.Input<string>;
    /**
     * The CDN Profile to which to attach the CDN Endpoint.
     */
    readonly profileName: pulumi.Input<string>;
    /**
     * Sets query string caching behavior. Allowed values are `IgnoreQueryString`, `BypassCaching` and `UseQueryString`. Defaults to `IgnoreQueryString`.
     */
    readonly querystringCachingBehaviour?: pulumi.Input<string>;
    /**
     * The name of the resource group in which to create the CDN Endpoint.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: any}>;
}
