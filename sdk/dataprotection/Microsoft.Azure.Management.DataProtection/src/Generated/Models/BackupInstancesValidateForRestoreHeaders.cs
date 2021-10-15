// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataProtection.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for ValidateForRestore operation.
    /// </summary>
    public partial class BackupInstancesValidateForRestoreHeaders
    {
        /// <summary>
        /// Initializes a new instance of the
        /// BackupInstancesValidateForRestoreHeaders class.
        /// </summary>
        public BackupInstancesValidateForRestoreHeaders()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// BackupInstancesValidateForRestoreHeaders class.
        /// </summary>
        /// <param name="location">The URL of the resource used to check the
        /// status of the asynchronous operation.</param>
        /// <param name="azureAsyncOperation">The URL of the resource used to
        /// check the status of the asynchronous operation.</param>
        /// <param name="retryAfter">Suggested delay to check the status of the
        /// asynchronous operation. The value is an integer that represents the
        /// seconds.</param>
        public BackupInstancesValidateForRestoreHeaders(string location = default(string), string azureAsyncOperation = default(string), int? retryAfter = default(int?))
        {
            Location = location;
            AzureAsyncOperation = azureAsyncOperation;
            RetryAfter = retryAfter;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the resource used to check the status of
        /// the asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets the URL of the resource used to check the status of
        /// the asynchronous operation.
        /// </summary>
        [JsonProperty(PropertyName = "Azure-AsyncOperation")]
        public string AzureAsyncOperation { get; set; }

        /// <summary>
        /// Gets or sets suggested delay to check the status of the
        /// asynchronous operation. The value is an integer that represents the
        /// seconds.
        /// </summary>
        [JsonProperty(PropertyName = "Retry-After")]
        public int? RetryAfter { get; set; }

    }
}
