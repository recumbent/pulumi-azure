// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing Azure Firewall.
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
// 		example, err := network.LookupFirewall(ctx, &network.LookupFirewallArgs{
// 			Name:              "firewall1",
// 			ResourceGroupName: "firewall-RG",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("firewallPrivateIp", example.IpConfigurations[0].PrivateIpAddress)
// 		return nil
// 	})
// }
// ```
func LookupFirewall(ctx *pulumi.Context, args *LookupFirewallArgs, opts ...pulumi.InvokeOption) (*LookupFirewallResult, error) {
	var rv LookupFirewallResult
	err := ctx.Invoke("azure:network/getFirewall:getFirewall", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getFirewall.
type LookupFirewallArgs struct {
	// The name of the Azure Firewall.
	Name string `pulumi:"name"`
	// The name of the Resource Group in which the Azure Firewall exists.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// A collection of values returned by getFirewall.
type LookupFirewallResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// A `ipConfiguration` block as defined below.
	IpConfigurations  []GetFirewallIpConfiguration `pulumi:"ipConfigurations"`
	Location          string                       `pulumi:"location"`
	Name              string                       `pulumi:"name"`
	ResourceGroupName string                       `pulumi:"resourceGroupName"`
	Tags              map[string]string            `pulumi:"tags"`
}
