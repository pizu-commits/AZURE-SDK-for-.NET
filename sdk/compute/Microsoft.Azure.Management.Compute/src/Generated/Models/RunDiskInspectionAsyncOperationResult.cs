// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Api output result when disk inspection result is completed.
    /// </summary>
    public partial class RunDiskInspectionAsyncOperationResult
    {
        /// <summary>
        /// Initializes a new instance of the
        /// RunDiskInspectionAsyncOperationResult class.
        /// </summary>
        public RunDiskInspectionAsyncOperationResult()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// RunDiskInspectionAsyncOperationResult class.
        /// </summary>
        /// <param name="resultStatus">Possible values include: 'Success',
        /// 'Failed'</param>
        /// <param name="createdUTC">The time when the disk inspection was
        /// completed.</param>
        public RunDiskInspectionAsyncOperationResult(string result = default(string), string resultStatus = default(string), ErrorDetail errorDetail = default(ErrorDetail), System.DateTime? createdUTC = default(System.DateTime?))
        {
            Result = result;
            ResultStatus = resultStatus;
            ErrorDetail = errorDetail;
            CreatedUTC = createdUTC;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'Success', 'Failed'
        /// </summary>
        [JsonProperty(PropertyName = "resultStatus")]
        public string ResultStatus { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "errorDetail")]
        public ErrorDetail ErrorDetail { get; set; }

        /// <summary>
        /// Gets or sets the time when the disk inspection was completed.
        /// </summary>
        [JsonProperty(PropertyName = "createdUTC")]
        public System.DateTime? CreatedUTC { get; set; }

    }
}
