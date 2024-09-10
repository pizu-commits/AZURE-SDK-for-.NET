// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.EventGrid.Models
{
    /// <summary> Properties of the Queue info for event subscription. </summary>
    public partial class QueueInfo
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

        /// <summary> Initializes a new instance of <see cref="QueueInfo"/>. </summary>
        public QueueInfo()
        {
        }

        /// <summary> Initializes a new instance of <see cref="QueueInfo"/>. </summary>
        /// <param name="receiveLockDurationInSeconds">
        /// Maximum period in seconds in which once the message is in received (by the client) state and waiting to be accepted, released or rejected.
        /// If this time elapsed after a message has been received by the client and not transitioned into accepted (not processed), released or rejected,
        /// the message is available for redelivery. This is an optional field, where default is 60 seconds, minimum is 60 seconds and maximum is 300 seconds.
        /// </param>
        /// <param name="maxDeliveryCount"> The maximum delivery count of the events. </param>
        /// <param name="deadLetterDestinationWithResourceIdentity">
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
        /// Uses the managed identity setup on the parent resource (namely, topic) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </param>
        /// <param name="eventTimeToLive">
        /// Time span duration in ISO 8601 format that determines how long messages are available to the subscription from the time the message was published.
        /// This duration value is expressed using the following format: \'P(n)Y(n)M(n)DT(n)H(n)M(n)S\', where:
        ///     - (n) is replaced by the value of each time element that follows the (n).
        ///     - P is the duration (or Period) designator and is always placed at the beginning of the duration.
        ///     - Y is the year designator, and it follows the value for the number of years.
        ///     - M is the month designator, and it follows the value for the number of months.
        ///     - W is the week designator, and it follows the value for the number of weeks.
        ///     - D is the day designator, and it follows the value for the number of days.
        ///     - T is the time designator, and it precedes the time components.
        ///     - H is the hour designator, and it follows the value for the number of hours.
        ///     - M is the minute designator, and it follows the value for the number of minutes.
        ///     - S is the second designator, and it follows the value for the number of seconds.
        /// This duration value cannot be set greater than the topic’s EventRetentionInDays. It is is an optional field where its minimum value is 1 minute, and its maximum is determined
        /// by topic’s EventRetentionInDays value. The followings are examples of valid values:
        ///     - \'P0DT23H12M\' or \'PT23H12M\': for duration of 23 hours and 12 minutes.
        ///     - \'P1D\' or \'P1DT0H0M0S\': for duration of 1 day.
        /// </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal QueueInfo(int? receiveLockDurationInSeconds, int? maxDeliveryCount, DeadLetterWithResourceIdentity deadLetterDestinationWithResourceIdentity, TimeSpan? eventTimeToLive, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ReceiveLockDurationInSeconds = receiveLockDurationInSeconds;
            MaxDeliveryCount = maxDeliveryCount;
            DeadLetterDestinationWithResourceIdentity = deadLetterDestinationWithResourceIdentity;
            EventTimeToLive = eventTimeToLive;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary>
        /// Maximum period in seconds in which once the message is in received (by the client) state and waiting to be accepted, released or rejected.
        /// If this time elapsed after a message has been received by the client and not transitioned into accepted (not processed), released or rejected,
        /// the message is available for redelivery. This is an optional field, where default is 60 seconds, minimum is 60 seconds and maximum is 300 seconds.
        /// </summary>
        [WirePath("receiveLockDurationInSeconds")]
        public int? ReceiveLockDurationInSeconds { get; set; }
        /// <summary> The maximum delivery count of the events. </summary>
        [WirePath("maxDeliveryCount")]
        public int? MaxDeliveryCount { get; set; }
        /// <summary>
        /// The dead letter destination of the event subscription. Any event that cannot be delivered to its' destination is sent to the dead letter destination.
        /// Uses the managed identity setup on the parent resource (namely, topic) to acquire the authentication tokens being used during delivery / dead-lettering.
        /// </summary>
        [WirePath("deadLetterDestinationWithResourceIdentity")]
        public DeadLetterWithResourceIdentity DeadLetterDestinationWithResourceIdentity { get; set; }
        /// <summary>
        /// Time span duration in ISO 8601 format that determines how long messages are available to the subscription from the time the message was published.
        /// This duration value is expressed using the following format: \'P(n)Y(n)M(n)DT(n)H(n)M(n)S\', where:
        ///     - (n) is replaced by the value of each time element that follows the (n).
        ///     - P is the duration (or Period) designator and is always placed at the beginning of the duration.
        ///     - Y is the year designator, and it follows the value for the number of years.
        ///     - M is the month designator, and it follows the value for the number of months.
        ///     - W is the week designator, and it follows the value for the number of weeks.
        ///     - D is the day designator, and it follows the value for the number of days.
        ///     - T is the time designator, and it precedes the time components.
        ///     - H is the hour designator, and it follows the value for the number of hours.
        ///     - M is the minute designator, and it follows the value for the number of minutes.
        ///     - S is the second designator, and it follows the value for the number of seconds.
        /// This duration value cannot be set greater than the topic’s EventRetentionInDays. It is is an optional field where its minimum value is 1 minute, and its maximum is determined
        /// by topic’s EventRetentionInDays value. The followings are examples of valid values:
        ///     - \'P0DT23H12M\' or \'PT23H12M\': for duration of 23 hours and 12 minutes.
        ///     - \'P1D\' or \'P1DT0H0M0S\': for duration of 1 day.
        /// </summary>
        [WirePath("eventTimeToLive")]
        public TimeSpan? EventTimeToLive { get; set; }
    }
}
