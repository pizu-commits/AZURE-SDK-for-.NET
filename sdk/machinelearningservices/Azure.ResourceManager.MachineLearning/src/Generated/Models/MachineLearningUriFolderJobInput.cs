// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.ResourceManager.MachineLearning;

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The MachineLearningUriFolderJobInput. </summary>
    public partial class MachineLearningUriFolderJobInput : MachineLearningJobInput
    {
        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFolderJobInput"/>. </summary>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public MachineLearningUriFolderJobInput(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
            JobInputType = JobInputType.UriFolder;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFolderJobInput"/>. </summary>
        /// <param name="description"> Description for the input. </param>
        /// <param name="jobInputType"> [Required] Specifies the type of job. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="mode"> Input Asset Delivery Mode. </param>
        /// <param name="uri"> [Required] Input Asset URI. </param>
        internal MachineLearningUriFolderJobInput(string description, JobInputType jobInputType, IDictionary<string, BinaryData> serializedAdditionalRawData, MachineLearningInputDeliveryMode? mode, Uri uri) : base(description, jobInputType, serializedAdditionalRawData)
        {
            Mode = mode;
            Uri = uri;
            JobInputType = jobInputType;
        }

        /// <summary> Initializes a new instance of <see cref="MachineLearningUriFolderJobInput"/> for deserialization. </summary>
        internal MachineLearningUriFolderJobInput()
        {
        }

        /// <summary> Input Asset Delivery Mode. </summary>
        public MachineLearningInputDeliveryMode? Mode { get; set; }
        /// <summary> [Required] Input Asset URI. </summary>
        public Uri Uri { get; set; }
    }
}
