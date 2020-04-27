// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package management

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing Management Group.
func LookupGroup(ctx *pulumi.Context, args *LookupGroupArgs, opts ...pulumi.InvokeOption) (*LookupGroupResult, error) {
	var rv LookupGroupResult
	err := ctx.Invoke("azure:management/getGroup:getGroup", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGroup.
type LookupGroupArgs struct {
	// Specifies the name or UUID of this Management Group.
	GroupId *string `pulumi:"groupId"`
	// Specifies the name or UUID of this Management Group.
	Name *string `pulumi:"name"`
}

// A collection of values returned by getGroup.
type LookupGroupResult struct {
	// A friendly name for the Management Group.
	DisplayName string `pulumi:"displayName"`
	GroupId     string `pulumi:"groupId"`
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
	// The ID of any Parent Management Group.
	ParentManagementGroupId string `pulumi:"parentManagementGroupId"`
	// A list of Subscription ID's which are assigned to the Management Group.
	SubscriptionIds []string `pulumi:"subscriptionIds"`
}
