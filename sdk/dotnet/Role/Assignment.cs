// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Role
{
    /// <summary>
    /// Assigns a given Principal (User or Group) to a given Role.
    /// 
    /// ## Example Usage (using a built-in Role)
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var primary = Output.Create(Azure.Core.GetSubscription.InvokeAsync());
    ///         var exampleClientConfig = Output.Create(Azure.Core.GetClientConfig.InvokeAsync());
    ///         var exampleAssignment = new Azure.Authorization.Assignment("exampleAssignment", new Azure.Authorization.AssignmentArgs
    ///         {
    ///             Scope = primary.Apply(primary =&gt; primary.Id),
    ///             RoleDefinitionName = "Reader",
    ///             PrincipalId = exampleClientConfig.Apply(exampleClientConfig =&gt; exampleClientConfig.ObjectId),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Example Usage (Custom Role &amp; Service Principal)
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var primary = Output.Create(Azure.Core.GetSubscription.InvokeAsync());
    ///         var exampleClientConfig = Output.Create(Azure.Core.GetClientConfig.InvokeAsync());
    ///         var exampleRoleDefinition = new Azure.Authorization.RoleDefinition("exampleRoleDefinition", new Azure.Authorization.RoleDefinitionArgs
    ///         {
    ///             RoleDefinitionId = "00000000-0000-0000-0000-000000000000",
    ///             Scope = primary.Apply(primary =&gt; primary.Id),
    ///             Permissions = 
    ///             {
    ///                 new Azure.Authorization.Inputs.RoleDefinitionPermissionArgs
    ///                 {
    ///                     Actions = 
    ///                     {
    ///                         "Microsoft.Resources/subscriptions/resourceGroups/read",
    ///                     },
    ///                     NotActions = {},
    ///                 },
    ///             },
    ///             AssignableScopes = 
    ///             {
    ///                 primary.Apply(primary =&gt; primary.Id),
    ///             },
    ///         });
    ///         var exampleAssignment = new Azure.Authorization.Assignment("exampleAssignment", new Azure.Authorization.AssignmentArgs
    ///         {
    ///             Name = "00000000-0000-0000-0000-000000000000",
    ///             Scope = primary.Apply(primary =&gt; primary.Id),
    ///             RoleDefinitionId = exampleRoleDefinition.Id,
    ///             PrincipalId = exampleClientConfig.Apply(exampleClientConfig =&gt; exampleClientConfig.ObjectId),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Example Usage (Custom Role &amp; User)
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var primary = Output.Create(Azure.Core.GetSubscription.InvokeAsync());
    ///         var exampleClientConfig = Output.Create(Azure.Core.GetClientConfig.InvokeAsync());
    ///         var exampleRoleDefinition = new Azure.Authorization.RoleDefinition("exampleRoleDefinition", new Azure.Authorization.RoleDefinitionArgs
    ///         {
    ///             RoleDefinitionId = "00000000-0000-0000-0000-000000000000",
    ///             Scope = primary.Apply(primary =&gt; primary.Id),
    ///             Permissions = 
    ///             {
    ///                 new Azure.Authorization.Inputs.RoleDefinitionPermissionArgs
    ///                 {
    ///                     Actions = 
    ///                     {
    ///                         "Microsoft.Resources/subscriptions/resourceGroups/read",
    ///                     },
    ///                     NotActions = {},
    ///                 },
    ///             },
    ///             AssignableScopes = 
    ///             {
    ///                 primary.Apply(primary =&gt; primary.Id),
    ///             },
    ///         });
    ///         var exampleAssignment = new Azure.Authorization.Assignment("exampleAssignment", new Azure.Authorization.AssignmentArgs
    ///         {
    ///             Name = "00000000-0000-0000-0000-000000000000",
    ///             Scope = primary.Apply(primary =&gt; primary.Id),
    ///             RoleDefinitionId = exampleRoleDefinition.Id,
    ///             PrincipalId = exampleClientConfig.Apply(exampleClientConfig =&gt; exampleClientConfig.ClientId),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// 
    /// ## Example Usage (Custom Role &amp; Management Group)
    /// 
    /// ```csharp
    /// using Pulumi;
    /// using Azure = Pulumi.Azure;
    /// 
    /// class MyStack : Stack
    /// {
    ///     public MyStack()
    ///     {
    ///         var primary = Output.Create(Azure.Core.GetSubscription.InvokeAsync());
    ///         var exampleClientConfig = Output.Create(Azure.Core.GetClientConfig.InvokeAsync());
    ///         var exampleGroup = Output.Create(Azure.Management.GetGroup.InvokeAsync());
    ///         var exampleRoleDefinition = new Azure.Authorization.RoleDefinition("exampleRoleDefinition", new Azure.Authorization.RoleDefinitionArgs
    ///         {
    ///             RoleDefinitionId = "00000000-0000-0000-0000-000000000000",
    ///             Scope = primary.Apply(primary =&gt; primary.Id),
    ///             Permissions = 
    ///             {
    ///                 new Azure.Authorization.Inputs.RoleDefinitionPermissionArgs
    ///                 {
    ///                     Actions = 
    ///                     {
    ///                         "Microsoft.Resources/subscriptions/resourceGroups/read",
    ///                     },
    ///                     NotActions = {},
    ///                 },
    ///             },
    ///             AssignableScopes = 
    ///             {
    ///                 primary.Apply(primary =&gt; primary.Id),
    ///             },
    ///         });
    ///         var exampleAssignment = new Azure.Authorization.Assignment("exampleAssignment", new Azure.Authorization.AssignmentArgs
    ///         {
    ///             Name = "00000000-0000-0000-0000-000000000000",
    ///             Scope = data.Azurerm_management_group.Primary.Id,
    ///             RoleDefinitionId = exampleRoleDefinition.Id,
    ///             PrincipalId = exampleClientConfig.Apply(exampleClientConfig =&gt; exampleClientConfig.ClientId),
    ///         });
    ///     }
    /// 
    /// }
    /// ```
    /// </summary>
    [Obsolete(@"azure.role.Assignment has been deprecated in favor of azure.authorization.Assignment")]
    public partial class Assignment : Pulumi.CustomResource
    {
        /// <summary>
        /// A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The ID of the Principal (User, Group or Service Principal) to assign the Role Definition to. Changing this forces a new resource to be created.
        /// </summary>
        [Output("principalId")]
        public Output<string> PrincipalId { get; private set; } = null!;

        /// <summary>
        /// The type of the `principal_id`, e.g. User, Group, Service Principal, Application, etc.
        /// </summary>
        [Output("principalType")]
        public Output<string> PrincipalType { get; private set; } = null!;

        /// <summary>
        /// The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `role_definition_name`.
        /// </summary>
        [Output("roleDefinitionId")]
        public Output<string> RoleDefinitionId { get; private set; } = null!;

        /// <summary>
        /// The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `role_definition_id`.
        /// </summary>
        [Output("roleDefinitionName")]
        public Output<string> RoleDefinitionName { get; private set; } = null!;

        /// <summary>
        /// The scope at which the Role Assignment applies to, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`, or `/providers/Microsoft.Management/managementGroups/myMG`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("scope")]
        public Output<string> Scope { get; private set; } = null!;

        /// <summary>
        /// If the `principal_id` is a newly provisioned `Service Principal` set this value to `true` to skip the `Azure Active Directory` check which may fail due to replication lag. This argument is only valid if the `principal_id` is a `Service Principal` identity. If it is not a `Service Principal` identity it will cause the role assignment to fail. Defaults to `false`.
        /// </summary>
        [Output("skipServicePrincipalAadCheck")]
        public Output<bool> SkipServicePrincipalAadCheck { get; private set; } = null!;


        /// <summary>
        /// Create a Assignment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Assignment(string name, AssignmentArgs args, CustomResourceOptions? options = null)
            : base("azure:role/assignment:Assignment", name, args ?? new AssignmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Assignment(string name, Input<string> id, AssignmentState? state = null, CustomResourceOptions? options = null)
            : base("azure:role/assignment:Assignment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Assignment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Assignment Get(string name, Input<string> id, AssignmentState? state = null, CustomResourceOptions? options = null)
        {
            return new Assignment(name, id, state, options);
        }
    }

    public sealed class AssignmentArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the Principal (User, Group or Service Principal) to assign the Role Definition to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("principalId", required: true)]
        public Input<string> PrincipalId { get; set; } = null!;

        /// <summary>
        /// The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `role_definition_name`.
        /// </summary>
        [Input("roleDefinitionId")]
        public Input<string>? RoleDefinitionId { get; set; }

        /// <summary>
        /// The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `role_definition_id`.
        /// </summary>
        [Input("roleDefinitionName")]
        public Input<string>? RoleDefinitionName { get; set; }

        /// <summary>
        /// The scope at which the Role Assignment applies to, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`, or `/providers/Microsoft.Management/managementGroups/myMG`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("scope", required: true)]
        public Input<string> Scope { get; set; } = null!;

        /// <summary>
        /// If the `principal_id` is a newly provisioned `Service Principal` set this value to `true` to skip the `Azure Active Directory` check which may fail due to replication lag. This argument is only valid if the `principal_id` is a `Service Principal` identity. If it is not a `Service Principal` identity it will cause the role assignment to fail. Defaults to `false`.
        /// </summary>
        [Input("skipServicePrincipalAadCheck")]
        public Input<bool>? SkipServicePrincipalAadCheck { get; set; }

        public AssignmentArgs()
        {
        }
    }

    public sealed class AssignmentState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// A unique UUID/GUID for this Role Assignment - one will be generated if not specified. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The ID of the Principal (User, Group or Service Principal) to assign the Role Definition to. Changing this forces a new resource to be created.
        /// </summary>
        [Input("principalId")]
        public Input<string>? PrincipalId { get; set; }

        /// <summary>
        /// The type of the `principal_id`, e.g. User, Group, Service Principal, Application, etc.
        /// </summary>
        [Input("principalType")]
        public Input<string>? PrincipalType { get; set; }

        /// <summary>
        /// The Scoped-ID of the Role Definition. Changing this forces a new resource to be created. Conflicts with `role_definition_name`.
        /// </summary>
        [Input("roleDefinitionId")]
        public Input<string>? RoleDefinitionId { get; set; }

        /// <summary>
        /// The name of a built-in Role. Changing this forces a new resource to be created. Conflicts with `role_definition_id`.
        /// </summary>
        [Input("roleDefinitionName")]
        public Input<string>? RoleDefinitionName { get; set; }

        /// <summary>
        /// The scope at which the Role Assignment applies to, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`, or `/providers/Microsoft.Management/managementGroups/myMG`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("scope")]
        public Input<string>? Scope { get; set; }

        /// <summary>
        /// If the `principal_id` is a newly provisioned `Service Principal` set this value to `true` to skip the `Azure Active Directory` check which may fail due to replication lag. This argument is only valid if the `principal_id` is a `Service Principal` identity. If it is not a `Service Principal` identity it will cause the role assignment to fail. Defaults to `false`.
        /// </summary>
        [Input("skipServicePrincipalAadCheck")]
        public Input<bool>? SkipServicePrincipalAadCheck { get; set; }

        public AssignmentState()
        {
        }
    }
}
