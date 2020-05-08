// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ManagedApplication.Outputs
{

    [OutputType]
    public sealed class ApplicationPlan
    {
        /// <summary>
        /// Specifies the name of the plan from the marketplace.
        /// </summary>
        public readonly string Name;
        /// <summary>
        /// Specifies the product of the plan from the marketplace.
        /// </summary>
        public readonly string Product;
        /// <summary>
        /// Specifies the promotion code to use with the plan.
        /// </summary>
        public readonly string? PromotionCode;
        /// <summary>
        /// Specifies the publisher of the plan.
        /// </summary>
        public readonly string Publisher;
        /// <summary>
        /// Specifies the version of the plan from the marketplace.
        /// </summary>
        public readonly string Version;

        [OutputConstructor]
        private ApplicationPlan(
            string name,

            string product,

            string? promotionCode,

            string publisher,

            string version)
        {
            Name = name;
            Product = product;
            PromotionCode = promotionCode;
            Publisher = publisher;
            Version = version;
        }
    }
}