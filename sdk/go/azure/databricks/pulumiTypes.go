// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package databricks

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type WorkspaceCustomParameters struct {
	// Are public IP Addresses not allowed?
	NoPublicIp *bool `pulumi:"noPublicIp"`
	// The name of the Private Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
	PrivateSubnetName *string `pulumi:"privateSubnetName"`
	// The name of the Public Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
	PublicSubnetName *string `pulumi:"publicSubnetName"`
	// The ID of a Virtual Network where this Databricks Cluster should be created.
	VirtualNetworkId *string `pulumi:"virtualNetworkId"`
}

// WorkspaceCustomParametersInput is an input type that accepts WorkspaceCustomParametersArgs and WorkspaceCustomParametersOutput values.
// You can construct a concrete instance of `WorkspaceCustomParametersInput` via:
//
// 		 WorkspaceCustomParametersArgs{...}
//
type WorkspaceCustomParametersInput interface {
	pulumi.Input

	ToWorkspaceCustomParametersOutput() WorkspaceCustomParametersOutput
	ToWorkspaceCustomParametersOutputWithContext(context.Context) WorkspaceCustomParametersOutput
}

type WorkspaceCustomParametersArgs struct {
	// Are public IP Addresses not allowed?
	NoPublicIp pulumi.BoolPtrInput `pulumi:"noPublicIp"`
	// The name of the Private Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
	PrivateSubnetName pulumi.StringPtrInput `pulumi:"privateSubnetName"`
	// The name of the Public Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
	PublicSubnetName pulumi.StringPtrInput `pulumi:"publicSubnetName"`
	// The ID of a Virtual Network where this Databricks Cluster should be created.
	VirtualNetworkId pulumi.StringPtrInput `pulumi:"virtualNetworkId"`
}

func (WorkspaceCustomParametersArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkspaceCustomParameters)(nil)).Elem()
}

func (i WorkspaceCustomParametersArgs) ToWorkspaceCustomParametersOutput() WorkspaceCustomParametersOutput {
	return i.ToWorkspaceCustomParametersOutputWithContext(context.Background())
}

func (i WorkspaceCustomParametersArgs) ToWorkspaceCustomParametersOutputWithContext(ctx context.Context) WorkspaceCustomParametersOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceCustomParametersOutput)
}

func (i WorkspaceCustomParametersArgs) ToWorkspaceCustomParametersPtrOutput() WorkspaceCustomParametersPtrOutput {
	return i.ToWorkspaceCustomParametersPtrOutputWithContext(context.Background())
}

func (i WorkspaceCustomParametersArgs) ToWorkspaceCustomParametersPtrOutputWithContext(ctx context.Context) WorkspaceCustomParametersPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceCustomParametersOutput).ToWorkspaceCustomParametersPtrOutputWithContext(ctx)
}

// WorkspaceCustomParametersPtrInput is an input type that accepts WorkspaceCustomParametersArgs, WorkspaceCustomParametersPtr and WorkspaceCustomParametersPtrOutput values.
// You can construct a concrete instance of `WorkspaceCustomParametersPtrInput` via:
//
// 		 WorkspaceCustomParametersArgs{...}
//
//  or:
//
// 		 nil
//
type WorkspaceCustomParametersPtrInput interface {
	pulumi.Input

	ToWorkspaceCustomParametersPtrOutput() WorkspaceCustomParametersPtrOutput
	ToWorkspaceCustomParametersPtrOutputWithContext(context.Context) WorkspaceCustomParametersPtrOutput
}

type workspaceCustomParametersPtrType WorkspaceCustomParametersArgs

func WorkspaceCustomParametersPtr(v *WorkspaceCustomParametersArgs) WorkspaceCustomParametersPtrInput {
	return (*workspaceCustomParametersPtrType)(v)
}

func (*workspaceCustomParametersPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkspaceCustomParameters)(nil)).Elem()
}

func (i *workspaceCustomParametersPtrType) ToWorkspaceCustomParametersPtrOutput() WorkspaceCustomParametersPtrOutput {
	return i.ToWorkspaceCustomParametersPtrOutputWithContext(context.Background())
}

func (i *workspaceCustomParametersPtrType) ToWorkspaceCustomParametersPtrOutputWithContext(ctx context.Context) WorkspaceCustomParametersPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceCustomParametersPtrOutput)
}

