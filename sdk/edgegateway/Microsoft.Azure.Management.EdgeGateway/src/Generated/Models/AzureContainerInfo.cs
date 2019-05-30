// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Azure container mapping of the endpoint.
    /// </summary>
    public partial class AzureContainerInfo
    {
        /// <summary>
        /// Initializes a new instance of the AzureContainerInfo class.
        /// </summary>
        public AzureContainerInfo()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the AzureContainerInfo class.
        /// </summary>
        /// <param name="storageAccountCredentialId">ID of the storage account
        /// credential used to access storage.</param>
        /// <param name="containerName">Container name (Based on the data
        /// format specified, this represents the name of Azure Files/Page
        /// blob/Block blob).</param>
        /// <param name="dataFormat">Storage format used for the file
        /// represented by the share. Possible values include: 'BlockBlob',
        /// 'PageBlob', 'AzureFile'</param>
        public AzureContainerInfo(string storageAccountCredentialId, string containerName, string dataFormat)
        {
            StorageAccountCredentialId = storageAccountCredentialId;
            ContainerName = containerName;
            DataFormat = dataFormat;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the storage account credential used to access
        /// storage.
        /// </summary>
        [JsonProperty(PropertyName = "storageAccountCredentialId")]
        public string StorageAccountCredentialId { get; set; }

        /// <summary>
        /// Gets or sets container name (Based on the data format specified,
        /// this represents the name of Azure Files/Page blob/Block blob).
        /// </summary>
        [JsonProperty(PropertyName = "containerName")]
        public string ContainerName { get; set; }

        /// <summary>
        /// Gets or sets storage format used for the file represented by the
        /// share. Possible values include: 'BlockBlob', 'PageBlob',
        /// 'AzureFile'
        /// </summary>
        [JsonProperty(PropertyName = "dataFormat")]
        public string DataFormat { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (StorageAccountCredentialId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "StorageAccountCredentialId");
            }
            if (ContainerName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "ContainerName");
            }
            if (DataFormat == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "DataFormat");
            }
        }
    }
}
