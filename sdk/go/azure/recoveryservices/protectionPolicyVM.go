// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package recoveryservices

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manages an Recovery Services VM Protection Policy.
type ProtectionPolicyVM struct {
	s *pulumi.ResourceState
}

// NewProtectionPolicyVM registers a new resource with the given unique name, arguments, and options.
func NewProtectionPolicyVM(ctx *pulumi.Context,
	name string, args *ProtectionPolicyVMArgs, opts ...pulumi.ResourceOpt) (*ProtectionPolicyVM, error) {
	if args == nil || args.Backup == nil {
		return nil, errors.New("missing required argument 'Backup'")
	}
	if args == nil || args.RecoveryVaultName == nil {
		return nil, errors.New("missing required argument 'RecoveryVaultName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["backup"] = nil
		inputs["name"] = nil
		inputs["recoveryVaultName"] = nil
		inputs["resourceGroupName"] = nil
		inputs["retentionDaily"] = nil
		inputs["retentionMonthly"] = nil
		inputs["retentionWeekly"] = nil
		inputs["retentionYearly"] = nil
		inputs["tags"] = nil
	} else {
		inputs["backup"] = args.Backup
		inputs["name"] = args.Name
		inputs["recoveryVaultName"] = args.RecoveryVaultName
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["retentionDaily"] = args.RetentionDaily
		inputs["retentionMonthly"] = args.RetentionMonthly
		inputs["retentionWeekly"] = args.RetentionWeekly
		inputs["retentionYearly"] = args.RetentionYearly
		inputs["tags"] = args.Tags
	}
	s, err := ctx.RegisterResource("azure:recoveryservices/protectionPolicyVM:ProtectionPolicyVM", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ProtectionPolicyVM{s: s}, nil
}

// GetProtectionPolicyVM gets an existing ProtectionPolicyVM resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetProtectionPolicyVM(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ProtectionPolicyVMState, opts ...pulumi.ResourceOpt) (*ProtectionPolicyVM, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["backup"] = state.Backup
		inputs["name"] = state.Name
		inputs["recoveryVaultName"] = state.RecoveryVaultName
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["retentionDaily"] = state.RetentionDaily
		inputs["retentionMonthly"] = state.RetentionMonthly
		inputs["retentionWeekly"] = state.RetentionWeekly
		inputs["retentionYearly"] = state.RetentionYearly
		inputs["tags"] = state.Tags
	}
	s, err := ctx.ReadResource("azure:recoveryservices/protectionPolicyVM:ProtectionPolicyVM", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &ProtectionPolicyVM{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *ProtectionPolicyVM) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *ProtectionPolicyVM) ID() *pulumi.IDOutput {
	return r.s.ID
}

// Configures the Policy backup frequecent, times & days as documented in the `backup` block below. 
func (r *ProtectionPolicyVM) Backup() *pulumi.Output {
	return r.s.State["backup"]
}

// Specifies the name of the Recovery Services Vault Policy. Changing this forces a new resource to be created.
func (r *ProtectionPolicyVM) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
func (r *ProtectionPolicyVM) RecoveryVaultName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["recoveryVaultName"])
}

// The name of the resource group in which to create the Recovery Services Protected VM. Changing this forces a new resource to be created.
func (r *ProtectionPolicyVM) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// Configures the policy daily retention as documented in the `retention_daily` block below. Required when backup frequency is `Daily`.
func (r *ProtectionPolicyVM) RetentionDaily() *pulumi.Output {
	return r.s.State["retentionDaily"]
}

// Configures the policy monthly retention as documented in the `retention_monthly` block below.
func (r *ProtectionPolicyVM) RetentionMonthly() *pulumi.Output {
	return r.s.State["retentionMonthly"]
}

// Configures the policy weekly retention as documented in the `retention_weekly` block below. Required when backup frequency is `Weekly`.
func (r *ProtectionPolicyVM) RetentionWeekly() *pulumi.Output {
	return r.s.State["retentionWeekly"]
}

// Configures the policy yearly retention as documented in the `retention_yearly` block below.
func (r *ProtectionPolicyVM) RetentionYearly() *pulumi.Output {
	return r.s.State["retentionYearly"]
}

func (r *ProtectionPolicyVM) Tags() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["tags"])
}

// Input properties used for looking up and filtering ProtectionPolicyVM resources.
type ProtectionPolicyVMState struct {
	// Configures the Policy backup frequecent, times & days as documented in the `backup` block below. 
	Backup interface{}
	// Specifies the name of the Recovery Services Vault Policy. Changing this forces a new resource to be created.
	Name interface{}
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName interface{}
	// The name of the resource group in which to create the Recovery Services Protected VM. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// Configures the policy daily retention as documented in the `retention_daily` block below. Required when backup frequency is `Daily`.
	RetentionDaily interface{}
	// Configures the policy monthly retention as documented in the `retention_monthly` block below.
	RetentionMonthly interface{}
	// Configures the policy weekly retention as documented in the `retention_weekly` block below. Required when backup frequency is `Weekly`.
	RetentionWeekly interface{}
	// Configures the policy yearly retention as documented in the `retention_yearly` block below.
	RetentionYearly interface{}
	Tags interface{}
}

// The set of arguments for constructing a ProtectionPolicyVM resource.
type ProtectionPolicyVMArgs struct {
	// Configures the Policy backup frequecent, times & days as documented in the `backup` block below. 
	Backup interface{}
	// Specifies the name of the Recovery Services Vault Policy. Changing this forces a new resource to be created.
	Name interface{}
	// Specifies the name of the Recovery Services Vault to use. Changing this forces a new resource to be created.
	RecoveryVaultName interface{}
	// The name of the resource group in which to create the Recovery Services Protected VM. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// Configures the policy daily retention as documented in the `retention_daily` block below. Required when backup frequency is `Daily`.
	RetentionDaily interface{}
	// Configures the policy monthly retention as documented in the `retention_monthly` block below.
	RetentionMonthly interface{}
	// Configures the policy weekly retention as documented in the `retention_weekly` block below. Required when backup frequency is `Weekly`.
	RetentionWeekly interface{}
	// Configures the policy yearly retention as documented in the `retention_yearly` block below.
	RetentionYearly interface{}
	Tags interface{}
}