type WorkspaceCustomParametersOutput struct{ *pulumi.OutputState }

func (WorkspaceCustomParametersOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkspaceCustomParameters)(nil)).Elem()
}

func (o WorkspaceCustomParametersOutput) ToWorkspaceCustomParametersOutput() WorkspaceCustomParametersOutput {
	return o
}

func (o WorkspaceCustomParametersOutput) ToWorkspaceCustomParametersOutputWithContext(ctx context.Context) WorkspaceCustomParametersOutput {
	return o
}

func (o WorkspaceCustomParametersOutput) ToWorkspaceCustomParametersPtrOutput() WorkspaceCustomParametersPtrOutput {
	return o.ToWorkspaceCustomParametersPtrOutputWithContext(context.Background())
}

func (o WorkspaceCustomParametersOutput) ToWorkspaceCustomParametersPtrOutputWithContext(ctx context.Context) WorkspaceCustomParametersPtrOutput {
	return o.ApplyT(func(v WorkspaceCustomParameters) *WorkspaceCustomParameters {
		return &v
	}).(WorkspaceCustomParametersPtrOutput)
}

// Are public IP Addresses not allowed?
func (o WorkspaceCustomParametersOutput) NoPublicIp() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v WorkspaceCustomParameters) *bool { return v.NoPublicIp }).(pulumi.BoolPtrOutput)
}

// The name of the Private Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
func (o WorkspaceCustomParametersOutput) PrivateSubnetName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkspaceCustomParameters) *string { return v.PrivateSubnetName }).(pulumi.StringPtrOutput)
}

// The name of the Public Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
func (o WorkspaceCustomParametersOutput) PublicSubnetName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkspaceCustomParameters) *string { return v.PublicSubnetName }).(pulumi.StringPtrOutput)
}

// The ID of a Virtual Network where this Databricks Cluster should be created.
func (o WorkspaceCustomParametersOutput) VirtualNetworkId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkspaceCustomParameters) *string { return v.VirtualNetworkId }).(pulumi.StringPtrOutput)
}

type WorkspaceCustomParametersPtrOutput struct{ *pulumi.OutputState }

func (WorkspaceCustomParametersPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkspaceCustomParameters)(nil)).Elem()
}

func (o WorkspaceCustomParametersPtrOutput) ToWorkspaceCustomParametersPtrOutput() WorkspaceCustomParametersPtrOutput {
	return o
}

func (o WorkspaceCustomParametersPtrOutput) ToWorkspaceCustomParametersPtrOutputWithContext(ctx context.Context) WorkspaceCustomParametersPtrOutput {
	return o
}

func (o WorkspaceCustomParametersPtrOutput) Elem() WorkspaceCustomParametersOutput {
	return o.ApplyT(func(v *WorkspaceCustomParameters) WorkspaceCustomParameters { return *v }).(WorkspaceCustomParametersOutput)
}

// Are public IP Addresses not allowed?
func (o WorkspaceCustomParametersPtrOutput) NoPublicIp() pulumi.BoolPtrOutput {
	return o.ApplyT(func(v *WorkspaceCustomParameters) *bool {
		if v == nil {
			return nil
		}
		return v.NoPublicIp
	}).(pulumi.BoolPtrOutput)
}

// The name of the Private Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
func (o WorkspaceCustomParametersPtrOutput) PrivateSubnetName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkspaceCustomParameters) *string {
		if v == nil {
			return nil
		}
		return v.PrivateSubnetName
	}).(pulumi.StringPtrOutput)
}

// The name of the Public Subnet within the Virtual Network. Required if `virtualNetworkId` is set.
func (o WorkspaceCustomParametersPtrOutput) PublicSubnetName() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkspaceCustomParameters) *string {
		if v == nil {
			return nil
		}
		return v.PublicSubnetName
	}).(pulumi.StringPtrOutput)
}

// The ID of a Virtual Network where this Databricks Cluster should be created.
func (o WorkspaceCustomParametersPtrOutput) VirtualNetworkId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkspaceCustomParameters) *string {
		if v == nil {
			return nil
		}
		return v.VirtualNetworkId
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(WorkspaceCustomParametersOutput{})
	pulumi.RegisterOutputType(WorkspaceCustomParametersPtrOutput{})
}
