// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// Forecasting target rolling window size.
    /// Please note &lt;see cref=&quot;TargetRollingWindowSize&quot;/&gt; is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include &lt;see cref=&quot;AutoTargetRollingWindowSize&quot;/&gt;, &lt;see cref=&quot;CustomTargetRollingWindowSize&quot;/&gt;.
    /// </summary>
    public partial class TargetRollingWindowSize
    {
        /// <summary> Initializes a new instance of TargetRollingWindowSize. </summary>
        public TargetRollingWindowSize()
        {
        }

        /// <summary> Initializes a new instance of TargetRollingWindowSize. </summary>
        /// <param name="mode"> [Required] TargetRollingWindowSiz detection mode. </param>
        internal TargetRollingWindowSize(TargetRollingWindowSizeMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] TargetRollingWindowSiz detection mode. </summary>
        internal TargetRollingWindowSizeMode Mode { get; set; }
    }
}
