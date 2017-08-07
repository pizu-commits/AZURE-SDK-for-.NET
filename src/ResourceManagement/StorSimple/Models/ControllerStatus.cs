// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for ControllerStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ControllerStatus
    {
        [EnumMember(Value = "NotPresent")]
        NotPresent,
        [EnumMember(Value = "PoweredOff")]
        PoweredOff,
        [EnumMember(Value = "Ok")]
        Ok,
        [EnumMember(Value = "Recovering")]
        Recovering,
        [EnumMember(Value = "Warning")]
        Warning,
        [EnumMember(Value = "Failure")]
        Failure
    }
    internal static class ControllerStatusEnumExtension
    {
        internal static string ToSerializedValue(this ControllerStatus? value)
        {
            return value == null ? null : ((ControllerStatus)value).ToSerializedValue();
        }

        internal static string ToSerializedValue(this ControllerStatus value)
        {
            switch( value )
            {
                case ControllerStatus.NotPresent:
                    return "NotPresent";
                case ControllerStatus.PoweredOff:
                    return "PoweredOff";
                case ControllerStatus.Ok:
                    return "Ok";
                case ControllerStatus.Recovering:
                    return "Recovering";
                case ControllerStatus.Warning:
                    return "Warning";
                case ControllerStatus.Failure:
                    return "Failure";
            }
            return null;
        }

        internal static ControllerStatus? ParseControllerStatus(this string value)
        {
            switch( value )
            {
                case "NotPresent":
                    return ControllerStatus.NotPresent;
                case "PoweredOff":
                    return ControllerStatus.PoweredOff;
                case "Ok":
                    return ControllerStatus.Ok;
                case "Recovering":
                    return ControllerStatus.Recovering;
                case "Warning":
                    return ControllerStatus.Warning;
                case "Failure":
                    return ControllerStatus.Failure;
            }
            return null;
        }
    }
}
