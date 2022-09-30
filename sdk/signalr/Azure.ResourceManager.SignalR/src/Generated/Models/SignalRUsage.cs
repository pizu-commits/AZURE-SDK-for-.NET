// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.SignalR.Models
{
    /// <summary> Object that describes a specific usage of the resources. </summary>
    public partial class SignalRUsage
    {
        /// <summary> Initializes a new instance of SignalRUsage. </summary>
        internal SignalRUsage()
        {
        }

        /// <summary> Initializes a new instance of SignalRUsage. </summary>
        /// <param name="id"> Fully qualified ARM resource id. </param>
        /// <param name="currentValue"> Current value for the usage quota. </param>
        /// <param name="limit"> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </param>
        /// <param name="name"> Localizable String object containing the name and a localized value. </param>
        /// <param name="unit"> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </param>
        internal SignalRUsage(string id, long? currentValue, long? limit, SignalRUsageName name, string unit)
        {
            Id = id;
            CurrentValue = currentValue;
            Limit = limit;
            Name = name;
            Unit = unit;
        }

        /// <summary> Fully qualified ARM resource id. </summary>
        public string Id { get; }
        /// <summary> Current value for the usage quota. </summary>
        public long? CurrentValue { get; }
        /// <summary> The maximum permitted value for the usage quota. If there is no limit, this value will be -1. </summary>
        public long? Limit { get; }
        /// <summary> Localizable String object containing the name and a localized value. </summary>
        public SignalRUsageName Name { get; }
        /// <summary> Representing the units of the usage quota. Possible values are: Count, Bytes, Seconds, Percent, CountPerSecond, BytesPerSecond. </summary>
        public string Unit { get; }
    }
}
