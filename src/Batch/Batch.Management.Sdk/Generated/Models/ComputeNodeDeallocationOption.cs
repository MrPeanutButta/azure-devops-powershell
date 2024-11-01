// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Batch.Models
{

    /// <summary>
    /// Defines values for ComputeNodeDeallocationOption.
    /// </summary>


    [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
    public enum ComputeNodeDeallocationOption
    {
        /// <summary>
        /// Terminate running task processes and requeue the tasks. The tasks will run
        /// again when a node is available. Remove nodes as soon as tasks have been
        /// terminated.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Requeue")]
        Requeue,
        /// <summary>
        /// Terminate running tasks. The tasks will be completed with failureInfo
        /// indicating that they were terminated, and will not run again. Remove nodes
        /// as soon as tasks have been terminated.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "Terminate")]
        Terminate,
        /// <summary>
        /// Allow currently running tasks to complete. Schedule no new tasks while
        /// waiting. Remove nodes when all tasks have completed.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "TaskCompletion")]
        TaskCompletion,
        /// <summary>
        /// Allow currently running tasks to complete, then wait for all task data
        /// retention periods to expire. Schedule no new tasks while waiting. Remove
        /// nodes when all task retention periods have expired.
        /// </summary>
        [System.Runtime.Serialization.EnumMember(Value = "RetainedData")]
        RetainedData
    }
    internal static class ComputeNodeDeallocationOptionEnumExtension
    {
        internal static string ToSerializedValue(this ComputeNodeDeallocationOption? value)
        {
            return value == null ? null : ((ComputeNodeDeallocationOption)value).ToSerializedValue();
        }
        internal static string ToSerializedValue(this ComputeNodeDeallocationOption value)
        {
            switch( value )
            {
                case ComputeNodeDeallocationOption.Requeue:
                    return "Requeue";
                case ComputeNodeDeallocationOption.Terminate:
                    return "Terminate";
                case ComputeNodeDeallocationOption.TaskCompletion:
                    return "TaskCompletion";
                case ComputeNodeDeallocationOption.RetainedData:
                    return "RetainedData";
            }
            return null;
        }
        internal static ComputeNodeDeallocationOption? ParseComputeNodeDeallocationOption(this string value)
        {
            switch( value )
            {
                case "Requeue":
                    return ComputeNodeDeallocationOption.Requeue;
                case "Terminate":
                    return ComputeNodeDeallocationOption.Terminate;
                case "TaskCompletion":
                    return ComputeNodeDeallocationOption.TaskCompletion;
                case "RetainedData":
                    return ComputeNodeDeallocationOption.RetainedData;
            }
            return null;
        }
    }
}