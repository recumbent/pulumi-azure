// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Machine Learning Workspace.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/machine_learning_workspace.html.markdown.
 */
export function getWorkspace(args: GetWorkspaceArgs, opts?: pulumi.InvokeOptions): Promise<GetWorkspaceResult> {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    return pulumi.runtime.invoke("azure:machinelearning/getWorkspace:getWorkspace", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);
}

/**
 * A collection of arguments for invoking getWorkspace.
 */
export interface GetWorkspaceArgs {
    /**
     * The name of the Machine Learning Workspace exists.
     */
    readonly name: string;
    /**
     * The name of the Resource Group where the Machine Learning Workspace exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getWorkspace.
 */
export interface GetWorkspaceResult {
    /**
     * The location where the Machine Learning Workspace exists.
     */
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * A mapping of tags assigned to the Machine Learning Workspace.
     */
    readonly tags: {[key: string]: string};
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
