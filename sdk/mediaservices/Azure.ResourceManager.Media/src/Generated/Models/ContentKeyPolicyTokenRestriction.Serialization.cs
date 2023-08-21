// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.Media.Models
{
    public partial class ContentKeyPolicyTokenRestriction : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("issuer"u8);
            writer.WriteStringValue(Issuer);
            writer.WritePropertyName("audience"u8);
            writer.WriteStringValue(Audience);
            if (PrimaryVerificationKey != null)
            {
                writer.WritePropertyName("primaryVerificationKey"u8);
                writer.WriteObjectValue(PrimaryVerificationKey);
            }
            else
            {
                writer.WriteNull("primaryVerificationKey");
            }
            if (Core.Optional.IsCollectionDefined(AlternateVerificationKeys))
            {
                writer.WritePropertyName("alternateVerificationKeys"u8);
                writer.WriteStartArray();
                foreach (var item in AlternateVerificationKeys)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsCollectionDefined(RequiredClaims))
            {
                writer.WritePropertyName("requiredClaims"u8);
                writer.WriteStartArray();
                foreach (var item in RequiredClaims)
                {
                    writer.WriteObjectValue(item);
                }
                writer.WriteEndArray();
            }
            writer.WritePropertyName("restrictionTokenType"u8);
            writer.WriteStringValue(RestrictionTokenType.ToString());
            if (Core.Optional.IsDefined(OpenIdConnectDiscoveryDocument))
            {
                writer.WritePropertyName("openIdConnectDiscoveryDocument"u8);
                writer.WriteStringValue(OpenIdConnectDiscoveryDocument);
            }
            writer.WritePropertyName("@odata.type"u8);
            writer.WriteStringValue(OdataType);
            writer.WriteEndObject();
        }

        internal static ContentKeyPolicyTokenRestriction DeserializeContentKeyPolicyTokenRestriction(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            string issuer = default;
            string audience = default;
            ContentKeyPolicyRestrictionTokenKey primaryVerificationKey = default;
            Core.Optional<IList<ContentKeyPolicyRestrictionTokenKey>> alternateVerificationKeys = default;
            Core.Optional<IList<ContentKeyPolicyTokenClaim>> requiredClaims = default;
            ContentKeyPolicyRestrictionTokenType restrictionTokenType = default;
            Core.Optional<string> openIdConnectDiscoveryDocument = default;
            string odataType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("issuer"u8))
                {
                    issuer = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("audience"u8))
                {
                    audience = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("primaryVerificationKey"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        primaryVerificationKey = null;
                        continue;
                    }
                    primaryVerificationKey = ContentKeyPolicyRestrictionTokenKey.DeserializeContentKeyPolicyRestrictionTokenKey(property.Value);
                    continue;
                }
                if (property.NameEquals("alternateVerificationKeys"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContentKeyPolicyRestrictionTokenKey> array = new List<ContentKeyPolicyRestrictionTokenKey>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyRestrictionTokenKey.DeserializeContentKeyPolicyRestrictionTokenKey(item));
                    }
                    alternateVerificationKeys = array;
                    continue;
                }
                if (property.NameEquals("requiredClaims"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<ContentKeyPolicyTokenClaim> array = new List<ContentKeyPolicyTokenClaim>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(ContentKeyPolicyTokenClaim.DeserializeContentKeyPolicyTokenClaim(item));
                    }
                    requiredClaims = array;
                    continue;
                }
                if (property.NameEquals("restrictionTokenType"u8))
                {
                    restrictionTokenType = new ContentKeyPolicyRestrictionTokenType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("openIdConnectDiscoveryDocument"u8))
                {
                    openIdConnectDiscoveryDocument = property.Value.GetString();
                    continue;
                }
                if (property.NameEquals("@odata.type"u8))
                {
                    odataType = property.Value.GetString();
                    continue;
                }
            }
            return new ContentKeyPolicyTokenRestriction(odataType, issuer, audience, primaryVerificationKey, Core.Optional.ToList(alternateVerificationKeys), Core.Optional.ToList(requiredClaims), restrictionTokenType, openIdConnectDiscoveryDocument.Value);
        }
    }
}
