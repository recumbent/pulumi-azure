// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about an existing Subnet within a Virtual Network.
func LookupSubnet(ctx *pulumi.Context, args *GetSubnetArgs) (*GetSubnetResult, error) {
	inputs := make(map[string]interface{})
	if args != nil {
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["virtualNetworkName"] = args.VirtualNetworkName
	}
	outputs, err := ctx.Invoke("azure:network/getSubnet:getSubnet", inputs)
	if err != nil {
		return nil, err
	}
	return &GetSubnetResult{
		AddressPrefix: outputs["addressPrefix"],
		IpConfigurations: outputs["ipConfigurations"],
		NetworkSecurityGroupId: outputs["networkSecurityGroupId"],
		RouteTableId: outputs["routeTableId"],
		Id: outputs["id"],
	}, nil
}

// A collection of arguments for invoking getSubnet.
type GetSubnetArgs struct {
	// Specifies the name of the Subnet.
	Name interface{}
	// Specifies the name of the resource group the Virtual Network is located in.
	ResourceGroupName interface{}
	// Specifies the name of the Virtual Network this Subnet is located within.
	VirtualNetworkName interface{}
}

// A collection of values returned by getSubnet.
type GetSubnetResult struct {
	// The address prefix used for the subnet.
	AddressPrefix interface{}
	// The collection of IP Configurations with IPs within this subnet.
	IpConfigurations interface{}
	// The ID of the Network Security Group associated with the subnet.
	NetworkSecurityGroupId interface{}
	// The ID of the Route Table associated with this subnet.
	RouteTableId interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
