// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Storage.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.Storage;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for HttpProtocol.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HttpProtocol
    {
        [EnumMember(Value = "https,http")]
        Httpshttp,
        [EnumMember(Value = "https")]
        Https
    }
    internal static class HttpProtocolEnumExtension
    {
        internal static string ToSerializedValue(this HttpProtocol? value)  =>
            value == null ? null : ((HttpProtocol)value).ToSerializedValue();

        internal static string ToSerializedValue(this HttpProtocol value)
        {
            switch( value )
            {
                case HttpProtocol.Httpshttp:
                    return "https,http";
                case HttpProtocol.Https:
                    return "https";
            }
            return null;
        }

        internal static HttpProtocol? ParseHttpProtocol(this string value)
        {
            switch( value )
            {
                case "https,http":
                    return HttpProtocol.Httpshttp;
                case "https":
                    return HttpProtocol.Https;
            }
            return null;
        }
    }
}
