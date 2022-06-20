// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.DataFactory.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.DataFactory
{
    /// <summary> A class representing the PipelineResource data model. </summary>
    public partial class PipelineResourceData : SubResource
    {
        /// <summary> Initializes a new instance of PipelineResourceData. </summary>
        public PipelineResourceData()
        {
            Activities = new ChangeTrackingList<Activity>();
            Parameters = new ChangeTrackingDictionary<string, ParameterSpecification>();
            Variables = new ChangeTrackingDictionary<string, VariableSpecification>();
            Annotations = new ChangeTrackingList<BinaryData>();
            RunDimensions = new ChangeTrackingDictionary<string, BinaryData>();
            AdditionalProperties = new ChangeTrackingDictionary<string, BinaryData>();
        }

        /// <summary> Initializes a new instance of PipelineResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="etag"> Etag identifies change in the resource. </param>
        /// <param name="description"> The description of the pipeline. </param>
        /// <param name="activities">
        /// List of activities in pipeline.
        /// Please note <see cref="Activity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </param>
        /// <param name="parameters"> List of parameters for pipeline. </param>
        /// <param name="variables"> List of variables for pipeline. </param>
        /// <param name="concurrency"> The max number of concurrent runs for the pipeline. </param>
        /// <param name="annotations"> List of tags that can be used for describing the Pipeline. </param>
        /// <param name="runDimensions"> Dimensions emitted by Pipeline. </param>
        /// <param name="folder"> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </param>
        /// <param name="policy"> Pipeline Policy. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        internal PipelineResourceData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, string etag, string description, IList<Activity> activities, IDictionary<string, ParameterSpecification> parameters, IDictionary<string, VariableSpecification> variables, int? concurrency, IList<BinaryData> annotations, IDictionary<string, BinaryData> runDimensions, PipelineFolder folder, PipelinePolicy policy, IDictionary<string, BinaryData> additionalProperties) : base(id, name, resourceType, systemData, etag)
        {
            Description = description;
            Activities = activities;
            Parameters = parameters;
            Variables = variables;
            Concurrency = concurrency;
            Annotations = annotations;
            RunDimensions = runDimensions;
            Folder = folder;
            Policy = policy;
            AdditionalProperties = additionalProperties;
        }

        /// <summary> The description of the pipeline. </summary>
        public string Description { get; set; }
        /// <summary>
        /// List of activities in pipeline.
        /// Please note <see cref="Activity"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AppendVariableActivity"/>, <see cref="AzureDataExplorerCommandActivity"/>, <see cref="AzureFunctionActivity"/>, <see cref="AzureMLBatchExecutionActivity"/>, <see cref="AzureMLExecutePipelineActivity"/>, <see cref="AzureMLUpdateResourceActivity"/>, <see cref="ControlActivity"/>, <see cref="CopyActivity"/>, <see cref="CustomActivity"/>, <see cref="DataLakeAnalyticsUsqlActivity"/>, <see cref="DatabricksNotebookActivity"/>, <see cref="DatabricksSparkJarActivity"/>, <see cref="DatabricksSparkPythonActivity"/>, <see cref="DeleteActivity"/>, <see cref="ExecuteDataFlowActivity"/>, <see cref="ExecutePipelineActivity"/>, <see cref="ExecuteSsisPackageActivity"/>, <see cref="ExecuteWranglingDataflowActivity"/>, <see cref="ExecutionActivity"/>, <see cref="FailActivity"/>, <see cref="FilterActivity"/>, <see cref="ForEachActivity"/>, <see cref="GetMetadataActivity"/>, <see cref="HDInsightHiveActivity"/>, <see cref="HDInsightMapReduceActivity"/>, <see cref="HDInsightPigActivity"/>, <see cref="HDInsightSparkActivity"/>, <see cref="HDInsightStreamingActivity"/>, <see cref="IfConditionActivity"/>, <see cref="LookupActivity"/>, <see cref="ScriptActivity"/>, <see cref="SetVariableActivity"/>, <see cref="SqlServerStoredProcedureActivity"/>, <see cref="SwitchActivity"/>, <see cref="UntilActivity"/>, <see cref="ValidationActivity"/>, <see cref="WaitActivity"/>, <see cref="WebActivity"/> and <see cref="WebHookActivity"/>.
        /// </summary>
        public IList<Activity> Activities { get; }
        /// <summary> List of parameters for pipeline. </summary>
        public IDictionary<string, ParameterSpecification> Parameters { get; }
        /// <summary> List of variables for pipeline. </summary>
        public IDictionary<string, VariableSpecification> Variables { get; }
        /// <summary> The max number of concurrent runs for the pipeline. </summary>
        public int? Concurrency { get; set; }
        /// <summary> List of tags that can be used for describing the Pipeline. </summary>
        public IList<BinaryData> Annotations { get; }
        /// <summary> Dimensions emitted by Pipeline. </summary>
        public IDictionary<string, BinaryData> RunDimensions { get; }
        /// <summary> The folder that this Pipeline is in. If not specified, Pipeline will appear at the root level. </summary>
        internal PipelineFolder Folder { get; set; }
        /// <summary> The name of the folder that this Pipeline is in. </summary>
        public string FolderName
        {
            get => Folder is null ? default : Folder.Name;
            set
            {
                if (Folder is null)
                    Folder = new PipelineFolder();
                Folder.Name = value;
            }
        }

        /// <summary> Pipeline Policy. </summary>
        internal PipelinePolicy Policy { get; set; }
        /// <summary> TimeSpan value, after which an Azure Monitoring Metric is fired. </summary>
        public BinaryData ElapsedTimeMetricDuration
        {
            get => Policy is null ? default : Policy.ElapsedTimeMetricDuration;
            set
            {
                if (Policy is null)
                    Policy = new PipelinePolicy();
                Policy.ElapsedTimeMetricDuration = value;
            }
        }

        /// <summary> Additional Properties. </summary>
        public IDictionary<string, BinaryData> AdditionalProperties { get; }
    }
}
