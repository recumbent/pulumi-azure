// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package automation

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an Automation Connection.
type Connection struct {
	pulumi.CustomResourceState

	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName pulumi.StringOutput `pulumi:"automationAccountName"`
	// A description for this Connection.
	Description pulumi.StringPtrOutput `pulumi:"description"`
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// The type of the Connection - can be either builtin type such as `Azure`, `AzureClassicCertificate`, and `AzureServicePrincipal`, or a user defined types. Changing this forces a new resource to be created.
	Type pulumi.StringOutput `pulumi:"type"`
	// A mapping of key value pairs passed to the connection. Different `type` needs different parameters in the `values`. Builtin types have required field values as below:
	Values pulumi.StringMapOutput `pulumi:"values"`
}

// NewConnection registers a new resource with the given unique name, arguments, and options.
func NewConnection(ctx *pulumi.Context,
	name string, args *ConnectionArgs, opts ...pulumi.ResourceOption) (*Connection, error) {
	if args == nil || args.AutomationAccountName == nil {
		return nil, errors.New("missing required argument 'AutomationAccountName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Type == nil {
		return nil, errors.New("missing required argument 'Type'")
	}
	if args == nil || args.Values == nil {
		return nil, errors.New("missing required argument 'Values'")
	}
	if args == nil {
		args = &ConnectionArgs{}
	}
	var resource Connection
	err := ctx.RegisterResource("azure:automation/connection:Connection", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetConnection gets an existing Connection resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetConnection(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ConnectionState, opts ...pulumi.ResourceOption) (*Connection, error) {
	var resource Connection
	err := ctx.ReadResource("azure:automation/connection:Connection", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering Connection resources.
type connectionState struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName *string `pulumi:"automationAccountName"`
	// A description for this Connection.
	Description *string `pulumi:"description"`
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// The type of the Connection - can be either builtin type such as `Azure`, `AzureClassicCertificate`, and `AzureServicePrincipal`, or a user defined types. Changing this forces a new resource to be created.
	Type *string `pulumi:"type"`
	// A mapping of key value pairs passed to the connection. Different `type` needs different parameters in the `values`. Builtin types have required field values as below:
	Values map[string]string `pulumi:"values"`
}

type ConnectionState struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName pulumi.StringPtrInput
	// A description for this Connection.
	Description pulumi.StringPtrInput
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// The type of the Connection - can be either builtin type such as `Azure`, `AzureClassicCertificate`, and `AzureServicePrincipal`, or a user defined types. Changing this forces a new resource to be created.
	Type pulumi.StringPtrInput
	// A mapping of key value pairs passed to the connection. Different `type` needs different parameters in the `values`. Builtin types have required field values as below:
	Values pulumi.StringMapInput
}

func (ConnectionState) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionState)(nil)).Elem()
}

type connectionArgs struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName string `pulumi:"automationAccountName"`
	// A description for this Connection.
	Description *string `pulumi:"description"`
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The type of the Connection - can be either builtin type such as `Azure`, `AzureClassicCertificate`, and `AzureServicePrincipal`, or a user defined types. Changing this forces a new resource to be created.
	Type string `pulumi:"type"`
	// A mapping of key value pairs passed to the connection. Different `type` needs different parameters in the `values`. Builtin types have required field values as below:
	Values map[string]string `pulumi:"values"`
}

// The set of arguments for constructing a Connection resource.
type ConnectionArgs struct {
	// The name of the automation account in which the Connection is created. Changing this forces a new resource to be created.
	AutomationAccountName pulumi.StringInput
	// A description for this Connection.
	Description pulumi.StringPtrInput
	// Specifies the name of the Connection. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the resource group in which the Connection is created. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// The type of the Connection - can be either builtin type such as `Azure`, `AzureClassicCertificate`, and `AzureServicePrincipal`, or a user defined types. Changing this forces a new resource to be created.
	Type pulumi.StringInput
	// A mapping of key value pairs passed to the connection. Different `type` needs different parameters in the `values`. Builtin types have required field values as below:
	Values pulumi.StringMapInput
}

func (ConnectionArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*connectionArgs)(nil)).Elem()
}