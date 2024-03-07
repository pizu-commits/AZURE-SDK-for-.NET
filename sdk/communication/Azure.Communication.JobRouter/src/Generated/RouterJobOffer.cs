// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.Communication.JobRouter
{
    /// <summary> An offer of a job to a worker. </summary>
    public partial class RouterJobOffer
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

        /// <summary> Initializes a new instance of <see cref="RouterJobOffer"/>. </summary>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="jobId"/> is null. </exception>
        internal RouterJobOffer(string jobId, int capacityCost)
        {
            Argument.AssertNotNull(jobId, nameof(jobId));

            JobId = jobId;
            CapacityCost = capacityCost;
        }

        /// <summary> Initializes a new instance of <see cref="RouterJobOffer"/>. </summary>
        /// <param name="offerId"> Id of an offer. </param>
        /// <param name="jobId"> Id of the job. </param>
        /// <param name="capacityCost"> The capacity cost consumed by the job offer. </param>
        /// <param name="offeredAt"> Timestamp when the offer was created in UTC. </param>
        /// <param name="expiresAt"> Timestamp when the offer will expire in UTC. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal RouterJobOffer(string offerId, string jobId, int capacityCost, DateTimeOffset? offeredAt, DateTimeOffset? expiresAt, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferId = offerId;
            JobId = jobId;
            CapacityCost = capacityCost;
            OfferedAt = offeredAt;
            ExpiresAt = expiresAt;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="RouterJobOffer"/> for deserialization. </summary>
        internal RouterJobOffer()
        {
        }

        /// <summary> Id of an offer. </summary>
        public string OfferId { get; }
        /// <summary> Id of the job. </summary>
        public string JobId { get; }
        /// <summary> The capacity cost consumed by the job offer. </summary>
        public int CapacityCost { get; }
        /// <summary> Timestamp when the offer was created in UTC. </summary>
        public DateTimeOffset? OfferedAt { get; }
        /// <summary> Timestamp when the offer will expire in UTC. </summary>
        public DateTimeOffset? ExpiresAt { get; }
    }
}
