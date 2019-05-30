// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Logic.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The X12 delimiter override settings.
    /// </summary>
    public partial class X12DelimiterOverrides
    {
        /// <summary>
        /// Initializes a new instance of the X12DelimiterOverrides class.
        /// </summary>
        public X12DelimiterOverrides()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the X12DelimiterOverrides class.
        /// </summary>
        /// <param name="dataElementSeparator">The data element
        /// separator.</param>
        /// <param name="componentSeparator">The component separator.</param>
        /// <param name="segmentTerminator">The segment terminator.</param>
        /// <param name="segmentTerminatorSuffix">The segment terminator
        /// suffix. Possible values include: 'NotSpecified', 'None', 'CR',
        /// 'LF', 'CRLF'</param>
        /// <param name="replaceCharacter">The replacement character.</param>
        /// <param name="replaceSeparatorsInPayload">The value indicating
        /// whether to replace separators in payload.</param>
        /// <param name="protocolVersion">The protocol version.</param>
        /// <param name="messageId">The message id.</param>
        /// <param name="targetNamespace">The target namespace on which this
        /// delimiter settings has to be applied.</param>
        public X12DelimiterOverrides(int dataElementSeparator, int componentSeparator, int segmentTerminator, SegmentTerminatorSuffix segmentTerminatorSuffix, int replaceCharacter, bool replaceSeparatorsInPayload, string protocolVersion = default(string), string messageId = default(string), string targetNamespace = default(string))
        {
            ProtocolVersion = protocolVersion;
            MessageId = messageId;
            DataElementSeparator = dataElementSeparator;
            ComponentSeparator = componentSeparator;
            SegmentTerminator = segmentTerminator;
            SegmentTerminatorSuffix = segmentTerminatorSuffix;
            ReplaceCharacter = replaceCharacter;
            ReplaceSeparatorsInPayload = replaceSeparatorsInPayload;
            TargetNamespace = targetNamespace;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the protocol version.
        /// </summary>
        [JsonProperty(PropertyName = "protocolVersion")]
        public string ProtocolVersion { get; set; }

        /// <summary>
        /// Gets or sets the message id.
        /// </summary>
        [JsonProperty(PropertyName = "messageId")]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or sets the data element separator.
        /// </summary>
        [JsonProperty(PropertyName = "dataElementSeparator")]
        public int DataElementSeparator { get; set; }

        /// <summary>
        /// Gets or sets the component separator.
        /// </summary>
        [JsonProperty(PropertyName = "componentSeparator")]
        public int ComponentSeparator { get; set; }

        /// <summary>
        /// Gets or sets the segment terminator.
        /// </summary>
        [JsonProperty(PropertyName = "segmentTerminator")]
        public int SegmentTerminator { get; set; }

        /// <summary>
        /// Gets or sets the segment terminator suffix. Possible values
        /// include: 'NotSpecified', 'None', 'CR', 'LF', 'CRLF'
        /// </summary>
        [JsonProperty(PropertyName = "segmentTerminatorSuffix")]
        public SegmentTerminatorSuffix SegmentTerminatorSuffix { get; set; }

        /// <summary>
        /// Gets or sets the replacement character.
        /// </summary>
        [JsonProperty(PropertyName = "replaceCharacter")]
        public int ReplaceCharacter { get; set; }

        /// <summary>
        /// Gets or sets the value indicating whether to replace separators in
        /// payload.
        /// </summary>
        [JsonProperty(PropertyName = "replaceSeparatorsInPayload")]
        public bool ReplaceSeparatorsInPayload { get; set; }

        /// <summary>
        /// Gets or sets the target namespace on which this delimiter settings
        /// has to be applied.
        /// </summary>
        [JsonProperty(PropertyName = "targetNamespace")]
        public string TargetNamespace { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
        }
    }
}
