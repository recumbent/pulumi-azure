// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about Service Tags.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/network"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		opt0 := "northeurope"
// 		_, err := network.GetServiceTags(ctx, &network.GetServiceTagsArgs{
// 			Location:       "westcentralus",
// 			Service:        "AzureKeyVault",
// 			LocationFilter: &opt0,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("addressPrefixes", data.Azurerm_service_tags.Example.Address_prefixes)
// 		return nil
// 	})
// }
// ```
func GetServiceTags(ctx *pulumi.Context, args *GetServiceTagsArgs, opts ...pulumi.InvokeOption) (*GetServiceTagsResult, error) {
	var rv GetServiceTagsResult
	err := ctx.Invoke("azure:network/getServiceTags:getServiceTags", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getServiceTags.
type GetServiceTagsArgs struct {
	// The Azure Region where the Service Tags exists. This value is not used to filter the results but for specifying the region to request. For filtering by region use `locationFilter` instead.  More information can be found here: [Service Tags URL parameters](https://docs.microsoft.com/en-us/rest/api/virtualnetwork/servicetags/list#uri-parameters).
	Location string `pulumi:"location"`
	// Changes the scope of the service tags. Can be any value that is also valid for `location`. If this field is empty then all address prefixes are considered instead of only location specific ones.
	LocationFilter *string `pulumi:"locationFilter"`
	// The type of the service for which address prefixes will be fetched. Available service tags can be found here: [Available service tags](https://docs.microsoft.com/en-us/azure/virtual-network/service-tags-overview#available-service-tags).
	Service string `pulumi:"service"`
}

// A collection of values returned by getServiceTags.
type GetServiceTagsResult struct {
	// List of address prefixes for the service type (and optionally a specific region).
	AddressPrefixes []string `pulumi:"addressPrefixes"`
	// The provider-assigned unique ID for this managed resource.
	Id             string  `pulumi:"id"`
	Location       string  `pulumi:"location"`
	LocationFilter *string `pulumi:"locationFilter"`
	Service        string  `pulumi:"service"`
}
