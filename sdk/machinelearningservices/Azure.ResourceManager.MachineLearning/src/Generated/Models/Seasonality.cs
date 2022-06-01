// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting seasonality.
    /// Please note &lt;see cref=&quot;Seasonality&quot;/&gt; is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include &lt;see cref=&quot;AutoSeasonality&quot;/&gt;, &lt;see cref=&quot;CustomSeasonality&quot;/&gt;.
    /// </summary>
    public partial class Seasonality
    {
        /// <summary> Initializes a new instance of Seasonality. </summary>
        public Seasonality()
        {
        }

        /// <summary> Initializes a new instance of Seasonality. </summary>
        /// <param name="mode"> [Required] Seasonality mode. </param>
        internal Seasonality(SeasonalityMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] Seasonality mode. </summary>
        internal SeasonalityMode Mode { get; set; }
    }
}
