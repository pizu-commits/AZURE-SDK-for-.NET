// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.ApplicationInsights.Models
{
    /// <summary> An Application Insights component API Key creation request definition. </summary>
    public partial class APIKeyContent
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="APIKeyContent"/>. </summary>
        public APIKeyContent()
        {
            LinkedReadProperties = new ChangeTrackingList<string>();
            LinkedWriteProperties = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="APIKeyContent"/>. </summary>
        /// <param name="name"> The name of the API Key. </param>
        /// <param name="linkedReadProperties"> The read access rights of this API Key. </param>
        /// <param name="linkedWriteProperties"> The write access rights of this API Key. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal APIKeyContent(string name, IList<string> linkedReadProperties, IList<string> linkedWriteProperties, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            LinkedReadProperties = linkedReadProperties;
            LinkedWriteProperties = linkedWriteProperties;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the API Key. </summary>
        public string Name { get; set; }
        /// <summary> The read access rights of this API Key. </summary>
        public IList<string> LinkedReadProperties { get; }
        /// <summary> The write access rights of this API Key. </summary>
        public IList<string> LinkedWriteProperties { get; }
    }
}
