// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.ApiManagement.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ApiManagement;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for UserState.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum UserState
    {
        [EnumMember(Value = "active")]
        Active,
        [EnumMember(Value = "blocked")]
        Blocked
    }
}
