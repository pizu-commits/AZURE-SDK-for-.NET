// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.ShortCodes.Models
{
    public partial class USProgramBrief : IUtf8JsonSerializable
    {
        void IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("id"u8);
            writer.WriteStringValue(Id);
            if (Optional.IsDefined(Status))
            {
                writer.WritePropertyName("status"u8);
                writer.WriteStringValue(Status.Value.ToString());
            }
            if (Optional.IsDefined(Number))
            {
                writer.WritePropertyName("number"u8);
                writer.WriteStringValue(Number);
            }
            if (Optional.IsCollectionDefined(ReviewNotes))
            {
                writer.WritePropertyName("reviewNotes"u8);
                writer.WriteStartArray();
                foreach (var item in ReviewNotes)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsCollectionDefined(Costs))
            {
                writer.WritePropertyName("costs"u8);
                writer.WriteStartArray();
                foreach (var item in Costs)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Optional.IsDefined(SubmissionDate))
            {
                writer.WritePropertyName("submissionDate"u8);
                writer.WriteStringValue(SubmissionDate.Value, "O");
            }
            if (Optional.IsDefined(StatusUpdatedDate))
            {
                writer.WritePropertyName("statusUpdatedDate"u8);
                writer.WriteStringValue(StatusUpdatedDate.Value, "O");
            }
            if (Optional.IsDefined(ProgramDetails))
            {
                writer.WritePropertyName("programDetails"u8);
                writer.WriteObjectValue(ProgramDetails);
            }
            if (Optional.IsDefined(CompanyInformation))
            {
                writer.WritePropertyName("companyInformation"u8);
                writer.WriteObjectValue(CompanyInformation);
            }
            if (Optional.IsDefined(MessageDetails))
            {
                writer.WritePropertyName("messageDetails"u8);
                writer.WriteObjectValue(MessageDetails);
            }
            if (Optional.IsDefined(TrafficDetails))
            {
                writer.WritePropertyName("trafficDetails"u8);
                writer.WriteObjectValue(TrafficDetails);
            }
            writer.WriteEndObject();
        }

        internal static USProgramBrief DeserializeUSProgramBrief(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Guid id = default;
            ProgramBriefStatus? status = default;
            string number = default;
            IList<ReviewNote> reviewNotes = default;
            IList<ShortCodeCost> costs = default;
            DateTimeOffset? submissionDate = default;
            DateTimeOffset? statusUpdatedDate = default;
            ProgramDetails programDetails = default;
            CompanyInformation companyInformation = default;
            MessageDetails messageDetails = default;
            TrafficDetails trafficDetails = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("id"u8))
                {
                    id = property.Value.GetGuid();
                    continue;
                }
                if (property.NameEquals("status"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    status = new ProgramBriefStatus(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("number"u8))
                {
                    number = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("reviewNotes"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ReviewNote> array = new List<ReviewNote>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ReviewNote.DeserializeReviewNote(item));
                    }
                    reviewNotes = array;
                    continue;
                }
                if (property.NameEquals("costs"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ShortCodeCost> array = new List<ShortCodeCost>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ShortCodeCost.DeserializeShortCodeCost(item));
                    }
                    costs = array;
                    continue;
                }
                if (property.NameEquals("submissionDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    submissionDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("statusUpdatedDate"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    statusUpdatedDate = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("programDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    programDetails = ProgramDetails.DeserializeProgramDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("companyInformation"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    companyInformation = CompanyInformation.DeserializeCompanyInformation(property.Value);
                    continue;
                }
                if (property.NameEquals("messageDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    messageDetails = MessageDetails.DeserializeMessageDetails(property.Value);
                    continue;
                }
                if (property.NameEquals("trafficDetails"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    trafficDetails = TrafficDetails.DeserializeTrafficDetails(property.Value);
                    continue;
                }
            }
            return new USProgramBrief(
                id,
                status,
                number,
                reviewNotes ?? new ChangeTrackingList<ReviewNote>(),
                costs ?? new ChangeTrackingList<ShortCodeCost>(),
                submissionDate,
                statusUpdatedDate,
                programDetails,
                companyInformation,
                messageDetails,
                trafficDetails);
        }
    }
}
