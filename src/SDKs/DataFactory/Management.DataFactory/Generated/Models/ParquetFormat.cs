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
    using System.Linq;

    /// <summary>
    /// The data stored in Parquet format.
    /// </summary>
    public partial class ParquetFormat : DatasetStorageFormat
    {
        /// <summary>
        /// Initializes a new instance of the ParquetFormat class.
        /// </summary>
        public ParquetFormat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ParquetFormat class.
        /// </summary>
        /// <param name="serializer">Serializer. Type: string (or Expression
        /// with resultType string).</param>
        /// <param name="deserializer">Deserializer. Type: string (or
        /// Expression with resultType string).</param>
        public ParquetFormat(object serializer = default(object), object deserializer = default(object))
            : base(serializer, deserializer)
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

    }
}
