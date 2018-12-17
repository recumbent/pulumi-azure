// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/pulumi/pulumi/sdk/go/pulumi"
	"github.com/pulumi/pulumi/sdk/go/pulumi/config"
)

func GetClientCertificatePassword(ctx *pulumi.Context) string {
	return config.Get(ctx, "azure:clientCertificatePassword")
}

func GetClientCertificatePath(ctx *pulumi.Context) string {
	return config.Get(ctx, "azure:clientCertificatePath")
}

func GetClientId(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "azure:clientId")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault("", nil, "ARM_CLIENT_ID").(string); ok {
		return dv
	}
	return v
}

func GetClientSecret(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "azure:clientSecret")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault("", nil, "ARM_CLIENT_SECRET").(string); ok {
		return dv
	}
	return v
}

func GetEnvironment(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "azure:environment")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault("public", nil, "ARM_ENVIRONMENT").(string); ok {
		return dv
	}
	panic(err.Error())
	return v
}

func GetMsiEndpoint(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "azure:msiEndpoint")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault("", nil, "ARM_MSI_ENDPOINT").(string); ok {
		return dv
	}
	return v
}

func GetSkipCredentialsValidation(ctx *pulumi.Context) bool {
	v, err := config.TryBool(ctx, "azure:skipCredentialsValidation")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault(false, parseEnvBool, "ARM_SKIP_CREDENTIALS_VALIDATION").(bool); ok {
		return dv
	}
	return v
}

func GetSkipProviderRegistration(ctx *pulumi.Context) bool {
	v, err := config.TryBool(ctx, "azure:skipProviderRegistration")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault(false, parseEnvBool, "ARM_SKIP_PROVIDER_REGISTRATION").(bool); ok {
		return dv
	}
	return v
}

func GetSubscriptionId(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "azure:subscriptionId")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault("", nil, "ARM_SUBSCRIPTION_ID").(string); ok {
		return dv
	}
	return v
}

func GetTenantId(ctx *pulumi.Context) string {
	v, err := config.Try(ctx, "azure:tenantId")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault("", nil, "ARM_TENANT_ID").(string); ok {
		return dv
	}
	return v
}

func GetUseMsi(ctx *pulumi.Context) bool {
	v, err := config.TryBool(ctx, "azure:useMsi")
	if err == nil {
		return v
	}
	if dv, ok := getEnvOrDefault(false, parseEnvBool, "ARM_USE_MSI").(bool); ok {
		return dv
	}
	return v
}
