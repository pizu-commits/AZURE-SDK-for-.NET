// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ApiManagement.Models
{
    /// <summary> Operation Entity contract Properties. </summary>
    public partial class AssociatedOperationProperties
    {
        /// <summary> Keeps track of any properties unknown to the library. </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="AssociatedOperationProperties"/>. </summary>
        internal AssociatedOperationProperties()
        {
        }

        /// <summary> Initializes a new instance of <see cref="AssociatedOperationProperties"/>. </summary>
        /// <param name="id"> Identifier of the operation in form /operations/{operationId}. </param>
        /// <param name="name"> Operation name. </param>
        /// <param name="apiName"> API Name. </param>
        /// <param name="apiRevision"> API Revision. </param>
        /// <param name="apiVersion"> API Version. </param>
        /// <param name="description"> Operation Description. </param>
        /// <param name="method"> A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them. </param>
        /// <param name="uriTemplate"> Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AssociatedOperationProperties(string id, string name, string apiName, string apiRevision, string apiVersion, string description, string method, string uriTemplate, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            Name = name;
            ApiName = apiName;
            ApiRevision = apiRevision;
            ApiVersion = apiVersion;
            Description = description;
            Method = method;
            UriTemplate = uriTemplate;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Identifier of the operation in form /operations/{operationId}. </summary>
        public string Id { get; }
        /// <summary> Operation name. </summary>
        public string Name { get; }
        /// <summary> API Name. </summary>
        public string ApiName { get; }
        /// <summary> API Revision. </summary>
        public string ApiRevision { get; }
        /// <summary> API Version. </summary>
        public string ApiVersion { get; }
        /// <summary> Operation Description. </summary>
        public string Description { get; }
        /// <summary> A Valid HTTP Operation Method. Typical Http Methods like GET, PUT, POST but not limited by only them. </summary>
        public string Method { get; }
        /// <summary> Relative URL template identifying the target resource for this operation. May include parameters. Example: /customers/{cid}/orders/{oid}/?date={date}. </summary>
        public string UriTemplate { get; }
    }
}
