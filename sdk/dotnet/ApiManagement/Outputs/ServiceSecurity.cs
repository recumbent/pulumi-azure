// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement.Outputs
{

    [OutputType]
    public sealed class ServiceSecurity
    {
        /// <summary>
        /// Should SSL 3.0 be enabled on the backend of the gateway? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableBackendSsl30;
        /// <summary>
        /// Should TLS 1.0 be enabled on the backend of the gateway? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableBackendTls10;
        /// <summary>
        /// Should TLS 1.1 be enabled on the backend of the gateway? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableBackendTls11;
        /// <summary>
        /// Should SSL 3.0 be enabled on the frontend of the gateway? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableFrontendSsl30;
        /// <summary>
        /// Should TLS 1.0 be enabled on the frontend of the gateway? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableFrontendTls10;
        /// <summary>
        /// Should TLS 1.1 be enabled on the frontend of the gateway? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableFrontendTls11;
        /// <summary>
        /// Should the `TLS_RSA_WITH_3DES_EDE_CBC_SHA` cipher be enabled for alL TLS versions (1.0, 1.1 and 1.2)? Defaults to `false`.
        /// </summary>
        public readonly bool? EnableTripleDesCiphers;

        [OutputConstructor]
        private ServiceSecurity(
            bool? enableBackendSsl30,

            bool? enableBackendTls10,

            bool? enableBackendTls11,

            bool? enableFrontendSsl30,

            bool? enableFrontendTls10,

            bool? enableFrontendTls11,

            bool? enableTripleDesCiphers)
        {
            EnableBackendSsl30 = enableBackendSsl30;
            EnableBackendTls10 = enableBackendTls10;
            EnableBackendTls11 = enableBackendTls11;
            EnableFrontendSsl30 = enableFrontendSsl30;
            EnableFrontendTls10 = enableFrontendTls10;
            EnableFrontendTls11 = enableFrontendTls11;
            EnableTripleDesCiphers = enableTripleDesCiphers;
        }
    }
}
