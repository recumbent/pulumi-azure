// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

// nolint: lll
package mssql

import (
	"reflect"

	"github.com/pkg/errors"
	"github.com/pulumi/pulumi/sdk/go/pulumi"
)

// Allows you to manage an Azure SQL Elastic Pool via the `2017-10-01-preview` API which allows for `vCore` and `DTU` based configurations.
// 
// > This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/mssql_elasticpool.html.markdown.
type ElasticPool struct {
	pulumi.CustomResourceState

	ElasticPoolProperties ElasticPoolElasticPoolPropertyArrayOutput `pulumi:"elasticPoolProperties"`
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location pulumi.StringOutput `pulumi:"location"`
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes pulumi.IntOutput `pulumi:"maxSizeBytes"`
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`.
	MaxSizeGb pulumi.Float64Output `pulumi:"maxSizeGb"`
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern.
	Name pulumi.StringOutput `pulumi:"name"`
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings ElasticPoolPerDatabaseSettingsOutput `pulumi:"perDatabaseSettings"`
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName pulumi.StringOutput `pulumi:"resourceGroupName"`
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName pulumi.StringOutput `pulumi:"serverName"`
	// A `sku` block as defined below.
	Sku ElasticPoolSkuOutput `pulumi:"sku"`
	// A mapping of tags to assign to the resource.
	Tags pulumi.StringMapOutput `pulumi:"tags"`
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant pulumi.BoolPtrOutput `pulumi:"zoneRedundant"`
}

// NewElasticPool registers a new resource with the given unique name, arguments, and options.
func NewElasticPool(ctx *pulumi.Context,
	name string, args *ElasticPoolArgs, opts ...pulumi.ResourceOption) (*ElasticPool, error) {
	if args == nil || args.PerDatabaseSettings == nil {
		return nil, errors.New("missing required argument 'PerDatabaseSettings'")
	}
	if args == nil || args.ResourceGroupName == nil {
		return nil, errors.New("missing required argument 'ResourceGroupName'")
	}
	if args == nil || args.ServerName == nil {
		return nil, errors.New("missing required argument 'ServerName'")
	}
	if args == nil || args.Sku == nil {
		return nil, errors.New("missing required argument 'Sku'")
	}
	if args == nil {
		args = &ElasticPoolArgs{}
	}
	var resource ElasticPool
	err := ctx.RegisterResource("azure:mssql/elasticPool:ElasticPool", name, args, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// GetElasticPool gets an existing ElasticPool resource's state with the given name, ID, and optional
// state properties that are used to uniquely qualify the lookup (nil if not required).
func GetElasticPool(ctx *pulumi.Context,
	name string, id pulumi.IDInput, state *ElasticPoolState, opts ...pulumi.ResourceOption) (*ElasticPool, error) {
	var resource ElasticPool
	err := ctx.ReadResource("azure:mssql/elasticPool:ElasticPool", name, id, state, &resource, opts...)
	if err != nil {
		return nil, err
	}
	return &resource, nil
}

// Input properties used for looking up and filtering ElasticPool resources.
type elasticPoolState struct {
	ElasticPoolProperties []ElasticPoolElasticPoolProperty `pulumi:"elasticPoolProperties"`
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location *string `pulumi:"location"`
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes *int `pulumi:"maxSizeBytes"`
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`.
	MaxSizeGb *float64 `pulumi:"maxSizeGb"`
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern.
	Name *string `pulumi:"name"`
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings *ElasticPoolPerDatabaseSettings `pulumi:"perDatabaseSettings"`
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName *string `pulumi:"resourceGroupName"`
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName *string `pulumi:"serverName"`
	// A `sku` block as defined below.
	Sku *ElasticPoolSku `pulumi:"sku"`
	// A mapping of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant *bool `pulumi:"zoneRedundant"`
}

type ElasticPoolState struct {
	ElasticPoolProperties ElasticPoolElasticPoolPropertyArrayInput
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location pulumi.StringPtrInput
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes pulumi.IntPtrInput
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`.
	MaxSizeGb pulumi.Float64PtrInput
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern.
	Name pulumi.StringPtrInput
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings ElasticPoolPerDatabaseSettingsPtrInput
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName pulumi.StringPtrInput
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName pulumi.StringPtrInput
	// A `sku` block as defined below.
	Sku ElasticPoolSkuPtrInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant pulumi.BoolPtrInput
}

func (ElasticPoolState) ElementType() reflect.Type {
	return reflect.TypeOf((*elasticPoolState)(nil)).Elem()
}

type elasticPoolArgs struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location *string `pulumi:"location"`
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes *int `pulumi:"maxSizeBytes"`
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`.
	MaxSizeGb *float64 `pulumi:"maxSizeGb"`
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern.
	Name *string `pulumi:"name"`
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings ElasticPoolPerDatabaseSettings `pulumi:"perDatabaseSettings"`
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName string `pulumi:"resourceGroupName"`
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName string `pulumi:"serverName"`
	// A `sku` block as defined below.
	Sku ElasticPoolSku `pulumi:"sku"`
	// A mapping of tags to assign to the resource.
	Tags map[string]string `pulumi:"tags"`
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant *bool `pulumi:"zoneRedundant"`
}

// The set of arguments for constructing a ElasticPool resource.
type ElasticPoolArgs struct {
	// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
	Location pulumi.StringPtrInput
	// The max data size of the elastic pool in bytes. Conflicts with `maxSizeGb`.
	MaxSizeBytes pulumi.IntPtrInput
	// The max data size of the elastic pool in gigabytes. Conflicts with `maxSizeBytes`.
	MaxSizeGb pulumi.Float64PtrInput
	// Specifies the SKU Name for this Elasticpool. The name of the SKU, will be either `vCore` based `tier` + `family` pattern (e.g. GP_Gen4, BC_Gen5) or the `DTU` based `BasicPool`, `StandardPool`, or `PremiumPool` pattern.
	Name pulumi.StringPtrInput
	// A `perDatabaseSettings` block as defined below.
	PerDatabaseSettings ElasticPoolPerDatabaseSettingsInput
	// The name of the resource group in which to create the elastic pool. This must be the same as the resource group of the underlying SQL server.
	ResourceGroupName pulumi.StringInput
	// The name of the SQL Server on which to create the elastic pool. Changing this forces a new resource to be created.
	ServerName pulumi.StringInput
	// A `sku` block as defined below.
	Sku ElasticPoolSkuInput
	// A mapping of tags to assign to the resource.
	Tags pulumi.StringMapInput
	// Whether or not this elastic pool is zone redundant. `tier` needs to be `Premium` for `DTU` based  or `BusinessCritical` for `vCore` based `sku`. Defaults to `false`.
	ZoneRedundant pulumi.BoolPtrInput
}

func (ElasticPoolArgs) ElementType() reflect.Type {
	return reflect.TypeOf((*elasticPoolArgs)(nil)).Elem()
}

