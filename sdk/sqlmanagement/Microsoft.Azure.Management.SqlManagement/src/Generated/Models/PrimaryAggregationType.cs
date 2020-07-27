// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Sql.Models
{
    using Newtonsoft.Json;

    /// <summary>
    /// Defines values for PrimaryAggregationType.
    /// </summary>
    /// <summary>
    /// Determine base value for a given allowed value if exists, else return
    /// the value itself
    /// </summary>
    [JsonConverter(typeof(PrimaryAggregationTypeConverter))]
    public struct PrimaryAggregationType : System.IEquatable<PrimaryAggregationType>
    {
        private PrimaryAggregationType(string underlyingValue)
        {
            UnderlyingValue=underlyingValue;
        }

        public static readonly PrimaryAggregationType None = "None";

        public static readonly PrimaryAggregationType Average = "Average";

        public static readonly PrimaryAggregationType Count = "Count";

        public static readonly PrimaryAggregationType Minimum = "Minimum";

        public static readonly PrimaryAggregationType Maximum = "Maximum";

        public static readonly PrimaryAggregationType Total = "Total";


        /// <summary>
        /// Underlying value of enum PrimaryAggregationType
        /// </summary>
        private readonly string UnderlyingValue;

        /// <summary>
        /// Returns string representation for PrimaryAggregationType
        /// </summary>
        public override string ToString()
        {
            return UnderlyingValue.ToString();
        }

        /// <summary>
        /// Compares enums of type PrimaryAggregationType
        /// </summary>
        public bool Equals(PrimaryAggregationType e)
        {
            return UnderlyingValue.Equals(e.UnderlyingValue);
        }

        /// <summary>
        /// Implicit operator to convert string to PrimaryAggregationType
        /// </summary>
        public static implicit operator PrimaryAggregationType(string value)
        {
            return new PrimaryAggregationType(value);
        }

        /// <summary>
        /// Implicit operator to convert PrimaryAggregationType to string
        /// </summary>
        public static implicit operator string(PrimaryAggregationType e)
        {
            return e.UnderlyingValue;
        }

        /// <summary>
        /// Overriding == operator for enum PrimaryAggregationType
        /// </summary>
        public static bool operator == (PrimaryAggregationType e1, PrimaryAggregationType e2)
        {
            return e2.Equals(e1);
        }

        /// <summary>
        /// Overriding != operator for enum PrimaryAggregationType
        /// </summary>
        public static bool operator != (PrimaryAggregationType e1, PrimaryAggregationType e2)
        {
            return !e2.Equals(e1);
        }

        /// <summary>
        /// Overrides Equals operator for PrimaryAggregationType
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is PrimaryAggregationType && Equals((PrimaryAggregationType)obj);
        }

        /// <summary>
        /// Returns for hashCode PrimaryAggregationType
        /// </summary>
        public override int GetHashCode()
        {
            return UnderlyingValue.GetHashCode();
        }

    }
}
