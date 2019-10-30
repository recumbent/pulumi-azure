// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure
{
    /// <summary>
    /// The provider type for the azurerm package. By default, resources use package-wide configuration
    /// settings, however an explicit `Provider` instance may be created and passed during resource
    /// construction to achieve fine-grained programmatic control over provider settings. See the
    /// [documentation](https://www.pulumi.com/docs/reference/programming-model/#providers) for more information.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/index.html.markdown.
    /// </summary>
    public partial class Provider : Pulumi.ProviderResource
    {
        /// <summary>
        /// Create a Provider resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Provider(string name, ProviderArgs? args = null, ResourceOptions? options = null)
            : base("azure", name, args, MakeResourceOptions(options, ""))
        {
        }

        private static ResourceOptions MakeResourceOptions(ResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new ResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = ResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
    }

    public sealed class ProviderArgs : Pulumi.ResourceArgs
    {
        [Input("auxiliaryTenantIds", json: true)]
        private InputList<string>? _auxiliaryTenantIds;
        public InputList<string> AuxiliaryTenantIds
        {
            get => _auxiliaryTenantIds ?? (_auxiliaryTenantIds = new InputList<string>());
            set => _auxiliaryTenantIds = value;
        }

        /// <summary>
        /// The password associated with the Client Certificate. For use when authenticating as a Service Principal
        /// using a Client Certificate
        /// </summary>
        [Input("clientCertificatePassword")]
        public Input<string>? ClientCertificatePassword { get; set; }

        /// <summary>
        /// The path to the Client Certificate associated with the Service Principal for use when authenticating as a
        /// Service Principal using a Client Certificate.
        /// </summary>
        [Input("clientCertificatePath")]
        public Input<string>? ClientCertificatePath { get; set; }

        /// <summary>
        /// The Client ID which should be used.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The Client Secret which should be used. For use When authenticating as a Service Principal using a Client
        /// Secret.
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// This will disable the x-ms-correlation-request-id header.
        /// </summary>
        [Input("disableCorrelationRequestId", json: true)]
        public Input<bool>? DisableCorrelationRequestId { get; set; }

        /// <summary>
        /// This will disable the Terraform Partner ID which is used if a custom `partner_id` isn't specified.
        /// </summary>
        [Input("disableTerraformPartnerId", json: true)]
        public Input<bool>? DisableTerraformPartnerId { get; set; }

        /// <summary>
        /// The Cloud Environment which should be used. Possible values are public, usgovernment, german, and china.
        /// Defaults to public.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The path to a custom endpoint for Managed Service Identity - in most circumstances this should be detected
        /// automatically.
        /// </summary>
        [Input("msiEndpoint")]
        public Input<string>? MsiEndpoint { get; set; }

        /// <summary>
        /// A GUID/UUID that is registered with Microsoft to facilitate partner resource usage attribution.
        /// </summary>
        [Input("partnerId")]
        public Input<string>? PartnerId { get; set; }

        /// <summary>
        /// This will cause the AzureRM Provider to skip verifying the credentials being used are valid.
        /// </summary>
        [Input("skipCredentialsValidation", json: true)]
        public Input<bool>? SkipCredentialsValidation { get; set; }

        /// <summary>
        /// Should the AzureRM Provider skip registering all of the Resource Providers that it supports, if they're not
        /// already registered?
        /// </summary>
        [Input("skipProviderRegistration", json: true)]
        public Input<bool>? SkipProviderRegistration { get; set; }

        /// <summary>
        /// The Subscription ID which should be used.
        /// </summary>
        [Input("subscriptionId")]
        public Input<string>? SubscriptionId { get; set; }

        /// <summary>
        /// The Tenant ID which should be used.
        /// </summary>
        [Input("tenantId")]
        public Input<string>? TenantId { get; set; }

        /// <summary>
        /// Allowed Managed Service Identity be used for Authentication.
        /// </summary>
        [Input("useMsi", json: true)]
        public Input<bool>? UseMsi { get; set; }

        public ProviderArgs()
        {
            ClientCertificatePassword = Utilities.GetEnv("ARM_CLIENT_CERTIFICATE_PASSWORD") ?? "";
            ClientCertificatePath = Utilities.GetEnv("ARM_CLIENT_CERTIFICATE_PATH") ?? "";
            ClientId = Utilities.GetEnv("ARM_CLIENT_ID") ?? "";
            ClientSecret = Utilities.GetEnv("ARM_CLIENT_SECRET") ?? "";
            DisableTerraformPartnerId = Utilities.GetEnvBoolean("ARM_DISABLE_TERRAFORM_PARTNER_ID") ?? true;
            Environment = Utilities.GetEnv("ARM_ENVIRONMENT") ?? "public";
            MsiEndpoint = Utilities.GetEnv("ARM_MSI_ENDPOINT") ?? "";
            PartnerId = Utilities.GetEnv("ARM_PARTNER_ID") ?? "";
            SkipCredentialsValidation = Utilities.GetEnvBoolean("ARM_SKIP_CREDENTIALS_VALIDATION") ?? false;
            SkipProviderRegistration = Utilities.GetEnvBoolean("ARM_SKIP_PROVIDER_REGISTRATION") ?? false;
            SubscriptionId = Utilities.GetEnv("ARM_SUBSCRIPTION_ID") ?? "";
            TenantId = Utilities.GetEnv("ARM_TENANT_ID") ?? "";
            UseMsi = Utilities.GetEnvBoolean("ARM_USE_MSI") ?? false;
        }
    }
}
