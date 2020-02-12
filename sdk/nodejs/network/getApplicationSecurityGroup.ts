// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing Application Security Group.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/application_security_group.html.markdown.
 */
export function getApplicationSecurityGroup(args: GetApplicationSecurityGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetApplicationSecurityGroupResult> & GetApplicationSecurityGroupResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetApplicationSecurityGroupResult> = pulumi.runtime.invoke("azure:network/getApplicationSecurityGroup:getApplicationSecurityGroup", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getApplicationSecurityGroup.
 */
export interface GetApplicationSecurityGroupArgs {
    /**
     * The name of the Application Security Group.
     */
    readonly name: string;
    /**
     * The name of the resource group in which the Application Security Group exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getApplicationSecurityGroup.
 */
export interface GetApplicationSecurityGroupResult {
    /**
     * The supported Azure location where the Application Security Group exists.
     */
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * A mapping of tags assigned to the resource.
     */
    readonly tags: {[key: string]: string};
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
