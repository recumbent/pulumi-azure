// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Policy
{
    /// <summary>
    /// Manages a policy set definition. 
    /// 
    /// &gt; **NOTE:**  Policy set definitions (also known as policy initiatives) do not take effect until they are assigned to a scope using a Policy Set Assignment.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/policy_set_definition.html.markdown.
    /// </summary>
    public partial class PolicySetDefinition : Pulumi.CustomResource
    {
        /// <summary>
        /// The description of the policy set definition.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The display name of the policy set definition.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// The ID of the Management Group where this policy should be defined. Changing this forces a new resource to be created.
        /// </summary>
        [Output("managementGroupId")]
        public Output<string?> ManagementGroupId { get; private set; } = null!;

        /// <summary>
        /// The metadata for the policy set definition. This is a json object representing additional metadata that should be stored with the policy definition.
        /// </summary>
        [Output("metadata")]
        public Output<string?> Metadata { get; private set; } = null!;

        /// <summary>
        /// The name of the policy set definition. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Parameters for the policy set definition. This field is a json object that allows you to parameterize your policy definition.
        /// </summary>
        [Output("parameters")]
        public Output<string?> Parameters { get; private set; } = null!;

        /// <summary>
        /// The policy definitions for the policy set definition. This is a json object representing the bundled policy definitions .
        /// </summary>
        [Output("policyDefinitions")]
        public Output<string?> PolicyDefinitions { get; private set; } = null!;

        /// <summary>
        /// The policy set type. Possible values are `BuiltIn` or `Custom`. Changing this forces a new resource to be created.
        /// </summary>
        [Output("policyType")]
        public Output<string> PolicyType { get; private set; } = null!;


        /// <summary>
        /// Create a PolicySetDefinition resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public PolicySetDefinition(string name, PolicySetDefinitionArgs args, CustomResourceOptions? options = null)
            : base("azure:policy/policySetDefinition:PolicySetDefinition", name, args, MakeResourceOptions(options, ""))
        {
        }

        private PolicySetDefinition(string name, Input<string> id, PolicySetDefinitionState? state = null, CustomResourceOptions? options = null)
            : base("azure:policy/policySetDefinition:PolicySetDefinition", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing PolicySetDefinition resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static PolicySetDefinition Get(string name, Input<string> id, PolicySetDefinitionState? state = null, CustomResourceOptions? options = null)
        {
            return new PolicySetDefinition(name, id, state, options);
        }
    }

    public sealed class PolicySetDefinitionArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the policy set definition.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the policy set definition.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        /// <summary>
        /// The ID of the Management Group where this policy should be defined. Changing this forces a new resource to be created.
        /// </summary>
        [Input("managementGroupId")]
        public Input<string>? ManagementGroupId { get; set; }

        /// <summary>
        /// The metadata for the policy set definition. This is a json object representing additional metadata that should be stored with the policy definition.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        /// <summary>
        /// The name of the policy set definition. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Parameters for the policy set definition. This field is a json object that allows you to parameterize your policy definition.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        /// <summary>
        /// The policy definitions for the policy set definition. This is a json object representing the bundled policy definitions .
        /// </summary>
        [Input("policyDefinitions")]
        public Input<string>? PolicyDefinitions { get; set; }

        /// <summary>
        /// The policy set type. Possible values are `BuiltIn` or `Custom`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("policyType", required: true)]
        public Input<string> PolicyType { get; set; } = null!;

        public PolicySetDefinitionArgs()
        {
        }
    }

    public sealed class PolicySetDefinitionState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description of the policy set definition.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The display name of the policy set definition.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        /// <summary>
        /// The ID of the Management Group where this policy should be defined. Changing this forces a new resource to be created.
        /// </summary>
        [Input("managementGroupId")]
        public Input<string>? ManagementGroupId { get; set; }

        /// <summary>
        /// The metadata for the policy set definition. This is a json object representing additional metadata that should be stored with the policy definition.
        /// </summary>
        [Input("metadata")]
        public Input<string>? Metadata { get; set; }

        /// <summary>
        /// The name of the policy set definition. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Parameters for the policy set definition. This field is a json object that allows you to parameterize your policy definition.
        /// </summary>
        [Input("parameters")]
        public Input<string>? Parameters { get; set; }

        /// <summary>
        /// The policy definitions for the policy set definition. This is a json object representing the bundled policy definitions .
        /// </summary>
        [Input("policyDefinitions")]
        public Input<string>? PolicyDefinitions { get; set; }

        /// <summary>
        /// The policy set type. Possible values are `BuiltIn` or `Custom`. Changing this forces a new resource to be created.
        /// </summary>
        [Input("policyType")]
        public Input<string>? PolicyType { get; set; }

        public PolicySetDefinitionState()
        {
        }
    }
}
