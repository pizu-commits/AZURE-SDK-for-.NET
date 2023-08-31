// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> Job endpoint definition. </summary>
    public partial class MachineLearningJobService
    {
        private Dictionary<string, BinaryData> _rawData;

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobService"/>. </summary>
        public MachineLearningJobService()
        {
            Properties = new ChangeTrackingDictionary<string, string>();
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningJobService"/>. </summary>
        /// <param name="endpoint"> Url for endpoint. </param>
        /// <param name="errorMessage"> Any error in the service. </param>
        /// <param name="jobServiceType"> Endpoint type. </param>
        /// <param name="port"> Port for endpoint. </param>
        /// <param name="properties"> Additional properties to set on the endpoint. </param>
        /// <param name="status"> Status of endpoint. </param>
        /// <param name="rawData"> Keeps track of any properties unknown to the library. </param>
        internal MachineLearningJobService(string endpoint, string errorMessage, string jobServiceType, int? port, IDictionary<string, string> properties, string status, Dictionary<string, BinaryData> rawData)
        {
            Endpoint = endpoint;
            ErrorMessage = errorMessage;
            JobServiceType = jobServiceType;
            Port = port;
            Properties = properties;
            Status = status;
            _rawData = rawData;
        }

        /// <summary> Url for endpoint. </summary>
        public string Endpoint { get; set; }
        /// <summary> Any error in the service. </summary>
        public string ErrorMessage { get; }
        /// <summary> Endpoint type. </summary>
        public string JobServiceType { get; set; }
        /// <summary> Port for endpoint. </summary>
        public int? Port { get; set; }
        /// <summary> Additional properties to set on the endpoint. </summary>
        public IDictionary<string, string> Properties { get; set; }
        /// <summary> Status of endpoint. </summary>
        public string Status { get; }
    }
}
