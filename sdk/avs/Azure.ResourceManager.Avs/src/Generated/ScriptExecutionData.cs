// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Avs.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Avs
{
    /// <summary>
    /// A class representing the ScriptExecution data model.
    /// An instance of a script executed by a user - custom or AVS
    /// </summary>
    public partial class ScriptExecutionData : ResourceData
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionData"/>. </summary>
        public ScriptExecutionData()
        {
            Parameters = new ChangeTrackingList<ScriptExecutionParameterDetails>();
            HiddenParameters = new ChangeTrackingList<ScriptExecutionParameterDetails>();
            Output = new ChangeTrackingList<string>();
            Information = new ChangeTrackingList<string>();
            Warnings = new ChangeTrackingList<string>();
            Errors = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="ScriptExecutionData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="scriptCmdletId"> A reference to the script cmdlet resource if user is running a AVS script. </param>
        /// <param name="parameters">
        /// Parameters the script will accept
        /// Please note <see cref="ScriptExecutionParameterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PSCredentialExecutionParameterDetails"/>, <see cref="ScriptSecureStringExecutionParameterDetails"/> and <see cref="ScriptStringExecutionParameterDetails"/>.
        /// </param>
        /// <param name="hiddenParameters">
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// Please note <see cref="ScriptExecutionParameterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PSCredentialExecutionParameterDetails"/>, <see cref="ScriptSecureStringExecutionParameterDetails"/> and <see cref="ScriptStringExecutionParameterDetails"/>.
        /// </param>
        /// <param name="failureReason"> Error message if the script was able to run, but if the script itself had errors or powershell threw an exception. </param>
        /// <param name="timeout"> Time limit for execution. </param>
        /// <param name="retention"> Time to live for the resource. If not provided, will be available for 60 days. </param>
        /// <param name="submittedOn"> Time the script execution was submitted. </param>
        /// <param name="startedOn"> Time the script execution was started. </param>
        /// <param name="finishedOn"> Time the script execution was finished. </param>
        /// <param name="provisioningState"> The state of the script execution resource. </param>
        /// <param name="output"> Standard output stream from the powershell execution. </param>
        /// <param name="namedOutputs"> User-defined dictionary. </param>
        /// <param name="information"> Standard information out stream from the powershell execution. </param>
        /// <param name="warnings"> Standard warning out stream from the powershell execution. </param>
        /// <param name="errors"> Standard error output stream from the powershell execution. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ScriptExecutionData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, ResourceIdentifier scriptCmdletId, IList<ScriptExecutionParameterDetails> parameters, IList<ScriptExecutionParameterDetails> hiddenParameters, string failureReason, string timeout, string retention, DateTimeOffset? submittedOn, DateTimeOffset? startedOn, DateTimeOffset? finishedOn, ScriptExecutionProvisioningState? provisioningState, IList<string> output, BinaryData namedOutputs, IReadOnlyList<string> information, IReadOnlyList<string> warnings, IReadOnlyList<string> errors, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            ScriptCmdletId = scriptCmdletId;
            Parameters = parameters;
            HiddenParameters = hiddenParameters;
            FailureReason = failureReason;
            Timeout = timeout;
            Retention = retention;
            SubmittedOn = submittedOn;
            StartedOn = startedOn;
            FinishedOn = finishedOn;
            ProvisioningState = provisioningState;
            Output = output;
            NamedOutputs = namedOutputs;
            Information = information;
            Warnings = warnings;
            Errors = errors;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A reference to the script cmdlet resource if user is running a AVS script. </summary>
        public ResourceIdentifier ScriptCmdletId { get; set; }
        /// <summary>
        /// Parameters the script will accept
        /// Please note <see cref="ScriptExecutionParameterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PSCredentialExecutionParameterDetails"/>, <see cref="ScriptSecureStringExecutionParameterDetails"/> and <see cref="ScriptStringExecutionParameterDetails"/>.
        /// </summary>
        public IList<ScriptExecutionParameterDetails> Parameters { get; }
        /// <summary>
        /// Parameters that will be hidden/not visible to ARM, such as passwords and credentials
        /// Please note <see cref="ScriptExecutionParameterDetails"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="PSCredentialExecutionParameterDetails"/>, <see cref="ScriptSecureStringExecutionParameterDetails"/> and <see cref="ScriptStringExecutionParameterDetails"/>.
        /// </summary>
        public IList<ScriptExecutionParameterDetails> HiddenParameters { get; }
        /// <summary> Error message if the script was able to run, but if the script itself had errors or powershell threw an exception. </summary>
        public string FailureReason { get; set; }
        /// <summary> Time limit for execution. </summary>
        public string Timeout { get; set; }
        /// <summary> Time to live for the resource. If not provided, will be available for 60 days. </summary>
        public string Retention { get; set; }
        /// <summary> Time the script execution was submitted. </summary>
        public DateTimeOffset? SubmittedOn { get; }
        /// <summary> Time the script execution was started. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Time the script execution was finished. </summary>
        public DateTimeOffset? FinishedOn { get; }
        /// <summary> The state of the script execution resource. </summary>
        public ScriptExecutionProvisioningState? ProvisioningState { get; }
        /// <summary> Standard output stream from the powershell execution. </summary>
        public IList<string> Output { get; }
        /// <summary>
        /// User-defined dictionary.
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        public BinaryData NamedOutputs { get; set; }
        /// <summary> Standard information out stream from the powershell execution. </summary>
        public IReadOnlyList<string> Information { get; }
        /// <summary> Standard warning out stream from the powershell execution. </summary>
        public IReadOnlyList<string> Warnings { get; }
        /// <summary> Standard error output stream from the powershell execution. </summary>
        public IReadOnlyList<string> Errors { get; }
    }
}
