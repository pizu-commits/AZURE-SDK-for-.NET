// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 2.2.22.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The format definition of a storage.
    /// </summary>
    public partial class DatasetStorageFormat
    {
        /// <summary>
        /// Initializes a new instance of the DatasetStorageFormat class.
        /// </summary>
        public DatasetStorageFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the DatasetStorageFormat class.
        /// </summary>
        /// <param name="serializer">Serializer. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="deserializer">Deserializer. Type: string (or
        /// Expression with resultType string).</param>
        public DatasetStorageFormat(object serializer = default(object), object deserializer = default(object))
        {
            Serializer = serializer;
            Deserializer = deserializer;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets serializer. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "serializer")]
        public object Serializer { get; set; }

        /// <summary>
        /// Gets or sets deserializer. Type: string (or Expression with
        /// resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "deserializer")]
        public object Deserializer { get; set; }

    }
}
