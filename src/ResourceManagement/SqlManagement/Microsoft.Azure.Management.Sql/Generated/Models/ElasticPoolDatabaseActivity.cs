// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Sql.Models
{
    using Azure;
    using Management;
    using Sql;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the activity on an elastic pool.
    /// </summary>
    [JsonTransformation]
    public partial class ElasticPoolDatabaseActivity : Resource
    {
        /// <summary>
        /// Initializes a new instance of the ElasticPoolDatabaseActivity
        /// class.
        /// </summary>
        public ElasticPoolDatabaseActivity() { }

        /// <summary>
        /// Initializes a new instance of the ElasticPoolDatabaseActivity
        /// class.
        /// </summary>
        /// <param name="location">Resource location</param>
        /// <param name="name">Resource name</param>
        /// <param name="id">The resource ID.</param>
        /// <param name="type">Resource type</param>
        /// <param name="tags">Resource tags</param>
        /// <param name="databaseName">The database name.</param>
        /// <param name="endTime">The time the operation finished (ISO8601
        /// format).</param>
        /// <param name="errorCode">The error code if available.</param>
        /// <param name="errorMessage">The error message if available.</param>
        /// <param name="errorSeverity">The error severity if
        /// available.</param>
        /// <param name="operation">The operation name.</param>
        /// <param name="operationId">The unique operation ID.</param>
        /// <param name="percentComplete">The percentage complete if
        /// available.</param>
        /// <param name="requestedElasticPoolName">The name for the elastic
        /// pool the database is moving into if available.</param>
        /// <param name="currentElasticPoolName">The name of the current
        /// elastic pool the database is in if available.</param>
        /// <param name="currentServiceObjective">The name of the current
        /// service objective if available.</param>
        /// <param name="requestedServiceObjective">The name of the requested
        /// service objective if available.</param>
        /// <param name="serverName">The name of the server the elastic pool is
        /// in.</param>
        /// <param name="startTime">The time the operation started (ISO8601
        /// format).</param>
        /// <param name="state">The current state of the operation.</param>
        public ElasticPoolDatabaseActivity(string location, string name = default(string), string id = default(string), string type = default(string), IDictionary<string, string> tags = default(IDictionary<string, string>), string databaseName = default(string), System.DateTime? endTime = default(System.DateTime?), int? errorCode = default(int?), string errorMessage = default(string), int? errorSeverity = default(int?), string operation = default(string), string operationId = default(string), int? percentComplete = default(int?), string requestedElasticPoolName = default(string), string currentElasticPoolName = default(string), string currentServiceObjective = default(string), string requestedServiceObjective = default(string), string serverName = default(string), System.DateTime? startTime = default(System.DateTime?), string state = default(string))
            : base(location, name, id, type, tags)
        {
            DatabaseName = databaseName;
            EndTime = endTime;
            ErrorCode = errorCode;
            ErrorMessage = errorMessage;
            ErrorSeverity = errorSeverity;
            Operation = operation;
            OperationId = operationId;
            PercentComplete = percentComplete;
            RequestedElasticPoolName = requestedElasticPoolName;
            CurrentElasticPoolName = currentElasticPoolName;
            CurrentServiceObjective = currentServiceObjective;
            RequestedServiceObjective = requestedServiceObjective;
            ServerName = serverName;
            StartTime = startTime;
            State = state;
        }

        /// <summary>
        /// Gets the database name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.databaseName")]
        public string DatabaseName { get; protected set; }

        /// <summary>
        /// Gets the time the operation finished (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; protected set; }

        /// <summary>
        /// Gets the error code if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorCode")]
        public int? ErrorCode { get; protected set; }

        /// <summary>
        /// Gets the error message if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorMessage")]
        public string ErrorMessage { get; protected set; }

        /// <summary>
        /// Gets the error severity if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.errorSeverity")]
        public int? ErrorSeverity { get; protected set; }

        /// <summary>
        /// Gets the operation name.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operation")]
        public string Operation { get; protected set; }

        /// <summary>
        /// Gets the unique operation ID.
        /// </summary>
        [JsonProperty(PropertyName = "properties.operationId")]
        public string OperationId { get; protected set; }

        /// <summary>
        /// Gets the percentage complete if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.percentComplete")]
        public int? PercentComplete { get; protected set; }

        /// <summary>
        /// Gets the name for the elastic pool the database is moving into if
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedElasticPoolName")]
        public string RequestedElasticPoolName { get; protected set; }

        /// <summary>
        /// Gets the name of the current elastic pool the database is in if
        /// available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentElasticPoolName")]
        public string CurrentElasticPoolName { get; protected set; }

        /// <summary>
        /// Gets the name of the current service objective if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.currentServiceObjective")]
        public string CurrentServiceObjective { get; protected set; }

        /// <summary>
        /// Gets the name of the requested service objective if available.
        /// </summary>
        [JsonProperty(PropertyName = "properties.requestedServiceObjective")]
        public string RequestedServiceObjective { get; protected set; }

        /// <summary>
        /// Gets the name of the server the elastic pool is in.
        /// </summary>
        [JsonProperty(PropertyName = "properties.serverName")]
        public string ServerName { get; protected set; }

        /// <summary>
        /// Gets the time the operation started (ISO8601 format).
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; protected set; }

        /// <summary>
        /// Gets the current state of the operation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.state")]
        public string State { get; protected set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}

