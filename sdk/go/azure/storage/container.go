// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package storage

import (
	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Manage an Azure Storage Container.
type Container struct {
	s *pulumi.ResourceState
}

// NewContainer registers a new resource with the given unique name, arguments, and options.
func NewContainer(ctx *pulumi.Context,
	name string, args *ContainerArgs, opts ...pulumi.ResourceOpt) (*Container, error) {
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.StorageAccountName == nil {
		return nil, errors.New("missing required argument 'StorageAccountName'")
	}
	inputs := make(map[string]interface{})
	if args == nil {
		inputs["containerAccessType"] = nil
		inputs["name"] = nil
		inputs["resourceGroupName"] = nil
		inputs["storageAccountName"] = nil
	} else {
		inputs["containerAccessType"] = args.ContainerAccessType
		inputs["name"] = args.Name
		inputs["resourceGroupName"] = args.ResourceGroupName
		inputs["storageAccountName"] = args.StorageAccountName
	}
	inputs["properties"] = nil
	s, err := ctx.RegisterResource("azure:storage/container:Container", name, true, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Container{s: s}, nil
}

// GetContainer gets an existing Container resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetContainer(ctx *pulumi.Context,
	name string, id pulumi.ID, state *ContainerState, opts ...pulumi.ResourceOpt) (*Container, error) {
	inputs := make(map[string]interface{})
	if state != nil {
		inputs["containerAccessType"] = state.ContainerAccessType
		inputs["name"] = state.Name
		inputs["properties"] = state.Properties
		inputs["resourceGroupName"] = state.ResourceGroupName
		inputs["storageAccountName"] = state.StorageAccountName
	}
	s, err := ctx.ReadResource("azure:storage/container:Container", name, id, inputs, opts...)
	if err != nil {
		return nil, err
	}
	return &Container{s: s}, nil
}

// URN is this resource's unique name assigned by Pulumi.
func (r *Container) URN() *pulumi.URNOutput {
	return r.s.URN
}

// ID is this resource's unique identifier assigned by its provider.
func (r *Container) ID() *pulumi.IDOutput {
	return r.s.ID
}

// The 'interface' for access the container provides. Can be either `blob`, `container` or `private`. Defaults to `private`.
func (r *Container) ContainerAccessType() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["containerAccessType"])
}

// The name of the storage container. Must be unique within the storage service the container is located.
func (r *Container) Name() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["name"])
}

// Key-value definition of additional properties associated to the storage container
func (r *Container) Properties() *pulumi.MapOutput {
	return (*pulumi.MapOutput)(r.s.State["properties"])
}

// The name of the resource group in which to
// create the storage container. Changing this forces a new resource to be created.
func (r *Container) ResourceGroupName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["resourceGroupName"])
}

// Specifies the storage account in which to create the storage container.
// Changing this forces a new resource to be created.
func (r *Container) StorageAccountName() *pulumi.StringOutput {
	return (*pulumi.StringOutput)(r.s.State["storageAccountName"])
}

// Input properties used for looking up and filtering Container resources.
type ContainerState struct {
	// The 'interface' for access the container provides. Can be either `blob`, `container` or `private`. Defaults to `private`.
	ContainerAccessType interface{}
	// The name of the storage container. Must be unique within the storage service the container is located.
	Name interface{}
	// Key-value definition of additional properties associated to the storage container
	Properties interface{}
	// The name of the resource group in which to
	// create the storage container. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// Specifies the storage account in which to create the storage container.
	// Changing this forces a new resource to be created.
	StorageAccountName interface{}
}

// The set of arguments for constructing a Container resource.
type ContainerArgs struct {
	// The 'interface' for access the container provides. Can be either `blob`, `container` or `private`. Defaults to `private`.
	ContainerAccessType interface{}
	// The name of the storage container. Must be unique within the storage service the container is located.
	Name interface{}
	// The name of the resource group in which to
	// create the storage container. Changing this forces a new resource to be created.
	ResourceGroupName interface{}
	// Specifies the storage account in which to create the storage container.
	// Changing this forces a new resource to be created.
	StorageAccountName interface{}
}
