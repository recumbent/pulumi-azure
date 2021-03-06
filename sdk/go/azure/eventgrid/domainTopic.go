// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package eventgrid

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages an EventGrid Domain Topic
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/eventgrid"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleResourceGroup, err := core.NewResourceGroup(ctx, "exampleResourceGroup", &core.ResourceGroupArgs{
// 			Location: pulumi.String("West US 2"),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleDomain, err := eventgrid.NewDomain(ctx, "exampleDomain", &eventgrid.DomainArgs{
// 			Location:          exampleResourceGroup.Location,
// 			ResourceGroupName: exampleResourceGroup.Name,
// 			Tags: pulumi.StringMap{
// 				"environment": pulumi.String("Production"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = eventgrid.NewDomainTopic(ctx, "exampleDomainTopic", &eventgrid.DomainTopicArgs{
// 			DomainName:        exampleDomain.Name,
// 			ResourceGroupName: exampleResourceGroup.Name,
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type DomainTopic struct {
	pulumi.CustomResourceState

	// Specifies the name of the EventGrid Domain. Changing this forces a new resource to be created.
	DomainName pulumi.StringOutput `pulumi:"domainName"`
	// Specifies the name of the EventGrid Domain Topic resource. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
}

// NewDomainTopic registers a new resource with the given unique name, arguments, and options.
func NewDomainTopic(ctx *pulumi.Context,
	name string, args *DomainTopicArgs, opts ...pulumi.ResourceOption) (*DomainTopic, error) {
	if args == nil || args.DomainName == nil {
		return nil, errors.New("missing required argument 'DomainName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil {
		args = &DomainTopicArgs{}
	}
	var resource DomainTopic
	err := ctx.RegisterResource("azure:eventgrid/domainTopic:DomainTopic", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetDomainTopic gets an existing DomainTopic resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetDomainTopic(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *DomainTopicState, opts ...pulumi.ResourceOption) (*DomainTopic, error) {
	var resource DomainTopic
	err := ctx.ReadResource("azure:eventgrid/domainTopic:DomainTopic", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering DomainTopic resources.
type domainTopicState struct {
	// Specifies the name of the EventGrid Domain. Changing this forces a new resource to be created.
	DomainName *string `pulumi:"domainName"`
	// Specifies the name of the EventGrid Domain Topic resource. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
}

type DomainTopicState struct {
	// Specifies the name of the EventGrid Domain. Changing this forces a new resource to be created.
	DomainName pulumi.StringPtrInput
	// Specifies the name of the EventGrid Domain Topic resource. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
}

func (DomainTopicState) ElementType() reflect.Type {
	return reflect.TypeOf((*domainTopicState)(nil)).Elem()
}

type domainTopicArgs struct {
	// Specifies the name of the EventGrid Domain. Changing this forces a new resource to be created.
	DomainName string `pulumi:"domainName"`
	// Specifies the name of the EventGrid Domain Topic resource. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
}

// The set of arguments for constructing a DomainTopic resource.
type DomainTopicArgs struct {
	// Specifies the name of the EventGrid Domain. Changing this forces a new resource to be created.
	DomainName pulumi.StringInput
	// Specifies the name of the EventGrid Domain Topic resource. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the resource group in which the EventGrid Domain exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
}

func (DomainTopicArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*domainTopicArgs)(nil)).Elem()
}
