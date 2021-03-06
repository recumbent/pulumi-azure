// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package streamanalytics

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Manages a Stream Analytics Stream Input EventHub.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/core"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/eventhub"
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/streamanalytics"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		exampleResourceGroup, err := core.LookupResourceGroup(ctx, &core.LookupResourceGroupArgs{
// 			Name: "example-resources",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleJob, err := streamanalytics.LookupJob(ctx, &streamanalytics.LookupJobArgs{
// 			Name:              "example-job",
// 			ResourceGroupName: azurerm_resource_group.Example.Name,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleEventHubNamespace, err := eventhub.NewEventHubNamespace(ctx, "exampleEventHubNamespace", &eventhub.EventHubNamespaceArgs{
// 			Location:          pulumi.String(exampleResourceGroup.Location),
// 			ResourceGroupName: pulumi.String(exampleResourceGroup.Name),
// 			Sku:               pulumi.String("Standard"),
// 			Capacity:          pulumi.Int(1),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleEventHub, err := eventhub.NewEventHub(ctx, "exampleEventHub", &eventhub.EventHubArgs{
// 			NamespaceName:     exampleEventHubNamespace.Name,
// 			ResourceGroupName: pulumi.String(exampleResourceGroup.Name),
// 			PartitionCount:    pulumi.Int(2),
// 			MessageRetention:  pulumi.Int(1),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		exampleConsumerGroup, err := eventhub.NewConsumerGroup(ctx, "exampleConsumerGroup", &eventhub.ConsumerGroupArgs{
// 			NamespaceName:     exampleEventHubNamespace.Name,
// 			EventhubName:      exampleEventHub.Name,
// 			ResourceGroupName: pulumi.String(exampleResourceGroup.Name),
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		_, err = streamanalytics.NewStreamInputEventHub(ctx, "exampleStreamInputEventHub", &streamanalytics.StreamInputEventHubArgs{
// 			StreamAnalyticsJobName:    pulumi.String(exampleJob.Name),
// 			ResourceGroupName:         pulumi.String(exampleJob.ResourceGroupName),
// 			EventhubConsumerGroupName: exampleConsumerGroup.Name,
// 			EventhubName:              exampleEventHub.Name,
// 			ServicebusNamespace:       exampleEventHubNamespace.Name,
// 			SharedAccessPolicyKey:     exampleEventHubNamespace.DefaultPrimaryKey,
// 			SharedAccessPolicyName:    pulumi.String("RootManageSharedAccessKey"),
// 			Serialization: &streamanalytics.StreamInputEventHubSerializationArgs{
// 				Type:     pulumi.String("Json"),
// 				Encoding: pulumi.String("UTF8"),
// 			},
// 		})
// 		if err != nil {
// 			return err
// 		}
// 		return nil
// 	})
// }
// ```
type StreamInputEventHub struct {
	pulumi.CustomResourceState

	// The name of an Event Hub Consumer Group that should be used to read events from the Event Hub. Specifying distinct consumer group names for multiple inputs allows each of those inputs to receive the same events from the Event Hub.
	EventhubConsumerGroupName pulumi.StringOutput `pulumi:"eventhubConsumerGroupName"`
	// The name of the Event Hub.
	EventhubName pulumi.StringOutput `pulumi:"eventhubName"`
	// The name of the Stream Input EventHub. Changing this forces a new resource to be created.
	Name pulumi.StringOutput `pulumi:"name"`
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// A `serialization` block as defined below.
	Serialization StreamInputEventHubSerializationOutput `pulumi:"serialization"`
	// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
	ServicebusNamespace pulumi.StringOutput `pulumi:"servicebusNamespace"`
	// The shared access policy key for the specified shared access policy.
	SharedAccessPolicyKey pulumi.StringOutput `pulumi:"sharedAccessPolicyKey"`
	// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
	SharedAccessPolicyName pulumi.StringOutput `pulumi:"sharedAccessPolicyName"`
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName pulumi.StringOutput `pulumi:"streamAnalyticsJobName"`
}

// NewStreamInputEventHub registers a new resource with the given unique name, arguments, and options.
func NewStreamInputEventHub(ctx *pulumi.Context,
	name string, args *StreamInputEventHubArgs, opts ...pulumi.ResourceOption) (*StreamInputEventHub, error) {
	if args == nil || args.EventhubConsumerGroupName == nil {
		return nil, errors.New("missing required argument 'EventhubConsumerGroupName'")
	}
	if args == nil || args.EventhubName == nil {
		return nil, errors.New("missing required argument 'EventhubName'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.Serialization == nil {
		return nil, errors.New("missing required argument 'Serialization'")
	}
	if args == nil || args.ServicebusNamespace == nil {
		return nil, errors.New("missing required argument 'ServicebusNamespace'")
	}
	if args == nil || args.SharedAccessPolicyKey == nil {
		return nil, errors.New("missing required argument 'SharedAccessPolicyKey'")
	}
	if args == nil || args.SharedAccessPolicyName == nil {
		return nil, errors.New("missing required argument 'SharedAccessPolicyName'")
	}
	if args == nil || args.StreamAnalyticsJobName == nil {
		return nil, errors.New("missing required argument 'StreamAnalyticsJobName'")
	}
	if args == nil {
		args = &StreamInputEventHubArgs{}
	}
	var resource StreamInputEventHub
	err := ctx.RegisterResource("azure:streamanalytics/streamInputEventHub:StreamInputEventHub", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetStreamInputEventHub gets an existing StreamInputEventHub resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetStreamInputEventHub(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *StreamInputEventHubState, opts ...pulumi.ResourceOption) (*StreamInputEventHub, error) {
	var resource StreamInputEventHub
	err := ctx.ReadResource("azure:streamanalytics/streamInputEventHub:StreamInputEventHub", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering StreamInputEventHub resources.
type streamInputEventHubState struct {
	// The name of an Event Hub Consumer Group that should be used to read events from the Event Hub. Specifying distinct consumer group names for multiple inputs allows each of those inputs to receive the same events from the Event Hub.
	EventhubConsumerGroupName *string `pulumi:"eventhubConsumerGroupName"`
	// The name of the Event Hub.
	EventhubName *string `pulumi:"eventhubName"`
	// The name of the Stream Input EventHub. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// A `serialization` block as defined below.
	Serialization *StreamInputEventHubSerialization `pulumi:"serialization"`
	// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
	ServicebusNamespace *string `pulumi:"servicebusNamespace"`
	// The shared access policy key for the specified shared access policy.
	SharedAccessPolicyKey *string `pulumi:"sharedAccessPolicyKey"`
	// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
	SharedAccessPolicyName *string `pulumi:"sharedAccessPolicyName"`
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName *string `pulumi:"streamAnalyticsJobName"`
}

type StreamInputEventHubState struct {
	// The name of an Event Hub Consumer Group that should be used to read events from the Event Hub. Specifying distinct consumer group names for multiple inputs allows each of those inputs to receive the same events from the Event Hub.
	EventhubConsumerGroupName pulumi.StringPtrInput
	// The name of the Event Hub.
	EventhubName pulumi.StringPtrInput
	// The name of the Stream Input EventHub. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringPtrInput
	// A `serialization` block as defined below.
	Serialization StreamInputEventHubSerializationPtrInput
	// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
	ServicebusNamespace pulumi.StringPtrInput
	// The shared access policy key for the specified shared access policy.
	SharedAccessPolicyKey pulumi.StringPtrInput
	// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
	SharedAccessPolicyName pulumi.StringPtrInput
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName pulumi.StringPtrInput
}

func (StreamInputEventHubState) ElementType() reflect.Type {
	return reflect.TypeOf((*streamInputEventHubState)(nil)).Elem()
}

type streamInputEventHubArgs struct {
	// The name of an Event Hub Consumer Group that should be used to read events from the Event Hub. Specifying distinct consumer group names for multiple inputs allows each of those inputs to receive the same events from the Event Hub.
	EventhubConsumerGroupName string `pulumi:"eventhubConsumerGroupName"`
	// The name of the Event Hub.
	EventhubName string `pulumi:"eventhubName"`
	// The name of the Stream Input EventHub. Changing this forces a new resource to be created.
	Name *string `pulumi:"name"`
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// A `serialization` block as defined below.
	Serialization StreamInputEventHubSerialization `pulumi:"serialization"`
	// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
	ServicebusNamespace string `pulumi:"servicebusNamespace"`
	// The shared access policy key for the specified shared access policy.
	SharedAccessPolicyKey string `pulumi:"sharedAccessPolicyKey"`
	// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
	SharedAccessPolicyName string `pulumi:"sharedAccessPolicyName"`
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName string `pulumi:"streamAnalyticsJobName"`
}

// The set of arguments for constructing a StreamInputEventHub resource.
type StreamInputEventHubArgs struct {
	// The name of an Event Hub Consumer Group that should be used to read events from the Event Hub. Specifying distinct consumer group names for multiple inputs allows each of those inputs to receive the same events from the Event Hub.
	EventhubConsumerGroupName pulumi.StringInput
	// The name of the Event Hub.
	EventhubName pulumi.StringInput
	// The name of the Stream Input EventHub. Changing this forces a new resource to be created.
	Name pulumi.StringPtrInput
	// The name of the Resource Group where the Stream Analytics Job exists. Changing this forces a new resource to be created.
	ResourceGroupName pulumi.StringInput
	// A `serialization` block as defined below.
	Serialization StreamInputEventHubSerializationInput
	// The namespace that is associated with the desired Event Hub, Service Bus Queue, Service Bus Topic, etc.
	ServicebusNamespace pulumi.StringInput
	// The shared access policy key for the specified shared access policy.
	SharedAccessPolicyKey pulumi.StringInput
	// The shared access policy name for the Event Hub, Service Bus Queue, Service Bus Topic, etc.
	SharedAccessPolicyName pulumi.StringInput
	// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
	StreamAnalyticsJobName pulumi.StringInput
}

func (StreamInputEventHubArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*streamInputEventHubArgs)(nil)).Elem()
}
