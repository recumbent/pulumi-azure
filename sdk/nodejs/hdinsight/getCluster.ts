// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Use this data source to access information about an existing HDInsight Cluster.
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/hdinsight_cluster.html.markdown.
 */
export function getCluster(args: GetClusterArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResult> & GetClusterResult {
    if (!opts) {
        opts = {}
    }

    if (!opts.version) {
        opts.version = utilities.getVersion();
    }
    const promise: Promise<GetClusterResult> = pulumi.runtime.invoke("azure:hdinsight/getCluster:getCluster", {
        "name": args.name,
        "resourceGroupName": args.resourceGroupName,
    }, opts);

    return pulumi.utils.liftProperties(promise, opts);
}

/**
 * A collection of arguments for invoking getCluster.
 */
export interface GetClusterArgs {
    /**
     * Specifies the name of this HDInsight Cluster.
     */
    readonly name: string;
    /**
     * Specifies the name of the Resource Group in which this HDInsight Cluster exists.
     */
    readonly resourceGroupName: string;
}

/**
 * A collection of values returned by getCluster.
 */
export interface GetClusterResult {
    /**
     * The version of HDInsights which is used on this HDInsight Cluster.
     */
    readonly clusterVersion: string;
    /**
     * A map of versions of software used on this HDInsights Cluster.
     */
    readonly componentVersions: {[key: string]: string};
    /**
     * The SSH Endpoint of the Edge Node for this HDInsight Cluster, if an Edge Node exists.
     */
    readonly edgeSshEndpoint: string;
    /**
     * A `gateway` block as defined below.
     */
    readonly gateways: outputs.hdinsight.GetClusterGateway[];
    /**
     * The HTTPS Endpoint for this HDInsight Cluster.
     */
    readonly httpsEndpoint: string;
    /**
     * The kind of HDInsight Cluster this is, such as a Spark or Storm cluster.
     */
    readonly kind: string;
    /**
     * The Azure Region in which this HDInsight Cluster exists.
     */
    readonly location: string;
    readonly name: string;
    readonly resourceGroupName: string;
    /**
     * The SSH Endpoint for this HDInsight Cluster.
     */
    readonly sshEndpoint: string;
    /**
     * A map of tags assigned to the HDInsight Cluster.
     */
    readonly tags: {[key: string]: string};
    /**
     * The SKU / Tier of this HDInsight Cluster.
     */
    readonly tier: string;
    /**
     * id is the provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
}
