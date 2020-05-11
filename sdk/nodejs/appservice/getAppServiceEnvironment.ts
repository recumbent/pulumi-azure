// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing App Service Environment
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = azure.appservice.getAppServiceEnvironment({
 *     name: "example-ase",
 *     resourceGroupName: "example-rg",
 * });
 * export const appServiceEnvironmentId = data.azurerm_app_service_environment.id;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/app_service_environment.html.markdown.
 */
export function getAppServiceEnvironment(args: GetAppServiceEnvironmentArgs, opts?: pulumi.InvokeOptions): Promise<GetAppServiceEnvironmentResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure:appservice/getAppServiceEnvironment:getAppServiceEnvironment", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getAppServiceEnvironment.
 */
export interface GetAppServiceEnvironmentArgs {
    /**
     * The name of the App Service Environment.
     */
    readonly name: string;
    /**
     * The Name of the Resource Group where the App Service Environment exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getAppServiceEnvironment.
 */
export interface GetAppServiceEnvironmentResult {
    /**
     * The number of app instances per App Service Environment Front End
     */
    readonly frontEndScaleFactor: number;
    /**
     * The Azure location where the App Service Environment exists
     */
    readonly location: string;
    readonly name: string;
    /**
     * The Pricing Tier (Isolated SKU) of the App Service Environment.
     */
    readonly pricingTier: string;
    readonly resourceGroupName: string;
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: string};
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
