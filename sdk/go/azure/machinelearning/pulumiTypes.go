// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package machinelearning

import (
	"context"
	"reflect"

	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

type WorkspaceIdentity struct {
	// The (Client) ID of the Service Principal.
	PrincipalId *string `pulumi:"principalId"`
	// The ID of the Tenant the Service Principal is assigned in.
	TenantId *string `pulumi:"tenantId"`
	// The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
	Type string `pulumi:"type"`
}

// WorkspaceIdentityInput is an input type that accepts WorkspaceIdentityArgs and WorkspaceIdentityOutput values.
// You can construct a concrete instance of `WorkspaceIdentityInput` via:
//
// 		 WorkspaceIdentityArgs{...}
//
type WorkspaceIdentityInput interface {
	pulumi.Input

	ToWorkspaceIdentityOutput() WorkspaceIdentityOutput
	ToWorkspaceIdentityOutputWithContext(context.Context) WorkspaceIdentityOutput
}

type WorkspaceIdentityArgs struct {
	// The (Client) ID of the Service Principal.
	PrincipalId pulumi.StringPtrInput `pulumi:"principalId"`
	// The ID of the Tenant the Service Principal is assigned in.
	TenantId pulumi.StringPtrInput `pulumi:"tenantId"`
	// The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
	Type pulumi.StringInput `pulumi:"type"`
}

func (WorkspaceIdentityArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkspaceIdentity)(nil)).Elem()
}

func (i WorkspaceIdentityArgs) ToWorkspaceIdentityOutput() WorkspaceIdentityOutput {
	return i.ToWorkspaceIdentityOutputWithContext(context.Background())
}

func (i WorkspaceIdentityArgs) ToWorkspaceIdentityOutputWithContext(ctx context.Context) WorkspaceIdentityOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceIdentityOutput)
}

func (i WorkspaceIdentityArgs) ToWorkspaceIdentityPtrOutput() WorkspaceIdentityPtrOutput {
	return i.ToWorkspaceIdentityPtrOutputWithContext(context.Background())
}

func (i WorkspaceIdentityArgs) ToWorkspaceIdentityPtrOutputWithContext(ctx context.Context) WorkspaceIdentityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceIdentityOutput).ToWorkspaceIdentityPtrOutputWithContext(ctx)
}

// WorkspaceIdentityPtrInput is an input type that accepts WorkspaceIdentityArgs, WorkspaceIdentityPtr and WorkspaceIdentityPtrOutput values.
// You can construct a concrete instance of `WorkspaceIdentityPtrInput` via:
//
// 		 WorkspaceIdentityArgs{...}
//
//  or:
//
// 		 nil
//
type WorkspaceIdentityPtrInput interface {
	pulumi.Input

	ToWorkspaceIdentityPtrOutput() WorkspaceIdentityPtrOutput
	ToWorkspaceIdentityPtrOutputWithContext(context.Context) WorkspaceIdentityPtrOutput
}

type workspaceIdentityPtrType WorkspaceIdentityArgs

func WorkspaceIdentityPtr(v *WorkspaceIdentityArgs) WorkspaceIdentityPtrInput {
	return (*workspaceIdentityPtrType)(v)
}

func (*workspaceIdentityPtrType) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkspaceIdentity)(nil)).Elem()
}

func (i *workspaceIdentityPtrType) ToWorkspaceIdentityPtrOutput() WorkspaceIdentityPtrOutput {
	return i.ToWorkspaceIdentityPtrOutputWithContext(context.Background())
}

func (i *workspaceIdentityPtrType) ToWorkspaceIdentityPtrOutputWithContext(ctx context.Context) WorkspaceIdentityPtrOutput {
	return pulumi.ToOutputWithContext(ctx, i).(WorkspaceIdentityPtrOutput)
}

type WorkspaceIdentityOutput struct{ *pulumi.OutputState }

func (WorkspaceIdentityOutput) ElementType() reflect.Type {
	return reflect.TypeOf((*WorkspaceIdentity)(nil)).Elem()
}

func (o WorkspaceIdentityOutput) ToWorkspaceIdentityOutput() WorkspaceIdentityOutput {
	return o
}

func (o WorkspaceIdentityOutput) ToWorkspaceIdentityOutputWithContext(ctx context.Context) WorkspaceIdentityOutput {
	return o
}

func (o WorkspaceIdentityOutput) ToWorkspaceIdentityPtrOutput() WorkspaceIdentityPtrOutput {
	return o.ToWorkspaceIdentityPtrOutputWithContext(context.Background())
}

func (o WorkspaceIdentityOutput) ToWorkspaceIdentityPtrOutputWithContext(ctx context.Context) WorkspaceIdentityPtrOutput {
	return o.ApplyT(func(v WorkspaceIdentity) *WorkspaceIdentity {
		return &v
	}).(WorkspaceIdentityPtrOutput)
}

// The (Client) ID of the Service Principal.
func (o WorkspaceIdentityOutput) PrincipalId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkspaceIdentity) *string { return v.PrincipalId }).(pulumi.StringPtrOutput)
}

// The ID of the Tenant the Service Principal is assigned in.
func (o WorkspaceIdentityOutput) TenantId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v WorkspaceIdentity) *string { return v.TenantId }).(pulumi.StringPtrOutput)
}

// The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
func (o WorkspaceIdentityOutput) Type() pulumi.StringOutput {
	return o.ApplyT(func(v WorkspaceIdentity) string { return v.Type }).(pulumi.StringOutput)
}

type WorkspaceIdentityPtrOutput struct{ *pulumi.OutputState }

func (WorkspaceIdentityPtrOutput) ElementType() reflect.Type {
	return reflect.TypeOf((**WorkspaceIdentity)(nil)).Elem()
}

func (o WorkspaceIdentityPtrOutput) ToWorkspaceIdentityPtrOutput() WorkspaceIdentityPtrOutput {
	return o
}

func (o WorkspaceIdentityPtrOutput) ToWorkspaceIdentityPtrOutputWithContext(ctx context.Context) WorkspaceIdentityPtrOutput {
	return o
}

func (o WorkspaceIdentityPtrOutput) Elem() WorkspaceIdentityOutput {
	return o.ApplyT(func(v *WorkspaceIdentity) WorkspaceIdentity { return *v }).(WorkspaceIdentityOutput)
}

// The (Client) ID of the Service Principal.
func (o WorkspaceIdentityPtrOutput) PrincipalId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkspaceIdentity) *string {
		if v == nil {
			return nil
		}
		return v.PrincipalId
	}).(pulumi.StringPtrOutput)
}

// The ID of the Tenant the Service Principal is assigned in.
func (o WorkspaceIdentityPtrOutput) TenantId() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkspaceIdentity) *string {
		if v == nil {
			return nil
		}
		return v.TenantId
	}).(pulumi.StringPtrOutput)
}

// The Type of Identity which should be used for this Disk Encryption Set. At this time the only possible value is `SystemAssigned`.
func (o WorkspaceIdentityPtrOutput) Type() pulumi.StringPtrOutput {
	return o.ApplyT(func(v *WorkspaceIdentity) *string {
		if v == nil {
			return nil
		}
		return &v.Type
	}).(pulumi.StringPtrOutput)
}

func init() {
	pulumi.RegisterOutputType(WorkspaceIdentityOutput{})
	pulumi.RegisterOutputType(WorkspaceIdentityPtrOutput{})
}
