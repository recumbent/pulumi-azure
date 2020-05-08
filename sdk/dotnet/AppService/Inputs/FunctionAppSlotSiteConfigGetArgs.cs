// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.AppService.Inputs
{

    public sealed class FunctionAppSlotSiteConfigGetArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Should the Function App be loaded at all times? Defaults to `false`.
        /// </summary>
        [Input("alwaysOn")]
        public Input<bool>? AlwaysOn { get; set; }

        /// <summary>
        /// A `cors` block as defined below.
        /// </summary>
        [Input("cors")]
        public Input<Inputs.FunctionAppSlotSiteConfigCorsGetArgs>? Cors { get; set; }

        /// <summary>
        /// State of FTP / FTPS service for this function app. Possible values include: `AllAllowed`, `FtpsOnly` and `Disabled`.
        /// </summary>
        [Input("ftpsState")]
        public Input<string>? FtpsState { get; set; }

        /// <summary>
        /// Specifies whether or not the http2 protocol should be enabled. Defaults to `false`.
        /// </summary>
        [Input("http2Enabled")]
        public Input<bool>? Http2Enabled { get; set; }

        [Input("ipRestrictions")]
        private InputList<Inputs.FunctionAppSlotSiteConfigIpRestrictionGetArgs>? _ipRestrictions;

        /// <summary>
        /// A [List of objects](https://www.terraform.io/docs/configuration/attr-as-blocks.html) representing ip restrictions as defined below.
        /// </summary>
        public InputList<Inputs.FunctionAppSlotSiteConfigIpRestrictionGetArgs> IpRestrictions
        {
            get => _ipRestrictions ?? (_ipRestrictions = new InputList<Inputs.FunctionAppSlotSiteConfigIpRestrictionGetArgs>());
            set => _ipRestrictions = value;
        }

        /// <summary>
        /// Linux App Framework and version for the AppService, e.g. `DOCKER|(golang:latest)`.
        /// </summary>
        [Input("linuxFxVersion")]
        public Input<string>? LinuxFxVersion { get; set; }

        /// <summary>
        /// The minimum supported TLS version for the function app. Possible values are `1.0`, `1.1`, and `1.2`. Defaults to `1.2` for new function apps.
        /// </summary>
        [Input("minTlsVersion")]
        public Input<string>? MinTlsVersion { get; set; }

        /// <summary>
        /// The number of pre-warmed instances for this function app. Only affects apps on the Premium plan.
        /// </summary>
        [Input("preWarmedInstanceCount")]
        public Input<int>? PreWarmedInstanceCount { get; set; }

        /// <summary>
        /// Should the Function App run in 32 bit mode, rather than 64 bit mode? Defaults to `true`.
        /// </summary>
        [Input("use32BitWorkerProcess")]
        public Input<bool>? Use32BitWorkerProcess { get; set; }

        /// <summary>
        /// Should WebSockets be enabled?
        /// </summary>
        [Input("websocketsEnabled")]
        public Input<bool>? WebsocketsEnabled { get; set; }

        public FunctionAppSlotSiteConfigGetArgs()
        {
        }
    }
}
