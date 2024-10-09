// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> The MessageTemplateDocument. </summary>
    public partial class MessageTemplateDocument : MessageTemplateValue
    {
        /// <summary> Initializes a new instance of <see cref="MessageTemplateDocument"/>. </summary>
        /// <param name="name"></param>
        /// <param name="uri"></param>
        /// <exception cref="ArgumentNullException"> <paramref name="name"/> or <paramref name="uri"/> is null. </exception>
        public MessageTemplateDocument(string name, Uri uri) : base(name)
        {
            Argument.AssertNotNull(name, nameof(name));
            Argument.AssertNotNull(uri, nameof(uri));

            Kind = MessageTemplateValueKind.Document;
            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateDocument"/>. </summary>
        /// <param name="name"></param>
        /// <param name="kind"></param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="uri"></param>
        /// <param name="caption"></param>
        /// <param name="fileName"></param>
        internal MessageTemplateDocument(string name, MessageTemplateValueKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, Uri uri, string caption, string fileName) : base(name, kind, serializedAdditionalRawData)
        {
            Uri = uri;
            Caption = caption;
            FileName = fileName;
        }

        /// <summary> Initializes a new instance of <see cref="MessageTemplateDocument"/> for deserialization. </summary>
        internal MessageTemplateDocument()
        {
        }

        /// <summary> Gets the uri. </summary>
        public Uri Uri { get; }
        /// <summary> Gets or sets the caption. </summary>
        public string Caption { get; set; }
        /// <summary> Gets or sets the file name. </summary>
        public string FileName { get; set; }
    }
}
