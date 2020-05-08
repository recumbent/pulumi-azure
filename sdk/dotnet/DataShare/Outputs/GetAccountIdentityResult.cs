// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.DataShare.Outputs
{

    [OutputType]
    public sealed class GetAccountIdentityResult
    {
        /// <summary>
        /// The ID of the Principal (Client) in Azure Active Directory.
        /// </summary>
        public readonly string PrincipalId;
        /// <summary>
        /// The ID of the Azure Active Directory Tenant.
        /// </summary>
        public readonly string TenantId;
        /// <summary>
        /// The identity type of the Data Share Account.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetAccountIdentityResult(
            string principalId,

            string tenantId,

            string type)
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
        }
    }
}
