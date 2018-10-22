// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package core

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Use this data source to access information about all the Subscriptions currently available.
func LookupSubscriptions(ctx *pulumi.Context) (*GetSubscriptionsResult, error) {
	outputs, err := ctx.Invoke("azure:core/getSubscriptions:getSubscriptions", nil)
	if err != nil {
		return nil, err
	}
	return &GetSubscriptionsResult{
		Subscriptions: outputs["subscriptions"],
		Id: outputs["id"],
	}, nil
}

// A collection of values returned by getSubscriptions.
type GetSubscriptionsResult struct {
	// One or more `subscription` blocks as defined below.
	Subscriptions interface{}
	// id is the provider-assigned unique ID for this managed resource.
	Id interface{}
}
