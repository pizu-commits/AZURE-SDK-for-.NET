// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.DataFactory.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The Amazon S3 settings needed for the interim Amazon S3 when copying
    /// from Amazon Redshift with unload. With this, data from Amazon Redshift
    /// source will be unloaded into S3 first and then copied into the targeted
    /// sink from the interim S3.
    /// </summary>
    public partial class RedshiftUnloadSettings
    {
        /// <summary>
        /// Initializes a new instance of the RedshiftUnloadSettings class.
        /// </summary>
        public RedshiftUnloadSettings()
        {
            S3LinkedServiceName = new LinkedServiceReference();
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RedshiftUnloadSettings class.
        /// </summary>
        /// <param name="s3LinkedServiceName">The name of the Amazon S3 linked
        /// service which will be used for the unload operation when copying
        /// from the Amazon Redshift source.</param>
        /// <param name="bucketName">The bucket of the interim Amazon S3 which
        /// will be used to store the unloaded data from Amazon Redshift
        /// source. The bucket must be in the same region as the Amazon
        /// Redshift source. Type: string (or Expression with resultType
        /// string).</param>
        public RedshiftUnloadSettings(LinkedServiceReference s3LinkedServiceName, object bucketName)
        {
            S3LinkedServiceName = s3LinkedServiceName;
            BucketName = bucketName;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the name of the Amazon S3 linked service which will be
        /// used for the unload operation when copying from the Amazon Redshift
        /// source.
        /// </summary>
        [JsonProperty(PropertyName = "s3LinkedServiceName")]
        public LinkedServiceReference S3LinkedServiceName { get; set; }

        /// <summary>
        /// Gets or sets the bucket of the interim Amazon S3 which will be used
        /// to store the unloaded data from Amazon Redshift source. The bucket
        /// must be in the same region as the Amazon Redshift source. Type:
        /// string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "bucketName")]
        public object BucketName { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (S3LinkedServiceName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "S3LinkedServiceName");
            }
            if (BucketName == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "BucketName");
            }
            if (S3LinkedServiceName != null)
            {
                S3LinkedServiceName.Validate();
            }
        }
    }
}
