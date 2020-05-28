// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ApiManagement
{
    /// <summary>
    /// Manages an API Management Named Value.
    /// 
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
    ///             Location = "West US",
    ///         });
    ///         var exampleService = new Azure.ApiManagement.Service("exampleService", new Azure.ApiManagement.ServiceArgs
    ///         {
    ///             Location = exampleResourceGroup.Location,
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             PublisherName = "pub1",
    ///             PublisherEmail = "pub1@email.com",
    ///             SkuName = "Developer_1",
    ///         });
    ///         var exampleNamedValue = new Azure.ApiManagement.NamedValue("exampleNamedValue", new Azure.ApiManagement.NamedValueArgs
    ///         {
    ///             ResourceGroupName = exampleResourceGroup.Name,
    ///             ApiManagementName = exampleService.Name,
    ///             DisplayName = "ExampleProperty",
    ///             Value = "Example Value",
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class NamedValue : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management Named Value should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("apiManagementName")]
        public Output<string> ApiManagementName { get; private set; } = null!;

        /// <summary>
        /// The display name of this API Management Named Value.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The name of the API Management Named Value. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the API Management Named Value should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Specifies whether the API Management Named Value is secret. Valid values are `true` or `false`. The default value is `false`.
        /// </summary>
        [Output("secret")]
        public Output<bool?> Secret { get; private set; } = null!;

        /// <summary>
        /// A list of tags to be applied to the API Management Named Value.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// The value of this API Management Named Value.
        /// </summary>
        [Output("value")]
        public Output<string> Value { get; private set; } = null!;


        /// <summary>
        /// Create a NamedValue resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NamedValue(string name, NamedValueArgs args, CustomResourceOptions? options = null)
            : base("azure:apimanagement/namedValue:NamedValue", name, args ?? new NamedValueArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NamedValue(string name, Input<string> id, NamedValueState? state = null, CustomResourceOptions? options = null)
            : base("azure:apimanagement/namedValue:NamedValue", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing NamedValue resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NamedValue Get(string name, Input<string> id, NamedValueState? state = null, CustomResourceOptions? options = null)
        {
            return new NamedValue(name, id, state, options);
        }
    }

    public sealed class NamedValueArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management Named Value should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public Input<string> ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The display name of this API Management Named Value.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// The name of the API Management Named Value. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the API Management Named Value should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Specifies whether the API Management Named Value is secret. Valid values are `true` or `false`. The default value is `false`.
        /// </summary>
        [Input("secret")]
        public Input<bool>? Secret { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to be applied to the API Management Named Value.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The value of this API Management Named Value.
        /// </summary>
        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public NamedValueArgs()
        {
        }
    }

    public sealed class NamedValueState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Management Service in which the API Management Named Value should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName")]
        public Input<string>? ApiManagementName { get; set; }

        /// <summary>
        /// The display name of this API Management Named Value.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The name of the API Management Named Value. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the API Management Named Value should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Specifies whether the API Management Named Value is secret. Valid values are `true` or `false`. The default value is `false`.
        /// </summary>
        [Input("secret")]
        public Input<bool>? Secret { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// A list of tags to be applied to the API Management Named Value.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// The value of this API Management Named Value.
        /// </summary>
        [Input("value")]
        public Input<string>? Value { get; set; }

        public NamedValueState()
        {
        }
    }
}
