// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Compute
{
    public static class GetPlatformImage
    {
        /// <summary>
        /// Use this data source to access information about a Platform Image.
        /// 
        /// {{% examples %}}
        /// ## Example Usage
        /// {{% example %}}
        /// 
        /// ```csharp
        /// using Pulumi;
        /// using Azure = Pulumi.Azure;
        /// 
        /// class MyStack : Stack
        /// {
        ///     public MyStack()
        ///     {
        ///         var example = Output.Create(Azure.Compute.GetPlatformImage.InvokeAsync(new Azure.Compute.GetPlatformImageArgs
        ///         {
        ///             Location = "West Europe",
        ///             Publisher = "Canonical",
        ///             Offer = "UbuntuServer",
        ///             Sku = "16.04-LTS",
        ///         }));
        ///         this.Id = example.Apply(example =&gt; example.Id);
        ///     }
        /// 
        ///     [Output("id")]
        ///     public Output&lt;string&gt; Id { get; set; }
        /// }
        /// ```
        /// 
        /// {{% /example %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetPlatformImageResult> InvokeAsync(GetPlatformImageArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetPlatformImageResult>("azure:compute/getPlatformImage:getPlatformImage", args ?? new GetPlatformImageArgs(), options.WithVersion());
    }


    public sealed class GetPlatformImageArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the Location to pull information about this Platform Image from.
        /// </summary>
        [Input("location", required: true)]
        public string Location { get; set; } = null!;

        /// <summary>
        /// Specifies the Offer associated with the Platform Image.
        /// </summary>
        [Input("offer", required: true)]
        public string Offer { get; set; } = null!;

        /// <summary>
        /// Specifies the Publisher associated with the Platform Image.
        /// </summary>
        [Input("publisher", required: true)]
        public string Publisher { get; set; } = null!;

        /// <summary>
        /// Specifies the SKU of the Platform Image.
        /// </summary>
        [Input("sku", required: true)]
        public string Sku { get; set; } = null!;

        /// <summary>
        /// The version of the Platform Image.
        /// </summary>
        [Input("version")]
        public string? Version { get; set; }

        public GetPlatformImageArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetPlatformImageResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Location;
        public readonly string Offer;
        public readonly string Publisher;
        public readonly string Sku;
        public readonly string Version;

        [OutputConstructor]
        private GetPlatformImageResult(
            string id,

            string location,

            string offer,

            string publisher,

            string sku,

            string version)
        {
            Id = id;
            Location = location;
            Offer = offer;
            Publisher = publisher;
            Sku = sku;
            Version = version;
        }
    }
}
