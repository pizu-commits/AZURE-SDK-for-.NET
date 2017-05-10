// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for PossibleOperationsDirections.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PossibleOperationsDirections
    {
        [EnumMember(Value = "PrimaryToRecovery")]
        PrimaryToRecovery,
        [EnumMember(Value = "RecoveryToPrimary")]
        RecoveryToPrimary
    }
}
