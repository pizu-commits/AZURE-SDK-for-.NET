// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary>
    /// The number of past periods to lag from the target column.
    /// Please note &lt;see cref=&quot;TargetLags&quot;/&gt; is the base class. In order to more specifically assign or retrieve the value of this property, the derived class is needed.
    /// The available derived classes include &lt;see cref=&quot;AutoTargetLags&quot;/&gt;, &lt;see cref=&quot;CustomTargetLags&quot;/&gt;.
    /// </summary>
    public partial class TargetLags
    {
        /// <summary> Initializes a new instance of TargetLags. </summary>
        public TargetLags()
        {
        }

        /// <summary> Initializes a new instance of TargetLags. </summary>
        /// <param name="mode"> [Required] Set target lags mode - Auto/Custom. </param>
        internal TargetLags(TargetLagsMode mode)
        {
            Mode = mode;
        }

        /// <summary> [Required] Set target lags mode - Auto/Custom. </summary>
        internal TargetLagsMode Mode { get; set; }
    }
}
