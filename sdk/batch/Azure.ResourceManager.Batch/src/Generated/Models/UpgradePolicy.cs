// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Batch.Models
{
    /// <summary> Describes an upgrade policy - automatic, manual, or rolling. </summary>
    public partial class UpgradePolicy
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="UpgradePolicy"/>. </summary>
        /// <param name="mode"> Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are automatically updated at the same time.&lt;br /&gt;&lt;br /&gt; **Rolling** - Scale set performs updates in batches with an optional pause time in between. </param>
        public UpgradePolicy(UpgradeMode mode)
        {
            Mode = mode;
        }

        /// <summary> Initializes a new instance of <see cref="UpgradePolicy"/>. </summary>
        /// <param name="mode"> Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are automatically updated at the same time.&lt;br /&gt;&lt;br /&gt; **Rolling** - Scale set performs updates in batches with an optional pause time in between. </param>
        /// <param name="automaticOSUpgradePolicy"> The configuration parameters used for performing automatic OS upgrade. </param>
        /// <param name="rollingUpgradePolicy"> This property is only supported on Pools with the virtualMachineConfiguration property. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal UpgradePolicy(UpgradeMode mode, AutomaticOSUpgradePolicy automaticOSUpgradePolicy, RollingUpgradePolicy rollingUpgradePolicy, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Mode = mode;
            AutomaticOSUpgradePolicy = automaticOSUpgradePolicy;
            RollingUpgradePolicy = rollingUpgradePolicy;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="UpgradePolicy"/> for deserialization. </summary>
        internal UpgradePolicy()
        {
        }

        /// <summary> Specifies the mode of an upgrade to virtual machines in the scale set.&lt;br /&gt;&lt;br /&gt; Possible values are:&lt;br /&gt;&lt;br /&gt; **Manual** - You  control the application of updates to virtual machines in the scale set. You do this by using the manualUpgrade action.&lt;br /&gt;&lt;br /&gt; **Automatic** - All virtual machines in the scale set are automatically updated at the same time.&lt;br /&gt;&lt;br /&gt; **Rolling** - Scale set performs updates in batches with an optional pause time in between. </summary>
        public UpgradeMode Mode { get; set; }
        /// <summary> The configuration parameters used for performing automatic OS upgrade. </summary>
        public AutomaticOSUpgradePolicy AutomaticOSUpgradePolicy { get; set; }
        /// <summary> This property is only supported on Pools with the virtualMachineConfiguration property. </summary>
        public RollingUpgradePolicy RollingUpgradePolicy { get; set; }
    }
}
