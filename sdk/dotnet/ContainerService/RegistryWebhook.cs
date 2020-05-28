// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.ContainerService
{
    /// <summary>
    /// Manages an Azure Container Registry Webhook.
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
    ///         var rg = new Azure.Core.ResourceGroup("rg", new Azure.Core.ResourceGroupArgs
    ///         {
    ///             Location = "West US",
    ///         });
    ///         var acr = new Azure.ContainerService.Registry("acr", new Azure.ContainerService.RegistryArgs
    ///         {
    ///             ResourceGroupName = rg.Name,
    ///             Location = rg.Location,
    ///             Sku = "Standard",
    ///             AdminEnabled = false,
    ///         });
    ///         var webhook = new Azure.ContainerService.RegistryWebhook("webhook", new Azure.ContainerService.RegistryWebhookArgs
    ///         {
    ///             ResourceGroupName = rg.Name,
    ///             RegistryName = acr.Name,
    ///             Location = rg.Location,
    ///             ServiceUri = "https://mywebhookreceiver.example/mytag",
    ///             Status = "enabled",
    ///             Scope = "mytag:*",
    ///             Actions = 
    ///             {
    ///                 "push",
    ///             },
    ///             CustomHeaders = 
    ///             {
    ///                 { "Content-Type", "application/json" },
    ///             },
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    public partial class RegistryWebhook : Pulumi.CustomResource
    {
        /// <summary>
        /// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chart_push`, `chart_delete`
        /// </summary>
        [Output("actions")]
        public Output<ImmutableArray<string>> Actions { get; private set; } = null!;

        /// <summary>
        /// Custom headers that will be added to the webhook notifications request.
        /// </summary>
        [Output("customHeaders")]
        public Output<ImmutableDictionary<string, string>?> CustomHeaders { get; private set; } = null!;

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
        /// </summary>
        [Output("registryName")]
        public Output<string> RegistryName { get; private set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
        /// </summary>
        [Output("scope")]
        public Output<string?> Scope { get; private set; } = null!;

        /// <summary>
        /// Specifies the service URI for the Webhook to post notifications.
        /// </summary>
        [Output("serviceUri")]
        public Output<string> ServiceUri { get; private set; } = null!;

        /// <summary>
        /// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
        /// </summary>
        [Output("status")]
        public Output<string?> Status { get; private set; } = null!;

        [Output("tags")]
        public Output<ImmutableDictionary<string, string>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a RegistryWebhook resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RegistryWebhook(string name, RegistryWebhookArgs args, CustomResourceOptions? options = null)
            : base("azure:containerservice/registryWebhook:RegistryWebhook", name, args ?? new RegistryWebhookArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RegistryWebhook(string name, Input<string> id, RegistryWebhookState? state = null, CustomResourceOptions? options = null)
            : base("azure:containerservice/registryWebhook:RegistryWebhook", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                Aliases =
                {
                    new Alias { Type = "azure:containerservice/registryWebook:RegistryWebook"},
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing RegistryWebhook resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RegistryWebhook Get(string name, Input<string> id, RegistryWebhookState? state = null, CustomResourceOptions? options = null)
        {
            return new RegistryWebhook(name, id, state, options);
        }
    }

    public sealed class RegistryWebhookArgs : Pulumi.ResourceArgs
    {
        [Input("actions", required: true)]
        private InputList<string>? _actions;

        /// <summary>
        /// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chart_push`, `chart_delete`
        /// </summary>
        public InputList<string> Actions
        {
            get => _actions ?? (_actions = new InputList<string>());
            set => _actions = value;
        }

        [Input("customHeaders")]
        private InputMap<string>? _customHeaders;

        /// <summary>
        /// Custom headers that will be added to the webhook notifications request.
        /// </summary>
        public InputMap<string> CustomHeaders
        {
            get => _customHeaders ?? (_customHeaders = new InputMap<string>());
            set => _customHeaders = value;
        }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("registryName", required: true)]
        public Input<string> RegistryName { get; set; } = null!;

        /// <summary>
        /// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Specifies the service URI for the Webhook to post notifications.
        /// </summary>
        [Input("serviceUri", required: true)]
        public Input<string> ServiceUri { get; set; } = null!;

        /// <summary>
        /// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public RegistryWebhookArgs()
        {
        }
    }

    public sealed class RegistryWebhookState : Pulumi.ResourceArgs
    {
        [Input("actions")]
        private InputList<string>? _actions;

        /// <summary>
        /// A list of actions that trigger the Webhook to post notifications. At least one action needs to be specified. Valid values are: `push`, `delete`, `quarantine`, `chart_push`, `chart_delete`
        /// </summary>
        public InputList<string> Actions
        {
            get => _actions ?? (_actions = new InputList<string>());
            set => _actions = value;
        }

        [Input("customHeaders")]
        private InputMap<string>? _customHeaders;

        /// <summary>
        /// Custom headers that will be added to the webhook notifications request.
        /// </summary>
        public InputMap<string> CustomHeaders
        {
            get => _customHeaders ?? (_customHeaders = new InputMap<string>());
            set => _customHeaders = value;
        }

        /// <summary>
        /// Specifies the supported Azure location where the resource exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// Specifies the name of the Container Registry Webhook. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The Name of Container registry this Webhook belongs to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("registryName")]
        public Input<string>? RegistryName { get; set; }

        /// <summary>
        /// The name of the resource group in which to create the Container Registry Webhook. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Specifies the scope of repositories that can trigger an event. For example, `foo:*` means events for all tags under repository `foo`. `foo:bar` means events for 'foo:bar' only. `foo` is equivalent to `foo:latest`. Empty means all events.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// Specifies the service URI for the Webhook to post notifications.
        /// </summary>
        [Input("serviceUri")]
        public Input<string>? ServiceUri { get; set; }

        /// <summary>
        /// Specifies if this Webhook triggers notifications or not. Valid values: `enabled` and `disabled`. Default is `enabled`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputMap<string>? _tags;
        public InputMap<string> Tags
        {
            get => _tags ?? (_tags = new InputMap<string>());
            set => _tags = value;
        }

        public RegistryWebhookState()
        {
        }
    }
}
