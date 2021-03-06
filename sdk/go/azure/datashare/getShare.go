// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package datashare

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access information about an existing Data Share.
//
// ## Example Usage
//
// ```go
// package main
//
// import (
// 	"github.com/pulumi/pulumi-azure/sdk/v3/go/azure/datashare"
// 	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
// )
//
// func main() {
// 	pulumi.Run(func(ctx *pulumi.Context) error {
// 		_, err := datashare.LookupAccount(ctx, &datashare.LookupAccountArgs{
// 			Name:              "example-account",
// 			ResourceGroupName: "example-resource-group",
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		exampleShare, err := datashare.LookupShare(ctx, &datashare.LookupShareArgs{
// 			Name:      "existing",
// 			AccountId: data.Azurerm_data_share_account.Exmaple.Id,
// 		}, nil)
// 		if err != nil {
// 			return err
// 		}
// 		ctx.Export("id", exampleShare.Id)
// 		return nil
// 	})
// }
// ```
func LookupShare(ctx *pulumi.Context, args *LookupShareArgs, opts ...pulumi.InvokeOption) (*LookupShareResult, error) {
	var rv LookupShareResult
	err := ctx.Invoke("azure:datashare/getShare:getShare", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getShare.
type LookupShareArgs struct {
	// The ID of the Data Share account in which the Data Share is created.
	AccountId string `pulumi:"accountId"`
	// The name of this Data Share.
	Name string `pulumi:"name"`
}

// A collection of values returned by getShare.
type LookupShareResult struct {
	AccountId string `pulumi:"accountId"`
	// The description of the Data Share.
	Description string `pulumi:"description"`
	// The provider-assigned unique ID for this managed resource.
	Id string `pulumi:"id"`
	// The kind of the Data Share.
	Kind string `pulumi:"kind"`
	// The name of the snapshot schedule.
	Name string `pulumi:"name"`
	// A `snapshotSchedule` block as defined below.
	SnapshotSchedules []GetShareSnapshotSchedule `pulumi:"snapshotSchedules"`
	// The terms of the Data Share.
	Terms string `pulumi:"terms"`
}
