// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.HealthcareApis;

namespace Azure.ResourceManager.HealthcareApis.Models
{
    /// <summary> A collection of IoT Connector FHIR destinations. </summary>
    internal partial class IotFhirDestinationCollection
    {
        /// <summary> Initializes a new instance of <see cref="IotFhirDestinationCollection"/>. </summary>
        internal IotFhirDestinationCollection()
        {
            Value = new ChangeTrackingList<HealthcareApisIotFhirDestinationData>();
        }

        /// <summary> Initializes a new instance of <see cref="IotFhirDestinationCollection"/>. </summary>
        /// <param name="nextLink"> The link used to get the next page of IoT FHIR destinations. </param>
        /// <param name="value"> The list of IoT Connector FHIR destinations. </param>
        internal IotFhirDestinationCollection(string nextLink, IReadOnlyList<HealthcareApisIotFhirDestinationData> value)
        {
            NextLink = nextLink;
            Value = value;
        }

        /// <summary> The link used to get the next page of IoT FHIR destinations. </summary>
        public string NextLink { get; }
        /// <summary> The list of IoT Connector FHIR destinations. </summary>
        public IReadOnlyList<HealthcareApisIotFhirDestinationData> Value { get; }
    }
}
