// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.ContentSafety
{
    /// <summary> The image analysis request. </summary>
    public partial class AnalyzeImageOptions
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

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOptions"/>. </summary>
        /// <param name="image"> The image needs to be analyzed. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="image"/> is null. </exception>
        public AnalyzeImageOptions(ContentSafetyImageData image)
        {
            Argument.AssertNotNull(image, nameof(image));

            Image = image;
            Categories = new ChangeTrackingList<ImageCategory>();
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOptions"/>. </summary>
        /// <param name="image"> The image needs to be analyzed. </param>
        /// <param name="categories"> The categories will be analyzed. If they are not assigned, a default set of analysis results for the categories will be returned. </param>
        /// <param name="outputType"> This refers to the type of image analysis output. If no value is assigned, the default value will be "FourSeverityLevels". </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AnalyzeImageOptions(ContentSafetyImageData image, IList<ImageCategory> categories, AnalyzeImageOutputType? outputType, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Image = image;
            Categories = categories;
            OutputType = outputType;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AnalyzeImageOptions"/> for deserialization. </summary>
        internal AnalyzeImageOptions()
        {
        }

        /// <summary> The image needs to be analyzed. </summary>
        public ContentSafetyImageData Image { get; }
        /// <summary> The categories will be analyzed. If they are not assigned, a default set of analysis results for the categories will be returned. </summary>
        public IList<ImageCategory> Categories { get; }
        /// <summary> This refers to the type of image analysis output. If no value is assigned, the default value will be "FourSeverityLevels". </summary>
        public AnalyzeImageOutputType? OutputType { get; set; }
    }
}
