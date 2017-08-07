// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.CustomerInsights.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.CustomerInsights;
    using Microsoft.Azure.Management.CustomerInsights.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The complete operation.
    /// </summary>
    public partial class ConnectorMappingCompleteOperation
    {
        /// <summary>
        /// Initializes a new instance of the ConnectorMappingCompleteOperation
        /// class.
        /// </summary>
        public ConnectorMappingCompleteOperation()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ConnectorMappingCompleteOperation
        /// class.
        /// </summary>
        /// <param name="completionOperationType">The type of completion
        /// operation. Possible values include: 'DoNothing', 'DeleteFile',
        /// 'MoveFile'</param>
        /// <param name="destinationFolder">The destination folder where files
        /// will be moved to once the import is done.</param>
        public ConnectorMappingCompleteOperation(CompletionOperationTypes? completionOperationType = default(CompletionOperationTypes?), string destinationFolder = default(string))
        {
            CompletionOperationType = completionOperationType;
            DestinationFolder = destinationFolder;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the type of completion operation. Possible values
        /// include: 'DoNothing', 'DeleteFile', 'MoveFile'
        /// </summary>
        [JsonProperty(PropertyName = "completionOperationType")]
        public CompletionOperationTypes? CompletionOperationType { get; set; }

        /// <summary>
        /// Gets or sets the destination folder where files will be moved to
        /// once the import is done.
        /// </summary>
        [JsonProperty(PropertyName = "destinationFolder")]
        public string DestinationFolder { get; set; }

    }
}
