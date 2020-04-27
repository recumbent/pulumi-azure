// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package batch

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing Batch pool
func LookupPool(ctx *pulumi.Context, args *LookupPoolArgs, opts ...pulumi.InvokeOption) (*LookupPoolResult, error) {
	var rv LookupPoolResult
	err := ctx.Invoke("azure:batch/getPool:getPool", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getPool.
type LookupPoolArgs struct {
	// The name of the Batch account.
	AccountName string `pulumi:"accountName"`
	// One or more `certificate` blocks that describe the certificates installed on each compute node in the pool.
	Certificates []GetPoolCertificate `pulumi:"certificates"`
	// The name of the endpoint.
	Name                 string                       `pulumi:"name"`
	NetworkConfiguration *GetPoolNetworkConfiguration `pulumi:"networkConfiguration"`
	ResourceGroupName    string                       `pulumi:"resourceGroupName"`
	// A `startTask` block that describes the start task settings for the Batch pool.
	StartTask *GetPoolStartTask `pulumi:"startTask"`
}

// A collection of values returned by getPool.
type LookupPoolResult struct {
	// The name of the Batch account.
	AccountName string `pulumi:"accountName"`
	// A `autoScale` block that describes the scale settings when using auto scale.
	AutoScales []GetPoolAutoScale `pulumi:"autoScales"`
	// One or more `certificate` blocks that describe the certificates installed on each compute node in the pool.
	Certificates []GetPoolCertificate `pulumi:"certificates"`
	// The container configuration used in the pool's VMs.
	ContainerConfigurations []GetPoolContainerConfiguration `pulumi:"containerConfigurations"`
	DisplayName             string                          `pulumi:"displayName"`
	// A `fixedScale` block that describes the scale settings when using fixed scale.
	FixedScales []GetPoolFixedScale `pulumi:"fixedScales"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The maximum number of tasks that can run concurrently on a single compute node in the pool.
	MaxTasksPerNode int               `pulumi:"maxTasksPerNode"`
	Metadata        map[string]string `pulumi:"metadata"`
	// The name of the endpoint.
	Name                 string                      `pulumi:"name"`
	NetworkConfiguration GetPoolNetworkConfiguration `pulumi:"networkConfiguration"`
	// The Sku of the node agents in the Batch pool.
	NodeAgentSkuId    string `pulumi:"nodeAgentSkuId"`
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// A `startTask` block that describes the start task settings for the Batch pool.
	StartTask *GetPoolStartTask `pulumi:"startTask"`
	// The reference of the storage image used by the nodes in the Batch pool.
	StorageImageReferences []GetPoolStorageImageReference `pulumi:"storageImageReferences"`
	// The size of the VM created in the Batch pool.
	VmSize string `pulumi:"vmSize"`
}
