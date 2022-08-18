// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> This activity will fail within its own scope and output a custom error message and error code. The error message and code can provided either as a string literal or as an expression that can be evaluated to a string at runtime. The activity scope can be the whole pipeline or a control activity (e.g. foreach, switch, until), if the fail activity is contained in it. </summary>
    public partial class FailActivity : ControlActivity
    {
        /// <summary> Initializes a new instance of FailActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="message"> The error message that surfaced in the Fail activity. It can be dynamic content that&apos;s evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        /// <param name="errorCode"> The error code that categorizes the error type of the Fail activity. It can be dynamic content that&apos;s evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/>, <paramref name="message"/> or <paramref name="errorCode"/> is null. </exception>
        public FailActivity(string name, BinaryData message, BinaryData errorCode) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (message == null)
            {
                throw new ArgumentNullException(nameof(message));
            }
            if (errorCode == null)
            {
                throw new ArgumentNullException(nameof(errorCode));
            }

            Message = message;
            ErrorCode = errorCode;
            ActivityType = "Fail";
        }

        /// <summary> Initializes a new instance of FailActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="message"> The error message that surfaced in the Fail activity. It can be dynamic content that&apos;s evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        /// <param name="errorCode"> The error code that categorizes the error type of the Fail activity. It can be dynamic content that&apos;s evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string). </param>
        internal FailActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<ActivityUserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, BinaryData message, BinaryData errorCode) : base(name, activityType, description, dependsOn, userProperties, additionalProperties)
        {
            Message = message;
            ErrorCode = errorCode;
            ActivityType = activityType ?? "Fail";
        }

        /// <summary>
        /// The error message that surfaced in the Fail activity. It can be dynamic content that&apos;s evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData Message { get; set; }
        /// <summary>
        /// The error code that categorizes the error type of the Fail activity. It can be dynamic content that&apos;s evaluated to a non empty/blank string at runtime. Type: string (or Expression with resultType string)..
        /// <para>
        /// To assign an object to this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formated json string to this property use <see cref="BinaryData.FromString(string)"/>.
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
        public BinaryData ErrorCode { get; set; }
    }
}
