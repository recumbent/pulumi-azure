// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Azure Data Factory (Version 2).
 * 
 * ## Example Usage
 * 
 * 
 * 
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as azure from "@pulumi/azure";
 * 
 * const example = azure.datafactory.getFactory({
 *     name: azurerm_data_factory.example.name,
 *     resourceGroupName: azurerm_data_factory.example.resource_group_name,
 * });
 * export const dataFactoryId = azurerm_data_factory.example.id;
 * ```
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/data_factory.html.markdown.
 */
export function getFactory(args: GetFactoryArgs, opts?: pulumi.InvokeOptions): Promise<GetFactoryResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure:datafactory/getFactory:getFactory", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getFactory.
 */
export interface GetFactoryArgs {
    /**
     * Specifies the name of the Data Factory to retrieve information about. 
     */
    readonly name: string;
    /**
     * The name of the resource group where the Data Factory exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getFactory.
 */
export interface GetFactoryResult {
    /**
     * A `githubConfiguration` block as defined below.
     */
    readonly githubConfigurations: outputs.datafactory.GetFactoryGithubConfiguration[];
    /**
     * An `identity` block as defined below.
     */
    readonly identities: outputs.datafactory.GetFactoryIdentity[];
    /**
     * The Azure location where the resource exists.
     */
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * A mapping of tags assigned to the resource.
     * ---
     */
    readonly tags: {[key: string]: string};
    /**
     * A `vstsConfiguration` block as defined below.
     */
    readonly vstsConfigurations: outputs.datafactory.GetFactoryVstsConfiguration[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
