// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Authorization
{
    public static class GetRoleDefinition
    {
        /// <summary>
        /// Use this data source to access information about an existing Role Definition.
        /// 
        /// {{% examples %}}
        /// {{% /examples %}}
        /// </summary>
        public static Task<GetRoleDefinitionResult> InvokeAsync(GetRoleDefinitionArgs? args = null, InvokeOptions? options = null)
            => Pulumi.Deployment.Instance.InvokeAsync<GetRoleDefinitionResult>("azure:authorization/getRoleDefinition:getRoleDefinition", args ?? new GetRoleDefinitionArgs(), options.WithVersion());
    }


    public sealed class GetRoleDefinitionArgs : Pulumi.InvokeArgs
    {
        /// <summary>
        /// Specifies the Name of either a built-in or custom Role Definition.
        /// </summary>
        [Input("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Specifies the ID of the Role Definition as a UUID/GUID.
        /// </summary>
        [Input("roleDefinitionId")]
        public string? RoleDefinitionId { get; set; }

        /// <summary>
        /// Specifies the Scope at which the Custom Role Definition exists.
        /// </summary>
        [Input("scope")]
        public string? Scope { get; set; }

        public GetRoleDefinitionArgs()
        {
        }
    }


    [OutputType]
    public sealed class GetRoleDefinitionResult
    {
        /// <summary>
        /// One or more assignable scopes for this Role Definition, such as `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333`, `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup`, or `/subscriptions/0b1f6471-1bf0-4dda-aec3-111122223333/resourceGroups/myGroup/providers/Microsoft.Compute/virtualMachines/myVM`.
        /// </summary>
        public readonly ImmutableArray<string> AssignableScopes;
        /// <summary>
        /// the Description of the built-in Role.
        /// </summary>
        public readonly string Description;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Name;
        /// <summary>
        /// a `permissions` block as documented below.
        /// </summary>
        public readonly ImmutableArray<Outputs.GetRoleDefinitionPermissionResult> Permissions;
        public readonly string RoleDefinitionId;
        public readonly string? Scope;
        /// <summary>
        /// the Type of the Role.
        /// </summary>
        public readonly string Type;

        [OutputConstructor]
        private GetRoleDefinitionResult(
            ImmutableArray<string> assignableScopes,

            string description,

            string id,

            string name,

            ImmutableArray<Outputs.GetRoleDefinitionPermissionResult> permissions,

            string roleDefinitionId,

            string? scope,

            string type)
        {
            AssignableScopes = assignableScopes;
            Description = description;
            Id = id;
            Name = name;
            Permissions = permissions;
            RoleDefinitionId = roleDefinitionId;
            Scope = scope;
            Type = type;
        }
    }
}
