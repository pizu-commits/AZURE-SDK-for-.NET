// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.Messages
{
    /// <summary> A request to send a media notification. </summary>
    public partial class MediaNotificationContent : NotificationContent
    {
        /// <summary> Initializes a new instance of <see cref="MediaNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="mediaUri"> A media url for the file. Required if the type is one of the supported media types, e.g. image. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="to"/> or <paramref name="mediaUri"/> is null. </exception>
        public MediaNotificationContent(Guid channelRegistrationId, IEnumerable<string> to, Uri mediaUri) : base(channelRegistrationId, to)
        {
            Argument.AssertNotNull(to, nameof(to));
            Argument.AssertNotNull(mediaUri, nameof(mediaUri));

            Kind = CommunicationMessageKind.Image;
            MediaUri = mediaUri;
        }

        /// <summary> Initializes a new instance of <see cref="MediaNotificationContent"/>. </summary>
        /// <param name="channelRegistrationId"> The Channel Registration ID for the Business Identifier. </param>
        /// <param name="to"> The native external platform user identifiers of the recipient. </param>
        /// <param name="kind"> The type discriminator describing a notification type. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        /// <param name="content"> Optional text content. </param>
        /// <param name="mediaUri"> A media url for the file. Required if the type is one of the supported media types, e.g. image. </param>
        internal MediaNotificationContent(Guid channelRegistrationId, IList<string> to, CommunicationMessageKind kind, IDictionary<string, BinaryData> serializedAdditionalRawData, string content, Uri mediaUri) : base(channelRegistrationId, to, kind, serializedAdditionalRawData)
        {
            Content = content;
            MediaUri = mediaUri;
        }

        /// <summary> Initializes a new instance of <see cref="MediaNotificationContent"/> for deserialization. </summary>
        internal MediaNotificationContent()
        {
        }

        /// <summary> Optional text content. </summary>
        public string Content { get; set; }
        /// <summary> A media url for the file. Required if the type is one of the supported media types, e.g. image. </summary>
        public Uri MediaUri { get; }
    }
}
