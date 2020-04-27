// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

/**
 * Manages a Managed Kubernetes Cluster (also known as AKS / Azure Kubernetes Service)
 * 
 *
 * > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/kubernetes_cluster.html.markdown.
 */
export class KubernetesCluster extends pulumi.CustomResource {
    /**
     * Get an existing KubernetesCluster resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: KubernetesClusterState, opts?: pulumi.CustomResourceOptions): KubernetesCluster {
        return new KubernetesCluster(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'azure:containerservice/kubernetesCluster:KubernetesCluster';

    /**
     * Returns true if the given object is an instance of KubernetesCluster.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is KubernetesCluster {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === KubernetesCluster.__pulumiType;
    }

    /**
     * A `addonProfile` block as defined below.
     */
    public readonly addonProfile!: pulumi.Output<outputs.containerservice.KubernetesClusterAddonProfile>;
    /**
     * The IP ranges to whitelist for incoming traffic to the masters.
     */
    public readonly apiServerAuthorizedIpRanges!: pulumi.Output<string[] | undefined>;
    /**
     * A `defaultNodePool` block as defined below.
     */
    public readonly defaultNodePool!: pulumi.Output<outputs.containerservice.KubernetesClusterDefaultNodePool>;
    /**
     * DNS prefix specified when creating the managed cluster. Changing this forces a new resource to be created.
     */
    public readonly dnsPrefix!: pulumi.Output<string>;
    /**
     * Whether Pod Security Policies are enabled. Note that this also requires role based access control to be enabled.
     */
    public readonly enablePodSecurityPolicy!: pulumi.Output<boolean | undefined>;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    public /*out*/ readonly fqdn!: pulumi.Output<string>;
    /**
     * A `identity` block as defined below. Changing this forces a new resource to be created.
     */
    public readonly identity!: pulumi.Output<outputs.containerservice.KubernetesClusterIdentity | undefined>;
    /**
     * A `kubeAdminConfig` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    public /*out*/ readonly kubeAdminConfigs!: pulumi.Output<outputs.containerservice.KubernetesClusterKubeAdminConfig[]>;
    /**
     * Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    public /*out*/ readonly kubeAdminConfigRaw!: pulumi.Output<string>;
    /**
     * A `kubeConfig` block as defined below.
     */
    public /*out*/ readonly kubeConfigs!: pulumi.Output<outputs.containerservice.KubernetesClusterKubeConfig[]>;
    /**
     * Raw Kubernetes config to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools
     */
    public /*out*/ readonly kubeConfigRaw!: pulumi.Output<string>;
    /**
     * A `kubeletIdentity` block as defined below.  
     */
    public /*out*/ readonly kubeletIdentities!: pulumi.Output<outputs.containerservice.KubernetesClusterKubeletIdentity[]>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    public readonly kubernetesVersion!: pulumi.Output<string>;
    /**
     * A `linuxProfile` block as defined below.
     */
    public readonly linuxProfile!: pulumi.Output<outputs.containerservice.KubernetesClusterLinuxProfile | undefined>;
    /**
     * The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
     */
    public readonly location!: pulumi.Output<string>;
    /**
     * The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * A `networkProfile` block as defined below.
     */
    public readonly networkProfile!: pulumi.Output<outputs.containerservice.KubernetesClusterNetworkProfile>;
    /**
     * The name of the Resource Group where the Kubernetes Nodes should exist. Changing this forces a new resource to be created.
     */
    public readonly nodeResourceGroup!: pulumi.Output<string>;
    /**
     * Should this Kubernetes Cluster have it's API server only exposed on internal IP addresses? This provides a Private IP Address for the Kubernetes API on the Virtual Network where the Kubernetes Cluster is located. Defaults to `false`. Changing this forces a new resource to be created.
     */
    public readonly privateClusterEnabled!: pulumi.Output<boolean>;
    /**
     * The FQDN for the Kubernetes Cluster when private link has been enabled, which is only resolvable inside the Virtual Network used by the Kubernetes Cluster.
     */
    public /*out*/ readonly privateFqdn!: pulumi.Output<string>;
    public readonly privateLinkEnabled!: pulumi.Output<boolean>;
    /**
     * Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
     */
    public readonly resourceGroupName!: pulumi.Output<string>;
    /**
     * A `roleBasedAccessControl` block. Changing this forces a new resource to be created.
     */
    public readonly roleBasedAccessControl!: pulumi.Output<outputs.containerservice.KubernetesClusterRoleBasedAccessControl>;
    /**
     * A `servicePrincipal` block as documented below.
     */
    public readonly servicePrincipal!: pulumi.Output<outputs.containerservice.KubernetesClusterServicePrincipal | undefined>;
    /**
     * A mapping of tags to assign to the resource.
     */
    public readonly tags!: pulumi.Output<{[key: string]: string} | undefined>;
    /**
     * A `windowsProfile` block as defined below.
     */
    public readonly windowsProfile!: pulumi.Output<outputs.containerservice.KubernetesClusterWindowsProfile>;

