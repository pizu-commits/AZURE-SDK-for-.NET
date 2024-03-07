// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Communication.Messages.Models.Channels;

namespace Azure.Communication.Messages
{
    /// <summary> The template object used to create templates. </summary>
    public partial class MessageTemplate
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

        /// <summary> Initializes a new instance of <see cref="MessageTemplate"/>. </summary>
        /// <param name="name"> Name of the template. </param>
        /// <param name="language"> The template's language, in the ISO 639 format, consist of a two-letter language code followed by an optional two-letter country code, e.g., 'en' or 'en_US'. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="language"/> is null. </exception>
        public MessageTemplate(string name, string language)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(language, nameof(language));

            Name = name;
            Language = language;
            Values = new ChangeTrackingList<MessageTemplateValue>();
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplate"/>. </summary>
        /// <param name="name"> Name of the template. </param>
        /// <param name="language"> The template's language, in the ISO 639 format, consist of a two-letter language code followed by an optional two-letter country code, e.g., 'en' or 'en_US'. </param>
        /// <param name="values"> The template values. </param>
        /// <param name="bindings"> The binding object to link values to the template specific locations. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MessageTemplate(string name, string language, IList<MessageTemplateValue> values, MessageTemplateBindings bindings, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            Language = language;
            Values = values;
            Bindings = bindings;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplate"/> for deserialization. </summary>
        internal MessageTemplate()
        {
        }

        /// <summary> Name of the template. </summary>
        public string Name { get; }
        /// <summary> The template's language, in the ISO 639 format, consist of a two-letter language code followed by an optional two-letter country code, e.g., 'en' or 'en_US'. </summary>
        public string Language { get; }
        /// <summary>
        /// The template values.
        /// Please note <see cref="MessageTemplateValue"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="MessageTemplateText"/>, <see cref="MessageTemplateImage"/>, <see cref="MessageTemplateDocument"/>, <see cref="MessageTemplateVideo"/>, <see cref="MessageTemplateLocation"/> and <see cref="MessageTemplateQuickAction"/>.
        /// </summary>
        public IList<MessageTemplateValue> Values { get; }
        /// <summary>
        /// The binding object to link values to the template specific locations
        /// Please note <see cref="MessageTemplateBindings"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="WhatsAppMessageTemplateBindings"/>.
        /// </summary>
        public MessageTemplateBindings Bindings { get; set; }
    }
}
