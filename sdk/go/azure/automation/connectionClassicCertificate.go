// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package automation

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an Automation Connection with type `AzureClassicCertificate`.
type ConnectionClassicCertificate struct {
	pulumi.CustomResourceState

	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName pulumi.StringOutput `pulumi:"automationAccountName"`
	// The name of the certificate asset.
	CertificateAssetName pulumi.StringOutput `pulumi:"certificateAssetName"`
	// A description for this Connection.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// The id of subscription.
	SubscriptionId pulumi.StringOutput `pulumi:"subscriptionId"`
	// The name of subscription.
	SubscriptionName pulumi.StringOutput `pulumi:"subscriptionName"`
}

// NewConnectionClassicCertificate registers a new resource with the given unique name, arguments, and options.
func NewConnectionClassicCertificate(ctx *pulumi.Context,
	name string, args *ConnectionClassicCertificateArgs, opts ...pulumi.ResourceOption) (*ConnectionClassicCertificate, error) {
	if args == nil || args.AutomationAccountName == nil {
		return nil, errors.New("missing required argument 'AutomationAccountName'")
	}
	if args == nil || args.CertificateAssetName == nil {
		return nil, errors.New("missing required argument 'CertificateAssetName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.SubscriptionId == nil {
		return nil, errors.New("missing required argument 'SubscriptionId'")
	}
	if args == nil || args.SubscriptionName == nil {
		return nil, errors.New("missing required argument 'SubscriptionName'")
	}
	if args == nil {
		args = &ConnectionClassicCertificateArgs{}
	}
	var resource ConnectionClassicCertificate
	err := ctx.RegisterResource("azure:automation/connectionClassicCertificate:ConnectionClassicCertificate", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnectionClassicCertificate gets an existing ConnectionClassicCertificate resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnectionClassicCertificate(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectionClassicCertificateState, opts ...pulumi.ResourceOption) (*ConnectionClassicCertificate, error) {
	var resource ConnectionClassicCertificate
	err := ctx.ReadResource("azure:automation/connectionClassicCertificate:ConnectionClassicCertificate", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ConnectionClassicCertificate resources.
type connectionClassicCertificateState struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName *string `pulumi:"automationAccountName"`
	// The name of the certificate asset.
	CertificateAssetName *string `pulumi:"certificateAssetName"`
	// A description for this Connection.
	Description *string `pulumi:"description"`
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// The id of subscription.
	SubscriptionId *string `pulumi:"subscriptionId"`
	// The name of subscription.
	SubscriptionName *string `pulumi:"subscriptionName"`
}

type ConnectionClassicCertificateState struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName pulumi.StringPtrInput
	// The name of the certificate asset.
	CertificateAssetName pulumi.StringPtrInput
	// A description for this Connection.
	Description pulumi.StringPtrInput
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// The id of subscription.
	SubscriptionId pulumi.StringPtrInput
	// The name of subscription.
	SubscriptionName pulumi.StringPtrInput
}

func (ConnectionClassicCertificateState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionClassicCertificateState)(nil)).Elem()
}

type connectionClassicCertificateArgs struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// The name of the certificate asset.
	CertificateAssetName string `pulumi:"certificateAssetName"`
	// A description for this Connection.
	Description *string `pulumi:"description"`
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The id of subscription.
	SubscriptionId string `pulumi:"subscriptionId"`
	// The name of subscription.
	SubscriptionName string `pulumi:"subscriptionName"`
}

// The set of arguments for constructing a ConnectionClassicCertificate resource.
type ConnectionClassicCertificateArgs struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName pulumi.StringInput
	// The name of the certificate asset.
	CertificateAssetName pulumi.StringInput
	// A description for this Connection.
	Description pulumi.StringPtrInput
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// The id of subscription.
	SubscriptionId pulumi.StringInput
	// The name of subscription.
	SubscriptionName pulumi.StringInput
}

func (ConnectionClassicCertificateArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionClassicCertificateArgs)(nil)).Elem()
}
