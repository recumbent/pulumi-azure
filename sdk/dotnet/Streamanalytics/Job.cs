// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Streamanalytics
{
    /// <summary>
    /// Manages a Stream Analytics Job.
    /// 
    /// &gt; This content is derived from https://github.com/terraform-providers/terraform-provider-azurerm/blob/master/website/docs/r/stream_analytics_job.html.markdown.
    /// </summary>
    public partial class Job : Pulumi.CustomResource
    {
        /// <summary>
        /// Specifies the compatibility level for this job - which controls certain runtime behaviors of the streaming job. Possible values are `1.0` and 1.1`.
        /// </summary>
        [Output("compatibilityLevel")]
        public Output<string> CompatibilityLevel { get; private set; } = null!;

        /// <summary>
        /// Specifies the Data Locale of the Job, which [should be a supported .NET Culture](https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx).
        /// </summary>
        [Output("dataLocale")]
        public Output<string> DataLocale { get; private set; } = null!;

        /// <summary>
        /// Specifies the maximum tolerable delay in seconds where events arriving late could be included. Supported range is `-1` (indefinite) to `1814399` (20d 23h 59m 59s).  Default is `0`.
        /// </summary>
        [Output("eventsLateArrivalMaxDelayInSeconds")]
        public Output<int?> EventsLateArrivalMaxDelayInSeconds { get; private set; } = null!;

        /// <summary>
        /// Specifies the maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. Supported range is `0` to `599` (9m 59s). Default is `5`.
        /// </summary>
        [Output("eventsOutOfOrderMaxDelayInSeconds")]
        public Output<int?> EventsOutOfOrderMaxDelayInSeconds { get; private set; } = null!;

        /// <summary>
        /// Specifies the policy which should be applied to events which arrive out of order in the input event stream. Possible values are `Adjust` and `Drop`.  Default is `Adjust`.
        /// </summary>
        [Output("eventsOutOfOrderPolicy")]
        public Output<string?> EventsOutOfOrderPolicy { get; private set; } = null!;

        /// <summary>
        /// The Job ID assigned by the Stream Analytics Job.
        /// </summary>
        [Output("jobId")]
        public Output<string> JobId { get; private set; } = null!;

        /// <summary>
        /// The Azure Region in which the Resource Group exists. Changing this forces a new resource to be created.
        /// </summary>
        [Output("location")]
        public Output<string> Location { get; private set; } = null!;

        /// <summary>
        /// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Specifies the policy which should be applied to events which arrive at the output and cannot be written to the external storage due to being malformed (such as missing column values, column values of wrong type or size). Possible values are `Drop` and `Stop`.  Default is `Drop`.
        /// </summary>
        [Output("outputErrorPolicy")]
        public Output<string?> OutputErrorPolicy { get; private set; } = null!;

        /// <summary>
        /// The name of the Resource Group where the Stream Analytics Job should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Output("resourceGroupName")]
        public Output<string> ResourceGroupName { get; private set; } = null!;

        /// <summary>
        /// Specifies the number of streaming units that the streaming job uses. Supported values are `1`, `3`, `6` and multiples of `6` up to `120`.
        /// </summary>
        [Output("streamingUnits")]
        public Output<int> StreamingUnits { get; private set; } = null!;

        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>> Tags { get; private set; } = null!;

        /// <summary>
        /// Specifies the query that will be run in the streaming job, [written in Stream Analytics Query Language (SAQL)](https://msdn.microsoft.com/library/azure/dn834998).
        /// </summary>
        [Output("transformationQuery")]
        public Output<string> TransformationQuery { get; private set; } = null!;


        /// <summary>
        /// Create a Job resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Job(string name, JobArgs args, CustomResourceOptions? options = null)
            : base("azure:streamanalytics/job:Job", name, args, MakeResourceOptions(options, ""))
        {
        }

        private Job(string name, Input<string> id, JobState? state = null, CustomResourceOptions? options = null)
            : base("azure:streamanalytics/job:Job", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Job resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Job Get(string name, Input<string> id, JobState? state = null, CustomResourceOptions? options = null)
        {
            return new Job(name, id, state, options);
        }
    }

    public sealed class JobArgs : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the compatibility level for this job - which controls certain runtime behaviors of the streaming job. Possible values are `1.0` and 1.1`.
        /// </summary>
        [Input("compatibilityLevel")]
        public Input<string>? CompatibilityLevel { get; set; }

        /// <summary>
        /// Specifies the Data Locale of the Job, which [should be a supported .NET Culture](https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx).
        /// </summary>
        [Input("dataLocale")]
        public Input<string>? DataLocale { get; set; }

        /// <summary>
        /// Specifies the maximum tolerable delay in seconds where events arriving late could be included. Supported range is `-1` (indefinite) to `1814399` (20d 23h 59m 59s).  Default is `0`.
        /// </summary>
        [Input("eventsLateArrivalMaxDelayInSeconds")]
        public Input<int>? EventsLateArrivalMaxDelayInSeconds { get; set; }

        /// <summary>
        /// Specifies the maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. Supported range is `0` to `599` (9m 59s). Default is `5`.
        /// </summary>
        [Input("eventsOutOfOrderMaxDelayInSeconds")]
        public Input<int>? EventsOutOfOrderMaxDelayInSeconds { get; set; }

        /// <summary>
        /// Specifies the policy which should be applied to events which arrive out of order in the input event stream. Possible values are `Adjust` and `Drop`.  Default is `Adjust`.
        /// </summary>
        [Input("eventsOutOfOrderPolicy")]
        public Input<string>? EventsOutOfOrderPolicy { get; set; }

        /// <summary>
        /// The Azure Region in which the Resource Group exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the policy which should be applied to events which arrive at the output and cannot be written to the external storage due to being malformed (such as missing column values, column values of wrong type or size). Possible values are `Drop` and `Stop`.  Default is `Drop`.
        /// </summary>
        [Input("outputErrorPolicy")]
        public Input<string>? OutputErrorPolicy { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Stream Analytics Job should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName", required: true)]
        public Input<string> ResourceGroupName { get; set; } = null!;

        /// <summary>
        /// Specifies the number of streaming units that the streaming job uses. Supported values are `1`, `3`, `6` and multiples of `6` up to `120`.
        /// </summary>
        [Input("streamingUnits", required: true)]
        public Input<int> StreamingUnits { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the query that will be run in the streaming job, [written in Stream Analytics Query Language (SAQL)](https://msdn.microsoft.com/library/azure/dn834998).
        /// </summary>
        [Input("transformationQuery", required: true)]
        public Input<string> TransformationQuery { get; set; } = null!;

        public JobArgs()
        {
        }
    }

    public sealed class JobState : Pulumi.ResourceArgs
    {
        /// <summary>
        /// Specifies the compatibility level for this job - which controls certain runtime behaviors of the streaming job. Possible values are `1.0` and 1.1`.
        /// </summary>
        [Input("compatibilityLevel")]
        public Input<string>? CompatibilityLevel { get; set; }

        /// <summary>
        /// Specifies the Data Locale of the Job, which [should be a supported .NET Culture](https://msdn.microsoft.com/en-us/library/system.globalization.culturetypes(v=vs.110).aspx).
        /// </summary>
        [Input("dataLocale")]
        public Input<string>? DataLocale { get; set; }

        /// <summary>
        /// Specifies the maximum tolerable delay in seconds where events arriving late could be included. Supported range is `-1` (indefinite) to `1814399` (20d 23h 59m 59s).  Default is `0`.
        /// </summary>
        [Input("eventsLateArrivalMaxDelayInSeconds")]
        public Input<int>? EventsLateArrivalMaxDelayInSeconds { get; set; }

        /// <summary>
        /// Specifies the maximum tolerable delay in seconds where out-of-order events can be adjusted to be back in order. Supported range is `0` to `599` (9m 59s). Default is `5`.
        /// </summary>
        [Input("eventsOutOfOrderMaxDelayInSeconds")]
        public Input<int>? EventsOutOfOrderMaxDelayInSeconds { get; set; }

        /// <summary>
        /// Specifies the policy which should be applied to events which arrive out of order in the input event stream. Possible values are `Adjust` and `Drop`.  Default is `Adjust`.
        /// </summary>
        [Input("eventsOutOfOrderPolicy")]
        public Input<string>? EventsOutOfOrderPolicy { get; set; }

        /// <summary>
        /// The Job ID assigned by the Stream Analytics Job.
        /// </summary>
        [Input("jobId")]
        public Input<string>? JobId { get; set; }

        /// <summary>
        /// The Azure Region in which the Resource Group exists. Changing this forces a new resource to be created.
        /// </summary>
        [Input("location")]
        public Input<string>? Location { get; set; }

        /// <summary>
        /// The name of the Stream Analytics Job. Changing this forces a new resource to be created.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Specifies the policy which should be applied to events which arrive at the output and cannot be written to the external storage due to being malformed (such as missing column values, column values of wrong type or size). Possible values are `Drop` and `Stop`.  Default is `Drop`.
        /// </summary>
        [Input("outputErrorPolicy")]
        public Input<string>? OutputErrorPolicy { get; set; }

        /// <summary>
        /// The name of the Resource Group where the Stream Analytics Job should exist. Changing this forces a new resource to be created.
        /// </summary>
        [Input("resourceGroupName")]
        public Input<string>? ResourceGroupName { get; set; }

        /// <summary>
        /// Specifies the number of streaming units that the streaming job uses. Supported values are `1`, `3`, `6` and multiples of `6` up to `120`.
        /// </summary>
        [Input("streamingUnits")]
        public Input<int>? StreamingUnits { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A mapping of tags assigned to the resource.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// Specifies the query that will be run in the streaming job, [written in Stream Analytics Query Language (SAQL)](https://msdn.microsoft.com/library/azure/dn834998).
        /// </summary>
        [Input("transformationQuery")]
        public Input<string>? TransformationQuery { get; set; }

        public JobState()
        {
        }
    }
}