    /**
     * Create a KubernetesCluster resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: KubernetesClusterArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: KubernetesClusterArgs | KubernetesClusterState, opts?: pulumi.CustomResourceOptions) {
        let inputs: pulumi.Inputs = {};
        if (opts && opts.id) {
            const state = argsOrState as KubernetesClusterState | undefined;
            inputs["addonProfile"] = state ? state.addonProfile : undefined;
            inputs["apiServerAuthorizedIpRanges"] = state ? state.apiServerAuthorizedIpRanges : undefined;
            inputs["defaultNodePool"] = state ? state.defaultNodePool : undefined;
            inputs["dnsPrefix"] = state ? state.dnsPrefix : undefined;
            inputs["enablePodSecurityPolicy"] = state ? state.enablePodSecurityPolicy : undefined;
            inputs["fqdn"] = state ? state.fqdn : undefined;
            inputs["identity"] = state ? state.identity : undefined;
            inputs["kubeAdminConfigs"] = state ? state.kubeAdminConfigs : undefined;
            inputs["kubeAdminConfigRaw"] = state ? state.kubeAdminConfigRaw : undefined;
            inputs["kubeConfigs"] = state ? state.kubeConfigs : undefined;
            inputs["kubeConfigRaw"] = state ? state.kubeConfigRaw : undefined;
            inputs["kubeletIdentities"] = state ? state.kubeletIdentities : undefined;
            inputs["kubernetesVersion"] = state ? state.kubernetesVersion : undefined;
            inputs["linuxProfile"] = state ? state.linuxProfile : undefined;
            inputs["location"] = state ? state.location : undefined;
            inputs["name"] = state ? state.name : undefined;
            inputs["networkProfile"] = state ? state.networkProfile : undefined;
            inputs["nodeResourceGroup"] = state ? state.nodeResourceGroup : undefined;
            inputs["privateClusterEnabled"] = state ? state.privateClusterEnabled : undefined;
            inputs["privateFqdn"] = state ? state.privateFqdn : undefined;
            inputs["privateLinkEnabled"] = state ? state.privateLinkEnabled : undefined;
            inputs["resourceGroupName"] = state ? state.resourceGroupName : undefined;
            inputs["roleBasedAccessControl"] = state ? state.roleBasedAccessControl : undefined;
            inputs["servicePrincipal"] = state ? state.servicePrincipal : undefined;
            inputs["tags"] = state ? state.tags : undefined;
            inputs["windowsProfile"] = state ? state.windowsProfile : undefined;
        } else {
            const args = argsOrState as KubernetesClusterArgs | undefined;
            if (!args || args.defaultNodePool === undefined) {
                throw new Error("Missing required property 'defaultNodePool'");
            }
            if (!args || args.dnsPrefix === undefined) {
                throw new Error("Missing required property 'dnsPrefix'");
            }
            if (!args || args.resourceGroupName === undefined) {
                throw new Error("Missing required property 'resourceGroupName'");
            }
            inputs["addonProfile"] = args ? args.addonProfile : undefined;
            inputs["apiServerAuthorizedIpRanges"] = args ? args.apiServerAuthorizedIpRanges : undefined;
            inputs["defaultNodePool"] = args ? args.defaultNodePool : undefined;
            inputs["dnsPrefix"] = args ? args.dnsPrefix : undefined;
            inputs["enablePodSecurityPolicy"] = args ? args.enablePodSecurityPolicy : undefined;
            inputs["identity"] = args ? args.identity : undefined;
            inputs["kubernetesVersion"] = args ? args.kubernetesVersion : undefined;
            inputs["linuxProfile"] = args ? args.linuxProfile : undefined;
            inputs["location"] = args ? args.location : undefined;
            inputs["name"] = args ? args.name : undefined;
            inputs["networkProfile"] = args ? args.networkProfile : undefined;
            inputs["nodeResourceGroup"] = args ? args.nodeResourceGroup : undefined;
            inputs["privateClusterEnabled"] = args ? args.privateClusterEnabled : undefined;
            inputs["privateLinkEnabled"] = args ? args.privateLinkEnabled : undefined;
            inputs["resourceGroupName"] = args ? args.resourceGroupName : undefined;
            inputs["roleBasedAccessControl"] = args ? args.roleBasedAccessControl : undefined;
            inputs["servicePrincipal"] = args ? args.servicePrincipal : undefined;
            inputs["tags"] = args ? args.tags : undefined;
            inputs["windowsProfile"] = args ? args.windowsProfile : undefined;
            inputs["fqdn"] = undefined /*out*/;
            inputs["kubeAdminConfigs"] = undefined /*out*/;
            inputs["kubeAdminConfigRaw"] = undefined /*out*/;
            inputs["kubeConfigs"] = undefined /*out*/;
            inputs["kubeConfigRaw"] = undefined /*out*/;
            inputs["kubeletIdentities"] = undefined /*out*/;
            inputs["privateFqdn"] = undefined /*out*/;
        }
        if (!opts) {
            opts = {}
        }

        if (!opts.version) {
            opts.version = utilities.getVersion();
        }
        super(KubernetesCluster.__pulumiType, name, inputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering KubernetesCluster resources.
 */
export interface KubernetesClusterState {
    /**
     * A `addonProfile` block as defined below.
     */
    readonly addonProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterAddonProfile>;
    /**
     * The IP ranges to whitelist for incoming traffic to the masters.
     */
    readonly apiServerAuthorizedIpRanges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A `defaultNodePool` block as defined below.
     */
    readonly defaultNodePool?: pulumi.Input<inputs.containerservice.KubernetesClusterDefaultNodePool>;
    /**
     * DNS prefix specified when creating the managed cluster. Changing this forces a new resource to be created.
     */
    readonly dnsPrefix?: pulumi.Input<string>;
    /**
     * Whether Pod Security Policies are enabled. Note that this also requires role based access control to be enabled.
     */
    readonly enablePodSecurityPolicy?: pulumi.Input<boolean>;
    /**
     * The FQDN of the Azure Kubernetes Managed Cluster.
     */
    readonly fqdn?: pulumi.Input<string>;
    /**
     * A `identity` block as defined below. Changing this forces a new resource to be created.
     */
    readonly identity?: pulumi.Input<inputs.containerservice.KubernetesClusterIdentity>;
    /**
     * A `kubeAdminConfig` block as defined below. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    readonly kubeAdminConfigs?: pulumi.Input<pulumi.Input<inputs.containerservice.KubernetesClusterKubeAdminConfig>[]>;
    /**
     * Raw Kubernetes config for the admin account to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools. This is only available when Role Based Access Control with Azure Active Directory is enabled.
     */
    readonly kubeAdminConfigRaw?: pulumi.Input<string>;
    /**
     * A `kubeConfig` block as defined below.
     */
    readonly kubeConfigs?: pulumi.Input<pulumi.Input<inputs.containerservice.KubernetesClusterKubeConfig>[]>;
    /**
     * Raw Kubernetes config to be used by [kubectl](https://kubernetes.io/docs/reference/kubectl/overview/) and other compatible tools
     */
    readonly kubeConfigRaw?: pulumi.Input<string>;
    /**
     * A `kubeletIdentity` block as defined below.  
     */
    readonly kubeletIdentities?: pulumi.Input<pulumi.Input<inputs.containerservice.KubernetesClusterKubeletIdentity>[]>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * A `linuxProfile` block as defined below.
     */
    readonly linuxProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterLinuxProfile>;
    /**
     * The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `networkProfile` block as defined below.
     */
    readonly networkProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterNetworkProfile>;
    /**
     * The name of the Resource Group where the Kubernetes Nodes should exist. Changing this forces a new resource to be created.
     */
    readonly nodeResourceGroup?: pulumi.Input<string>;
    /**
     * Should this Kubernetes Cluster have it's API server only exposed on internal IP addresses? This provides a Private IP Address for the Kubernetes API on the Virtual Network where the Kubernetes Cluster is located. Defaults to `false`. Changing this forces a new resource to be created.
     */
    readonly privateClusterEnabled?: pulumi.Input<boolean>;
    /**
     * The FQDN for the Kubernetes Cluster when private link has been enabled, which is only resolvable inside the Virtual Network used by the Kubernetes Cluster.
     */
    readonly privateFqdn?: pulumi.Input<string>;
    readonly privateLinkEnabled?: pulumi.Input<boolean>;
    /**
     * Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName?: pulumi.Input<string>;
    /**
     * A `roleBasedAccessControl` block. Changing this forces a new resource to be created.
     */
    readonly roleBasedAccessControl?: pulumi.Input<inputs.containerservice.KubernetesClusterRoleBasedAccessControl>;
    /**
     * A `servicePrincipal` block as documented below.
     */
    readonly servicePrincipal?: pulumi.Input<inputs.containerservice.KubernetesClusterServicePrincipal>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A `windowsProfile` block as defined below.
     */
    readonly windowsProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterWindowsProfile>;
}

/**
 * The set of arguments for constructing a KubernetesCluster resource.
 */
export interface KubernetesClusterArgs {
    /**
     * A `addonProfile` block as defined below.
     */
    readonly addonProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterAddonProfile>;
    /**
     * The IP ranges to whitelist for incoming traffic to the masters.
     */
    readonly apiServerAuthorizedIpRanges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A `defaultNodePool` block as defined below.
     */
    readonly defaultNodePool: pulumi.Input<inputs.containerservice.KubernetesClusterDefaultNodePool>;
    /**
     * DNS prefix specified when creating the managed cluster. Changing this forces a new resource to be created.
     */
    readonly dnsPrefix: pulumi.Input<string>;
    /**
     * Whether Pod Security Policies are enabled. Note that this also requires role based access control to be enabled.
     */
    readonly enablePodSecurityPolicy?: pulumi.Input<boolean>;
    /**
     * A `identity` block as defined below. Changing this forces a new resource to be created.
     */
    readonly identity?: pulumi.Input<inputs.containerservice.KubernetesClusterIdentity>;
    /**
     * Version of Kubernetes specified when creating the AKS managed cluster. If not specified, the latest recommended version will be used at provisioning time (but won't auto-upgrade).
     */
    readonly kubernetesVersion?: pulumi.Input<string>;
    /**
     * A `linuxProfile` block as defined below.
     */
    readonly linuxProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterLinuxProfile>;
    /**
     * The location where the Managed Kubernetes Cluster should be created. Changing this forces a new resource to be created.
     */
    readonly location?: pulumi.Input<string>;
    /**
     * The name of the Managed Kubernetes Cluster to create. Changing this forces a new resource to be created.
     */
    readonly name?: pulumi.Input<string>;
    /**
     * A `networkProfile` block as defined below.
     */
    readonly networkProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterNetworkProfile>;
    /**
     * The name of the Resource Group where the Kubernetes Nodes should exist. Changing this forces a new resource to be created.
     */
    readonly nodeResourceGroup?: pulumi.Input<string>;
    /**
     * Should this Kubernetes Cluster have it's API server only exposed on internal IP addresses? This provides a Private IP Address for the Kubernetes API on the Virtual Network where the Kubernetes Cluster is located. Defaults to `false`. Changing this forces a new resource to be created.
     */
    readonly privateClusterEnabled?: pulumi.Input<boolean>;
    readonly privateLinkEnabled?: pulumi.Input<boolean>;
    /**
     * Specifies the Resource Group where the Managed Kubernetes Cluster should exist. Changing this forces a new resource to be created.
     */
    readonly resourceGroupName: pulumi.Input<string>;
    /**
     * A `roleBasedAccessControl` block. Changing this forces a new resource to be created.
     */
    readonly roleBasedAccessControl?: pulumi.Input<inputs.containerservice.KubernetesClusterRoleBasedAccessControl>;
    /**
     * A `servicePrincipal` block as documented below.
     */
    readonly servicePrincipal?: pulumi.Input<inputs.containerservice.KubernetesClusterServicePrincipal>;
    /**
     * A mapping of tags to assign to the resource.
     */
    readonly tags?: pulumi.Input<{[key: string]: pulumi.Input<string>}>;
    /**
     * A `windowsProfile` block as defined below.
     */
    readonly windowsProfile?: pulumi.Input<inputs.containerservice.KubernetesClusterWindowsProfile>;
}
