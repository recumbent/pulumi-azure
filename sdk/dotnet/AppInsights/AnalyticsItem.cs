// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppInsights
{
    /// <summary>
    /// Manages an Application Insights Analytics Item component.
    /// 
    /// ## Example Usage
    /// 
    /// 
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var exampleResourceGroup = new Azure.Core.ResourceGroup("exampleResourceGroup", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West Europe",
    ///         });
    ///         var exampleInsights = new Azure.AppInsights.Insights("exampleInsights", new Azure.AppInsights.InsightsArgs
    ///         {
    ///             Location = "West Europe",
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             ApplicationType = "web",
    ///         });
    ///         var exampleAnalyticsItem = new Azure.AppInsights.AnalyticsItem("exampleAnalyticsItem", new Azure.AppInsights.AnalyticsItemArgs
    ///         {
    ///             ApplicationInsightsId = exampleInsights.Id,
    ///             Content = "requests //simple example query",
    ///             Scope = "shared",
    ///             Type = "query",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class AnalyticsItem : Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of the Application Insights component on which the Analytics Item exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("applicationInsightsId")]
        public Output<string> ApplicationInsightsId { get; private set; } = null!;

        /// <summary>
        /// The content for the Analytics Item, for example the query text if `type` is `query`.
        /// </summary>
        [Output("content")]
        public Output<string> Content { get; private set; } = null!;

        /// <summary>
        /// The alias to use for the function. Required when `type` is `function`.
        /// </summary>
        [Output("functionAlias")]
        public Output<string?> FunctionAlias { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Application Insights Analytics Item. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The scope for the Analytics Item. Can be `shared` or `user`. Changing this forces a new resource to be created. Must be `shared` for functions.
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;

        /// <summary>
        /// A string containing the time the Analytics Item was created.
        /// </summary>
        [Output("timeCreated")]
        public Output<string> TimeCreated { get; private set; } = null!;

        /// <summary>
        /// A string containing the time the Analytics Item was last modified.
        /// </summary>
        [Output("timeModified")]
        public Output<string> TimeModified { get; private set; } = null!;

        /// <summary>
        /// The type of Analytics Item to create. Can be one of `query`, `function`, `folder`, `recent`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("type")]
        public Output<string> Type { get; private set; } = null!;

        /// <summary>
        /// A string indicating the version of the query format
        /// </summary>
        [Output("version")]
        public Output<string> Version { get; private set; } = null!;


        /// <summary>
        /// Create a AnalyticsItem resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AnalyticsItem(string name, AnalyticsItemArgs args, CustomResourceOptions? options = null)
            : base("azure:appinsights/analyticsItem:AnalyticsItem", name, args ?? new AnalyticsItemArgs(), MakeResourceOptions(options, ""))
        {
        }

        private AnalyticsItem(string name, Input<string> id, AnalyticsItemState? state = null, CustomResourceOptions? options = null)
            : base("azure:appinsights/analyticsItem:AnalyticsItem", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing AnalyticsItem resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AnalyticsItem Get(string name, Input<string> id, AnalyticsItemState? state = null, CustomResourceOptions? options = null)
        {
            return new AnalyticsItem(name, id, state, options);
        }
    }

    public sealed class AnalyticsItemArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Application Insights component on which the Analytics Item exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("applicationInsightsId", required: true)]
        public Input<string> ApplicationInsightsId { get; set; } = null!;

        /// <summary>
        /// The content for the Analytics Item, for example the query text if `type` is `query`.
        /// </summary>
        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        /// <summary>
        /// The alias to use for the function. Required when `type` is `function`.
        /// </summary>
        [Input("functionAlias")]
        public Input<string>? FunctionAlias { get; set; }

        /// <summary>
        /// Specifies the name of the Application Insights Analytics Item. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope for the Analytics Item. Can be `shared` or `user`. Changing this forces a new resource to be created. Must be `shared` for functions.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// The type of Analytics Item to create. Can be one of `query`, `function`, `folder`, `recent`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public AnalyticsItemArgs()
        {
        }
    }

    public sealed class AnalyticsItemState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of the Application Insights component on which the Analytics Item exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("applicationInsightsId")]
        public Input<string>? ApplicationInsightsId { get; set; }

        /// <summary>
        /// The content for the Analytics Item, for example the query text if `type` is `query`.
        /// </summary>
        [Input("content")]
        public Input<string>? Content { get; set; }

        /// <summary>
        /// The alias to use for the function. Required when `type` is `function`.
        /// </summary>
        [Input("functionAlias")]
        public Input<string>? FunctionAlias { get; set; }

        /// <summary>
        /// Specifies the name of the Application Insights Analytics Item. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The scope for the Analytics Item. Can be `shared` or `user`. Changing this forces a new resource to be created. Must be `shared` for functions.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// A string containing the time the Analytics Item was created.
        /// </summary>
        [Input("timeCreated")]
        public Input<string>? TimeCreated { get; set; }

        /// <summary>
        /// A string containing the time the Analytics Item was last modified.
        /// </summary>
        [Input("timeModified")]
        public Input<string>? TimeModified { get; set; }

        /// <summary>
        /// The type of Analytics Item to create. Can be one of `query`, `function`, `folder`, `recent`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        /// <summary>
        /// A string indicating the version of the query format
        /// </summary>
        [Input("version")]
        public Input<string>? Version { get; set; }

        public AnalyticsItemState()
        {
        }
    }
}
