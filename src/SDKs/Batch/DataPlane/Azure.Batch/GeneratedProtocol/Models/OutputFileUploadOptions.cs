// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Batch.Protocol.Models
{
    using System.Linq;

    /// <summary>
    /// Details about an output file upload operation, including under what
    /// conditions to perform the upload.
    /// </summary>
    public partial class OutputFileUploadOptions
    {
        /// <summary>
        /// Initializes a new instance of the OutputFileUploadOptions class.
        /// </summary>
        public OutputFileUploadOptions() { }

        /// <summary>
        /// Initializes a new instance of the OutputFileUploadOptions class.
        /// </summary>
        /// <param name="uploadCondition">The conditions under which the task
        /// output file or set of files should be uploaded.</param>
        public OutputFileUploadOptions(OutputFileUploadCondition uploadCondition)
        {
            this.UploadCondition = uploadCondition;
        }

        /// <summary>
        /// Gets or sets the conditions under which the task output file or set
        /// of files should be uploaded.
        /// </summary>
        /// <remarks>
        /// The default is taskCompletion. Possible values include:
        /// 'taskSuccess', 'taskFailure', 'taskCompletion'
        /// </remarks>
        [Newtonsoft.Json.JsonProperty(PropertyName = "uploadCondition")]
        public OutputFileUploadCondition UploadCondition { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
