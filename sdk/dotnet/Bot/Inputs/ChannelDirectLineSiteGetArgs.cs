// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Bot.Inputs
{

    public sealed class ChannelDirectLineSiteGetArgs : Pulumi.ResourceArgs
    {
        [Input("enabled")]
        public Input<bool>? Enabled { get; set; }

        [Input("enhancedAuthenticationEnabled")]
        public Input<bool>? EnhancedAuthenticationEnabled { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("key")]
        public Input<string>? Key { get; set; }

        [Input("key2")]
        public Input<string>? Key2 { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("trustedOrigins")]
        private InputList<string>? _trustedOrigins;
        public InputList<string> TrustedOrigins
        {
            get => _trustedOrigins ?? (_trustedOrigins = new InputList<string>());
            set => _trustedOrigins = value;
        }

        [Input("v1Allowed")]
        public Input<bool>? V1Allowed { get; set; }

        [Input("v3Allowed")]
        public Input<bool>? V3Allowed { get; set; }

        public ChannelDirectLineSiteGetArgs()
        {
        }
    }
}