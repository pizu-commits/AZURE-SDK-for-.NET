// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Models;
using Azure.ResourceManager.SecurityInsights.Models;

namespace Azure.ResourceManager.SecurityInsights
{
    /// <summary>
    /// A class representing the SecurityInsightsWatchlist data model.
    /// Represents a Watchlist in Azure Security Insights.
    /// </summary>
    public partial class SecurityInsightsWatchlistData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsWatchlistData"/>. </summary>
        public SecurityInsightsWatchlistData()
        {
            Labels = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="SecurityInsightsWatchlistData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="watchlistId"> The id (a Guid) of the watchlist. </param>
        /// <param name="displayName"> The display name of the watchlist. </param>
        /// <param name="provider"> The provider of the watchlist. </param>
        /// <param name="source"> The source of the watchlist. </param>
        /// <param name="createdOn"> The time the watchlist was created. </param>
        /// <param name="updatedOn"> The last time the watchlist was updated. </param>
        /// <param name="createdBy"> Describes a user that created the watchlist. </param>
        /// <param name="updatedBy"> Describes a user that updated the watchlist. </param>
        /// <param name="description"> A description of the watchlist. </param>
        /// <param name="watchlistType"> The type of the watchlist. </param>
        /// <param name="watchlistAlias"> The alias of the watchlist. </param>
        /// <param name="isDeleted"> A flag that indicates if the watchlist is deleted or not. </param>
        /// <param name="labels"> List of labels relevant to this watchlist. </param>
        /// <param name="defaultDuration"> The default duration of a watchlist (in ISO 8601 duration format). </param>
        /// <param name="tenantId"> The tenantId where the watchlist belongs to. </param>
        /// <param name="numberOfLinesToSkip"> The number of lines in a csv content to skip before the header. </param>
        /// <param name="rawContent">
        /// The raw content that represents to watchlist items to create. Example : This line will be skipped
        /// header1,header2
        /// value1,value2
        /// </param>
        /// <param name="itemsSearchKey"> The search key is used to optimize query performance when using watchlists for joins with other data. For example, enable a column with IP addresses to be the designated SearchKey field, then use this field as the key field when joining to other event data by IP address. </param>
        /// <param name="contentType"> The content type of the raw content. For now, only text/csv is valid. </param>
        /// <param name="uploadStatus"> The status of the Watchlist upload : New, InProgress or Complete. **Note** : When a Watchlist upload status is InProgress, the Watchlist cannot be deleted. </param>
        /// <param name="etag"> Etag of the azure resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal SecurityInsightsWatchlistData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, Guid? watchlistId, string displayName, string provider, Source? source, DateTimeOffset? createdOn, DateTimeOffset? updatedOn, SecurityInsightsUserInfo createdBy, SecurityInsightsUserInfo updatedBy, string description, string watchlistType, string watchlistAlias, bool? isDeleted, IList<string> labels, TimeSpan? defaultDuration, Guid? tenantId, int? numberOfLinesToSkip, string rawContent, string itemsSearchKey, string contentType, string uploadStatus, ETag? etag, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            WatchlistId = watchlistId;
            DisplayName = displayName;
            Provider = provider;
            Source = source;
            CreatedOn = createdOn;
            UpdatedOn = updatedOn;
            CreatedBy = createdBy;
            UpdatedBy = updatedBy;
            Description = description;
            WatchlistType = watchlistType;
            WatchlistAlias = watchlistAlias;
            IsDeleted = isDeleted;
            Labels = labels;
            DefaultDuration = defaultDuration;
            TenantId = tenantId;
            NumberOfLinesToSkip = numberOfLinesToSkip;
            RawContent = rawContent;
            ItemsSearchKey = itemsSearchKey;
            ContentType = contentType;
            UploadStatus = uploadStatus;
            ETag = etag;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The id (a Guid) of the watchlist. </summary>
        public Guid? WatchlistId { get; set; }
        /// <summary> The display name of the watchlist. </summary>
        public string DisplayName { get; set; }
        /// <summary> The provider of the watchlist. </summary>
        public string Provider { get; set; }
        /// <summary> The source of the watchlist. </summary>
        public Source? Source { get; set; }
        /// <summary> The time the watchlist was created. </summary>
        public DateTimeOffset? CreatedOn { get; set; }
        /// <summary> The last time the watchlist was updated. </summary>
        public DateTimeOffset? UpdatedOn { get; set; }
        /// <summary> Describes a user that created the watchlist. </summary>
        public SecurityInsightsUserInfo CreatedBy { get; set; }
        /// <summary> Describes a user that updated the watchlist. </summary>
        public SecurityInsightsUserInfo UpdatedBy { get; set; }
        /// <summary> A description of the watchlist. </summary>
        public string Description { get; set; }
        /// <summary> The type of the watchlist. </summary>
        public string WatchlistType { get; set; }
        /// <summary> The alias of the watchlist. </summary>
        public string WatchlistAlias { get; set; }
        /// <summary> A flag that indicates if the watchlist is deleted or not. </summary>
        public bool? IsDeleted { get; set; }
        /// <summary> List of labels relevant to this watchlist. </summary>
        public IList<string> Labels { get; }
        /// <summary> The default duration of a watchlist (in ISO 8601 duration format). </summary>
        public TimeSpan? DefaultDuration { get; set; }
        /// <summary> The tenantId where the watchlist belongs to. </summary>
        public Guid? TenantId { get; set; }
        /// <summary> The number of lines in a csv content to skip before the header. </summary>
        public int? NumberOfLinesToSkip { get; set; }
        /// <summary>
        /// The raw content that represents to watchlist items to create. Example : This line will be skipped
        /// header1,header2
        /// value1,value2
        /// </summary>
        public string RawContent { get; set; }
        /// <summary> The search key is used to optimize query performance when using watchlists for joins with other data. For example, enable a column with IP addresses to be the designated SearchKey field, then use this field as the key field when joining to other event data by IP address. </summary>
        public string ItemsSearchKey { get; set; }
        /// <summary> The content type of the raw content. For now, only text/csv is valid. </summary>
        public string ContentType { get; set; }
        /// <summary> The status of the Watchlist upload : New, InProgress or Complete. **Note** : When a Watchlist upload status is InProgress, the Watchlist cannot be deleted. </summary>
        public string UploadStatus { get; set; }
        /// <summary> Etag of the azure resource. </summary>
        public ETag? ETag { get; set; }
    }
}
