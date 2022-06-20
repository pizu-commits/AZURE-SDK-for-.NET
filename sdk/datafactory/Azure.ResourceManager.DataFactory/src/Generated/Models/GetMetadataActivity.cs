// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.DataFactory.Models
{
    /// <summary> Activity to get metadata of dataset. </summary>
    public partial class GetMetadataActivity : ExecutionActivity
    {
        /// <summary> Initializes a new instance of GetMetadataActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="dataset"> GetMetadata activity dataset reference. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="dataset"/> is null. </exception>
        public GetMetadataActivity(string name, DatasetReference dataset) : base(name)
        {
            if (name == null)
            {
                throw new ArgumentNullException(nameof(name));
            }
            if (dataset == null)
            {
                throw new ArgumentNullException(nameof(dataset));
            }

            Dataset = dataset;
            FieldList = new ChangeTrackingList<BinaryData>();
            ActivityType = "GetMetadata";
        }

        /// <summary> Initializes a new instance of GetMetadataActivity. </summary>
        /// <param name="name"> Activity name. </param>
        /// <param name="activityType"> Type of activity. </param>
        /// <param name="description"> Activity description. </param>
        /// <param name="dependsOn"> Activity depends on condition. </param>
        /// <param name="userProperties"> Activity user properties. </param>
        /// <param name="additionalProperties"> Additional Properties. </param>
        /// <param name="linkedServiceName"> Linked service reference. </param>
        /// <param name="policy"> Activity policy. </param>
        /// <param name="dataset"> GetMetadata activity dataset reference. </param>
        /// <param name="fieldList"> Fields of metadata to get from dataset. </param>
        /// <param name="storeSettings">
        /// GetMetadata activity store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleReadSettings"/>, <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/>, <see cref="OracleCloudStorageReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </param>
        /// <param name="formatSettings">
        /// GetMetadata activity format settings.
        /// Please note <see cref="FormatReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BinaryReadSettings"/>, <see cref="JsonReadSettings"/>, <see cref="XmlReadSettings"/> and <see cref="DelimitedTextReadSettings"/>.
        /// </param>
        internal GetMetadataActivity(string name, string activityType, string description, IList<ActivityDependency> dependsOn, IList<UserProperty> userProperties, IDictionary<string, BinaryData> additionalProperties, LinkedServiceReference linkedServiceName, ActivityPolicy policy, DatasetReference dataset, IList<BinaryData> fieldList, StoreReadSettings storeSettings, FormatReadSettings formatSettings) : base(name, activityType, description, dependsOn, userProperties, additionalProperties, linkedServiceName, policy)
        {
            Dataset = dataset;
            FieldList = fieldList;
            StoreSettings = storeSettings;
            FormatSettings = formatSettings;
            ActivityType = activityType ?? "GetMetadata";
        }

        /// <summary> GetMetadata activity dataset reference. </summary>
        public DatasetReference Dataset { get; set; }
        /// <summary> Fields of metadata to get from dataset. </summary>
        public IList<BinaryData> FieldList { get; }
        /// <summary>
        /// GetMetadata activity store settings.
        /// Please note <see cref="StoreReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="AmazonS3CompatibleReadSettings"/>, <see cref="AmazonS3ReadSettings"/>, <see cref="AzureBlobFSReadSettings"/>, <see cref="AzureBlobStorageReadSettings"/>, <see cref="AzureDataLakeStoreReadSettings"/>, <see cref="AzureFileStorageReadSettings"/>, <see cref="FileServerReadSettings"/>, <see cref="FtpReadSettings"/>, <see cref="GoogleCloudStorageReadSettings"/>, <see cref="HdfsReadSettings"/>, <see cref="HttpReadSettings"/>, <see cref="OracleCloudStorageReadSettings"/> and <see cref="SftpReadSettings"/>.
        /// </summary>
        public StoreReadSettings StoreSettings { get; set; }
        /// <summary>
        /// GetMetadata activity format settings.
        /// Please note <see cref="FormatReadSettings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="BinaryReadSettings"/>, <see cref="JsonReadSettings"/>, <see cref="XmlReadSettings"/> and <see cref="DelimitedTextReadSettings"/>.
        /// </summary>
        public FormatReadSettings FormatSettings { get; set; }
    }
}
