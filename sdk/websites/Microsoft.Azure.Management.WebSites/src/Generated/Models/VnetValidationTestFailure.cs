// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Microsoft.Azure.Management.WebSites.Models
{
    /// <summary> A class that describes a test that failed during NSG and UDR validation. </summary>
    public partial class VnetValidationTestFailure : ProxyOnlyResource
    {
        /// <summary> Initializes a new instance of VnetValidationTestFailure. </summary>
        public VnetValidationTestFailure()
        {
        }

        /// <summary> Initializes a new instance of VnetValidationTestFailure. </summary>
        /// <param name="id"> Resource Id. </param>
        /// <param name="name"> Resource Name. </param>
        /// <param name="kind"> Kind of resource. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="testName"> The name of the test that failed. </param>
        /// <param name="details"> The details of what caused the failure, e.g. the blocking rule name, etc. </param>
        internal VnetValidationTestFailure(string id, string name, string kind, string type, string testName, string details) : base(id, name, kind, type)
        {
            TestName = testName;
            Details = details;
        }

        /// <summary> The name of the test that failed. </summary>
        public string TestName { get; set; }
        /// <summary> The details of what caused the failure, e.g. the blocking rule name, etc. </summary>
        public string Details { get; set; }
    }
}
