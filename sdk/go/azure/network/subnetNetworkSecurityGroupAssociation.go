// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package network

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Associates a Network Security Group with a Subnet within a Virtual Network.
// 
// -> **NOTE:** Subnet <-> Network Security Group associations currently need to be configured on both this resource and using the `network_security_group_id` field on the `azurerm_subnet` resource. The next major version of the AzureRM Provider (2.0) will remove the `network_security_group_id` field from the `azurerm_subnet` resource such that this resource is used to link resources in future.
type SubnetNetworkSecurityGroupAssociation struct {
	s *pulumi.ResourceState
}

// NewSubnetNetworkSecurityGroupAssociation registers a new resource with the given unique name, arguments, and options.
func NewSubnetNetworkSecurityGroupAssociation(ctx *pulumi.Context,
	name string, args *SubnetNetworkSecurityGroupAssociationArgs, opts ...pulumi.ResourceOpt) (*SubnetNetworkSecurityGroupAssociation, error) {
	if args == nil || args.NetworkSecurityGroupId == nil {
		return nil, errors.New("missing required argument 'NetworkSecurityGroupId'")
	}
	if args == nil || args.SubnetId == nil {
		return nil, errors.New("missing required argument 'SubnetId'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["networkSecurityGroupId"] = nil
		inputs["subnetId"] = nil
	} else {
		inputs["networkSecurityGroupId"] = args.NetworkSecurityGroupId
		inputs["subnetId"] = args.SubnetId
	}
	s, err := ctx.RegisterResource("azure:network/subnetNetworkSecurityGroupAssociation:SubnetNetworkSecurityGroupAssociation", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SubnetNetworkSecurityGroupAssociation{s: s}, nil
}

// GetSubnetNetworkSecurityGroupAssociation gets an existing SubnetNetworkSecurityGroupAssociation resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetSubnetNetworkSecurityGroupAssociation(ctx *pulumi.Context,
	name string, id pulumi.ID, state *SubnetNetworkSecurityGroupAssociationState, opts ...pulumi.ResourceOpt) (*SubnetNetworkSecurityGroupAssociation, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["networkSecurityGroupId"] = state.NetworkSecurityGroupId
		inputs["subnetId"] = state.SubnetId
	}
	s, err := ctx.ReadResource("azure:network/subnetNetworkSecurityGroupAssociation:SubnetNetworkSecurityGroupAssociation", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &SubnetNetworkSecurityGroupAssociation{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *SubnetNetworkSecurityGroupAssociation) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *SubnetNetworkSecurityGroupAssociation) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The ID of the Network Security Group which should be associated with the Subnet. Changing this forces a new resource to be created.
func (r *SubnetNetworkSecurityGroupAssociation) NetworkSecurityGroupId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["networkSecurityGroupId"])
}

// The ID of the Subnet. Changing this forces a new resource to be created.
func (r *SubnetNetworkSecurityGroupAssociation) SubnetId() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["subnetId"])
}

// Input properties used for looking up and filtering SubnetNetworkSecurityGroupAssociation resources.
type SubnetNetworkSecurityGroupAssociationState struct {
	// The ID of the Network Security Group which should be associated with the Subnet. Changing this forces a new resource to be created.
	NetworkSecurityGroupId interface{}
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId interface{}
}

// The set of arguments for constructing a SubnetNetworkSecurityGroupAssociation resource.
type SubnetNetworkSecurityGroupAssociationArgs struct {
	// The ID of the Network Security Group which should be associated with the Subnet. Changing this forces a new resource to be created.
	NetworkSecurityGroupId interface{}
	// The ID of the Subnet. Changing this forces a new resource to be created.
	SubnetId interface{}
}
