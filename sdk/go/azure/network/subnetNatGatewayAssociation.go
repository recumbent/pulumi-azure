// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Associates a NAT Gateway with a Subnet within a Virtual Network.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/network"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleResourceGroup, err := core.NewResourceGroup(ctx, "exampleResourceGroup", &core.ResourceGroupArgs{
// 			Location: pulumi.String("East US 2"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleVirtualNetwork, err := network.NewVirtualNetwork(ctx, "exampleVirtualNetwork", &network.VirtualNetworkArgs{
// 			AddressSpaces: pulumi.StringArray{
// 				pulumi.String("10.0.0.0/16"),
// 			},
// 			Location:          exampleResourceGroup.Location,
// 			ResourceGroupName: exampleResourceGroup.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleSubnet, err := network.NewSubnet(ctx, "exampleSubnet", &network.SubnetArgs{
// 			ResourceGroupName:  exampleResourceGroup.Name,
// 			VirtualNetworkName: exampleVirtualNetwork.Name,
// 			AddressPrefixes: pulumi.StringArray{
// 				pulumi.String("10.0.2.0/24"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleNatGateway, err := network.NewNatGateway(ctx, "exampleNatGateway", &network.NatGatewayArgs{
// 			Location:          exampleResourceGroup.Location,
// 			ResourceGroupName: exampleResourceGroup.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = network.NewSubnetNatGatewayAssociation(ctx, "exampleSubnetNatGatewayAssociation", &network.SubnetNatGatewayAssociationArgs{
// 			SubnetId:     exampleSubnet.ID(),
// 			NatGatewayId: exampleNatGateway.ID(),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type SubnetNatGatewayAssociation struct {
	pulumi.CustomResourceState

	// The ID of the NAT Gateway which should be associated with the Subnet. Changing this forces a new resource to be created.
	NatGatewayId pulumi.StringOutput `pulumi:"natGatewayId"`
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId pulumi.StringOutput `pulumi:"subnetId"`
}

// NewSubnetNatGatewayAssociation registers a new resource with the given unique name, arguments, and options.
func NewSubnetNatGatewayAssociation(ctx *pulumi.Context,
	name string, args *SubnetNatGatewayAssociationArgs, opts ...pulumi.ResourceOption) (*SubnetNatGatewayAssociation, error) {
	if args == nil || args.NatGatewayId == nil {
		return nil, errors.New("missing required argument 'NatGatewayId'")
	}
	if args == nil || args.SubnetId == nil {
		return nil, errors.New("missing required argument 'SubnetId'")
	}
	if args == nil {
		args = &SubnetNatGatewayAssociationArgs{}
	}
	var resource SubnetNatGatewayAssociation
	err := ctx.RegisterResource("azure:network/subnetNatGatewayAssociation:SubnetNatGatewayAssociation", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetSubnetNatGatewayAssociation gets an existing SubnetNatGatewayAssociation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubnetNatGatewayAssociation(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *SubnetNatGatewayAssociationState, opts ...pulumi.ResourceOption) (*SubnetNatGatewayAssociation, error) {
	var resource SubnetNatGatewayAssociation
	err := ctx.ReadResource("azure:network/subnetNatGatewayAssociation:SubnetNatGatewayAssociation", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering SubnetNatGatewayAssociation resources.
type subnetNatGatewayAssociationState struct {
	// The ID of the NAT Gateway which should be associated with the Subnet. Changing this forces a new resource to be created.
	NatGatewayId *string `pulumi:"natGatewayId"`
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId *string `pulumi:"subnetId"`
}

type SubnetNatGatewayAssociationState struct {
	// The ID of the NAT Gateway which should be associated with the Subnet. Changing this forces a new resource to be created.
	NatGatewayId pulumi.StringPtrInput
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId pulumi.StringPtrInput
}

func (SubnetNatGatewayAssociationState) ElementType() reflect.Type {
	return reflect.TypeOf((*subnetNatGatewayAssociationState)(nil)).Elem()
}

type subnetNatGatewayAssociationArgs struct {
	// The ID of the NAT Gateway which should be associated with the Subnet. Changing this forces a new resource to be created.
	NatGatewayId string `pulumi:"natGatewayId"`
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId string `pulumi:"subnetId"`
}

// The set of arguments for constructing a SubnetNatGatewayAssociation resource.
type SubnetNatGatewayAssociationArgs struct {
	// The ID of the NAT Gateway which should be associated with the Subnet. Changing this forces a new resource to be created.
	NatGatewayId pulumi.StringInput
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId pulumi.StringInput
}

func (SubnetNatGatewayAssociationArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*subnetNatGatewayAssociationArgs)(nil)).Elem()
}
