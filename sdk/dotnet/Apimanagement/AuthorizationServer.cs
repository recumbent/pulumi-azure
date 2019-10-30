// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Apimanagement
{
    /// <summary>
    /// Manages an Authorization Server within an API Management Service.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/api_management_authorization_server.html.markdown.
    /// </summary>
    public partial class AuthorizationServer : Pulumi.CustomResource
    {
        /// <summary>
        /// The name of the API Management Service in which this Authorization Server should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Output("apiManagementName")]
        public Output<string> ApiManagementName { get; private set; } = null!;

        /// <summary>
        /// The OAUTH Authorization Endpoint.
        /// </summary>
        [Output("authorizationEndpoint")]
        public Output<string> AuthorizationEndpoint { get; private set; } = null!;

        /// <summary>
        /// The HTTP Verbs supported by the Authorization Endpoint. Possible values are `DELETE`, `GET`, `HEAD`, `OPTIONS`, `PATCH`, `POST`, `PUT` and `TRACE`.
        /// </summary>
        [Output("authorizationMethods")]
        public Output<ImmutableArray<string>> AuthorizationMethods { get; private set; } = null!;

        /// <summary>
        /// The mechanism by which Access Tokens are passed to the API. Possible values are `authorizationHeader` and `query`.
        /// </summary>
        [Output("bearerTokenSendingMethods")]
        public Output<ImmutableArray<string>> BearerTokenSendingMethods { get; private set; } = null!;

        /// <summary>
        /// The Authentication Methods supported by the Token endpoint of this Authorization Server.. Possible values are `Basic` and `Body`.
        /// </summary>
        [Output("clientAuthenticationMethods")]
        public Output<ImmutableArray<string>> ClientAuthenticationMethods { get; private set; } = null!;

        /// <summary>
        /// The Client/App ID registered with this Authorization Server.
        /// </summary>
        [Output("clientId")]
        public Output<string> ClientId { get; private set; } = null!;

        /// <summary>
        /// The URI of page where Client/App Registration is performed for this Authorization Server.
        /// </summary>
        [Output("clientRegistrationEndpoint")]
        public Output<string> ClientRegistrationEndpoint { get; private set; } = null!;

        /// <summary>
        /// The Client/App Secret registered with this Authorization Server.
        /// </summary>
        [Output("clientSecret")]
        public Output<string?> ClientSecret { get; private set; } = null!;

        /// <summary>
        /// The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.
        /// </summary>
        [Output("defaultScope")]
        public Output<string?> DefaultScope { get; private set; } = null!;

        /// <summary>
        /// A description of the Authorization Server, which may contain HTML formatting tags.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The user-friendly name of this Authorization Server.
        /// </summary>
        [Output("displayName")]
        public Output<string> DisplayName { get; private set; } = null!;

        /// <summary>
        /// Form of Authorization Grants required when requesting an Access Token. Possible values are `authorizationCode`, `clientCredentials`, `implicit` and `resourceOwnerPassword`.
        /// </summary>
        [Output("grantTypes")]
        public Output<ImmutableArray<string>> GrantTypes { get; private set; } = null!;

        /// <summary>
        /// The name of this Authorization Server. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// The password associated with the Resource Owner.
        /// </summary>
        [Output("resourceOwnerPassword")]
        public Output<string?> ResourceOwnerPassword { get; private set; } = null!;

        /// <summary>
        /// The username associated with the Resource Owner.
        /// </summary>
        [Output("resourceOwnerUsername")]
        public Output<string?> ResourceOwnerUsername { get; private set; } = null!;

        /// <summary>
        /// Does this Authorization Server support State? If this is set to `true` the client may use the state parameter to raise protocol security.
        /// </summary>
        [Output("supportState")]
        public Output<bool?> SupportState { get; private set; } = null!;

        [Output("tokenBodyParameters")]
        public Output<ImmutableArray<Outputs.AuthorizationServerTokenBodyParameters>> TokenBodyParameters { get; private set; } = null!;

        /// <summary>
        /// The OAUTH Token Endpoint.
        /// </summary>
        [Output("tokenEndpoint")]
        public Output<string?> TokenEndpoint { get; private set; } = null!;


        /// <summary>
        /// Create a AuthorizationServer resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public AuthorizationServer(string name, AuthorizationServerArgs args, CustomResourceOptions? options = null)
            : base("azure:apimanagement/authorizationServer:AuthorizationServer", name, args, MakeResourceOptions(options, ""))
        {
        }

        private AuthorizationServer(string name, Input<string> id, AuthorizationServerState? state = null, CustomResourceOptions? options = null)
            : base("azure:apimanagement/authorizationServer:AuthorizationServer", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing AuthorizationServer resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static AuthorizationServer Get(string name, Input<string> id, AuthorizationServerState? state = null, CustomResourceOptions? options = null)
        {
            return new AuthorizationServer(name, id, state, options);
        }
    }

    public sealed class AuthorizationServerArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Management Service in which this Authorization Server should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName", required: true)]
        public Input<string> ApiManagementName { get; set; } = null!;

        /// <summary>
        /// The OAUTH Authorization Endpoint.
        /// </summary>
        [Input("authorizationEndpoint", required: true)]
        public Input<string> AuthorizationEndpoint { get; set; } = null!;

        [Input("authorizationMethods", required: true)]
        private InputList<string>? _authorizationMethods;

        /// <summary>
        /// The HTTP Verbs supported by the Authorization Endpoint. Possible values are `DELETE`, `GET`, `HEAD`, `OPTIONS`, `PATCH`, `POST`, `PUT` and `TRACE`.
        /// </summary>
        public InputList<string> AuthorizationMethods
        {
            get => _authorizationMethods ?? (_authorizationMethods = new InputList<string>());
            set => _authorizationMethods = value;
        }

        [Input("bearerTokenSendingMethods")]
        private InputList<string>? _bearerTokenSendingMethods;

        /// <summary>
        /// The mechanism by which Access Tokens are passed to the API. Possible values are `authorizationHeader` and `query`.
        /// </summary>
        public InputList<string> BearerTokenSendingMethods
        {
            get => _bearerTokenSendingMethods ?? (_bearerTokenSendingMethods = new InputList<string>());
            set => _bearerTokenSendingMethods = value;
        }

        [Input("clientAuthenticationMethods")]
        private InputList<string>? _clientAuthenticationMethods;

        /// <summary>
        /// The Authentication Methods supported by the Token endpoint of this Authorization Server.. Possible values are `Basic` and `Body`.
        /// </summary>
        public InputList<string> ClientAuthenticationMethods
        {
            get => _clientAuthenticationMethods ?? (_clientAuthenticationMethods = new InputList<string>());
            set => _clientAuthenticationMethods = value;
        }

        /// <summary>
        /// The Client/App ID registered with this Authorization Server.
        /// </summary>
        [Input("clientId", required: true)]
        public Input<string> ClientId { get; set; } = null!;

        /// <summary>
        /// The URI of page where Client/App Registration is performed for this Authorization Server.
        /// </summary>
        [Input("clientRegistrationEndpoint", required: true)]
        public Input<string> ClientRegistrationEndpoint { get; set; } = null!;

        /// <summary>
        /// The Client/App Secret registered with this Authorization Server.
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.
        /// </summary>
        [Input("defaultScope")]
        public Input<string>? DefaultScope { get; set; }

        /// <summary>
        /// A description of the Authorization Server, which may contain HTML formatting tags.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The user-friendly name of this Authorization Server.
        /// </summary>
        [Input("displayName", required: true)]
        public Input<string> DisplayName { get; set; } = null!;

        [Input("grantTypes", required: true)]
        private InputList<string>? _grantTypes;

        /// <summary>
        /// Form of Authorization Grants required when requesting an Access Token. Possible values are `authorizationCode`, `clientCredentials`, `implicit` and `resourceOwnerPassword`.
        /// </summary>
        public InputList<string> GrantTypes
        {
            get => _grantTypes ?? (_grantTypes = new InputList<string>());
            set => _grantTypes = value;
        }

        /// <summary>
        /// The name of this Authorization Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// The password associated with the Resource Owner.
        /// </summary>
        [Input("resourceOwnerPassword")]
        public Input<string>? ResourceOwnerPassword { get; set; }

        /// <summary>
        /// The username associated with the Resource Owner.
        /// </summary>
        [Input("resourceOwnerUsername")]
        public Input<string>? ResourceOwnerUsername { get; set; }

        /// <summary>
        /// Does this Authorization Server support State? If this is set to `true` the client may use the state parameter to raise protocol security.
        /// </summary>
        [Input("supportState")]
        public Input<bool>? SupportState { get; set; }

        [Input("tokenBodyParameters")]
        private InputList<Inputs.AuthorizationServerTokenBodyParametersArgs>? _tokenBodyParameters;
        public InputList<Inputs.AuthorizationServerTokenBodyParametersArgs> TokenBodyParameters
        {
            get => _tokenBodyParameters ?? (_tokenBodyParameters = new InputList<Inputs.AuthorizationServerTokenBodyParametersArgs>());
            set => _tokenBodyParameters = value;
        }

        /// <summary>
        /// The OAUTH Token Endpoint.
        /// </summary>
        [Input("tokenEndpoint")]
        public Input<string>? TokenEndpoint { get; set; }

        public AuthorizationServerArgs()
        {
        }
    }

    public sealed class AuthorizationServerState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of the API Management Service in which this Authorization Server should be created. Changing this forces a new resource to be created.
        /// </summary>
        [Input("apiManagementName")]
        public Input<string>? ApiManagementName { get; set; }

        /// <summary>
        /// The OAUTH Authorization Endpoint.
        /// </summary>
        [Input("authorizationEndpoint")]
        public Input<string>? AuthorizationEndpoint { get; set; }

        [Input("authorizationMethods")]
        private InputList<string>? _authorizationMethods;

        /// <summary>
        /// The HTTP Verbs supported by the Authorization Endpoint. Possible values are `DELETE`, `GET`, `HEAD`, `OPTIONS`, `PATCH`, `POST`, `PUT` and `TRACE`.
        /// </summary>
        public InputList<string> AuthorizationMethods
        {
            get => _authorizationMethods ?? (_authorizationMethods = new InputList<string>());
            set => _authorizationMethods = value;
        }

        [Input("bearerTokenSendingMethods")]
        private InputList<string>? _bearerTokenSendingMethods;

        /// <summary>
        /// The mechanism by which Access Tokens are passed to the API. Possible values are `authorizationHeader` and `query`.
        /// </summary>
        public InputList<string> BearerTokenSendingMethods
        {
            get => _bearerTokenSendingMethods ?? (_bearerTokenSendingMethods = new InputList<string>());
            set => _bearerTokenSendingMethods = value;
        }

        [Input("clientAuthenticationMethods")]
        private InputList<string>? _clientAuthenticationMethods;

        /// <summary>
        /// The Authentication Methods supported by the Token endpoint of this Authorization Server.. Possible values are `Basic` and `Body`.
        /// </summary>
        public InputList<string> ClientAuthenticationMethods
        {
            get => _clientAuthenticationMethods ?? (_clientAuthenticationMethods = new InputList<string>());
            set => _clientAuthenticationMethods = value;
        }

        /// <summary>
        /// The Client/App ID registered with this Authorization Server.
        /// </summary>
        [Input("clientId")]
        public Input<string>? ClientId { get; set; }

        /// <summary>
        /// The URI of page where Client/App Registration is performed for this Authorization Server.
        /// </summary>
        [Input("clientRegistrationEndpoint")]
        public Input<string>? ClientRegistrationEndpoint { get; set; }

        /// <summary>
        /// The Client/App Secret registered with this Authorization Server.
        /// </summary>
        [Input("clientSecret")]
        public Input<string>? ClientSecret { get; set; }

        /// <summary>
        /// The Default Scope used when requesting an Access Token, specified as a string containing space-delimited values.
        /// </summary>
        [Input("defaultScope")]
        public Input<string>? DefaultScope { get; set; }

        /// <summary>
        /// A description of the Authorization Server, which may contain HTML formatting tags.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The user-friendly name of this Authorization Server.
        /// </summary>
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("grantTypes")]
        private InputList<string>? _grantTypes;

        /// <summary>
        /// Form of Authorization Grants required when requesting an Access Token. Possible values are `authorizationCode`, `clientCredentials`, `implicit` and `resourceOwnerPassword`.
        /// </summary>
        public InputList<string> GrantTypes
        {
            get => _grantTypes ?? (_grantTypes = new InputList<string>());
            set => _grantTypes = value;
        }

        /// <summary>
        /// The name of this Authorization Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// The name of the Resource Group in which the API Management Service exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// The password associated with the Resource Owner.
        /// </summary>
        [Input("resourceOwnerPassword")]
        public Input<string>? ResourceOwnerPassword { get; set; }

        /// <summary>
        /// The username associated with the Resource Owner.
        /// </summary>
        [Input("resourceOwnerUsername")]
        public Input<string>? ResourceOwnerUsername { get; set; }

        /// <summary>
        /// Does this Authorization Server support State? If this is set to `true` the client may use the state parameter to raise protocol security.
        /// </summary>
        [Input("supportState")]
        public Input<bool>? SupportState { get; set; }

        [Input("tokenBodyParameters")]
        private InputList<Inputs.AuthorizationServerTokenBodyParametersGetArgs>? _tokenBodyParameters;
        public InputList<Inputs.AuthorizationServerTokenBodyParametersGetArgs> TokenBodyParameters
        {
            get => _tokenBodyParameters ?? (_tokenBodyParameters = new InputList<Inputs.AuthorizationServerTokenBodyParametersGetArgs>());
            set => _tokenBodyParameters = value;
        }

        /// <summary>
        /// The OAUTH Token Endpoint.
        /// </summary>
        [Input("tokenEndpoint")]
        public Input<string>? TokenEndpoint { get; set; }

        public AuthorizationServerState()
        {
        }
    }

    namespace Inputs
    {

    public sealed class AuthorizationServerTokenBodyParametersArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of this Authorization Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public AuthorizationServerTokenBodyParametersArgs()
        {
        }
    }

    public sealed class AuthorizationServerTokenBodyParametersGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of this Authorization Server. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        public AuthorizationServerTokenBodyParametersGetArgs()
        {
        }
    }
    }

    namespace Outputs
    {

    [OutputType]
    public sealed class AuthorizationServerTokenBodyParameters
    {
        /// <summary>
        /// The name of this Authorization Server. Changing this forces a new resource to be created.
        /// </summary>
        public readonly string Name;
        public readonly string Value;

        [OutputConstructor]
        private AuthorizationServerTokenBodyParameters(
            string name,
            string value)
        {
            Name = name;
            Value = value;
        }
    }
    }
}
