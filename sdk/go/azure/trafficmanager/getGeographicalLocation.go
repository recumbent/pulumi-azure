// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package trafficmanager

import (
	"github.com/pulumi/pulumi/sdk/v2/go/pulumi"
)

// Use this data source to access the ID of a specified Traffic Manager Geographical Location within the Geographical Hierarchy.
//
// Deprecated: azure.getGeographicalLocation has been deprecated in favour of azure.getTrafficManager
func GetGeographicalLocation(ctx *pulumi.Context, args *GetGeographicalLocationArgs, opts ...pulumi.InvokeOption) (*GetGeographicalLocationResult, error) {
	var rv GetGeographicalLocationResult
	err := ctx.Invoke("azure:trafficmanager/getGeographicalLocation:getGeographicalLocation", args, &rv, opts...)
	if err != nil {
		return nil, err
	}
	return &rv, nil
}

// A collection of arguments for invoking getGeographicalLocation.
type GetGeographicalLocationArgs struct {
	// Specifies the name of the Location, for example `World`, `Europe` or `Germany`.
	Name string `pulumi:"name"`
}

// A collection of values returned by getGeographicalLocation.
type GetGeographicalLocationResult struct {
	// The provider-assigned unique ID for this managed resource.
	Id   string `pulumi:"id"`
	Name string `pulumi:"name"`
}
