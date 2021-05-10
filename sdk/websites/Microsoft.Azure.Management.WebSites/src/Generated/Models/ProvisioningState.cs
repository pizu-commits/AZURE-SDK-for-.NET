// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.WebSites.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ProvisioningState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ProvisioningState
    {
        [EnumMember(Value = "Succeeded")]
        Succeeded,
        [EnumMember(Value = "Failed")]
        Failed,
        [EnumMember(Value = "Canceled")]
        Canceled,
        [EnumMember(Value = "InProgress")]
        InProgress,
        [EnumMember(Value = "Deleting")]
        Deleting
    }
    internal static class ProvisioningStateEnumExtension
    {
        internal static string ToSerializedValue(this ProvisioningState? value)
        {
            return value == null ? null : ((ProvisioningState)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ProvisioningState value)
        {
            switch( value )
            {
                case ProvisioningState.Succeeded:
                    return "Succeeded";
                case ProvisioningState.Failed:
                    return "Failed";
                case ProvisioningState.Canceled:
                    return "Canceled";
                case ProvisioningState.InProgress:
                    return "InProgress";
                case ProvisioningState.Deleting:
                    return "Deleting";
            }
            return null;
        }

        internal static ProvisioningState? ParseProvisioningState(this string value)
        {
            switch( value )
            {
                case "Succeeded":
                    return ProvisioningState.Succeeded;
                case "Failed":
                    return ProvisioningState.Failed;
                case "Canceled":
                    return ProvisioningState.Canceled;
                case "InProgress":
                    return ProvisioningState.InProgress;
                case "Deleting":
                    return ProvisioningState.Deleting;
            }
            return null;
        }
    }
}
