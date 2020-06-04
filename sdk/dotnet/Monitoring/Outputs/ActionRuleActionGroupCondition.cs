// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Azure.Monitoring.Outputs
{

    [OutputType]
    public sealed class ActionRuleActionGroupCondition
    {
        /// <summary>
        /// A `alert_context` block as defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionAlertContext? AlertContext;
        /// <summary>
        /// A `alert_rule_id` block as defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionAlertRuleId? AlertRuleId;
        /// <summary>
        /// A `description` block as defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionDescription? Description;
        /// <summary>
        /// A `monitor` block as defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionMonitor? Monitor;
        /// <summary>
        /// A `monitor_service` as block defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionMonitorService? MonitorService;
        /// <summary>
        /// A `severity` block as defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionSeverity? Severity;
        /// <summary>
        /// A `target_resource_type` block as defined below.
        /// </summary>
        public readonly Outputs.ActionRuleActionGroupConditionTargetResourceType? TargetResourceType;

        [OutputConstructor]
        private ActionRuleActionGroupCondition(
            Outputs.ActionRuleActionGroupConditionAlertContext? alertContext,

            Outputs.ActionRuleActionGroupConditionAlertRuleId? alertRuleId,

            Outputs.ActionRuleActionGroupConditionDescription? description,

            Outputs.ActionRuleActionGroupConditionMonitor? monitor,

            Outputs.ActionRuleActionGroupConditionMonitorService? monitorService,

            Outputs.ActionRuleActionGroupConditionSeverity? severity,

            Outputs.ActionRuleActionGroupConditionTargetResourceType? targetResourceType)
        {
            AlertContext = alertContext;
            AlertRuleId = alertRuleId;
            Description = description;
            Monitor = monitor;
            MonitorService = monitorService;
            Severity = severity;
            TargetResourceType = targetResourceType;
        }
    }
}
