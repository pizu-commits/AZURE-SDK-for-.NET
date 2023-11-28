// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Kusto.Models
{
    /// <summary> Azure capacity definition. </summary>
    public partial class KustoCapacity
    {
        /// <summary> Initializes a new instance of <see cref="KustoCapacity"/>. </summary>
        /// <param name="scaleType"> Scale type. </param>
        /// <param name="minimum"> Minimum allowed capacity. </param>
        /// <param name="maximum"> Maximum allowed capacity. </param>
        /// <param name="default"> The default capacity that would be used. </param>
        internal KustoCapacity(KustoScaleType scaleType, int minimum, int maximum, int @default)
        {
            ScaleType = scaleType;
            Minimum = minimum;
            Maximum = maximum;
            Default = @default;
        }

        /// <summary> Scale type. </summary>
        public KustoScaleType ScaleType { get; }
        /// <summary> Minimum allowed capacity. </summary>
        public int Minimum { get; }
        /// <summary> Maximum allowed capacity. </summary>
        public int Maximum { get; }
        /// <summary> The default capacity that would be used. </summary>
        public int Default { get; }
    }
}
