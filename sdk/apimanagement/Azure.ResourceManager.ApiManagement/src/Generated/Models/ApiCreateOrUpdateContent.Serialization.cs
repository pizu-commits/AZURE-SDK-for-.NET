// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.ApiManagement.Models
{
    public partial class ApiCreateOrUpdateContent : Core.IUtf8JsonSerializable
    {
        void Core.IUtf8JsonSerializable.Write(Utf8JsonWriter writer)
        {
            writer.WriteStartObject();
            writer.WritePropertyName("properties"u8);
            writer.WriteStartObject();
            if (Core.Optional.IsDefined(Description))
            {
                writer.WritePropertyName("description"u8);
                writer.WriteStringValue(Description);
            }
            if (Core.Optional.IsDefined(AuthenticationSettings))
            {
                writer.WritePropertyName("authenticationSettings"u8);
                writer.WriteObjectValue(AuthenticationSettings);
            }
            if (Core.Optional.IsDefined(SubscriptionKeyParameterNames))
            {
                writer.WritePropertyName("subscriptionKeyParameterNames"u8);
                writer.WriteObjectValue(SubscriptionKeyParameterNames);
            }
            if (Core.Optional.IsDefined(ApiType))
            {
                writer.WritePropertyName("type"u8);
                writer.WriteStringValue(ApiType.Value.ToString());
            }
            if (Core.Optional.IsDefined(ApiRevision))
            {
                writer.WritePropertyName("apiRevision"u8);
                writer.WriteStringValue(ApiRevision);
            }
            if (Core.Optional.IsDefined(ApiVersion))
            {
                writer.WritePropertyName("apiVersion"u8);
                writer.WriteStringValue(ApiVersion);
            }
            if (Core.Optional.IsDefined(IsCurrent))
            {
                writer.WritePropertyName("isCurrent"u8);
                writer.WriteBooleanValue(IsCurrent.Value);
            }
            if (Core.Optional.IsDefined(ApiRevisionDescription))
            {
                writer.WritePropertyName("apiRevisionDescription"u8);
                writer.WriteStringValue(ApiRevisionDescription);
            }
            if (Core.Optional.IsDefined(ApiVersionDescription))
            {
                writer.WritePropertyName("apiVersionDescription"u8);
                writer.WriteStringValue(ApiVersionDescription);
            }
            if (Core.Optional.IsDefined(ApiVersionSetId))
            {
                writer.WritePropertyName("apiVersionSetId"u8);
                writer.WriteStringValue(ApiVersionSetId);
            }
            if (Core.Optional.IsDefined(IsSubscriptionRequired))
            {
                writer.WritePropertyName("subscriptionRequired"u8);
                writer.WriteBooleanValue(IsSubscriptionRequired.Value);
            }
            if (Core.Optional.IsDefined(TermsOfServiceUri))
            {
                writer.WritePropertyName("termsOfServiceUrl"u8);
                writer.WriteStringValue(TermsOfServiceUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(Contact))
            {
                writer.WritePropertyName("contact"u8);
                writer.WriteObjectValue(Contact);
            }
            if (Core.Optional.IsDefined(License))
            {
                writer.WritePropertyName("license"u8);
                writer.WriteObjectValue(License);
            }
            if (Core.Optional.IsDefined(SourceApiId))
            {
                writer.WritePropertyName("sourceApiId"u8);
                writer.WriteStringValue(SourceApiId);
            }
            if (Core.Optional.IsDefined(DisplayName))
            {
                writer.WritePropertyName("displayName"u8);
                writer.WriteStringValue(DisplayName);
            }
            if (Core.Optional.IsDefined(ServiceUri))
            {
                writer.WritePropertyName("serviceUrl"u8);
                writer.WriteStringValue(ServiceUri.AbsoluteUri);
            }
            if (Core.Optional.IsDefined(Path))
            {
                writer.WritePropertyName("path"u8);
                writer.WriteStringValue(Path);
            }
            if (Core.Optional.IsCollectionDefined(Protocols))
            {
                writer.WritePropertyName("protocols"u8);
                writer.WriteStartArray();
                foreach (var item in Protocols)
                {
                    writer.WriteStringValue(item.ToString());
                }
                writer.WriteEndArray();
            }
            if (Core.Optional.IsDefined(ApiVersionSet))
            {
                writer.WritePropertyName("apiVersionSet"u8);
                writer.WriteObjectValue(ApiVersionSet);
            }
            if (Core.Optional.IsDefined(Value))
            {
                writer.WritePropertyName("value"u8);
                writer.WriteStringValue(Value);
            }
            if (Core.Optional.IsDefined(Format))
            {
                writer.WritePropertyName("format"u8);
                writer.WriteStringValue(Format.Value.ToString());
            }
            if (Core.Optional.IsDefined(WsdlSelector))
            {
                writer.WritePropertyName("wsdlSelector"u8);
                writer.WriteObjectValue(WsdlSelector);
            }
            if (Core.Optional.IsDefined(SoapApiType))
            {
                writer.WritePropertyName("apiType"u8);
                writer.WriteStringValue(SoapApiType.Value.ToString());
            }
            writer.WriteEndObject();
            writer.WriteEndObject();
        }
    }
}
