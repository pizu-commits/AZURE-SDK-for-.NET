// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.AppPlatform.Models
{
    /// <summary> API route config of the Spring Cloud Gateway. </summary>
    public partial class AppPlatformGatewayApiRoute
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

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayApiRoute"/>. </summary>
        public AppPlatformGatewayApiRoute()
        {
            Predicates = new ChangeTrackingList<string>();
            Filters = new ChangeTrackingList<string>();
            Tags = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="AppPlatformGatewayApiRoute"/>. </summary>
        /// <param name="title"> A title, will be applied to methods in the generated OpenAPI documentation. </param>
        /// <param name="description"> A description, will be applied to methods in the generated OpenAPI documentation. </param>
        /// <param name="uri"> Full uri, will override `appName`. </param>
        /// <param name="isSsoEnabled"> Enable sso validation. </param>
        /// <param name="isTokenRelayed"> Pass currently-authenticated user's identity token to application service, default is 'false'. </param>
        /// <param name="predicates"> A number of conditions to evaluate a route for each request. Each predicate may be evaluated against request headers and parameter values. All of the predicates associated with a route must evaluate to true for the route to be matched to the request. </param>
        /// <param name="filters"> To modify the request before sending it to the target endpoint, or the received response. </param>
        /// <param name="order"> Route processing order. </param>
        /// <param name="tags"> Classification tags, will be applied to methods in the generated OpenAPI documentation. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AppPlatformGatewayApiRoute(string title, string description, Uri uri, bool? isSsoEnabled, bool? isTokenRelayed, IList<string> predicates, IList<string> filters, int? order, IList<string> tags, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Title = title;
            Description = description;
            Uri = uri;
            IsSsoEnabled = isSsoEnabled;
            IsTokenRelayed = isTokenRelayed;
            Predicates = predicates;
            Filters = filters;
            Order = order;
            Tags = tags;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> A title, will be applied to methods in the generated OpenAPI documentation. </summary>
        public string Title { get; set; }
        /// <summary> A description, will be applied to methods in the generated OpenAPI documentation. </summary>
        public string Description { get; set; }
        /// <summary> Full uri, will override `appName`. </summary>
        public Uri Uri { get; set; }
        /// <summary> Enable sso validation. </summary>
        public bool? IsSsoEnabled { get; set; }
        /// <summary> Pass currently-authenticated user's identity token to application service, default is 'false'. </summary>
        public bool? IsTokenRelayed { get; set; }
        /// <summary> A number of conditions to evaluate a route for each request. Each predicate may be evaluated against request headers and parameter values. All of the predicates associated with a route must evaluate to true for the route to be matched to the request. </summary>
        public IList<string> Predicates { get; }
        /// <summary> To modify the request before sending it to the target endpoint, or the received response. </summary>
        public IList<string> Filters { get; }
        /// <summary> Route processing order. </summary>
        public int? Order { get; set; }
        /// <summary> Classification tags, will be applied to methods in the generated OpenAPI documentation. </summary>
        public IList<string> Tags { get; }
    }
}
