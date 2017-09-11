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
    /// Defines values for AccessTier.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AccessTier
    {
        [EnumMember(Value = "Hot")]
        Hot,
        [EnumMember(Value = "Cool")]
        Cool
    }
    internal static class AccessTierEnumExtension
    {
        internal static string ToSerializedValue(this AccessTier? value)  =>
            value == null ? null : ((AccessTier)value).ToSerializedValue();

        internal static string ToSerializedValue(this AccessTier value)
        {
            switch( value )
            {
                case AccessTier.Hot:
                    return "Hot";
                case AccessTier.Cool:
                    return "Cool";
            }
            return null;
        }

        internal static AccessTier? ParseAccessTier(this string value)
        {
            switch( value )
            {
                case "Hot":
                    return AccessTier.Hot;
                case "Cool":
                    return AccessTier.Cool;
            }
            return null;
        }
    }
}
