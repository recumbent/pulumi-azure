// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Healthcare.Inputs
{

    public sealed class ServiceAuthenticationConfigurationGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The intended audience to receive authentication tokens for the service. The default value is https://azurehealthcareapis.com
        /// </summary>
        [Input("audience")]
        public Input<string>? Audience { get; set; }

        /// <summary>
        /// The Azure Active Directory (tenant) that serves as the authentication authority to access the service. The default authority is the Directory defined in the authentication scheme in use when running this provider.
        /// Authority must be registered to Azure AD and in the following format: https://{Azure-AD-endpoint}/{tenant-id}.
        /// </summary>
        [Input("authority")]
        public Input<string>? Authority { get; set; }

        /// <summary>
        /// Enables the 'SMART on FHIR' option for mobile and web implementations.
        /// </summary>
        [Input("smartProxyEnabled")]
        public Input<bool>? SmartProxyEnabled { get; set; }

        public ServiceAuthenticationConfigurationGetArgs()
        {
        }
    }
}