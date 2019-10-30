// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Appinsights
{
    public static partial class Invokes
    {
        /// <summary>
        /// Use this data source to access information about an existing Application Insights component.
        /// 
        /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/d/application_insights.html.markdown.
        /// </summary>
        public static Task<GetInsightsResult> GetInsights(GetInsightsArgs args, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetInsightsResult>("azure:appinsights/getInsights:getInsights", args, options.WithVersion());
    }

    public sealed class GetInsightsArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the name of the Application Insights component.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// Specifies the name of the resource group the Application Insights component is located in.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        public GetInsightsArgs()
        {
        }
    }

    [OutputType]
    public sealed class GetInsightsResult
    {
        /// <summary>
        /// The App ID associated with this Application Insights component.
        /// </summary>
        public readonly string AppId;
        /// <summary>
        /// The type of the component.
        /// </summary>
        public readonly string ApplicationType;
        /// <summary>
        /// The instrumentation key of the Application Insights component.
        /// </summary>
        public readonly string InstrumentationKey;
        /// <summary>
        /// The Azure location where the component exists.
        /// </summary>
        public readonly string Location;
        public readonly string Name;
        public readonly string ResourceGroupName;
        /// <summary>
        /// Tags applied to the component.
        /// </summary>
        public readonly ImmutableDictionary<string, string> Tags;
        /// <summary>
        /// id is the provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;

        [OutputConstructor]
        private GetInsightsResult(
            string appId,
            string applicationType,
            string instrumentationKey,
            string location,
            string name,
            string resourceGroupName,
            ImmutableDictionary<string, string> tags,
            string id)
        {
            AppId = appId;
            ApplicationType = applicationType;
            InstrumentationKey = instrumentationKey;
            Location = location;
            Name = name;
            ResourceGroupName = resourceGroupName;
            Tags = tags;
            Id = id;
        }
    }
}
