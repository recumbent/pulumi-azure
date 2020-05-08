// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Inputs
{

    public sealed class FunctionAppSlotAuthSettingsGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// An `active_directory` block as defined below.
        /// </summary>
        [Input("activeDirectory")]
        public Input<Inputs.FunctionAppSlotAuthSettingsActiveDirectoryGetArgs>? ActiveDirectory { get; set; }

        [Input("additionalLoginParams")]
        private InputMap<string>? _additionalLoginParams;

        /// <summary>
        /// Login parameters to send to the OpenID Connect authorization endpoint when a user logs in. Each parameter must be in the form "key=value".
        /// </summary>
        public InputMap<string> AdditionalLoginParams
        {
            get => _additionalLoginParams ?? (_additionalLoginParams = new InputMap<string>());
            set => _additionalLoginParams = value;
        }

        [Input("allowedExternalRedirectUrls")]
        private InputList<string>? _allowedExternalRedirectUrls;

        /// <summary>
        /// External URLs that can be redirected to as part of logging in or logging out of the app.
        /// </summary>
        public InputList<string> AllowedExternalRedirectUrls
        {
            get => _allowedExternalRedirectUrls ?? (_allowedExternalRedirectUrls = new InputList<string>());
            set => _allowedExternalRedirectUrls = value;
        }

        /// <summary>
        /// The default provider to use when multiple providers have been set up. Possible values are `AzureActiveDirectory`, `Facebook`, `Google`, `MicrosoftAccount` and `Twitter`.
        /// </summary>
        [Input("defaultProvider")]
        public Input<string>? DefaultProvider { get; set; }

        /// <summary>
        /// Is Authentication enabled?
        /// </summary>
        [Input("enabled", required: true)]
        public Input<bool> Enabled { get; set; } = null!;

        /// <summary>
        /// A `facebook` block as defined below.
        /// </summary>
        [Input("facebook")]
        public Input<Inputs.FunctionAppSlotAuthSettingsFacebookGetArgs>? Facebook { get; set; }

        /// <summary>
        /// A `google` block as defined below.
        /// </summary>
        [Input("google")]
        public Input<Inputs.FunctionAppSlotAuthSettingsGoogleGetArgs>? Google { get; set; }

        /// <summary>
        /// Issuer URI. When using Azure Active Directory, this value is the URI of the directory tenant, e.g. https://sts.windows.net/{tenant-guid}/.
        /// </summary>
        [Input("issuer")]
        public Input<string>? Issuer { get; set; }

        /// <summary>
        /// A `microsoft` block as defined below.
        /// </summary>
        [Input("microsoft")]
        public Input<Inputs.FunctionAppSlotAuthSettingsMicrosoftGetArgs>? Microsoft { get; set; }

        /// <summary>
        /// The runtime version of the Authentication/Authorization module.
        /// </summary>
        [Input("runtimeVersion")]
        public Input<string>? RuntimeVersion { get; set; }

        /// <summary>
        /// The number of hours after session token expiration that a session token can be used to call the token refresh API. Defaults to 72.
        /// </summary>
        [Input("tokenRefreshExtensionHours")]
        public Input<double>? TokenRefreshExtensionHours { get; set; }

        /// <summary>
        /// If enabled the module will durably store platform-specific security tokens that are obtained during login flows. Defaults to false.
        /// </summary>
        [Input("tokenStoreEnabled")]
        public Input<bool>? TokenStoreEnabled { get; set; }

        /// <summary>
        /// A `twitter` block as defined below.
        /// </summary>
        [Input("twitter")]
        public Input<Inputs.FunctionAppSlotAuthSettingsTwitterGetArgs>? Twitter { get; set; }

        /// <summary>
        /// The action to take when an unauthenticated client attempts to access the app. Possible values are `AllowAnonymous` and `RedirectToLoginPage`.
        /// </summary>
        [Input("unauthenticatedClientAction")]
        public Input<string>? UnauthenticatedClientAction { get; set; }

        public FunctionAppSlotAuthSettingsGetArgs()
        {
        }
    }
}